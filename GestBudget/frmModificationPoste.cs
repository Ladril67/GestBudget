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
    public partial class frmModificationPoste : Form
    {
        OleDbConnection connec = new OleDbConnection();
        DataSet ds = new DataSet();
        DataGridViewCell cell;

        public frmModificationPoste()
        {
            InitializeComponent();
        }

        private void frmModificationPoste_Load(object sender, EventArgs e)
        {
            connec.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\budget.mdb";
            initContextMenu();
            MiseAJour();
        }

        private void MiseAJour()
        {
            remplirDGV();
        }

        private void initContextMenu()
        {
            dgvPeriod.ContextMenuStrip = cmsPoste;
            dgvRevenu.ContextMenuStrip = cmsPoste;
        }

        private void remplirDGV() //Remplit les dataGridView
        {
            try
            {
                
                connec.Open();
                OleDbCommand cd1 = new OleDbCommand("SELECT * FROM [PostePeriodique]", connec);
                OleDbDataAdapter da1 = new OleDbDataAdapter(cd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dgvPeriod.DataSource = dt1;

                OleDbCommand cd2 = new OleDbCommand("SELECT * FROM [PosteRevenu]", connec);
                OleDbDataAdapter da2 = new OleDbDataAdapter(cd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dgvRevenu.DataSource = dt2;

                OleDbCommand cd3 = new OleDbCommand("SELECT [Echeances].codePoste, [Poste].libPoste, [Echeances].datePrelevt, [Echeances].montantEcheance FROM [Echeances], [Poste] WHERE [Echeances].codePoste = [Poste].codePoste", connec);
                OleDbDataAdapter da3 = new OleDbDataAdapter(cd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                dgvEcheance.DataSource = dt3;

                connec.Close();

            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de chaine de connexion ! DGV");
                MessageBox.Show(erreur.Message);
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL ! DGV");
                MessageBox.Show(erreur.Message);
            }
            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }
            }

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifBox modBox;
            if (cell.Value.ToString() != "")
            {
                modBox = new frmModifBox(cell.Value.ToString());
            }
            else
            {
                modBox = new frmModifBox("");
            }

            modBox.ShowDialog();
            if (modBox.DialogResult == DialogResult.OK)
            {
                cell.Value = modBox.Contenu;
                if (cell.DataGridView.Name == "dgvPeriod")
                {
                    try
                    {
                        connec.Open();
                        string requete = "UPDATE [PostePeriodique] SET [" + cell.OwningColumn.DataPropertyName + "] = " + cell.Value.ToString() + " WHERE [codePoste] = " + cell.DataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString();
                        OleDbCommand cd1 = new OleDbCommand(requete, connec);
                        cd1.ExecuteNonQuery();
                        connec.Close();
                        MessageBox.Show("Modification effectuée");
                    }
                    catch (InvalidOperationException erreur)
                    {
                        MessageBox.Show("Erreur de chaine de connexion ! ModDGVPeriod");
                        MessageBox.Show(erreur.Message);
                    }
                    catch (OleDbException erreur)
                    {
                        MessageBox.Show("Erreur de requete SQL ! ModDGVPeriod");
                        MessageBox.Show(erreur.Message);
                    }
                }
                else if(cell.DataGridView.Name == "dgvRevenu")
                {
                    try
                    {
                        connec.Open();
                        string requete = "UPDATE [PosteRevenu] SET [" + cell.OwningColumn.DataPropertyName + "] = " + cell.Value.ToString() + " WHERE [codePoste] = " + cell.DataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString();
                        OleDbCommand cd1 = new OleDbCommand(requete, connec);
                        cd1.ExecuteNonQuery();
                        connec.Close();
                        MessageBox.Show("Modification effectuée");
                    }
                    catch (InvalidOperationException erreur)
                    {
                        MessageBox.Show("Erreur de chaine de connexion ! ModDGVPeriod");
                        MessageBox.Show(erreur.Message);
                    }
                    catch (OleDbException erreur)
                    {
                        MessageBox.Show("Erreur de requete SQL ! ModDGVPeriod");
                        MessageBox.Show(erreur.Message);
                    }
                }
            }
            MiseAJour();
        }

        private void dgvPeriod_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cell = dgvPeriod.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void dgvRevenu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cell = dgvRevenu.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cell.DataGridView.Name == "dgvPeriod")
            {
                try
                {
                    connec.Open();
                    string requete = "DELETE FROM [PostePeriodique] WHERE [CodePoste] = "+cell.DataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString();
                    OleDbCommand cd1 = new OleDbCommand(requete, connec);
                    cd1.ExecuteNonQuery();
                    connec.Close();
                    MessageBox.Show("Suppression effectuée");
                }
                catch (InvalidOperationException erreur)
                {
                    MessageBox.Show("Erreur de chaine de connexion ! SupprDGVPeriod");
                    MessageBox.Show(erreur.Message);
                }
                catch (OleDbException erreur)
                {
                    MessageBox.Show("Erreur de requete SQL ! SupprDGVPeriod");
                    MessageBox.Show(erreur.Message);
                }
            }
            else if (cell.DataGridView.Name == "dgvRevenu")
            {
                try
                {
                    connec.Open();
                    string requete = "DELETE FROM [PosteRevenu] WHERE [CodePoste] = "+ cell.DataGridView.Rows[cell.RowIndex].Cells[0].Value.ToString();
                    OleDbCommand cd1 = new OleDbCommand(requete, connec);
                    cd1.ExecuteNonQuery();
                    connec.Close();
                    MessageBox.Show("Suppression effectuée");
                }
                catch (InvalidOperationException erreur)
                {
                    MessageBox.Show("Erreur de chaine de connexion ! SupprDGVPeriod");
                    MessageBox.Show(erreur.Message);
                }
                catch (OleDbException erreur)
                {
                    MessageBox.Show("Erreur de requete SQL ! SupprDGVPeriod");
                    MessageBox.Show(erreur.Message);
                }
            }
            MiseAJour();
        }
    }
}
