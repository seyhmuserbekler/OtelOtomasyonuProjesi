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
        public SqlCommand kmt = new SqlCommand();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet dtst = new DataSet();


       

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
             adtr = new SqlDataAdapter("select * from Musteriler",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }




        private void ButonKaydet_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
             kmt = new SqlCommand("SELECT * FROM Musteriler ", baglanti);
              adtr = new SqlDataAdapter(kmt);

              adtr.Fill(tablo);


            if (textBox3.Text != "" && textBox1.Text != "" && comboBox1.Text != "")
            {
               
                kmt.Connection = baglanti;
                kmt.CommandText = "INSERT INTO Musteriler(TcKimlik,Ad,Soyad,Telefon,Cinsiyet) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "', '"+textBox3.Text+"' ,'" + comboBox1.Text + "') ";
                kmt.ExecuteNonQuery();
                kmt.CommandText = "INSERT INTO Odalar(Isim,Limit,Durum) VALUES ('" + comboBox4.Text + "','"+comboBox3.Text+"','"+comboBox2.Text+"') ";
                kmt.ExecuteNonQuery();
                kmt.CommandText = "INSERT INTO HangiOdadaKimVar(OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) VALUES ('" + comboBox4.Text + "', '" + textBox1.Text + "','" + dateTimePicker1.Value.ToShortTimeString() + "','" + dateTimePicker2.Text + "','" + comboBox2.Text + "') ";
                kmt.ExecuteNonQuery();
               // kmt.CommandText = "DELETE from HangiOdadaKimVar WHERE OdaID='" + comboBox3.Text + "'";
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                baglanti.Close();
                comboBox1.Items.Clear();
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                textBox2.Clear();
                comboBox1.Text = "";
                
               
                MessageBox.Show("Odanız Ayrılmıştır! ");
            }
            else
            {
                MessageBox.Show("Boş Alanları Doldurunuz!");
            }



        }

    }

}
