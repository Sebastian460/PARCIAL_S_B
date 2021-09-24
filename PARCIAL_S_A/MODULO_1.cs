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
    public partial class MODULO_1 : Form
    {
        private object txtnumero1;
        private object txtnumero2;

        public MODULO_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            int mayor;

            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            if (numero1 >= numero2)
                mayor = numero1;
            else
                mayor = numero2;

            textBox3.Text = mayor.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MODULO_3 M3 = new MODULO_3();
            M3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MODULO_5 M5 = new MODULO_5();
            M5.Show();
        }
    }
}
