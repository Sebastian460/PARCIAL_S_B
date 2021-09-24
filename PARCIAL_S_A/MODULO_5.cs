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
    public partial class MODULO_5 : Form
    {
        public MODULO_5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.ReadLine());
            String exp;
            bool pangrama = true;
            for (int i = 0; i < n; i++, pangrama = true)
            {
                exp = textBox1.ReadLine();
                for (char ascii = 'A'; ascii <= 'Z'; ascii++)
                {
                    if (!exp.ToUpper().Contains("" + ascii))
                    {
                        pangrama = false;
                        break;
                    }
                }
                textBox1.WriteLine((pangrama ? "SI" : "NO"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MODULO_1 M1 = new MODULO_1();
            M1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MODULO_3 M3 = new MODULO_3();
            M3.Show();
        }
    }
}
