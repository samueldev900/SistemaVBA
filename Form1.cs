
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SistemaVBA
{
    public partial class Form1 : Form
    {
        String connectionString = "Data Source=NomeDoServidor;Initial Catalog=NomeDoBancoDeDados;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            var strConnection = "server=localhost;uid=root;database=cadastro";
            var conexao = new MySqlConnection(strConnection);
            try
            {
                conexao.Open();
                MessageBox.Show("Conectado com Sucesso");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            MessageBox.Show("O seu nome é" + text);
        }
    }
}
