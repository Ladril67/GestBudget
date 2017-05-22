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

namespace GestBudget
{
    public partial class frmBudgetMois : Form
    {
        OleDbConnection connec = new OleDbConnection();
        DataSet ds = new DataSet();

        public frmBudgetMois()
        {
            InitializeComponent();
        }

        private void frmBudgetMois_Load(object sender, EventArgs e)
        {/*
            try
            {
                connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ladri\DUT\A21\MINI_PROJET\GestBudget\budget.mdb";
                connec.Open();
                DataTable schema = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                connec.Close();

                string requete = "";
                string nomTable = "";

                foreach (DataRow ligne in schema.Rows)
                {
                    nomTable = ligne[2].ToString();
                    requete = @"select * from " + nomTable;
                    OleDbCommand cd1 = new OleDbCommand(requete, connec);
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    da.SelectCommand = cd1;


                    da.Fill(ds, nomTable);

                }

            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion !");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL !");
            }
            finally
            {
            }*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
