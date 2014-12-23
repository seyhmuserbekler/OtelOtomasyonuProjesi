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
    public partial class Form5 : Form
    {

        SqlConnection baglanti;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=SEYHMUS\\SQLEXPRESS;Initial Catalog=OtelOtomasyonuSql;Integrated Security=true");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
           }


           try
           {
              SqlCommand komut = new SqlCommand("SELECT M.TCKimlik, M.Ad+' '+M.Soyad as AdSoyad, H.GirisTarihi, H.CikisTarihi, O.Isim FROM HangiOdadaKimVar as H LEFT JOIN Musteriler as M ON (H.MusteriID = M.ID) LEFT JOIN Odalar as O ON (H.OdaID = O.ID) WHERE M.TCKimlik = '"+Convert.ToString(textBox1.Text)+"'", baglanti);

               SqlDataAdapter adp = new SqlDataAdapter(komut);

               DataTable veriler = new DataTable();

                adp.Fill(veriler);

                listView1.Items.Clear();

               if (veriler.Rows.Count > 0)
               {
                    for (int i = 0; i < veriler.Rows.Count; i++)
                    {
                        DataRow satir = veriler.Rows[i];

                       if (satir.RowState != DataRowState.Deleted)
                        {
                           // ListViewItem item = new ListViewItem(satir["TCKimlik"].ToString());

                            ListViewItem item = new ListViewItem();
                            item.Text = satir["TCKimlik"].ToString();
                            item.SubItems.Add(satir["AdSoyad"].ToString());
                            item.SubItems.Add(satir["GirisTarihi"].ToString());
                            item.SubItems.Add(satir["GirisTarihi"].ToString());
                            item.SubItems.Add(satir["Isim"].ToString());
                            listView1.Items.Add(item);
                        }
                   }
                }
                else
               {
                    MessageBox.Show("Müşteri Bulunamadı");
                }

               
                baglanti.Close();
            
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
               
            }
       }

        private void ButonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButonGeri_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
        }
}

