
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Mysqlx.Crud;
using System.Collections.Generic;
using System.Reflection;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using System.Text.RegularExpressions;
using System.Net.Http;


namespace SistemaVBA
{

    public partial class cadastrarProduto : Form
    {
        string idValue;
        string stringConnect = "server=localhost;uid=root;database=cadastro";
        public cadastrarProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeProduto = ProdutoTextBox.Text;
            string marcaProduto = MarcaTextBox.Text;
            string modeloProduto = ModeloTextBox.Text;
            decimal precoCusto = Convert.ToDecimal(costPriceTextBox.Text);
            decimal precoFinal = Convert.ToDecimal(finalPricetextBox.Text);
            string barCode = IDtextBox.Text;

            string sql = "INSERT INTO produto (nome, marca, modelo, preco_de_custo, preco_final, codigo_de_barras) " +
                         "VALUES (@Nome, @Marca, @Modelo, @PrecoDeCusto, @PrecoFinal, @CodigoDeBarras)";


            using (MySqlConnection conexao = new MySqlConnection(stringConnect))
            {
                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", nomeProduto);
                    comando.Parameters.AddWithValue("@Marca", marcaProduto);
                    comando.Parameters.AddWithValue("@Modelo", modeloProduto);
                    comando.Parameters.AddWithValue("@PrecoDeCusto", precoCusto);
                    comando.Parameters.AddWithValue("@PrecoFinal", precoFinal);
                    comando.Parameters.AddWithValue("@CodigoDeBarras", barCode);

                    try
                    {
                        conexao.Open();
                        int linhasAfetadas = comando.ExecuteNonQuery();
                        LimparCampos();
                        MessageBox.Show("Inserido com sucesso!");
                        atualizar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao inserir: {ex.Message}");
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
        }

        private void LimparCampos()
        {
            ProdutoTextBox.Text = String.Empty;
            MarcaTextBox.Text = String.Empty;
            ModeloTextBox.Text = String.Empty;
            costPriceTextBox.Text = String.Empty;
            finalPricetextBox.Text = String.Empty;
            IDtextBox.Text = String.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                idValue = row.Cells[0].Value.ToString();

                if (idValue != null)
                {
                    int id = Convert.ToInt32(idValue);
                }
            }

            ProdutoTextBox.Text = row.Cells[1].Value.ToString();
            MarcaTextBox.Text = row.Cells[2].Value.ToString();
            ModeloTextBox.Text = row.Cells[3].Value.ToString();
            costPriceTextBox.Text = row.Cells[4].Value.ToString();
            finalPricetextBox.Text = row.Cells[5].Value.ToString();
            IDtextBox.Text = row.Cells[6].Value.ToString();

        }

        private void cadastrarProduto_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            string sqlQuery = "SELECT id,nome,marca,modelo,preco_de_custo,preco_final,codigo_de_barras FROM produto";

            using (MySqlConnection conexao = new MySqlConnection(stringConnect))
            {
                using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                        dataGridView1.Columns[0].Width = 30;
                        dataGridView1.Columns[4].Width = 115;
                        dataGridView1.Columns[5].Width = 100;
                        dataGridView1.Columns[6].Width = 93;

                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Nome";
                        dataGridView1.Columns[2].HeaderText = "Marca";
                        dataGridView1.Columns[3].HeaderText = "Modelo";
                        dataGridView1.Columns[4].HeaderText = "Preço de Custo";
                        dataGridView1.Columns[5].HeaderText = "Preço Final";
                        dataGridView1.Columns[6].HeaderText = "Código de Barras";
                    }
                }

            }

        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            var conexao = new MySqlConnection(stringConnect);
            var sqlQuery = "DELETE FROM produto WHERE id =" + idValue;
            using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
            {
                comando.Parameters.AddWithValue("@IdValue", idValue);

                try
                {
                    conexao.Open();
                    int rowsAffected = comando.ExecuteNonQuery();
                    MessageBox.Show("Deletado com Sucesso");
                    atualizar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }

        }

        private void edit_botton_Click(object sender, EventArgs e)
        {
            var conexao = new MySqlConnection(stringConnect);
            var sqlQuery = "UPDATE `cadastro`.`produto` SET `nome` = '" + ProdutoTextBox.Text + "', `marca` = '" + MarcaTextBox.Text + "', `preco_de_custo` = '" + costPriceTextBox.Text + "', `preco_final` = '" + finalPricetextBox.Text + "', `codigo_de_barras` = '" + IDtextBox.Text + "' WHERE id = " + idValue;

            using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
            {
                try
                {
                    conexao.Open();
                    int rowsAffected = comando.ExecuteNonQuery();
                    MessageBox.Show("Produto atualizado com Sucesso");
                    atualizar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }

        }

        private void atualizar()
        {
            DataTable table = new DataTable();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            string sqlQuery = "SELECT id,nome,marca,modelo,preco_de_custo,preco_final,codigo_de_barras FROM produto";

            var connectionString = "server=localhost;uid=root;database=cadastro";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }

        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}

