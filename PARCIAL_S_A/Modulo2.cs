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
    public partial class Modulo2 : Form
    {
        public Modulo2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            int lado;
            int altura;
            lado = int.Parse(BaseC.Text);
            altura = int.Parse(AlturaC.Text);

            int Res = lado * altura;

            MessageBox.Show("EL AREA DEL CUADRADO ES :" + Res + " ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnM6_Click(object sender, EventArgs e)
        {
            Modulo6 M6 = new Modulo6();
            M6.Show();
        }

        private void BtnM1_Click(object sender, EventArgs e)
        {

        }

        private void BtnM4_Click(object sender, EventArgs e)
        {
            Modulo4 M4 = new Modulo4(); 
            M4.Show();
        }
    }
}
