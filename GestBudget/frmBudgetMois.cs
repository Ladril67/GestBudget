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
        {
            try
            {
<<<<<<< HEAD
=======
                connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\budget.mdb";
                connec.Open();
                DataTable schema = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                
>>>>>>> 13cce644852e86422778c2e0fde46e828f8daeb3

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnAjoutTransa_Click(object sender, EventArgs e)
        {
            try
            {
                connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
                connec.Open();

                DateTime date = dtpTransa.Value;
                string desc = txtDescriptionTransa.Text;
                string montant = txtMontantTransa.Text;


                string requete = "select count(*) from Poste";
                OleDbCommand cd1 = new OleDbCommand(requete, connec);
                int c = (int)cd1.ExecuteScalar();
                MessageBox.Show("" + c);
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
    }
}
