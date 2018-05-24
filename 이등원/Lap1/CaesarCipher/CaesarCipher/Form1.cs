using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            string oupput = this.txtPlain.Text;
            this.txtCipher.Text = CaesarInto(oupput, (int)this.numShift.Value);
            this.txtPlain.Clear();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            string oupput = this.txtCipher.Text;
            this.txtPlain.Text = CaesarOut(oupput, (int)this.numShift.Value);
            this.txtCipher.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtPlain.Clear();
            this.txtCipher.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string CaesarInto(string value, int shift)
        {
            int shiftCal = shift % 26;
            char[] buffer = value.ToCharArray();
            
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsUpper(letter))
                {
                    letter = (char)(letter + shiftCal);

                    if (letter > 'Z')
                    {
                        letter = (char)(letter - 26);
                    }
                }

                if (char.IsLower(letter))
                {
                    letter = (char)(letter + shiftCal);

                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        public string CaesarOut(string value, int shift)
        {
            int shiftCal = shift % 26;
            char[] buffer = value.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsUpper(letter))
                {
                    letter = (char)(letter - shiftCal);

                    if (letter < 'A')
                    {
                        letter = (char)(letter + 26);
                    }
                }

                if (char.IsLower(letter))
                {
                    letter = (char)(letter - shiftCal);

                    if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                }

                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }

    
}
