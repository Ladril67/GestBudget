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
    public partial class frmPrevisionnel : Form
    {
        OleDbConnection connec = new OleDbConnection();

        public frmPrevisionnel()
        {
            InitializeComponent();
        }

        private void frmPrevisionnel_Load(object sender, EventArgs e)
        {
            remplircboPoste();
            remplircboPeriodicite();
            grpEcheances.Hide();
        }

        private void tboMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtMontant.Text.Contains(",") && txtMontant.Text != "")
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

        public void remplircboPoste()
        {
            //Mise en place de la connection string et on ouvre la connection
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
            connec.Open();

            //On récupère les données de la table pour travailler en mode déconnecté
            DataTable tbl1 = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                new object[] { null, null, null, "TABLE" });

            //on parcours la DataTable et on récupère uniquement la table qui nous intéresse
            foreach (DataRow ds in tbl1.Rows)
            {
                if (ds[2].ToString() == "Poste")
                {
                    //Création et execution de la requête SQL permettant de récupérer les noms et prénoms des participants
                    OleDbCommand cd1 = new OleDbCommand();
                    cd1.Connection = connec;
                    cd1.CommandType = CommandType.Text;
                    cd1.CommandText = "Select libPoste from Poste";
                    int nb = cd1.ExecuteNonQuery();

                    OleDbDataReader dr = cd1.ExecuteReader();
                    


                    //création et indentation des checkbox générées dynamiquements
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            cboPoste.Items.Add(dr[nb]);                          
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                }
            }
            connec.Close();
        }

        public void remplircboPeriodicite()
        {
            //Mise en place de la connection string et on ouvre la connection
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
            connec.Open();

            //On récupère les données de la table pour travailler en mode déconnecté
            DataTable tbl1 = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                new object[] { null, null, null, "TABLE" });

            //on parcours la DataTable et on récupère uniquement la table qui nous intéresse
            foreach (DataRow ds in tbl1.Rows)
            {
                if (ds[2].ToString() == "Periodicite")
                {
                    //Création et execution de la requête SQL permettant de récupérer les noms et prénoms des participants
                    OleDbCommand cd2 = new OleDbCommand();
                    cd2.Connection = connec;
                    cd2.CommandType = CommandType.Text;
                    cd2.CommandText = "SELECT libPer FROM Periodicite";
                    int nb = cd2.ExecuteNonQuery();

                    OleDbDataReader dr = cd2.ExecuteReader();


                    //création et indentation des checkbox générées dynamiquements
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            cboPeriodicite.Items.Add(dr[nb]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                }
            }
            connec.Close();
        }


        private void txtPrelevement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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
                //Gestion des lettres
                e.Handled = true;
            }
        }

        private void txtPrelevement_TextChanged(object sender, EventArgs e)
        {
            grpEcheances.Controls.Clear();
            //Génération dynamique des éléments dans la groupbox selon le texte de txtPrelevement
            int top = 15;
            int left = 15;
            grpEcheances.Show();
            int nb = 0;
            if (txtPrelevement.Text != "")
            {
                nb = int.Parse(txtPrelevement.Text);
                for (int i = 0; i < nb; i++)
                {
                    if (i == 0)
                    {
                        DateTimePicker dtPremier = new DateTimePicker();
                        dtPremier.ValueChanged += new System.EventHandler(dtPremier_ValueChanged);
                        dtPremier.Top = 30 * i + top;
                        dtPremier.Left = left + 85;
                        grpEcheances.Controls.Add(dtPremier);
                        dtPremier.Top = 30 * i + top;
                        dtPremier.Left = left + 85;
                        grpEcheances.Controls.Add(dtPremier);
                    }
                    else
                    {
                        DateTimePicker dt = new DateTimePicker();
                        dt.Top = 30 * i + top;
                        dt.Left = left + 85;
                        grpEcheances.Controls.Add(dt);
                        dt.Top = 30 * i + top;
                        dt.Left = left + 85;
                        grpEcheances.Controls.Add(dt);
                    }

                    int n = i + 1;

                    //Génération des Labels
                    Label lbl = new Label();
                    lbl.Text = "Echéance n°" + n;
                    lbl.Top = 30 * i + top;
                    lbl.Left = left;
                    grpEcheances.Controls.Add(lbl);

                    //Génération des textboxs
                    if (i == 0)
                    {

                        TextBox txtPremier = new TextBox();
                        txtPremier.TextChanged += new System.EventHandler(txtPremier_TextChanged);
                        txtPremier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(TextBoxPonctuel_KeyPress);
                        txtPremier.Top = 30 * i + top;
                        txtPremier.Left = left + 300;
                        grpEcheances.Controls.Add(txtPremier);
                    }
                    else
                    {
                        TextBox txt = new TextBox();
                        txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(TextBoxPonctuel_KeyPress);
                        txt.Top = 30 * i + top;
                        txt.Left = left + 300;
                        grpEcheances.Controls.Add(txt);
                    }

                }
            }
            RemplirDate();
        }

        public void dtPremier_ValueChanged(Object sender, EventArgs e)
        {
            //Initialisation de la Date
            DateTime date = ((DateTimePicker)sender).Value;
            int i = 0;
            int mois = date.Month;
            int annee = date.Year;
            foreach (DateTimePicker dt in grpEcheances.Controls.OfType<DateTimePicker>())
            {
                if (i == 0)
                {
                    i = i + 1;

                }
                else if (i != 0)
                {
                    //Gestion de l'incrémentation des mois et du changement éventuel d'année
                    mois = mois + 1;
                    if (mois <= 12)
                    {
                        dt.Value = new DateTime(annee, mois, date.Day);
                        i = i + 1;
                    }
                    else
                    {
                        mois = 1;
                        annee = annee + 1;
                        dt.Value = new DateTime(annee, mois, date.Day);
                    }
                }

            }
        }

        public void TextBoxPonctuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((TextBox)sender).Text.Contains(",") && ((TextBox)sender).Text != "")
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


        public void RemplirDate()
        {
                //Initialisation de la Date
                DateTime date = DateTime.Now;
               int i = 0;
               int mois = date.Month;
               int annee = date.Year;
               foreach ( DateTimePicker dt in grpEcheances.Controls.OfType<DateTimePicker>())
               {
                    if (i == 0)
                    {
                        dt.Value = date;
                        i = i + 1;

                    }
                    else if (i != 0)
                    {
                        //Gestion de l'incrémentation des mois et du changement éventuel d'année
                        mois = mois + 1;
                        if (mois <= 12)
                        {
                            dt.Value = new DateTime(annee, mois, date.Day);
                            i = i + 1;
                        }
                        else
                        {
                            mois = 1;
                            annee = annee + 1;
                            dt.Value = new DateTime(annee, mois, date.Day);
                        }
                    }
                    
                }
        }

        public void RemplirTxtMontant()
        {
            int i = 0;
            foreach(TextBox txt in grpEcheances.Controls.OfType<TextBox>())
            {
                if (i == 0)
                {
                    
                }
            }
        }

        private void txtPremier_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string montant = "";
            foreach(TextBox txt in grpEcheances.Controls.OfType<TextBox>())
            {
                if (i == 0)
                {
                    montant = txt.Text;
                }
                else
                {
                    txt.Text = montant;
                }
                i += 1;
            }
        }

        /*public void remplirParticipants()
        {
            ry
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
                                c.Controls.Add(cbPersonne);

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
        }*/
    }
}

