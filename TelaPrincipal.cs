using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVBA
{
    public partial class TelaPrincipal : Form
    {

        public string data;
        public string nomeTable;
        public string stringId;
        public string hora;

        public TelaPrincipal()
        {
            InitializeComponent();
            data = DateTime.Now.ToString("ddMMyyyy");
            hora = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            nomeTable = $"table_{data}";

            tableExist();


        }

        private void cadastroProduto_button_Click(object sender, EventArgs e)
        {
            var cadastro = new cadastrarProduto();
            cadastro.TopMost = true;
            cadastro.ShowDialog();
        }


        private void novaVenda_button_Click(object sender, EventArgs e)
        {
            var cadastro = new NovaVenda();
            cadastro.TopMost = true;
            cadastro.ShowDialog();
        }

        public void TelaPrincipal_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            // SELECTION MODE
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            string connectionString = "server=localhost;uid=root;database=vendas";
            string sqlQuery = $"SELECT * FROM table_{data}";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                        dataGridView1.Columns[0].Width = 30;
                        dataGridView1.Columns[1].Width = 230;
                        dataGridView1.Columns[6].Width = 160;

                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Nome";
                        dataGridView1.Columns[2].HeaderText = "Modelo";
                        dataGridView1.Columns[3].HeaderText = "Metodo de Pagamento";
                        dataGridView1.Columns[4].HeaderText = "Troco";
                        dataGridView1.Columns[5].HeaderText = "Preço";
                        dataGridView1.Columns[6].HeaderText = "Hora da Venda";

                    }
                }
            }

            dataGridView1.DataSource = table;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var id = row.Cells["ID"].Value;
            stringId = Convert.ToString(id);
        }

        private void deleteVenda_button_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;database=vendas";

            string sqlQuery = $"DELETE FROM table_{data} WHERE id={stringId}";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open(); // Abre a conexão aqui

                    using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                    {
                        int rowsAffected = comando.ExecuteNonQuery();
                        // Faça o que desejar com a informação sobre as linhas afetadas, se necessário.
                        MessageBox.Show("Deletado com Sucesso");
                        atualizar();
                    }
                }
                catch (Exception ex)
                {
                    // Lidar com exceções, se houver.
                    Console.WriteLine("Erro: " + ex.Message);
                }
                // Não é necessário abrir novamente a conexão aqui
            }
        }

        private void editVenda_button_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;database=vendas";
            string sqlQuery = "UPDATE FROM ";
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
                string query = $"SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = DATABASE() AND table_name = '{nomeTable}'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute a consulta
                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result == 0)
                    {
                        MessageBox.Show($"A tabela {nomeTable} não existe.");
                        createTable();
                    }
                    else
                    {
                        MessageBox.Show($"A tabela {nomeTable} existe.");
                    }
                }
            }

        }

        public void createTable()
        {
            var strConnection = "server=localhost;uid=root;database=vendas";
            var sqlString = $"CREATE TABLE {nomeTable} (id INT PRIMARY KEY AUTO_INCREMENT, produto VARCHAR(50) NOT NULL, modelo VARCHAR(50) NOT NULL, metodo_pagamento varchar(20) NOT NULL, troco DECIMAL(10, 2), preco_final DECIMAL(10, 2), hora_venda DATETIME DEFAULT CURRENT_TIMESTAMP) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4";

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

        private void atualizar()
        {
            DataTable table = new DataTable();

            //SELECTION MODE
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            string sqlQuery = $"SELECT id,produto,modelo,metodo_pagamento,troco,preco_final,hora_venda FROM {nomeTable}";

            var connectionString = "server=localhost;uid=root;database=vendas";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Associe o DataTable ao DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizar();
        }
    }

}
