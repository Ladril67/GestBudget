using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pique_Sous
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBudgetMois_Click(object sender, EventArgs e)
        {
            frmBudgetMois form = new frmBudgetMois();
            form.ShowDialog();
        }

        private void btnPrevisionnel_Click(object sender, EventArgs e)
        {
            frmPrevisionnel form = new frmPrevisionnel();
            form.ShowDialog();
        }
    }
}
