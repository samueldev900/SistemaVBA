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
        public NovaVenda()
        {
            InitializeComponent();
            data = DateTime.Today.ToString("ddMMyyyy");
            hora = DateTime.Now.Hour.ToString() + ":"+ DateTime.Now.Minute.ToString();
            createTable();
        }
        DataTable table = new DataTable();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NovaVenda_Load(object sender, EventArgs e)
        {

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Product Name", typeof(string));
            table.Columns.Add("Marca", typeof(string));
            table.Columns.Add("Modelo", typeof(string));
            table.Columns.Add("Preço", typeof(int));

            dataGridView1.DataSource = table;
        }

        public string getProduto()
        {
            return this.produto;
        }

        public void createTable()
        {
            var strConnection = "server=localhost;uid=root;database=vendas";
            var sqlString = "CREATE TABLE tabela_" + data + " (\r\n    id INT PRIMARY KEY AUTO_INCREMENT,\r\n    produto VARCHAR(50) NOT NULL,\r\n    modelo VARCHAR(50) NOT NULL,\r\n    preco_final DECIMAL(10, 2),\r\n    hora_venda VARCHAR(20)\r\n) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;";
            using (MySqlConnection conexao = new MySqlConnection(strConnection))
            {
                using(MySqlCommand comando = new MySqlCommand(sqlString, conexao))
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


    }
}
