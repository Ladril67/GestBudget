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

        }

        public void setupDGV()
        {
            //Mise en place de la connection string et on ouvre la connection
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
            connec.Open();

            String rqtPoste = "Select libPoste FROM Poste";
            OleDbCommand cdPoste = new OleDbCommand(rqtPoste, connec);
            cdPoste.ExecuteNonQuery();

            OleDbDataReader drPoste = cdPoste.ExecuteReader();

            int k = 0;

            if (drPoste.HasRows)
            {
                while (drPoste.Read())
                {
                    
                }
            }
        }
    }
}
