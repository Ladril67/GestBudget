﻿using System;
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

        private void remplitCbo(ComboBox cb, string nomTable, string champAffiche, string champCache)
        {
            cb.DataSource = ds.Tables[nomTable];
            cb.DisplayMember = champAffiche;
            cb.ValueMember = champCache;
        }

        private void remplirParticipants()
        {
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
                int jointure = 0;
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
                    jointure = dr1.GetInt32(6);
                }
                //Pour eviter de faire une requette avec une jointure
                OleDbCommand cd2 = new OleDbCommand("SELECT [TypeTransaction].* FROM [TypeTransaction] where [codeType] = " + jointure, connec);
                OleDbDataReader dr2 = cd2.ExecuteReader();
                while (dr2.Read())
                {
                    lblType.Text = dr2.GetString(1);
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
                        lvPersonne.Items.Add(dr4.GetString(0) + " " + dr4.GetString(1));
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
            finally
            {
            }
        }




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
                    string requete = "CREATE TABLE [temp] AS SELECT [Beneficiaires].* FROM [Beneficiaires] WHERE [Beneficiaires].[codeTransaction] =" + txtCodeToMod.Text;
                    OleDbCommand cd1 = new OleDbCommand(requete, connec);
                    cd1.ExecuteNonQuery();
                    MessageBox.Show("1er");
                    requete = "DELETE FROM [Beneficiaires] WHERE [Beneficiaires].[codeTransaction] = " + txtCodeToMod.Text;
                    OleDbCommand cd2 = new OleDbCommand(requete, connec);
                    cd2.ExecuteNonQuery();
                    MessageBox.Show("2e");
                    requete = "UPDATE [temp] SET [codeTransaction] = " + txtModCode.Text;
                    OleDbCommand cd3 = new OleDbCommand(requete, connec);
                    cd3.ExecuteNonQuery();
                    MessageBox.Show("3e");
                    requete = "INSERT INTO [Beneficiaires] SELECT * FROM [temp]";
                    OleDbCommand cd4 = new OleDbCommand(requete, connec);
                    cd4.ExecuteNonQuery();
                    MessageBox.Show("4e");
                    requete = "DROP TABLE [temp]";
                    OleDbCommand cd5 = new OleDbCommand(requete, connec);
                    cd5.ExecuteNonQuery();
                    MessageBox.Show("Benef done");

                    requete = "UPDATE [Transaction] SET [codeTransaction] = " + txtModCode.Text + ", [dateTransaction] = '" + dtpModDate.Value + "', [description] = '" + txtModDesc.Text + "', [montant] = " + txtModMontant.Text + ", [recetteON] = " + chkModRecette.Checked.ToString() + ", [percuON] = " + chkModPercu.Checked.ToString() + ", [type] = " + cboModType.SelectedValue + " WHERE [codeTransaction] = " + txtCodeToMod.Text;
                    OleDbCommand cd6 = new OleDbCommand(requete, connec);
                    cd6.ExecuteNonQuery();
                    MessageBox.Show("second update done");
                    connec.Close();
                    MessageBox.Show("Transaction modifiée");
                    MiseAJour();
                }
                catch (InvalidOperationException erreur)
                {
                    MessageBox.Show("Erreur de chaine de connexion ! validMod");
                }
                catch (OleDbException erreur)
                {
                    MessageBox.Show("Erreur de requete SQL ! ValidMod");
                }
            }
        }

        private void btnAnnulerMod_Click(object sender, EventArgs e)
        {
            txtCodeToMod_TextChanged(sender, e);
        }
    }
}

