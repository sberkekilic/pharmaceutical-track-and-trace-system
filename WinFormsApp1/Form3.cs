using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_Load(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-LIN8EHF;Initial Catalog=Drugs;Integrated Security=True";
            SqlConnection baglan = new SqlConnection(ConnectionString);
            SqlCommand komut = new SqlCommand("select distinct MarkaAdi,ID from Ilaclar", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            baglan.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "MarkaAdi";
            comboBox1.ValueMember = "ID";
        }
    }
}
