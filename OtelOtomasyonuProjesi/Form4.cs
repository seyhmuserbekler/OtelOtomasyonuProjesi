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
            // TODO: This line of code loads data into the 'otelOtomasyonuSqlDataSet.Odalar' table. You can move, or remove it, as needed.
            this.odalarTableAdapter.Fill(this.otelOtomasyonuSqlDataSet.Odalar);
            adtr = new SqlDataAdapter("select * from Musteriler",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

            DataTable tablo2 = new DataTable();
            adtr = new SqlDataAdapter("select ID from Odalar where Durum='bos'", baglanti);
            adtr.Fill(tablo2);
            comboBox3.DataSource = tablo2;
            comboBox3.DisplayMember = "ID";
            comboBox3.ValueMember = "ID";

            comboBox3.SelectedText = " ";
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
                kmt.CommandText = "UPDATE Odalar SET Durum='dolu' where ID='"+comboBox3.Text+"'";
                kmt.ExecuteNonQuery();
                kmt.CommandText = "INSERT INTO HangiOdadaKimVar(OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) VALUES ('" + comboBox3.Text + "', '" + textBox1.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "','" + comboBox2.Text + "') ";
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.odalarTableAdapter.FillBy(this.otelOtomasyonuSqlDataSet.Odalar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.odalarTableAdapter.FillBy1(this.otelOtomasyonuSqlDataSet.Odalar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.odalarTableAdapter.FillBy2(this.otelOtomasyonuSqlDataSet.Odalar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.odalarTableAdapter.FillBy4(this.otelOtomasyonuSqlDataSet.Odalar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.odalarTableAdapter.FillBy4(this.otelOtomasyonuSqlDataSet.Odalar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.odalarTableAdapter.FillBy4(this.otelOtomasyonuSqlDataSet.Odalar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.odalarTableAdapter.FillBy(this.otelOtomasyonuSqlDataSet.Odalar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.odalarTableAdapter.FillBy(this.otelOtomasyonuSqlDataSet.Odalar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.odalarTableAdapter.FillBy(this.otelOtomasyonuSqlDataSet.Odalar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğine emin misiniz?", "Sil",MessageBoxButtons.YesNo);

	    switch (result)
	        {
	     	case DialogResult.Yes:
		    {
                string ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                baglanti.Open();
                kmt.Connection = baglanti;
                kmt.CommandText = "DELETE from Musteriler WHERE ID='" + ID + "'";
                kmt.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi basarılı..");
			break;
		    }
		    case DialogResult.No:
		    {
			break;
		    }
	    }
            

        }

    }

}
