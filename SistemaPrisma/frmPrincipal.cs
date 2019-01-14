using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrisma
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            
            InitializeComponent();
                
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario frmFunc = new frmFuncionario();
            frmFunc.Show();

            
            
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ordemDeServiçoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmOrdemServiço frmOS = new frmOrdemServiço();
            frmOS.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa frmEmp = new frmEmpresa();
            frmEmp.Show();
        }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario frmInv = new frmInventario();
            frmInv.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmUser = new frmUsuario();
            frmUser.Show();
        }
    }
}
