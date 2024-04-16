using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaVBA
{
    public partial class editVenda : Form
    {
        string idGlobal;
        string nameTableGlobal;
        string metodoPagamento;

        string sqlConnect = "server=localhost;uid=root;database=vendas";
        public editVenda(string nomeTable, string idProduct)
        {
            InitializeComponent();
            Connect(nomeTable, idProduct);
            idGlobal = idProduct;
            nameTableGlobal = nomeTable;
        }


        public void Connect(string nomeTabela, string ID)
        {
            string sqlQuery = $"select produto,modelo,metodo_pagamento,troco,preco_final from {nomeTabela} where id = {ID}";

            using (MySqlConnection conexao = new MySqlConnection(sqlConnect))
            {

                using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                {
                    try
                    {
                        conexao.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                name_textBox.Text = reader.GetString(0);
                                modelo_textBox.Text = reader.GetString(1);

                                if (reader.GetString(2) == "Dinheiro")
                                {
                                    dinheiro_radioButton.Checked = true;
                                }
                                else if (reader.GetString(2) == "Debito")
                                {
                                    debito_radioButton.Checked = true;

                                }
                                else if (reader.GetString(2) == "Credito")
                                {
                                    credito_radioButton.Checked = true;
                                }
                                else
                                {
                                    pix_radioButton.Checked = true;
                                }



                                troco_textBox.Text = Convert.ToString(reader.GetDecimal(3));
                                preco_textBox.Text = Convert.ToString(reader.GetDecimal(4));

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }


        }

        private void update_button_Click(object sender, EventArgs e)
        {
           
            if (dinheiro_radioButton.Checked)
            {
                metodoPagamento = "Dinheiro";
            }
            else if (credito_radioButton.Checked)
            {
                metodoPagamento = "Credito";
            }
            else if (debito_radioButton.Checked)
            {
                metodoPagamento = "Debito";

            }
            else if (pix_radioButton.Checked)
            {
                metodoPagamento = "Pix";

            }
            else
            {
                MessageBox.Show("Por Favor Selecione uma opção.");
            }

            using (MySqlConnection conexao = new MySqlConnection(sqlConnect))
            {
                string sqlQuery = $"UPDATE {nameTableGlobal} SET produto=@produtoValue, modelo=@modelo, metodo_pagamento=@metodoPagamento, troco=@troco, preco_final=@precoFinal";
                using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                {
                    try
                    {
                        comando.Parameters.AddWithValue("@produtoValue", name_textBox.Text);
                        comando.Parameters.AddWithValue("@modelo", modelo_textBox.Text);
                        comando.Parameters.AddWithValue("@metodoPagamento", metodoPagamento);
                        comando.Parameters.AddWithValue("@troco", troco_textBox.Text);
                        comando.Parameters.AddWithValue("@precoFinal", preco_textBox.Text);

                        conexao.Open();
                        int rowsAffected = comando.ExecuteNonQuery();
                        MessageBox.Show("Produto atualizado com sucesso");
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }

        }
    }
}
