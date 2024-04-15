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
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaVBA
{
    public partial class editVenda : Form
    {
        string sqlConnect = "server=localhost;uid=root;database=vendas";

        public editVenda(string nomeTable,string ID)
        {
            InitializeComponent();
            Connect(nomeTable);  
        }
        

        public void Connect(string nomeTabela)
        {
            string sqlQuery = $"SELECT * FROM {nomeTabela}";

            List<editVenda> dadosDoBanco = new List<editVenda>();


            using (MySqlConnection conexao = new MySqlConnection(sqlConnect))
            {

                using (MySqlCommand comando = new MySqlCommand(sqlQuery,conexao))
                {
                    try
                    {
                        conexao.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {

                        }

                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }


        }
    }
}
