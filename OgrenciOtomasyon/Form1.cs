using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyon
{
    public partial class Form1 : Form
    {

        public static string adSoyad = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtKullanici.Text.Trim().ToLower()
                == "admin" && txtSifre.Text == "1234")
            {
                
                adSoyad = txtAdSoyad.Text;
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();



            }
            else
            {
                lblMsg.Text = "Hatalı kullanıcı adı şifre";
                txtKullanici.Text = "";
                txtSifre.Clear();



            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            this.AcceptButton = btnGiris;
            this.CancelButton = btnCikis;

        }
    }
}
