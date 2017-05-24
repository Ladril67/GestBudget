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
        int lastCodeTransac=2;

        public frmBudgetMois()
        {
            InitializeComponent();
        }

        private void frmBudgetMois_Load(object sender, EventArgs e)
        {
            try
            {
                connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
                connec.Open();
                DataTable schema = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                

                string requete = @"select * from TypeTransaction";
                OleDbCommand cd1 = new OleDbCommand(requete, connec);
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cd1;


                da.Fill(ds, "TypeTransaction");

                remplitCbo(cboTypeTransa, "TypeTransaction", "libType", "codeType");
                connec.Close();
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
            }
        }

        private void btnAjoutTransa_Click(object sender, EventArgs e)
        {
            try
            {
                connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
                connec.Open();

                string date = dtpTransa.Value.ToString();
                string desc = txtDescriptionTransa.Text;
                string montant = txtMontantTransa.Text;
                string recette = chkRecette.Checked.ToString();
                string percu = chkPercu.Checked.ToString();
                int type = (int)cboTypeTransa.SelectedValue;

                //string requete = "insert into Transaction values ("+(lastCodeTransac+1)+","+date+","+desc+","+montant+","+recette+","+percu+","+type+")";
                //OleDbCommand cd1 = new OleDbCommand(requete, connec);
                //int c = (int)cd1.ExecuteScalar();
                MessageBox.Show("insert into Transaction values (" + (lastCodeTransac + 1) + "," + date + "," + desc + "," + montant + "," + recette + "," + percu + "," + type + ")");
                connec.Close();

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
            }
        }

        private void remplitCbo(ComboBox cb, string nomTable, string champAffiche, string champCache)
        {
            cb.DataSource = ds.Tables[nomTable];
            cb.DisplayMember = champAffiche;
            cb.ValueMember = champCache;
        }
    }
}
