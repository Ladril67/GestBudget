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
    public partial class frmBudgetMois : Form
    {
        OleDbConnection connec = new OleDbConnection();
        DataSet ds = new DataSet();
        DataSet dsTransac = new DataSet();
        int lastCodeTransac = 0;

        public frmBudgetMois()
        {
            InitializeComponent();
        }

        private void frmBudgetMois_Load(object sender, EventArgs e)
        {
            remplirParticipants();
            remplirDGV();
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

                OleDbCommand cd2 = new OleDbCommand("SELECT [Transaction].* FROM[Transaction]", connec);
                lastCodeTransac = (int)cd2.ExecuteNonQuery();
                MessageBox.Show("" + lastCodeTransac);
                connec.Close();
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! formLoad");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! formLoad");
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

                string requete = "insert into Transaction values (" + (lastCodeTransac + 1) + "," + date + "," + desc + "," + montant + "," + recette + "," + percu + "," + type + ")";
                OleDbCommand cd1 = new OleDbCommand(requete, connec);
                int c = (int)cd1.ExecuteScalar();
                MessageBox.Show(requete);

                foreach (CheckBox chk in grpParticipantsTransa.Controls)
                {
                    if (chk.Checked)
                    {
                        //recupération codePersonne
                        string[] perso = chk.Text.ToLower().Split(' ');
                        requete = "select codePersonne from Personne where lower(pnPersonne) = '" + perso[0] + "' and lower(nomPersonne) = '" + perso[1] + "'";
                        OleDbCommand cd2 = new OleDbCommand(requete, connec);
                        int codePerso = (int)cd2.ExecuteScalar();
                        MessageBox.Show(requete);
                        //ajout dans table Bénéficiaires
                        requete = "insert into Beneficiaires values (" + (lastCodeTransac + 1) + "," + codePerso + ")";
                        OleDbCommand cd3 = new OleDbCommand(requete, connec);
                        cd3.ExecuteNonQuery();
                        MessageBox.Show(requete);
                    }
                }
                connec.Close();

            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! ajoutTransa");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! ajoutTransa");
            }
        }

        private void remplitCbo(ComboBox cb, string nomTable, string champAffiche, string champCache)
        {
            cb.DataSource = ds.Tables[nomTable];
            cb.DisplayMember = champAffiche;
            cb.ValueMember = champCache;
        }

        private void remplirParticipants()
        {
            //Mise en place de la connection string et on ouvre la connection
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
            connec.Open();

            //On récupère les données de la table pour travailler en mode déconnecté
            DataTable tbl1 = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                new object[] { null, null, null, "TABLE" });
            foreach (DataRow ds in tbl1.Rows)
            {
                if (ds[2].ToString() == "Personne")
                {
                    //Création et execution de la requête SQL permettant de récupérer les noms et prénoms des participants
                    OleDbCommand cd1 = new OleDbCommand();
                    cd1.Connection = connec;
                    cd1.CommandType = CommandType.Text;
                    cd1.CommandText = "Select pnPersonne,nomPersonne from Personne";
                    int nb = cd1.ExecuteNonQuery();

                    OleDbDataReader dr = cd1.ExecuteReader();


                    //création et indentation des checkbox générées dynamiquements
                    if (dr.HasRows)
                    {
                        int top = 25;
                        int left = 15;
                        int i = 0;
                        while (dr.Read())
                        {
                            CheckBox cbPersonne = new CheckBox();
                            cbPersonne.Text = dr[nb].ToString() + " " + dr[nb + 1].ToString();

                            cbPersonne.Top = top + i * 10;
                            cbPersonne.Left = left;
                            cbPersonne.AutoSize = true;

                            i += 2;
                            grpParticipantsTransa.Controls.Add(cbPersonne);

                        }
                    }
                }

            }
            connec.Close();
        }

        private void txtMontantTransa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!txtMontantTransa.Text.Contains(",") && txtMontantTransa.Text != "")
            {
                //Gestion de la virgule
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                //Gestion des chiffres
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                //Gestion du Backspace/sup
                e.Handled = false;
            }
            else
            {
                //Gestion du reste des characteres
                e.Handled = true;
            }
        }
        private void btnSuivant_Click(object sender, EventArgs e)
        {

        }

        private void btnAvant_Click(object sender, EventArgs e)
        {
            init1a1();
        }

        private void init1a1()
        {
            try
            {
                connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
                connec.Open();
                OleDbCommand cd1 = new OleDbCommand("SELECT [Transaction].* FROM[Transaction]", connec);

                OleDbDataReader dr = cd1.ExecuteReader();

                DataTable schemaTable = dr.GetSchemaTable();

                DataRow ligne;
                ligne = schemaTable.Rows[2];
                lblCode.Text = ligne[0].ToString();

                connec.Close();

            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! 1a1");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! 1a1");
            }
            finally
            {
            }
        }

        private void remplirDGV() //Remplit la dataGridView dans Suppression d'une transaction
        {
            try
            {
                connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
                connec.Open();
                OleDbCommand cd1 = new OleDbCommand("SELECT [Transaction].* FROM[Transaction]", connec);

                OleDbDataReader dr = cd1.ExecuteReader();

                DataTable schemaTable = dr.GetSchemaTable();

                dgvTransactions.DataSource = schemaTable;
                
                connec.Close();

            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! DGV");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! DGV");
            }
            finally
            {
            }
        }
    }
}

