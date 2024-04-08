
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


namespace SistemaVBA
{



    public partial class cadastrarProduto : Form
    {
        object idValue;
        public cadastrarProduto()
        {
            InitializeComponent();

            var strConnection = new Connect();
            var conexao = new MySqlConnection(strConnection.GetConnectionString());
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
                        ProdutoTextBox.Text = String.Empty;
                        MarcaTextBox.Text = String.Empty;
                        ModeloTextBox.Text = String.Empty ;
                        costPriceTextBox.Text = String.Empty;
                        finalPricetextBox.Text = String.Empty;
                        IDtextBox.Text = String.Empty;
                        MessageBox.Show("Inserido com sucesso!");
                        atualizar();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            // Obtenha a referência para a linha selecionada
            DataGridViewRow row = dataGridView1.Rows[index];

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                // Obtém o valor da célula da coluna "ID" da linha clicada
                idValue = row.Cells[0].Value.ToString();

                // Verifica se o valor é válido e não nulo
                if (idValue != null)
                {
                    // Converte o valor para o tipo desejado (por exemplo, int)
                    int id = Convert.ToInt32(idValue);

                    // Agora você pode usar o ID capturado conforme necessário
                    // Por exemplo, exibir em uma caixa de mensagem
                    //MessageBox.Show("ID selecionado: " + id.ToString());
                }
            }

            // Captura o ID do Produto  ProdutoTextBox.Text = row.Cells[0].Value.ToString();



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

            //SELECTION MODE
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


        private void TimerAtualizacao_Tick(object sender, EventArgs e)
        {
            // Implemente o código de atualização dos dados aqui
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            var strConnection = new Connect();
            var conexao = new MySqlConnection(strConnection.GetConnectionString());
            var sqlQuery = "DELETE FROM produto WHERE id =" + idValue;
            using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
            {
                comando.Parameters.AddWithValue("@IdValue", idValue);

                try
                {
                    conexao.Open();
                    int rowsAffected = comando.ExecuteNonQuery();
                    // Faça o que desejar com a informação sobre as linhas afetadas, se necessário.
                    MessageBox.Show("Deletado com Sucesso");
                    atualizar();

                }
                catch (Exception ex)
                {
                    // Lidar com exceções, se houver.
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
            var strConnection = new Connect();
            var conexao = new MySqlConnection(strConnection.GetConnectionString());
            var sqlQuery = "UPDATE `cadastro`.`produto` SET `nome` = '" + ProdutoTextBox.Text + "', `marca` = '" + MarcaTextBox.Text + "', `preco_de_custo` = '" + costPriceTextBox.Text + "', `preco_final` = '" + finalPricetextBox.Text + "', `codigo_de_barras` = '" + IDtextBox.Text + "' WHERE id = " + idValue;

            using (MySqlCommand comando = new MySqlCommand(sqlQuery, conexao))
            {
                try
                {
                    conexao.Open();
                    int rowsAffected = comando.ExecuteNonQuery();
                    // Faça o que desejar com a informação sobre as linhas afetadas, se necessário.
                    MessageBox.Show("Produto atualizado com Sucesso");
                    atualizar();
                }
                catch (Exception ex)
                {
                    // Lidar com exceções, se houver.
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

            //SELECTION MODE
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

                        // Associe o DataTable ao DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
                }

            }

        }


}

