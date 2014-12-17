using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtelOtomasyonuProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin" && textBox2.Text=="123")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("şifre veya kullanıcı adı hatalı!!");
            }
        }

       
    }
}
