using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelOtomasyonuProjesi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=SEYHMUS\\SQLEXPRESS;Initial Catalog=OtelOtomasyonuSql;Integrated Security=true");
        DataTable tablo = new DataTable();
        public SqlCommand kmt = new SqlCommand();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet dtst = new DataSet();

        private void Form6_Load(object sender, EventArgs e)
        {
            int odaID = Form3.oda;


            adtr = new SqlDataAdapter("select TCKimlik,Ad,Soyad,Telefon,Cinsiyet,Odalar.ID,Limit, GirisTarihi,CikisTarihi from Musteriler inner join  HangiOdadaKimVar  on Musteriler.TCKimlik=HangiOdadaKimVar.MusteriID inner join Odalar on Odalar.ID=HangiOdadaKimVar.OdaID where HangiOdadaKimVar.OdaID='"+odaID.ToString()+"'", baglanti);
            adtr.Fill(tablo);


            tc.Text = tablo.Rows[0][0].ToString();
            ad.Text = tablo.Rows[0][1].ToString();
            soyad.Text = tablo.Rows[0][2].ToString();
            tel.Text = tablo.Rows[0][3].ToString();
            cins.Text = tablo.Rows[0][4].ToString();
            kackisi.Text = tablo.Rows[0][6].ToString();
            oda.Text = tablo.Rows[0][5].ToString();
            gtarih.Text = string.Format("{0:d}", tablo.Rows[0][7]);
            ctarih.Text = string.Format("{0:d}", tablo.Rows[0][8]);

           // gtarih.Text = tablo.Rows[0][7].ToString();
           // ctarih.Text = tablo.Rows[0][8].ToString();


           

            
        }

        private void button28_Click(object sender, EventArgs e)
           {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


             DialogResult result = MessageBox.Show("silmek istediğinizden emin misiniz?", "Sil",
		MessageBoxButtons.YesNo);
	    switch (result)
	    {
		case DialogResult.Yes:
		    {


            kmt.Connection = baglanti;
            kmt.CommandText = "UPDATE Odalar SET Durum='bos' where ID='" + Form3.oda + "'";
            kmt.ExecuteNonQuery();
            baglanti.Close();

            tc.Text = "";
            ad.Text = "";
            soyad.Text = "";
            tel.Text = "";
            cins.Text = "";
            kackisi.Text = "";
            oda.Text = "";
            gtarih.Text = "";
            ctarih.Text = "";

            MessageBox.Show("Oda boşaltıldı");
            break;
            }
        case DialogResult.No:
            {
                break;
            }
        }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
