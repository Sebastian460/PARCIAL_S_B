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
    public partial class Modulo4 : Form
    {
        public Modulo4()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string Actual = txtPalabra.Text;
            string Cambiado = " ";

            for (int i = Actual.Length; i -1>= 0; i--)
            {
                Cambiado += Actual.Substring(i, 1);
            }
            MessageBox.Show("Palabra Invertida"+ ":" + Cambiado + " ", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void BtnM1_Click(object sender, EventArgs e)
        {

        }

        private void BtnM2_Click(object sender, EventArgs e)
        {
            Modulo2 M2 = new Modulo2();
            M2.Show();
        }

        private void BtnM6_Click(object sender, EventArgs e)
        {
            Modulo6 M6 = new Modulo6();
            M6.Show();
        }
    }
}
