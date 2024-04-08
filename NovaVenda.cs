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
        private string produto;
        public string data;
        public string hora;
        public string nomeTabela;
        public int valorRecebido;
        public int troco;
        public NovaVenda()
        {
            InitializeComponent();
            data = DateTime.Today.ToString("ddMMyyyy");
            hora = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            nomeTabela = $"table_{data}";
            tableExist();

            valorRecebido = 12;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NovaVenda_Load(object sender, EventArgs e)
        {
            //table.Columns.Add("ID", typeof(int));
            //table.Columns.Add("Product Name", typeof(string));
            //table.Columns.Add("Marca", typeof(string));
            //table.Columns.Add("Modelo", typeof(string));
            //table.Columns.Add("Preço", typeof(int));


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

        public string getProduto()
        {
            return this.produto;
        }


        public void createTable()
        {
            var strConnection = "server=localhost;uid=root;database=vendas";
            var sqlString = "CREATE TABLE " + nomeTabela + " (\r\n    id INT PRIMARY KEY AUTO_INCREMENT,\r\n    produto VARCHAR(50) NOT NULL,\r\n    modelo VARCHAR(50) NOT NULL,\r\n    preco_final DECIMAL(10, 2),\r\n    hora_venda VARCHAR(20)\r\n) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;";
            using (MySqlConnection conexao = new MySqlConnection(strConnection))
            {
                using (MySqlCommand comando = new MySqlCommand(sqlString, conexao))
                {

                    try
                    {
                        conexao.Open();
                        int linhasAfetadas = comando.ExecuteNonQuery();
                        MessageBox.Show("Tabela Criada com Sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao inserir: {ex.Message}");
                        Console.WriteLine(ex.Message);
                    }

                }
            }


        }

        public void tableExist()
        {
            string connectionString = "server=localhost;uid=root;database=vendas";

            // Nome da tabela a ser verificada

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abra a conexão com o banco de dados
                connection.Open();

                // Consulta SQL para verificar a existência da tabela
                string query = $"SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = DATABASE() AND table_name = '{nomeTabela}'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute a consulta
                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result == 0)
                    {
                        MessageBox.Show($"A tabela {nomeTabela} não existe.");
                        createTable();
                    }
                    else
                    {
                        //MessageBox.Show($"A tabela {nomeTabela} existe.");
                    }
                }
            }
        }

        private void dinheiro_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Visible = true;
                labelValorRecebido.Visible = false;
                valorRecebidoTextBox.Visible = false;
                trocoLabel.Visible = false;
            }
            else
            {
                textBox1.Visible = false;
            }
        }
    }
}
