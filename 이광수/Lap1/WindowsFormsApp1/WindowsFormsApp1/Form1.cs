using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt01_Click(object sender, EventArgs e)
        {
            byte[] ascii = Encoding.ASCII.GetBytes(txtPlain01.Text);
            for (int i=0; i< ascii.Length; i++)
            {
                if (ascii[i] > 64 && ascii[i] < 91)
                {
                    ascii[i] = (byte)(65+(ascii[i]-65+numericUpDown1.Value)%26);
                }
                else if (ascii[i] > 96 && ascii[i] < 123)
                {
                    ascii[i] = (byte)(97+(ascii[i]-97+numericUpDown1.Value)%26);
                }
            }
            txtDecrypt01.Text = Encoding.ASCII.GetString(ascii);
        }

        private void btnDecrypt01_Click(object sender, EventArgs e)
        {
            byte[] ascii = Encoding.ASCII.GetBytes(txtDecrypt01.Text);
            for (int i = 0; i < ascii.Length; i++)
            {
                if (ascii[i] > 64 && ascii[i] < 91)
                {
                    ascii[i] = (byte)(90-(90-ascii[i]+numericUpDown1.Value)%26);
                }
                else if (ascii[i] > 96 && ascii[i] < 123)
                {
                    ascii[i] = (byte)(122-(122-ascii[i]+numericUpDown1.Value)%26);                }
                }
            //txtDecrypt01.Text = Convert.ToInt32(ascii);
            txtPlain01.Text = Encoding.ASCII.GetString(ascii);
        }

        private void btnReset01_Click(object sender, EventArgs e)
        {
            txtPlain01.Text = "";
            txtDecrypt01.Text = "";
        }

        private void btnExit01_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
