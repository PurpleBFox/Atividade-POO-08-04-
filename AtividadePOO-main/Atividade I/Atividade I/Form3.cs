using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_I
{
    public partial class frmnadadores : Form
    {
        public frmnadadores()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmmenu inicial = new frmmenu();
            inicial.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distancia, ganho;

            distancia = Convert.ToDouble(txtDistancia.Text);
           

             if (distancia < 800)
            {
                ganho = 5000.00;
            }
             else if(distancia >= 800 &&  distancia <= 1500)
            {
                ganho = 10000.00;
            }
            else
            {
                ganho = 15000.00;
            }

            txtValor.Text = ganho.ToString();
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
