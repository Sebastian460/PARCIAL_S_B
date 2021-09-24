using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_S_A
{
    public partial class MODULO_3 : Form
    {
        public MODULO_3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            int letras = 0;
            char letra = Convert.ToChar(textBox2.Text.Substring(0, 1));

            for (int i = 0; i < texto.Length - 1; i++)
            {
                char letrap = Convert.ToChar(textBox1.Text.Substring(i, 1));

                if (letrap == letra)
                {
                    letras++;
                }

                textBox3.Text = letras.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MODULO_1 M1 = new MODULO_1();
            M1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
