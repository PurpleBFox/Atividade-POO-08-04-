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
    public partial class frmsalarios : Form
    {   
        public frmsalarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPsalario_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double CarrosVendidos, ValorTotal, SalarioFixo, Comissao, Porc, SalarioTotal;

            
            Comissao = Convert.ToDouble(txtComissao.Text);
            SalarioFixo = Convert.ToDouble(txtSalarioFixo.Text);
            CarrosVendidos = Convert.ToDouble(txtCarrosVendidos.Text);
            ValorTotal = Convert.ToDouble(txtValorDeVendas.Text);

            Porc = (ValorTotal * 5) / 100;

            SalarioTotal =  Porc + Comissao + SalarioFixo;
            txtSalarioPorc.Text = Porc.ToString();
            txtSalarioFinal.Text = SalarioTotal.ToString(); 
        }

        private void lblText1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSalarioFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu inicial = new frmmenu();
            inicial.Show();
        }

        private void Salarios_Load(object sender, EventArgs e)
        {

        }

        private void txtSalarioPorc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
