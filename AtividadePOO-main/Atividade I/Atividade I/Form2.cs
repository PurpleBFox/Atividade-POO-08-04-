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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void priojetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmsalarios salarios = new frmsalarios();
            salarios.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nadadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmnadadores natacao = new frmnadadores();
            natacao.Show();
        }
    }
}
