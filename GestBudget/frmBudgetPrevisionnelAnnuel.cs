using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pique_Sous
{
    public partial class frmBudgetPrevisionnelAnnuel : Form
    {
        public frmBudgetPrevisionnelAnnuel()
        {
            InitializeComponent();
        }

        OleDbConnection connec = new OleDbConnection();
        private void frmBudgetPrevisionnelAnnuel_Load(object sender, EventArgs e)
        {
            setupDGV();
        }

        public void setupDGV()
        {

            
            //Mise en place de la connection string et on ouvre la connection
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
            connec.Open();

            try
            {
                String rqtPoste = "SELECT libPoste FROM Poste";
                OleDbCommand cdPoste = new OleDbCommand(rqtPoste, connec);
                OleDbDataReader dr = cdPoste.ExecuteReader();
                int c = 0;
                while (dr.Read())
                {
                    dgvPrevisionnelAnnuel.Rows.Add();
                    dgvPrevisionnelAnnuel.Rows[c].Cells[0].Value = dr.GetString(0);
                    c++;
                }
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! DGV \n " + erreur.Message);
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! DGV \n " + erreur.Message);
            }

        }
    }
}
