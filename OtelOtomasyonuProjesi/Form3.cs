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
    public partial class Form3 : Form
        {

        SqlConnection baglanti = new SqlConnection("Data Source=SEYHMUS\\SQLEXPRESS;Initial Catalog=OtelOtomasyonuSql;Integrated Security=true");
        DataTable tablo = new DataTable();
        public SqlCommand kmt = new SqlCommand();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet dtst = new DataSet();

        public Form3()
        {
            InitializeComponent();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }


        Button[] b = new Button[28];


        public static int oda = 0;

        private void tikla(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            try
            {
                Form6 frm6 = new Form6();
                oda = Convert.ToInt32(b.Name);

                frm6.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Oda Boş");
            }

            
        }

            private void Form3_Load(object sender, EventArgs e)
              {
            adtr = new SqlDataAdapter("select ID from Odalar where Durum='dolu'", baglanti);
            adtr.Fill(tablo);

            b[1] = button1;
            b[2] = button2;
            b[3] = button3;
            b[4] = button4;
            b[5] = button5;
            b[6] = button6;
            b[7] = button7;
            b[8] = button8;
            b[9] = button9;
            b[10] = button10;
            b[11] = button11;
            b[12] = button12;
            b[13] = button13;
            b[14] = button14;
            b[15] = button15;
            b[16] = button16;
            b[17] = button17;
            b[18] = button18;
            b[19] = button19;
            b[20] = button20;
            b[21] = button21;
            b[22] = button22;
            b[23] = button23;
            b[24] = button24;
            b[25] = button25;
            b[26] = button26;
            b[27] = button27;

            

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                string odaID = tablo.Rows[i][0].ToString();
                b[Convert.ToInt32(odaID)].BackColor = Color.Red;
                b[Convert.ToInt32(odaID)].Name = tablo.Rows[i][0].ToString();
            }

            b[1].Click += new System.EventHandler(this.tikla);
            b[2].Click += new System.EventHandler(this.tikla);
            b[3].Click += new System.EventHandler(this.tikla);
            b[4].Click += new System.EventHandler(this.tikla);
            b[5].Click += new System.EventHandler(this.tikla);
            b[6].Click += new System.EventHandler(this.tikla);
            b[7].Click += new System.EventHandler(this.tikla);
            b[8].Click += new System.EventHandler(this.tikla);
            b[9].Click += new System.EventHandler(this.tikla);
            b[10].Click += new System.EventHandler(this.tikla);
            b[11].Click += new System.EventHandler(this.tikla);
            b[12].Click += new System.EventHandler(this.tikla);
            b[13].Click += new System.EventHandler(this.tikla);
            b[14].Click += new System.EventHandler(this.tikla);
            b[15].Click += new System.EventHandler(this.tikla); 
            b[16].Click += new System.EventHandler(this.tikla);
            b[17].Click += new System.EventHandler(this.tikla);
            b[18].Click += new System.EventHandler(this.tikla);
            b[19].Click += new System.EventHandler(this.tikla);
            b[20].Click += new System.EventHandler(this.tikla);
            b[21].Click += new System.EventHandler(this.tikla);
            b[22].Click += new System.EventHandler(this.tikla);
            b[23].Click += new System.EventHandler(this.tikla);
            b[24].Click += new System.EventHandler(this.tikla);
            b[25].Click += new System.EventHandler(this.tikla);
            b[26].Click += new System.EventHandler(this.tikla);
            b[27].Click += new System.EventHandler(this.tikla);

        }
    }
}
