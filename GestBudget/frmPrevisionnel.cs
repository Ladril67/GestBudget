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
            flpEcheance.Hide();
            lblEcheance.Hide();
            flpEcheance.AutoScroll = true;
            remplirBeneficiaire();
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

        //Fonction qui remplit la comboBox des postes
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


        //Remplissage de la comboBox des périodicités d'une transaction
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

        //Fonction qui va générer dynamiquement les controles dans PostePonctuel
        private void txtPrelevement_TextChanged(object sender, EventArgs e)
        {
            flpEcheance.Controls.Clear();
            lblEcheance.Show();
            //Génération dynamique des éléments dans la groupbox selon le texte de txtPrelevement
            int top = 15;
            int left = 15;
            flpEcheance.Show();
            int nb = 0;
            if (txtPrelevement.Text != "")
            {
                nb = int.Parse(txtPrelevement.Text);
                int Tag = 1;
                for (int i = 0; i < nb; i++)
                {
                    if (i == 0)
                    {
                        
                        DateTimePicker dtPremier = new DateTimePicker();
                        dtPremier.ValueChanged += new System.EventHandler(dtPremier_ValueChanged);
                        dtPremier.Top = 30 * i + top;
                        dtPremier.Tag = Tag;
                        dtPremier.Left = left + 85;
                        flpEcheance.Controls.Add(dtPremier);
                        Tag += 1;

                    }
                    else
                    {
                        DateTimePicker dt = new DateTimePicker();
                        dt.Top = 30 * i + top;
                        dt.Left = left + 85;
                        dt.Tag = Tag;
                        flpEcheance.Controls.Add(dt);
                        Tag += 1;
                    }

                    int n = i + 1;

                    //Génération des Labels
                    Label lbl = new Label();
                    lbl.Text = "Echéance n°" + n;
                    lbl.Top = 30 * i + top;
                    lbl.Left = left;
                    lbl.Tag = Tag;
                    flpEcheance.Controls.Add(lbl);
                    Tag += 1;

                    //Génération des textboxs
                    if (i == 0)
                    {

                        TextBox txtPremier = new TextBox();
                        txtPremier.TextChanged += new System.EventHandler(txtPremier_TextChanged);
                        txtPremier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(TextBoxPonctuel_KeyPress);
                        txtPremier.Top = 30 * i + top;
                        txtPremier.Left = left + 300;
                        txtPremier.Tag = Tag;
                        flpEcheance.Controls.Add(txtPremier);
                        Tag += 1;
                    }
                    else
                    {
                        TextBox txt = new TextBox();
                        txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(TextBoxPonctuel_KeyPress);
                        txt.Top = 30 * i + top;
                        txt.Left = left + 300;
                        txt.Tag = Tag;
                        flpEcheance.Controls.Add(txt);
                        Tag += 1;
                    }

                }
            }
            RemplirDate();
        }

        //Fonction qui va changer la valeur des dates des DateTimePickers en fonction de celle du premier
        public void dtPremier_ValueChanged(Object sender, EventArgs e)
        {
            //Initialisation de la Date
            DateTime date = ((DateTimePicker)sender).Value;
            int i = 0;
            int mois = date.Month;
            int annee = date.Year;
            foreach (DateTimePicker dt in flpEcheance.Controls.OfType<DateTimePicker>())
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
                        if(mois == 2)
                        {
                            if (date.Day >= 28)
                            {
                                dt.Value = new DateTime(annee, mois, 28);
                            }
                            else { }
                        }
                        else
                        {
                            dt.Value = new DateTime(annee, mois, date.Day);
                            i = i + 1;
                        }
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

        //bloque tous les caractères sauf virgule et chiffres
        public void TextBoxPonctuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((TextBox)sender).Text.Contains(",") && ((TextBox)sender).Text != "" && e.KeyChar == ',')
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

        //Remplissage de la date des DateTimePickers dans Echeances
        public void RemplirDate()
        {
            //Initialisation de la Date
            DateTime date = DateTime.Now;
            int i = 0;
            int mois = date.Month;
            int annee = date.Year;
            foreach (DateTimePicker dt in flpEcheance.Controls.OfType<DateTimePicker>())
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

        //Permet de changer automatiquement le texte des TextBox en fonction de la valeur de la première TextBox
        private void txtPremier_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string montant = "";
            foreach(TextBox txt in flpEcheance.Controls.OfType<TextBox>())
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

        //Fonction qui remplit la ComboBox bénéficiaires avec les personnes présentent dans la base de donnée
        public void remplirBeneficiaire()
        {
            try
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
                            while (dr.Read())
                            {
                                 string cbPersonne = dr[nb].ToString() + " " + dr[nb + 1].ToString();
                                cboBeneficiaire.Items.Add(cbPersonne);
                            }
                        }
                    }
                }
                connec.Close();
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! : RemplirParticipant\n" + erreur.Message);
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! : RemplirParticipant \n" + erreur.Message);
            }
            finally
            {
            }
        }

        //Créer le poste dans PosteFixe
        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                //Mise en place de la connection string et on ouvre la connection
                connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
                connec.Open();

                //Récupération du code correspondant au poste choisi
                string poste = "SELECT codePoste FROM Poste WHERE libPoste = '" + cboPoste.SelectedItem.ToString() + "'";
                OleDbCommand cdPoste = new OleDbCommand(poste, connec);
                int CodePoste = (int)cdPoste.ExecuteScalar();

                int Montant = int.Parse(txtMontant.Text);

                //Récupération du code correspondant à la périodicité choisie
                string periodicite = "SELECT [codePer] FROM [Periodicite] WHERE [libPer] = '" + cboPeriodicite.SelectedItem.ToString() + "'";
                OleDbCommand cdPeriod = new OleDbCommand(periodicite, connec);
                int codePer = (int)cdPeriod.ExecuteScalar();


                int Jour = int.Parse(tboJour.Text);

                //Requête principale qui insère un poste dans poste periodique
                string requete = "INSERT INTO [PostePeriodique] values (" + CodePoste + "," + Montant + "," + codePer + "," + Jour + ")";
                OleDbCommand cd1 = new OleDbCommand(requete, connec);
                int nb = cd1.ExecuteNonQuery();
                connec.Close();
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! btnValider_click \n" + erreur.Message);
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! btnValider_click \n" + erreur.Message);
            }
            MessageBox.Show("Insertion du poste intitulé : '" + cboPoste.SelectedItem.ToString() + "' à été effectuée avec succès");
        }

        //Créer le poste Ponctuel 
        private void btnValiderPonctuel_Click(object sender, EventArgs e)
        {
            //Mise en place de la connection string et on ouvre la connection
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
            connec.Open();

            int codePoste = creerPoste(txtIntitule.Text);
            try
            {
                string requete = "INSERT INTO PostePonctuel VALUES (" + codePoste + ",'" + txtIntitule.Text + ": " + txtCommentaire.Text + "')";
                OleDbCommand insertPonctuel = new OleDbCommand(requete, connec);
                insertPonctuel.ExecuteNonQuery();
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! ValiderPonctuel_Click : insert poste \n" + erreur.Message);
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! ValiderPonctuel_Click : insert poste \n" + erreur.Message);
            }
            MessageBox.Show("Poste ponctuel intitulé : '" + txtIntitule.Text + "' à été effectée avec succès");
        
            try
            {

                //Déclaration de la variable qui serviraa déclencher la requete SQL après avoir récupérer les 3 controles indispensables pour la requête
                int compteur = -2;
                //Déclaration des controls
                DateTimePicker dtTransa = new DateTimePicker();
                Label lblTransa = new Label();
                TextBox txtTransa = new TextBox();

                foreach (Control c in flpEcheance.Controls)
                {
                    if (((int)c.Tag)%3 == 1)
                    {
                        dtTransa = ((DateTimePicker)c);
                    }
                    else if( ((int)c.Tag)%3 == 2)
                    {
                        lblTransa = ((Label)c);
                    }
                    else if (((int)c.Tag)%3 == 0)
                    {
                        txtTransa = ((TextBox)c);
                    }

                    if (compteur % 3 == 0 &&  compteur>=0)
                    {
                        string rqtTransa = "INSERT INTO Echeances VALUES(" + codePoste + ",'" + dtTransa.Value.ToString() + "'," + int.Parse(txtTransa.Text) + ")";
                        OleDbCommand cdTransa = new OleDbCommand(rqtTransa, connec);
                        cdTransa.ExecuteNonQuery();
                    }
                    else { }
                    compteur = compteur + 1;
                }
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! ValiderPonctuel_Click : Insert transaction \n" + erreur.Message);
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! ValiderPonctuel_Click : insert transaction \n" + erreur.Message);
            }
            MessageBox.Show("Poste ponctuel intitulé : '" + txtIntitule.Text + "' à été effectée avec succès");
            connec.Close();
        }

        //Fonction appelée pour créer un poste dans la base Poste
        public int creerPoste(String poste)
        {
            //Création du poste passé en paramètre
            string table = "Poste";
            int IDPoste = getID(table,"code"+table) + 1;
            try
            {
                string requete = "INSERT INTO Poste VALUES (" + IDPoste + ",'" + poste + "')";
                OleDbCommand cd1 = new OleDbCommand(requete, connec);
                cd1.ExecuteNonQuery();
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! CreerPoste \n" + erreur.Message);
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! CreerPoste \n" + erreur.Message);
            }
            MessageBox.Show("Insertion du Poste n°" + IDPoste + " et de nom : '" + poste + "' à été effectuée avec succès");
            return IDPoste;
        }


        //Récupère l'index le plus élevé de la colonne de la table passée en paramètre
        public int getID(string Table, string colonne)
        {
            int max = 0;


            try
            { 

                string requete = "SELECT " +  colonne + " FROM [" + Table + "]";
                OleDbCommand cd1 = new OleDbCommand(requete, connec);
                cd1.ExecuteNonQuery();


                List<int> Listcode = new List<int>();
                OleDbDataReader dr = cd1.ExecuteReader();

                while (dr.Read())
                {
                    Listcode.Add(dr.GetInt32(0));
                }

                for (int i = 1; i<Listcode.Count(); i++)
                {
                    if (Listcode[i-1] > Listcode[i])
                    {
                        max = Listcode[i-1];
                    }
                    else
                    {
                        max = Listcode[i];
                    }
                }
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! GetID \n "+ erreur.Message);
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! GetID \n" + erreur.Message );
            }
            return max;
            
        }

        //Créer le poste revenu
        private void Valider_Click(object sender, EventArgs e)
        {
           //Mise en place de la connection string et on ouvre la connection
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
            connec.Open();

            //Vérification de l'existence du poste
            String PosteUpper = txtPosteRevenu.Text.ToUpper();
            string rqtPoste = "SELECT codePoste FROM Poste WHERE UCASE(libPoste) = '" + PosteUpper + "'";
            OleDbCommand cdExPoste = new OleDbCommand(rqtPoste, connec);
            int nb = cdExPoste.ExecuteNonQuery();

            OleDbDataReader drPoste = cdExPoste.ExecuteReader();

            int codePoste = 0;

            if (drPoste.HasRows)
            {
                while (drPoste.Read())
                {
                    codePoste = drPoste.GetInt32(0);
                    MessageBox.Show("Ce poste existe déjà");
                }
            }
            else
            {
                codePoste = creerPoste(txtPosteRevenu.Text);
            }


            //Déclaration et initialisation des paramètres necessaires a la requete d'insertion         


            int Montant = int.Parse(txtMontantRevenu.Text);

            string prenom = "";
            string nom = "";

            for (int k = 0; k < cboBeneficiaire.Text.Length; k++)
            {
                if (cboBeneficiaire.Text[k] == ' ')
                {
                    prenom = cboBeneficiaire.Text.Substring(0,k);
                    nom = cboBeneficiaire.Text.Substring(k+1);
                }
                else { }

            }
            
            try
            {
                //Récupération du codePersonne correspondant à la personne choisie dans la combobox
                string rqtPersonne = "SELECT [codePersonne] FROM [Personne] WHERE pnPersonne = '" + prenom + "' and nomPersonne ='" + nom + "'";
                OleDbCommand cdCodePersonne = new OleDbCommand(rqtPersonne, connec);
                int codePersonne = ((int)cdCodePersonne.ExecuteScalar());


                int jour = int.Parse(txtJourDuMois.Text);

                //Vérification de l'existence du codePoste dans PostePonctuel
                string rqtCodePoste = "SELECT codePoste FROM PosteRevenu WHERE codePoste = "+ codePoste;
                OleDbCommand cdCodePoste = new OleDbCommand(rqtPoste, connec);
                int nb2 = cdCodePoste.ExecuteNonQuery();

                OleDbDataReader drCodePoste = cdCodePoste.ExecuteReader();
                int MontantUpdate = Montant + int.Parse(txtMontantRevenu.Text);
                if (drPoste.HasRows)
                {
                    while (drCodePoste.Read())
                    {
                        int codePosteUpdate = drCodePoste.GetInt32(0);
                        string rqtUpdate = "UPDATE [PosteRevenu] SET [montant] = "+MontantUpdate+ " WHERE [codePoste] = " + codePosteUpdate;
                        OleDbCommand cdUpdate = new OleDbCommand(rqtUpdate, connec);
                        cdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Mis a jour du montant du poste existant");
                    }
                 

                }
                else
                {
                    //Requête SQL principale d'insertion dans la base revenu
                    string requete = "INSERT INTO PosteRevenu VALUES (" + codePoste + "," + Montant + "," + codePersonne + "," + jour + ")";
                    OleDbCommand cd1 = new OleDbCommand(requete, connec);
                    cd1.ExecuteNonQuery();
                }

                drPoste.Close();


                
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! Valider_click \n " + erreur.Message);
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! Valider_click \n " + erreur.Message);
            }
            connec.Close();
        }

        //Permet d'insérer un autre poste dans la comboBox
        private void btnAutre_Click(object sender, EventArgs e)
        {
            //Mise en place de la connection string et on ouvre la connection
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
            connec.Open();
            creerPoste(cboPoste.Text);
            connec.Close();
        }

       //bloque tous les caractères sauf virgule et chiffres
        private void txtMontantRevenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtMontantRevenu.Text.Contains(",") && txtMontantRevenu.Text != "" && e.KeyChar == ',')
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


        //Onglet Modification
        private void btnModPoste_Click(object sender, EventArgs e)
        {
            frmModificationPoste frm = new frmModificationPoste();
            frm.ShowDialog();
        }
        //Onglet de budgetPrévisionnelAnnuel
        private void button1_Click(object sender, EventArgs e)
        {
            frmBudgetPrevisionnelAnnuel frm = new frmBudgetPrevisionnelAnnuel();
            frm.ShowDialog();
        }
    }
}

