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

                OleDbDataAdapter da = new OleDbDataAdapter(cdPoste);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvPrevisionnelAnnuel.DataSource = dt;
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! DGV \n " + erreur.Message);
            }
            catch (OleDbException erreur)
            {
<<<<<<< HEAD
                while (drPoste.Read())
                {
                    
                }
=======
                MessageBox.Show("Erreur de requete SQL ! DGV \n " + erreur.Message);
>>>>>>> b96233da8362f83c3b15002a1808719841b04be3
            }

        }
    }
}
