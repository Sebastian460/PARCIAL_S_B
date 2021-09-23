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
    public partial class Modulo6 : Form
    {
        public Modulo6()
        {
            InitializeComponent();

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnM2_Click(object sender, EventArgs e)
        {
            Modulo2 M2 = new Modulo2();
            M2.Show();

        }

        private void BtnM4_Click(object sender, EventArgs e)
        {
            Modulo4 M4 = new Modulo4();
            M4.Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            GuardarPalabra();
        }

        private void GuardarPalabra()
        {
            string Tamaño = txtPalabra.Text;
            int Count = Tamaño.Length;
            string A =" ";

            for (int i = 0; i < Count; i++)
            {
                if (Tamaño[i] == ' ')
                    A += " ";
                else
                    A += " ____ ";
            }
            textBox1.Text=A;
         
                
           
           
            

        }
    }
}
