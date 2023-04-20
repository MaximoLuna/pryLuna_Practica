using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLuna_Practica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void txtTextoA_TextChanged(object sender, EventArgs e)
        {
            string varTextoA;
            varTextoA = txtTextoA.Text;
            label1.Text = varTextoA.Length.ToString();
        }

        private void txtTextoB_TextChanged(object sender, EventArgs e)
        {
            if (varTextoA.IndexOf(txtTextoB.Text) != -1)
            { 
                txtTextoB.BackColor = Color.Green; 
            }
            else 
            {
                
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            txtTextoB.Visible = true;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            //Reemplazar el texto
            //Capturar el texto, comparar si existe ese caracter en el TextoA
            //y pedir confirmacion de reemplazar
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            //label3.Text = dtpFecha.Value.ToString();
            label3.Text = dtpFecha.Value.Month.ToString();
        }
    }
}
