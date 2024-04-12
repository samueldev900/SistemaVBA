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

        public TelaPrincipal()
        {
            InitializeComponent();
            data = DateTime.Now.ToString("ddMMyyyy");
            nomeTable = $"table_{data}";
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
    }

}
