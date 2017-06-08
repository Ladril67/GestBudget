using sharpPDF;
using sharpPDF.Enumerators;
using sharpPDF.Tables;
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

        //Pour Onglet 1a1
        int ligneTable = 0;

        public frmBudgetMois()
        {
            InitializeComponent();
        }

        private void frmBudgetMois_Load(object sender, EventArgs e)
        {
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
            MiseAJour();
        }

        private void remplitCbo(ComboBox cb, string nomTable, string champAffiche, string champCache)
        {
            cb.DataSource = ds.Tables[nomTable];
            cb.DisplayMember = champAffiche;
            cb.ValueMember = champCache;
        }

        private void remplirParticipants()
        {
            grpParticipantsTransa.Controls.Clear();
            try
            {
                //Mise en place de la connection string et on ouvre la connection
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
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! : RemplirParticipant");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! : RemplirParticipant");
            }
            finally
            {
            }
        }

        private void MiseAJour()
        {
            init1a1(1);
            remplirParticipants();
            remplirDGV();
            try
            {

                connec.Open();

                ds.Clear();
                string requete = @"select * from TypeTransaction";
                OleDbCommand cd1 = new OleDbCommand(requete, connec);
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cd1;

                da.Fill(ds, "TypeTransaction");

                remplitCbo(cboTypeTransa, "TypeTransaction", "libType", "codeType");
                remplitCbo(cboModType, "TypeTransaction", "libType", "codeType");
                remplitCbo(cboRecapLib, "TypeTransaction", "libType", "codeType");

                OleDbCommand cd2 = new OleDbCommand("SELECT MAX([Transaction].CodeTransaction) FROM [Transaction]", connec);
                lastCodeTransac = (int)cd2.ExecuteScalar();
                connec.Close();
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! miseajour");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! miseajour");
            }
        }

        //Onglet AjouterTransaction
        private void btnAjoutTransa_Click(object sender, EventArgs e)
        {
            try
            {
                connec.Open();
                DateTime date = dtpTransa.Value;
                string desc = txtDescriptionTransa.Text;
                string montant = txtMontantTransa.Text;
                string recette = chkRecette.Checked.ToString();
                string percu = chkPercu.Checked.ToString();
                int type = (int)cboTypeTransa.SelectedValue;

                lastCodeTransac++;
                string requete = "INSERT INTO [Transaction] VALUES (" + lastCodeTransac + ",'" + date.ToString() + "', '" + desc + "'," + montant + "," + recette + "," + percu + ",'" + type + "')";
                OleDbCommand cd1 = new OleDbCommand(requete, connec);
                cd1.ExecuteNonQuery();

                foreach (CheckBox chk in grpParticipantsTransa.Controls)
                {
                    if (chk.Checked)
                    {
                        //recupération codePersonne
                        string[] perso = chk.Text.Split(' ');
                        requete = "SELECT [Personne].[codePersonne] FROM [Personne] WHERE [pnPersonne] = '" + perso[0] + "' AND [nomPersonne] = '" + perso[1] + "'";
                        OleDbCommand cd2 = new OleDbCommand(requete, connec);
                        int codePerso = (int)cd2.ExecuteScalar();
                        //ajout dans table Bénéficiaires
                        requete = "INSERT INTO [Beneficiaires] VALUES (" + lastCodeTransac + "," + codePerso + ")";
                        OleDbCommand cd3 = new OleDbCommand(requete, connec);
                        cd3.ExecuteNonQuery();
                    }
                }
                connec.Close();
                MessageBox.Show("Transaction ajoutée !");
                MiseAJour();

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

        private void btnAjouterPersonneTransa_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Voulez vous vraiment ajouter cette transaction ?", "Ajout", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                try
                {
                    connec.Open();
                    string requete = "SELECT MAX(codePersonne) FROM Personne";
                    OleDbCommand cd = new OleDbCommand(requete, connec);
                    int codePers = (int)cd.ExecuteScalar() + 1;

                    requete = "INSERT INTO [Personne] VALUES (" + codePers + ",'" + txtNomNewPers.Text + "','" + txtPrenomNewPers.Text + "', null)";
                    OleDbCommand cd1 = new OleDbCommand(requete, connec);
                    cd1.ExecuteNonQuery();
                    connec.Close();
                    MessageBox.Show("Personne ajoutée !");
                    MiseAJour();
                }
                catch (InvalidOperationException erreur)
                {
                    MessageBox.Show("Erreur de chaine de connexion ! ajoutPers");
                    MessageBox.Show(erreur.Message);
                }
                catch (OleDbException erreur)
                {
                    MessageBox.Show("Erreur de requete SQL ! ajoutPers");
                    MessageBox.Show(erreur.Message);
                }
            }
            else
            {
                MessageBox.Show("Ben faut être sûr");
            }
        }

        private void btnSupprPers_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Voulez vous vraiment supprimer la/les personne(s) ?", "Suppression", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                try
                {
                    connec.Open();
                    string requete = "";
                    foreach (CheckBox chk in grpParticipantsTransa.Controls)
                    {
                        if (chk.Checked)
                        {
                            //recupération codePersonne
                            string[] perso = chk.Text.Split(' ');
                            requete = "DELETE FROM [Personne] WHERE [nomPersonne] = '"+perso[1]+"' AND [pnPersonne] = '"+perso[0]+"'";
                            OleDbCommand cd2 = new OleDbCommand(requete, connec);
                            cd2.ExecuteNonQuery();
                        }
                    }
                    connec.Close();
                    MessageBox.Show("Personne(s) supprimée(s) !");
                    MiseAJour();
                }
                catch (InvalidOperationException erreur)
                {
                    MessageBox.Show("Erreur de chaine de connexion ! supprPers");
                    MessageBox.Show(erreur.Message);
                }
                catch (OleDbException erreur)
                {
                    MessageBox.Show("Erreur de requete SQL ! supprPers");
                    MessageBox.Show(erreur.Message);
                }
            }
            else
            {
                MessageBox.Show("Ben faut être sûr");
            }
        }
        
        private void txtMontantTransa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtMontantTransa.Text.Contains(",") && txtMontantTransa.Text != "" && e.KeyChar == ',')
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
        
        //Onglet  1a1
        private void btnDernier_Click(object sender, EventArgs e)
        {
            init1a1(2);
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            init1a1(-2);
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            init1a1(1);
        }

        private void btnAvant_Click(object sender, EventArgs e)
        {
            init1a1(-1);
        }

        private void init1a1(int ligne)
        {
            try
            {
                lvPersonne.Items.Clear();
                List<int> max = new List<int>();
                string jointure = "";
                int codeTransaction = 0;
                List<int> Personne = new List<int>();
                OleDbCommand cd0 = new OleDbCommand("SELECT [codeTransaction] FROM[Transaction]", connec);
                connec.Open();
                OleDbDataReader dr0 = cd0.ExecuteReader();
                while (dr0.Read())
                {
                    max.Add(dr0.GetInt32(0));
                }

                if(ligne == -2)
                {
                    ligne = 1;
                    ligneTable = 1;
                }
                else if(ligne == -1)
                {
                    if(ligneTable == 1)
                    {
                        ligne = 1;
                    }
                    else
                    {
                        ligneTable--;
                        ligne = ligneTable;
                    }
                }
                else if(ligne == 1)
                {
                    if(ligneTable == max.Count)
                    {
                        ligne = max.Count;
                    }
                    else
                    {
                        ligneTable++;
                        ligne = ligneTable;
                    }
                }
                else
                {
                    ligne = max.Count;
                    ligneTable = max.Count;
                }

                OleDbCommand cd1 = new OleDbCommand("SELECT [Transaction].* FROM[Transaction] where [codeTransaction] = " + ligne, connec);
                OleDbDataReader dr1 = cd1.ExecuteReader();

                while (dr1.Read())
                {
                    lblCode.Text = dr1.GetInt32(0).ToString();
                    codeTransaction = dr1.GetInt32(0);
                    dtp1a1.Value = dr1.GetDateTime(1);
                    lblDescription.Text = dr1.GetString(2);
                    lblValeur.Text = dr1.GetValue(3).ToString() + " €";
                    checkRecette.Checked = dr1.GetBoolean(4);
                    chkPercu.Checked = dr1.GetBoolean(5);
                    if (dr1[6].ToString() == "")
                    {
                        jointure = "";
                    }
                    else
                    {
                        jointure = dr1.GetInt32(6).ToString();

                    }
                }

                if (jointure != "")
                {
                    //Pour eviter de faire une requette avec une jointure
                    OleDbCommand cd2 = new OleDbCommand("SELECT [TypeTransaction].* FROM [TypeTransaction] where [codeType] = " + jointure, connec);
                    OleDbDataReader dr2 = cd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        lblType.Text = dr2.GetString(1);
                    }
                }
                else
                {
                    lblType.Text = "Type NULL";
                }
                

                OleDbCommand cd3 = new OleDbCommand("SELECT [CodePersonne] FROM[Beneficiaires] where [codeTransaction] =" + codeTransaction, connec);
                OleDbDataReader dr3 = cd3.ExecuteReader();
                while (dr3.Read())
                {
                    Personne.Add(dr3.GetInt32(0));
                }
                for(int i=0;i< Personne.Count(); i++)
                {
                    OleDbCommand cd4 = new OleDbCommand("SELECT [nomPersonne],[pnPersonne] FROM[Personne] where [codePersonne] =" + Personne[i].ToString(), connec);
                    OleDbDataReader dr4 = cd4.ExecuteReader();
                    while (dr4.Read())
                    {
                        lvPersonne.Items.Add(dr4.GetString(0) + dr4.GetString(1));
                    }
                }

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
        }
        
        //Onglet SuppressionTransaction
        private void remplirDGV() //Remplit la dataGridView dans Suppression et Modification
        {
            try
            {

                connec.Open();
                OleDbCommand cd1 = new OleDbCommand("SELECT [Transaction].* FROM[Transaction]", connec);

                OleDbDataAdapter da = new OleDbDataAdapter(cd1);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvTransactions.DataSource = dt;
                dgvModifTransa.DataSource = dt;
                
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
        }

        private void btnSupprTransac_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Voulez vous vraiment supprimer cette transaction ?", "Suppression", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                int codeTransa = int.Parse(txtCodeToSuppr.Text);
                if (codeTransa <= lastCodeTransac)
                {
                    try
                    {
                        connec.Open();
                        string requete = "DELETE FROM [Beneficiaires] WHERE [Beneficiaires].[codeTransaction] = " + codeTransa;
                        OleDbCommand cd1 = new OleDbCommand(requete, connec);
                        cd1.ExecuteNonQuery();
                        requete = "DELETE FROM [Transaction] WHERE [Transaction].codeTransaction = " + codeTransa;
                        OleDbCommand cd2 = new OleDbCommand(requete, connec);
                        cd2.ExecuteNonQuery();
                        connec.Close();
                        MiseAJour();
                        MessageBox.Show("Transaction supprimée");
                    }
                    catch (InvalidOperationException erreur)
                    {
                        MessageBox.Show("Erreur de chaine de connexion ! Suppr");
                    }
                    catch (OleDbException erreur)
                    {
                        MessageBox.Show("Erreur de requete SQL ! Suppr");
                    }
                }
            }
            else if (dR == DialogResult.No)
            {
                MessageBox.Show("Ben soit sûr alors !");
            }
        }

        private void txtCodeToSuppr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        
        //Onglet ModifierTransaction
        private void txtCodeToMod_TextChanged(object sender, EventArgs e)
        {
            if (txtCodeToMod.Text != "" && int.Parse(txtCodeToMod.Text) <= lastCodeTransac)
            {
                try
                {
                    int codeType = 0;

                    connec.Open();
                    string requete = "SELECT [Transaction].* FROM [Transaction] WHERE [CodeTransaction] = " + txtCodeToMod.Text;
                    OleDbCommand cd1 = new OleDbCommand(requete, connec);
                    OleDbDataReader dr = cd1.ExecuteReader();

                    while (dr.Read())
                    {
                        txtModCode.Text = dr.GetInt32(0).ToString();
                        dtpModDate.Value = dr.GetDateTime(1);
                        txtModDesc.Text = dr.GetString(2);
                        txtModMontant.Text = dr.GetValue(3).ToString();
                        chkModRecette.Checked = dr.GetBoolean(4);
                        chkModPercu.Checked = dr.GetBoolean(5);
                        codeType = dr.GetInt32(6);
                    }
                    connec.Close();

                    cboModType.SelectedIndex = codeType - 1;
                }
                catch (InvalidOperationException erreur)
                {
                    MessageBox.Show("Erreur de chaine de connexion ! modAffichage");
                }
                catch (OleDbException erreur)
                {
                    MessageBox.Show("Erreur de requete SQL ! modAffichage");
                }
            }
            else
            {
                txtModCode.Text = "";
                dtpModDate.Value = DateTime.Now;
                txtModDesc.Text = "";
                txtModMontant.Text = "";
                chkModRecette.Checked = false;
                chkModPercu.Checked = false;
            }
        }

        private void btnValidMod_Click(object sender, EventArgs e)
        {
            if (txtCodeToMod.Text != "")
            {
                try
                {
                    connec.Open();
                    string requete = "SELECT * INTO temp FROM Beneficiaires WHERE codeTransaction = " + txtCodeToMod.Text;
                    OleDbCommand cd1 = new OleDbCommand(requete, connec);
                    cd1.ExecuteNonQuery();
                    requete = "DELETE FROM [Beneficiaires] WHERE [Beneficiaires].[codeTransaction] = " + txtCodeToMod.Text;
                    OleDbCommand cd2 = new OleDbCommand(requete, connec);
                    cd2.ExecuteNonQuery();
                    requete = "UPDATE [temp] SET [codeTransaction] = " + txtModCode.Text;
                    OleDbCommand cd3 = new OleDbCommand(requete, connec);
                    cd3.ExecuteNonQuery();

                    requete = "UPDATE [Transaction] SET [codeTransaction] = " + txtModCode.Text + ", [dateTransaction] = '" + dtpModDate.Value + "', [description] = '" + txtModDesc.Text + "', [montant] = " + txtModMontant.Text + ", [recetteON] = " + chkModRecette.Checked.ToString() + ", [percuON] = " + chkModPercu.Checked.ToString() + ", [type] = " + cboModType.SelectedValue + " WHERE [codeTransaction] = " + txtCodeToMod.Text;
                    OleDbCommand cd6 = new OleDbCommand(requete, connec);
                    cd6.ExecuteNonQuery();

                    OleDbCommand cd4 = new OleDbCommand("SELECT * from temp",connec);
                    OleDbDataReader dr = cd4.ExecuteReader();
                    while (dr.Read())
                    {
                        int codePers = dr.GetInt32(1);
                        requete = "INSERT INTO Beneficiaires VALUES ("+txtModCode.Text+", "+codePers+")";
                        OleDbCommand cd = new OleDbCommand(requete, connec);
                        cd.ExecuteNonQuery();
                    }
                    dr.Close();

                    requete = "DROP TABLE [temp]";
                    OleDbCommand cd5 = new OleDbCommand(requete, connec);
                    cd5.ExecuteNonQuery();
                    
                    connec.Close();
                    MessageBox.Show("Transaction modifiée");
                    MiseAJour();
                }
                catch (InvalidOperationException erreur)
                {
                    MessageBox.Show("Erreur de chaine de connexion ! validMod");
                    MessageBox.Show(erreur.Message);
                }
                catch (OleDbException erreur)
                {
                    MessageBox.Show("Erreur de requete SQL ! ValidMod");
                    MessageBox.Show(erreur.Message);
                }
            }
        }

        private void btnAnnulerMod_Click(object sender, EventArgs e)
        {
            txtCodeToMod_TextChanged(sender, e);
        }
        
        //Onglet Recapitulatif
        private void btnCreeReca_Click(object sender, EventArgs e)
        {
            try
            {
                //Initialisation des variables
                connec.Open();
                string mois = dtpReca.Value.Month.ToString();
                string annee = dtpReca.Value.Year.ToString();
                string text = "____________________________________________________";
                string typeNull = "Type NULL";
                float montant = 0;
                int recette = 0;
                int percu = 0;
                int indentation = 20;
                int hauteurDesLignes = 720;
                List<string> un = new List<string>();
                List<string> de = new List<string>();
                List<string> tr = new List<string>();
                List<string> qu = new List<string>();
                List<string> ci = new List<string>();
                List<string> si = new List<string>();
                List<Boolean> nbTransaction = new List<Boolean>();
                pdfDocument myDoc = new pdfDocument("Recapitulatif_" + mois + "_" + annee, "Pique_Sous");
                pdfPage myPage = myDoc.addPage();
                
                //SQL
                OleDbCommand cd1 = new OleDbCommand("SELECT [Transaction].* FROM [Transaction] WHERE MONTH([dateTransaction]) = " + dtpReca.Value.Month.ToString(), connec);
                OleDbDataReader dr1 = cd1.ExecuteReader();
                
                //Lecture de la base
                while (dr1.Read())
                {
                    nbTransaction.Add(dr1.GetBoolean(4));
                    if (dr1.GetBoolean(4) == true)
                    {
                        recette++;
                    }
                    if (dr1.GetBoolean(5) == true)
                    {
                        percu++;
                    }
                    montant = montant + dr1.GetFloat(3);

                    un.Add(dr1[1].ToString().Substring(0,11));
                    de.Add(dr1[2].ToString());
                    tr.Add(dr1[3].ToString());
                    qu.Add(dr1[4].ToString());
                    ci.Add(dr1[5].ToString());

                    if (dr1[6].ToString() != "")
                    {
                        si.Add(dr1[6].ToString());
                    }
                    else
                    {
                        si.Add(typeNull);
                    }
                }
                for (int i = 0; i < si.Count; i++)
                {
                    if (si[i] != typeNull)
                    {
                        //Pour eviter de faire une requette avec une jointure
                        OleDbCommand cd2 = new OleDbCommand("SELECT [TypeTransaction].* FROM [TypeTransaction] where [codeType] = " + si[i], connec);
                        OleDbDataReader dr2 = cd2.ExecuteReader();
                        while (dr2.Read())
                        {
                            si[i] = dr2[1].ToString();
                        }
                    }
                }

                //Creation du text dans le PDF
                myPage.addText("Recapitulatif du : " + mois + "_" + annee, indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText(text, indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText("Dépenses", indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - (30 + 25 * un.Count);
                myPage.addText(text, indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText("Recette : " + recette.ToString(), indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText(text, indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText(" Depenses : " + montant.ToString(), indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText(text, indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText("Reste a persevoir : " + percu.ToString(), indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText(text, indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText("Somme total dépensée : -" + montant.ToString(), indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText(text, indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText("nombres de transactions : " + nbTransaction.Count.ToString(), indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                hauteurDesLignes = hauteurDesLignes - 30;
                myPage.addText(text, indentation, hauteurDesLignes, myDoc.getFontReference(predefinedFont.csHelvetica), 20);
                
                //Initiallisation tableau PDF
                pdfTable myTable = new pdfTable(myDoc);
                myTable.borderSize = 1;
                myTable.borderColor = sharpPDF.pdfColor.Black;
                myTable.tableHeader.addColumn(90);
                myTable.tableHeader.addColumn(120);
                myTable.tableHeader.addColumn(70);
                myTable.tableHeader.addColumn(70);
                myTable.tableHeader.addColumn(70);
                myTable.tableHeader.addColumn(110);
                pdfTableRow myRow = myTable.createRow();

                //Remplissage de la première ligne du tableau
                myRow[0].addText("Date Transaction");
                myRow[1].addText("Description");
                myRow[2].addText("Montant");
                myRow[3].addText("Recette ?");
                myRow[4].addText("Perçu ?");
                myRow[5].addText("Type de dépence ?");
                myTable.addRow(myRow);

                //Remplissage des ligne du tableau
                for( int i = 0; i< un.Count; i++)
                {
                    myRow = myTable.createRow();
                    myRow[0].addText(un[i]);
                    myRow[1].addText(de[i]);
                    myRow[2].addText(tr[i]);
                    myRow[3].addText(qu[i]);
                    myRow[4].addText(ci[i]);
                    myRow[5].addText(si[i]);
                    myTable.addRow(myRow);
                }

                //Place le tableau
                myTable.coordY = 650;
                myTable.coordX = 20;
                myPage.addTable(myTable);
                
                //creer le PDF
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
 
                    myDoc.createPDF(fbd.SelectedPath+@"\Recapitulatif_"+mois+".pdf");
                    myDoc.createPDF(fbd.SelectedPath+@"\Recapitulatif_" + mois +".pdf");
                }
                //myDoc.createPDF(@"C:\Users\Miniyeti67\Desktop\Mini Projet\" + mois + ".pdf");
                //myDoc.createPDF(@"C:\Users\ladri\Desktop\" + mois + ".pdf");
 
                    myDoc.createPDF(fbd.SelectedPath+@"\Recapitulatif_" + mois + "_" + annee +".pdf");
                
 
                myPage = null;
                myDoc = null;
                connec.Close();
                MessageBox.Show("PDF créé");
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! pdf");
                MessageBox.Show(erreur.Message);
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! pdf");
                MessageBox.Show(erreur.Message);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string requete = "SELECT [Transaction].*, [TypeTransaction].libType FROM [Transaction], [TypeTransaction] WHERE [Transaction].type = [TypeTransaction].codeType AND ";
            if (chkRecapDate.Checked)
            {
                if (requete.EndsWith("AND "))
                {
                    requete += "[dateTransaction] = DateValue('" + dtpRecapDate.Value.ToShortDateString() + "')";
                }
                else
                {
                    requete += " AND [dateTransaction] = DateValue('" + dtpRecapDate.Value.ToShortDateString() + "')";
                }
            }
            if (chkRecapLibelle.Checked)
            {
                if (requete.EndsWith("AND "))
                {
                    requete += "[type] = " + cboRecapLib.SelectedValue;
                }
                else
                {
                    requete += " AND [type] = " + cboRecapLib.SelectedValue;
                }
            }
            if (chkRecapMontant.Checked)
            {
                if (requete.EndsWith("AND "))
                {
                    requete += "[montant] = " + txtRecapMontant.Text;
                }
                else
                {
                    requete += " AND [montant] = " + txtRecapMontant.Text;
                }
            }
            if (chkRecapPercu.Checked)
            {
                if (requete.EndsWith("AND "))
                {
                    requete += "[percuON] = " + cboRecapPercu.SelectedItem.ToString();
                }
                else
                {
                    requete += " AND [percuON] = " + cboRecapPercu.SelectedItem.ToString();
                }
            }
            if (chkRecapRecette.Checked)
            {
                if (requete.EndsWith("AND "))
                {
                    requete += "[recetteON] = " + cboRecapRecette.SelectedItem.ToString();
                }
                else
                {
                    requete += " AND [recetteON] = " + cboRecapRecette.SelectedItem.ToString();
                }
            }
            if (requete.EndsWith("AND "))
            {
                requete = "SELECT [Transaction].*, [TypeTransaction].libType FROM [Transaction], [TypeTransaction] WHERE [Transaction].type = [TypeTransaction].codeType";
            }
            try
            {
                connec.Open();
                OleDbCommand cd1 = new OleDbCommand(requete, connec);
                OleDbDataAdapter da = new OleDbDataAdapter(cd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRecapitulatif.DataSource = dt;
                connec.Close();
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! Recap");
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! Recap");
                MessageBox.Show(erreur.Message);
            }
        }
    }
}
        