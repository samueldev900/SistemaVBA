
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SistemaVBA
{
    public partial class cadastrarProduto : Form
    {
        String connectionString = "Data Source=NomeDoServidor;Initial Catalog=NomeDoBancoDeDados;Integrated Security=True";
        public cadastrarProduto()
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
                //conexao.Close();
            }
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

            var connectionString = "server=localhost;uid=root;database=cadastro";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
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
                        MessageBox.Show("Inserido com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao inserir: {ex.Message}");
                    }
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Seu código para lidar com o evento TextChanged de textBox3 aqui
        }

    }
}
