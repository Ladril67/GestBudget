using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pique_Sous
{
    public partial class frmModificationPoste : Form
    {
        OleDbConnection connec = new OleDbConnection();
        DataSet ds = new DataSet();

        public frmModificationPoste()
        {
            InitializeComponent();
        }

        private void frmModificationPoste_Load(object sender, EventArgs e)
        {
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
            initContextMenu();
            MiseAJour();
        }

        private void MiseAJour()
        {
            remplirDGV();
        }

        private void initContextMenu()
        {
            dgvPeriod.ContextMenuStrip = cmsPeriod;
            dgvRevenu.ContextMenuStrip = cmsRevenu;
        }

        private void remplirDGV() //Remplit les dataGridView
        {
            try
            {
                DataTable dt = new DataTable();
                connec.Open();
                OleDbCommand cd1 = new OleDbCommand("SELECT * FROM [PostePeriodique]", connec);
                OleDbDataAdapter da1 = new OleDbDataAdapter(cd1);
                da1.Fill(dt);
                dgvPeriod.DataSource = dt;

                OleDbCommand cd2 = new OleDbCommand("SELECT * FROM [PosteRevenu]", connec);
                OleDbDataAdapter da2 = new OleDbDataAdapter(cd2);
                da2.Fill(dt);
                dgvRevenu.DataSource = dt;

                OleDbCommand cd3 = new OleDbCommand("SELECT R.codePoste, P.libPoste, R.datePrelevt, R.montantEcheance FROM [PosteRevenu] R, [Poste] P WHERE R.codePoste = P.codePoste", connec);
                OleDbDataAdapter da3 = new OleDbDataAdapter(cd3);
                da3.Fill(dt);
                dgvEcheance.DataSource = dt;

                connec.Close();

            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! DGV");
                MessageBox.Show(erreur.Message);
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! DGV");
                MessageBox.Show(erreur.Message);
            }
        }
    }
}
