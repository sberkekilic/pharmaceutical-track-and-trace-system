using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-LIN8EHF;Initial Catalog=Drugs;Integrated Security=True";

            SqlConnection baglan = new SqlConnection(ConnectionString);

            baglan.Open();

            SqlCommand komut = new SqlCommand("select * from Ilaclar", baglan);

            SqlDataReader oku = komut.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(oku);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;

            baglan.Close();
        }

    }
}
