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
        public decimal totalVendas;
        public decimal somaVendas;
        string connectionString = "server=localhost;uid=root;database=vendas";

        public TelaPrincipal()
        {
            InitializeComponent();
            data = DateTime.Now.ToString("ddMMyyyy");
            hora = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            nomeTable = $"table_{data}";

            tableExist();
            somarVenda();

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
            cadastro.FormClosed += NovaVenda_FormClosed;
            cadastro.TopMost = true;
            cadastro.ShowDialog();
        }

        private void NovaVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            atualizar(); 
            somarVenda();
        }
        public void TelaPrincipal_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            
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

                        DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                        dataGridView1.Columns.Insert(7, editButton);
                        editButton.Text = "Editar";
                        editButton.UseColumnTextForButtonValue = true;

                        DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                        dataGridView1.Columns.Insert(8, deleteButton);
                        deleteButton.Text = "Excluir";
                        deleteButton.UseColumnTextForButtonValue = true;

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
                        dataGridView1.Columns[6].HeaderText = "Hora da Venda";
                        dataGridView1.Columns[7].HeaderText = "Editar";
                        dataGridView1.Columns[8].HeaderText = "Delete";
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

            {
                MessageBox.Show($"Botão na linha {e.RowIndex} clicado, Id dessa Linha: {stringId}");
            }
        }

        private void deleteVenda_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o item ?", "Excluir Venda", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string sqlQuery = $"DELETE FROM table_{data} WHERE id={stringId}";

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conexao.Open();

                        using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
                        {
                            int rowsAffected = comando.ExecuteNonQuery();
                            MessageBox.Show("Deletado com Sucesso");
                            atualizar();
                            somarVenda();
                        }
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
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada");
            }
        }



        private void editVenda_button_Click(object sender, EventArgs e)
        {
            var editVenda = new editVenda(nomeTable,stringId);
            editVenda.FormClosed += editVenda_FormClosed;
            editVenda.TopMost = true;
            editVenda.ShowDialog();
        }
        private void editVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            atualizar();
            somarVenda();
        }
        public void tableExist()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

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
            var sqlString = $"CREATE TABLE {nomeTable} (id INT PRIMARY KEY AUTO_INCREMENT, produto VARCHAR(50) NOT NULL, modelo VARCHAR(50) NOT NULL, metodo_pagamento varchar(20) NOT NULL, troco DECIMAL(10, 2), preco_final DECIMAL(10, 2), hora_venda DATETIME DEFAULT CURRENT_TIMESTAMP) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
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

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            string sqlQuery = $"SELECT id,produto,modelo,metodo_pagamento,troco,preco_final,hora_venda FROM {nomeTable}";


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

        private void button1_Click(object sender, EventArgs e)
        {
            atualizar();
            somarVenda();
        }

        private void somarVenda()
        {
            somaVendas = 0;
            string sql = $"SELECT preco_final from {nomeTable}";
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    try
                    {
                        conexao.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                decimal precoFinal = reader.GetDecimal(0);
                                                                           
                                somaVendas += precoFinal;
                            }
                            if(somaVendas > totalVendas)
                            {   
                                totalVendas = somaVendas;
                                totalVendas_label.Text = $"R$ {totalVendas}";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao Selecionar dados: {ex.Message}");
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
