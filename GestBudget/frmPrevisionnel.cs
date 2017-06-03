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
            //Génération dynamique des DateTimePicker en fonction du texte dans txtprelevemen
            int top = 15;
            int left = 15;
            grpEcheances.Show();
            int nb = 0;
            if (txtPrelevement.Text != "")
            {
                nb = int.Parse(txtPrelevement.Text);
                for (int i = 0; i < nb; i++)
                {
                    DateTimePicker dt = new DateTimePicker();
                    dt.Top = 30 * i + top;
                    dt.Left = left;
                    grpEcheances.Controls.Add(dt);
                }
                RemplirDate();
            }
        }

        public void RemplirDate()
        {
            {
                //Initialisation de la Date
                int i = 0;
                DateTime date = DateTime.Now;
                int mois = date.Month;
                int annee = date.Year;
                foreach ( DateTimePicker dt in grpEcheances.Controls)
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

        }


    }
}

