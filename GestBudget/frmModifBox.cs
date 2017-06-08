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
    public partial class frmModifBox : Form
    {

        public frmModifBox(string contenu)
        {
            InitializeComponent();
            txtContenu.Text = contenu;
        }

        public string Contenu { get; set; }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Contenu = txtContenu.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
