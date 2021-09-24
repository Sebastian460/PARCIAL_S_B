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
            Juego(txtPalabra.Text," ");
        }

        public void Juego(string Tamaño,string A)
        {
            int Count = Tamaño.Length;
            for (int i = 0; i < Count; i++)
            {
                if (Tamaño[i] == ' ')
                    A += " ";
                else
                    A += " ____ ";
            }
            textBox1.Text = A;
        }

        public void BtnA_Click(object sender, EventArgs e)

        {

            LetraNoVerificada(BtnA.Text,Convert.ToInt32(lblVidas.Text),txtPalabra.Text);
            LetraVerificada(BtnA.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnA.Text);
            BtnA.Enabled = false;
            VerificarGanoP(BtnA.Text,txtPalabra.Text, Convert.ToInt32(lblVidas.Text),textBox1.Text);
        }

        private void LetraPuesta(string var)
        {
            textBox2.Text += " "+var;
        }

        public void LetraNoVerificada(string var, int Vidas, string Tamaño)
        {

            if (Tamaño.IndexOf(var) == -1)
                Vidas--;
            lblVidas.Text =Convert.ToString(Vidas);

            
        }
        public void LetraVerificada(string var, string Tamaño, string A)
        {
            int Count = Tamaño.Length;
            string MostrarPalabra = "";
            for (int i = 0; i < Count; i++)
            {
                if (var == Convert.ToString(Tamaño[i]))
                    MostrarPalabra += var;
                else
                    MostrarPalabra += Convert.ToString(A[i]);
            }
            textBox1.Text += MostrarPalabra;
            
        }

        public void VerificarGanoP(string var,string Tamaño,int Vidas,string A)
        {
            if(A.IndexOf("__")<0)
            {
                MessageBox.Show("Felicidades has encontrado la palabra" + ":" + txtPalabra+ " ", "enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
            if (Vidas==0)
            {
                MessageBox.Show("Te has quedado sin intentos" + ":"+ "0", "Lo siento", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnB.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnB.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnB.Text);
            BtnB.Enabled = false;
            VerificarGanoP(BtnB.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnC.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnC.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnC.Text);
            BtnC.Enabled = false;
            VerificarGanoP(BtnC.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnD.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnD.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnD.Text);
            BtnD.Enabled = false;
            VerificarGanoP(BtnD.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnE.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnE.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnE.Text);
            BtnE.Enabled = false;
            VerificarGanoP(BtnE.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnF.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnF.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnF.Text);
            BtnF.Enabled = false;
            VerificarGanoP(BtnF.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnG_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnG.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnG.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnG.Text);
            BtnG.Enabled = false;
            VerificarGanoP(BtnG.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnH.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnH.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnH.Text);
            BtnH.Enabled = false;
            VerificarGanoP(BtnH.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnI_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnI.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnI.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnI.Text);
            BtnI.Enabled = false;
            VerificarGanoP(BtnI.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnJ.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnJ.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnJ.Text);
            BtnJ.Enabled = false;
            VerificarGanoP(BtnJ.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnK_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnK.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnK.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnK.Text);
            BtnK.Enabled = false;
            VerificarGanoP(BtnK.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnL.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnL.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnL.Text);
            BtnL.Enabled = false;
            VerificarGanoP(BtnL.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnM.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnM.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnM.Text);
            BtnM.Enabled = false;
            VerificarGanoP(BtnM.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnN.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnN.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnN.Text);
            BtnN.Enabled = false;
            VerificarGanoP(BtnN.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnÑ_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnÑ.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnÑ.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnÑ.Text);
            BtnÑ.Enabled = false;
            VerificarGanoP(BtnÑ.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnO.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnO.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnO.Text);
            BtnO.Enabled = false;
            VerificarGanoP(BtnO.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnP.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnP.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnP.Text);
            BtnP.Enabled = false;
            VerificarGanoP(BtnP.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnQ.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnQ.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnQ.Text);
            BtnQ.Enabled = false;
            VerificarGanoP(BtnQ.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnR.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnR.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnR.Text);
            BtnR.Enabled = false;
            VerificarGanoP(BtnR.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnS.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnS.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnS.Text);
            BtnS.Enabled = false;
            VerificarGanoP(BtnS.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnT.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnT.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnT.Text);
            BtnT.Enabled = false;
            VerificarGanoP(BtnT.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnU_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnU.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnU.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnU.Text);
            BtnU.Enabled = false;
            VerificarGanoP(BtnU.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnV.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnV.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnV.Text);
            BtnV.Enabled = false;
            VerificarGanoP(BtnV.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnW_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnW.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnW.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnW.Text);
            BtnW.Enabled = false;
            VerificarGanoP(BtnW.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnX.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnX.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnX.Text);
            BtnX.Enabled = false;
            VerificarGanoP(BtnX.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnY_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnY.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnY.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnY.Text);
            BtnY.Enabled = false;
            VerificarGanoP(BtnY.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            LetraNoVerificada(BtnZ.Text, Convert.ToInt32(lblVidas.Text), txtPalabra.Text);
            LetraVerificada(BtnZ.Text, txtPalabra.Text, textBox1.Text);
            LetraPuesta(BtnZ.Text);
            BtnZ.Enabled = false;
            VerificarGanoP(BtnZ.Text, txtPalabra.Text, Convert.ToInt32(lblVidas.Text), textBox1.Text);
        }
    }
}
