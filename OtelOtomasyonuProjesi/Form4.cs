using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtelOtomasyonuProjesi
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SEYHMUS\\SQLEXPRESS;Initial Catalog=OtelOtomasyonuSql;Integrated Security=true");
        DataTable tablo=new DataTable();

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

       
        private void Form4_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Musteriler",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }




        private void ButonKaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("SELECT * FROM Musteriler ", baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable veri = new DataTable();
            adapter.Fill(veri);



        }

    }

}
