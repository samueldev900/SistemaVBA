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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVBA
{
    public partial class NovaVenda : Form
    {
        private string[] produto = new string[5];
        public string data;
        public string hora;
        public string nomeTabela;
        public string metodoPagamento;
        public decimal troco = 0;
        public int valorRecebidoInt;
        public decimal valorProduto;
        public string modelo = "--";
        public NovaVenda()
        {
            InitializeComponent();
            data = DateTime.Today.ToString("ddMMyyyy");
            hora = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            nomeTabela = $"table_{data}";


            labelValorRecebido.Visible = false;
            valorRecebidoTextBox.Visible = false;
            trocoLabel.Visible = false;

            valorRecebidoTextBox.TextChanged += valorRecebidoTextBox_TextChanged;
            valorRecebidoTextBox.KeyPress += valorRecebidoTextBox_KeyPress;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {

                if (row.Cells[1].Value != null)
                    textBox2.Text = row.Cells[1].Value.ToString();
                else
                    textBox2.Text = "";

                if (row.Cells[2].Value != null)
                    textBox3.Text = row.Cells[2].Value.ToString();
                else
                    textBox3.Text = "";

                if (row.Cells[3].Value != null)
                    textBox4.Text = row.Cells[3].Value.ToString();
                else
                    textBox4.Text = "";

                if (row.Cells[4].Value != null)
                {
                    textBox5.Text = row.Cells[4].Value.ToString();
                    label3.Text = $"Total: {row.Cells[4].Value}";
                    if (decimal.TryParse(row.Cells[4].Value.ToString(), out decimal valor))
                    {
                        valorProduto = valor;
                    }
                    else
                    {
                        // Não foi possível converter para decimal, faça algo aqui para lidar com isso.
                    }
                }
                else
                {
                    textBox5.Text = "";
                    label3.Text = "Total: ";
                }
            }

            label3.Text = $"Total: {row.Cells[4].Value}";
            valorProduto = (decimal)row.Cells[4].Value;
            nomeProduto_label.Text = $"Produto: {row.Cells[1].Value.ToString()}";
            produto[0] = row.Cells[1].Value.ToString();
            produto[1] = row.Cells[4].Value.ToString();



        }
  






        private void NovaVenda_Load(object sender, EventArgs e)
        {

            DataTable table = new DataTable();

            //SELECTION MODE
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            string sqlQuery = "SELECT id,nome,marca,modelo,preco_final FROM produto;";

            var connectionString = "server=localhost;uid=root;database=cadastro";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                        dataGridView1.Columns[0].Width = 30;
                        dataGridView1.Columns[1].Width = 171;

                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Nome";
                        dataGridView1.Columns[2].HeaderText = "Marca";
                        dataGridView1.Columns[3].HeaderText = "Modelo";
                        dataGridView1.Columns[4].HeaderText = "Preço";

                    }
                }

            }
        }

       
        private void dinheiro_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (debitoButton1.Checked)
            {
                labelValorRecebido.Visible = false;
                valorRecebidoTextBox.Visible = false;
                trocoLabel.Visible = false;
            }
            else
            {
                labelValorRecebido.Visible = true;
                valorRecebidoTextBox.Visible = true;
                trocoLabel.Visible = true;
                metodoPagamento = "Dinheiro";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (debitoButton1.Checked)
            {
                metodoPagamento = "Débito";
            }
        }

        private void credito_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (debitoButton1.Checked)
            {
                metodoPagamento = "Crédito";
            }
        }

        private void pix_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pix_radioButton.Checked)
            {
                metodoPagamento = "Pix";

            }

        }

        private void trocoLabel_Click(object sender, EventArgs e)
        {
            trocoLabel.Text = "metodoPagamento";
        }
        private void valorRecebidoTextBox_TextChanged(object sender, EventArgs e)
        {
            // Obtém o texto atual do textbox
            string texto = valorRecebidoTextBox.Text;
            decimal valorRecebidoInt = 0;

            // Verifica se o texto não está vazio
            if (!string.IsNullOrEmpty(texto))
            {
                valorRecebidoInt = decimal.Parse(texto);
            }

            // Calcula o troco

            decimal troco = valorRecebidoInt - valorProduto;

            // Atualiza o texto do label
            trocoLabel.Text = $"Troco: R$ {troco}";
        }

        private void valorRecebidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado não é um número ou a tecla backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancela a tecla pressionada
                e.Handled = true;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(!dinheiro_radio.Checked && !debitoButton1.Checked && !credito_radioButton.Checked && !pix_radioButton.Checked)
            {
                MessageBox.Show("Por favor selecione um método de Pagamento");
            }
            else if(textBox2.Text.Length == 0 && textBox5.Text.Length == 0)
            {
                MessageBox.Show("Por favor, Selecione um produto");

            }
            else if(dinheiro_radio.Checked && valorRecebidoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Informe o Valor Recebido");
            }
            else
            {
                string connectionString = "server=localhost;uid=root;database=vendas";
                if (!dinheiro_radio.Checked)
                {
                    valorRecebidoInt = 0;
                    troco = 0;
                }
                else
                {
                    valorRecebidoInt = Convert.ToInt32(valorRecebidoTextBox.Text);
                    troco = valorRecebidoInt - Convert.ToDecimal(produto[1]);
                }

                var sql = $"INSERT INTO {nomeTabela} (id, produto, modelo,metodo_pagamento,troco, preco_final) VALUES (NULL, @produto, modelo,@metodo_pagamento,@troco, @preco_final)";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@produto", produto[0]);
                        //comando.Parameters.AddWithValue("@modelo", modelo);
                        comando.Parameters.AddWithValue("@metodo_pagamento", metodoPagamento);
                        comando.Parameters.AddWithValue("@troco", troco);
                        comando.Parameters.AddWithValue("@preco_final", produto[1]); // Suponho que produto[1] seja o preço final

                        // Executa o comando
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        // Verifica se a inserção foi bem sucedida
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Venda bem sucedida!");
                        }
                        else
                        {
                            MessageBox.Show("Falha na inserção");
                        }
                    }
                }

            }
        }
    }
}
