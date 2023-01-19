﻿using System;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        private void Form3_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=DESKTOP-LIN8EHF;Initial Catalog=Drugs;Integrated Security=True;MultipleActiveResultSets=true");
            cn.Open();

            BindData();
            //BindData2();

            cn.Close();
        }

        public void BindData2()
        {
            string selected = comboBox1.GetItemText(comboBox1.SelectedItem);
            cmd = new SqlCommand("select IlacKodu from Ilaclar where MarkaAdi=@x", cn);
            cmd.Parameters.AddWithValue("@x", selected);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0].ToString());
            }
            dr.Close();
            
        }

        public void BindData()
        {
            cmd = new SqlCommand("select distinct MarkaAdi from Ilaclar", cn);
            dr = cmd.ExecuteReader();
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
            comboBox2.Items.Clear();
            cmd = new SqlCommand("select IlacKodu from Ilaclar where MarkaAdi=@x", cn);
            cmd.Parameters.AddWithValue("@x", comboBox1.Text);
            cn.Open();
            dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0].ToString());
            }
            cn.Close();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> mylist = new List<string>(new string[] { "Yolda", "Hazırlanıyor", "Teslim edildi" });

            Random R = new Random();

            // get random number from 0 to 2. 
            int someRandomNumber = R.Next(0, mylist.Count());
            string ConnectionString = "Data Source=DESKTOP-LIN8EHF;Initial Catalog=Drugs;Integrated Security=True";

            SqlConnection baglan = new SqlConnection(ConnectionString);

            baglan.Open();

            SqlCommand komut = new SqlCommand("insert into SiparisTakip (Marka, IlacKodu, SiparisAdet, SiparisTarihi, Durumu) values\r\n(@Marka, @IlacKodu, @SiparisAdet, @SiparisTarihi, @Durumu)", baglan);
            komut.Parameters.AddWithValue("@Marka", (comboBox1.SelectedItem));
            komut.Parameters.AddWithValue("@IlacKodu", (comboBox2.SelectedItem));
            komut.Parameters.AddWithValue("@SiparisAdet", int.Parse(textBox1.Text));
            komut.Parameters.AddWithValue("@SiparisTarihi", DateTime.Now.ToString("MM/dd/yyyy"));
            komut.Parameters.AddWithValue("@Durumu", mylist.ElementAt(someRandomNumber));

            SqlDataReader oku = komut.ExecuteReader();

            baglan.Close();

            var id = Guid.NewGuid().ToString();
            string message = $"Sipariş Başarıyla Verildi\r\nSipariş Kodu:{id}";
            string title = "Sipariş Verme";
            MessageBox.Show(message, title);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
