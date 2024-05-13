using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OgrenciOtomasyon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbConnection bag  = new OleDbConnection();


            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i]is TextBox)
                {
                    Controls[i].Text = String.Empty;
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)== false && e.KeyChar != (char)(08))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)(32) && e.KeyChar != (char)(08))
            {
                e.Handled = true;
                txtAdress.Text = String.Empty;
            }
        }
    }
}
