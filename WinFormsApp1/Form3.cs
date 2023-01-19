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
        SqlConnection cn;
        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-LIN8EHF;Initial Catalog=Drugs;Integrated Security=True;MultipleActiveResultSets=true");
            cn.Open();
            BindData();
        }

        public void BindData()
        {
            SqlCommand cmd = new SqlCommand("select distinct MarkaAdi from Ilaclar", cn);
            SqlDataReader dr = cmd.ExecuteReader();

            SqlCommand cmd2 = new SqlCommand("select IlacKodu from Ilaclar where MarkaAdi=@x", cn);
            SqlDataReader dr2 = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void comboBox1_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
