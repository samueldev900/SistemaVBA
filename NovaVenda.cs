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
    public partial class NovaVenda : Form
    {
        public NovaVenda()
        {
            InitializeComponent();
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
    }
}
