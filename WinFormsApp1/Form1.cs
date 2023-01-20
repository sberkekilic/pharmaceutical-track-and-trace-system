using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            string ConnectionString = "Data Source=DESKTOP-LIN8EHF;Initial Catalog=Drugs;Integrated Security=True;MultipleActiveResultSets=true";

            SqlConnection baglan = new SqlConnection(ConnectionString);

            baglan.Open();

            SqlCommand komut = new SqlCommand("update AnaTablo\r\nset MarkaToplamIlacStok= t.sumStok\r\nfrom AnaTablo a \r\ninner join \r\n(\r\nselect MarkaAdi,sum(Stok) sumStok\r\nfrom Ilaclar\r\ngroup by MarkaAdi\r\n) t\r\non t.MarkaAdi = a.Marka\r\n\r\nupdate AnaTablo\r\nset MarkaOrtalamaIlacAlisTutari= t.avgAlisTutari\r\nfrom AnaTablo a \r\ninner join \r\n(\r\nselect MarkaAdi,avg(AlisTutari) avgAlisTutari\r\nfrom Ilaclar\r\ngroup by MarkaAdi\r\n) t\r\non t.MarkaAdi = a.Marka\r\n\r\nupdate AnaTablo\r\nset MarkaOrtalamaSatisMiktari= t.avgSatisMiktari\r\nfrom AnaTablo a \r\ninner join \r\n(\r\nselect MarkaAdi,avg(SatisMiktari) avgSatisMiktari\r\nfrom Ilaclar\r\ngroup by MarkaAdi\r\n) t\r\non t.MarkaAdi = a.Marka\r\n\r\nselect * from AnaTablo", baglan);
            SqlCommand komut2 = new SqlCommand("update ToplamStok set ToplamIlacStok = (SELECT Sum(Ilaclar.Stok) AS ToplamIlacStok FROM Ilaclar) select * from ToplamStok", baglan);

            SqlDataReader oku = komut.ExecuteReader();
            SqlDataReader oku2 = komut2.ExecuteReader();

            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            table.Load(oku);
            table.EndLoadData();
            table2.Load(oku2);
            label19.Text = table2.Rows[0]["ToplamIlacStok"].ToString();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;

            baglan.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-LIN8EHF;Initial Catalog=Drugs;Integrated Security=True;MultipleActiveResultSets=true";

            SqlConnection baglan = new SqlConnection(ConnectionString);

            baglan.Open();

            SqlCommand komut = new SqlCommand("update AnaTablo\r\nset MarkaToplamIlacStok= t.sumStok\r\nfrom AnaTablo a \r\ninner join \r\n(\r\nselect MarkaAdi,sum(Stok) sumStok\r\nfrom Ilaclar\r\ngroup by MarkaAdi\r\n) t\r\non t.MarkaAdi = a.Marka\r\n\r\nupdate AnaTablo\r\nset MarkaOrtalamaIlacAlisTutari= t.avgAlisTutari\r\nfrom AnaTablo a \r\ninner join \r\n(\r\nselect MarkaAdi,avg(AlisTutari) avgAlisTutari\r\nfrom Ilaclar\r\ngroup by MarkaAdi\r\n) t\r\non t.MarkaAdi = a.Marka\r\n\r\nupdate AnaTablo\r\nset MarkaOrtalamaSatisMiktari= t.avgSatisMiktari\r\nfrom AnaTablo a \r\ninner join \r\n(\r\nselect MarkaAdi,avg(SatisMiktari) avgSatisMiktari\r\nfrom Ilaclar\r\ngroup by MarkaAdi\r\n) t\r\non t.MarkaAdi = a.Marka\r\n\r\nselect * from AnaTablo", baglan);
            SqlCommand komut2 = new SqlCommand("update ToplamStok set ToplamIlacStok = (SELECT Sum(Ilaclar.Stok) AS ToplamIlacStok FROM Ilaclar) select * from ToplamStok", baglan);

            SqlDataReader oku = komut.ExecuteReader();
            SqlDataReader oku2 = komut2.ExecuteReader();

            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            table.Load(oku);
            table.EndLoadData();
            table2.Load(oku2);
            label19.Text = table2.Rows[0]["ToplamIlacStok"].ToString();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;

            baglan.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            { } 
            else 
            {
                dataGridView2.Visible = true;
                string ConnectionString = "Data Source=DESKTOP-LIN8EHF;Initial Catalog=Drugs;Integrated Security=True";

                SqlConnection baglan = new SqlConnection(ConnectionString);

                baglan.Open();

                SqlCommand komut = new SqlCommand("select * from Ilaclar where ID=@ID", baglan);
                komut.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

                SqlDataReader oku = komut.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(oku);

                dataGridView2.AutoGenerateColumns = false;

                dataGridView2.DataSource = table;

                baglan.Close();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "" ||
                textBox5.Text == "" ||
                textBox6.Text == "" ||
                textBox7.Text == "" ||
                textBox8.Text == ""
                )
            {}
            else
            {
                string ConnectionString = "Data Source=DESKTOP-LIN8EHF;Initial Catalog=Drugs;Integrated Security=True";

                SqlConnection baglan = new SqlConnection(ConnectionString);

                baglan.Open();

                SqlCommand komut = new SqlCommand("insert into Ilaclar (ID, MarkaAdi, IlacKodu, AlisTutari, Stok, AlisTarihi, SGKKarsilama) values\r\n(@ID, @MarkaAdi, @IlacKodu, @AlisTutari, @Stok, @AlisTarihi, @SGKKarsilama) insert into AnaTablo (Marka) values (@MarkaAdi)", baglan);
                komut.Parameters.AddWithValue("@IlacKodu", (textBox2.Text));
                komut.Parameters.AddWithValue("@ID", int.Parse(textBox3.Text));
                komut.Parameters.AddWithValue("@MarkaAdi", (textBox4.Text));
                komut.Parameters.AddWithValue("@AlisTutari", int.Parse(textBox5.Text));
                komut.Parameters.AddWithValue("@Stok", int.Parse(textBox6.Text));
                komut.Parameters.AddWithValue("@AlisTarihi", DateTime.Parse(textBox7.Text));
                komut.Parameters.AddWithValue("@SGKKarsilama", int.Parse(textBox8.Text));

                SqlDataReader oku = komut.ExecuteReader();

                baglan.Close();

                string message = "Kayýt Baþarýyla Eklendi";
                string title = "Kayýt Güncelleme";
                MessageBox.Show(message, title);
            }

            


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "" ||
                textBox5.Text == "" ||
                textBox6.Text == "" ||
                textBox7.Text == "" ||
                textBox8.Text == ""
                )
            { }
            else
            {
                string ConnectionString = "Data Source=DESKTOP-LIN8EHF;Initial Catalog=Drugs;Integrated Security=True";

                SqlConnection baglan = new SqlConnection(ConnectionString);

                baglan.Open();

                SqlCommand komut = new SqlCommand("delete from Ilaclar where ID=@ID and MarkaAdi=@MarkaAdi and IlacKodu=@IlacKodu and AlisTutari=@AlisTutari and Stok=@Stok \r\nand AlisTarihi=@AlisTarihi and SGKKarsilama=@SGKKarsilama delete from AnaTablo where Marka=@MarkaAdi", baglan);
                komut.Parameters.AddWithValue("@IlacKodu", (textBox2.Text));
                komut.Parameters.AddWithValue("@ID", int.Parse(textBox3.Text));
                komut.Parameters.AddWithValue("@MarkaAdi", (textBox4.Text));
                komut.Parameters.AddWithValue("@AlisTutari", int.Parse(textBox5.Text));
                komut.Parameters.AddWithValue("@Stok", int.Parse(textBox6.Text));
                komut.Parameters.AddWithValue("@AlisTarihi", DateTime.Parse(textBox7.Text));
                komut.Parameters.AddWithValue("@SGKKarsilama", int.Parse(textBox8.Text));

                SqlDataReader oku = komut.ExecuteReader();

                baglan.Close();

                string message = "Kayýt Baþarýyla Silindi";
                string title = "Kayýt Güncelleme";
                MessageBox.Show(message, title);
            }

            

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();

            
        }
    }
}