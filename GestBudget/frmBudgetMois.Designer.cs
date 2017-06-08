namespace Pique_Sous
{
    partial class frmBudgetMois
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudgetMois));
            this.tcBudgetMois = new System.Windows.Forms.TabControl();
            this.tpAffichage1a1 = new System.Windows.Forms.TabPage();
            this.dtp1a1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblValeur = new System.Windows.Forms.Label();
            this.checkRecette = new System.Windows.Forms.CheckBox();
            this.checkPercu = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnAvant = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.tpNewTransaction = new System.Windows.Forms.TabPage();
            this.chkPercu = new System.Windows.Forms.CheckBox();
            this.chkRecette = new System.Windows.Forms.CheckBox();
            this.btnAjouterPersonneTransa = new System.Windows.Forms.Button();
            this.grpParticipantsTransa = new System.Windows.Forms.GroupBox();
            this.btnAjoutTransa = new System.Windows.Forms.Button();
            this.btnAjoutType = new System.Windows.Forms.Button();
            this.cboTypeTransa = new System.Windows.Forms.ComboBox();
            this.lblTypeTransa = new System.Windows.Forms.Label();
            this.txtMontantTransa = new System.Windows.Forms.TextBox();
            this.lblMontantTransa = new System.Windows.Forms.Label();
            this.txtDescriptionTransa = new System.Windows.Forms.TextBox();
            this.lblDescripionTransa = new System.Windows.Forms.Label();
            this.dtpTransa = new System.Windows.Forms.DateTimePicker();
            this.lblDateTransa = new System.Windows.Forms.Label();
            this.tpDeleteTransaction = new System.Windows.Forms.TabPage();
            this.btnSupprTransac = new System.Windows.Forms.Button();
            this.txtCodeToSuppr = new System.Windows.Forms.TextBox();
            this.lblCodeToSuppr = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.tpModifTransaction = new System.Windows.Forms.TabPage();
            this.btnAnnulerMod = new System.Windows.Forms.Button();
            this.btnValidMod = new System.Windows.Forms.Button();
            this.txtCodeToMod = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtModMontant = new System.Windows.Forms.TextBox();
            this.txtModCode = new System.Windows.Forms.TextBox();
            this.lblModCode = new System.Windows.Forms.Label();
            this.lblModDate = new System.Windows.Forms.Label();
            this.lblModDesc = new System.Windows.Forms.Label();
            this.lblModMontant = new System.Windows.Forms.Label();
            this.lblModRecette = new System.Windows.Forms.Label();
            this.lblModPercu = new System.Windows.Forms.Label();
            this.lblModType = new System.Windows.Forms.Label();
            this.chkModRecette = new System.Windows.Forms.CheckBox();
            this.chkModPercu = new System.Windows.Forms.CheckBox();
            this.dtpModDate = new System.Windows.Forms.DateTimePicker();
            this.txtModDesc = new System.Windows.Forms.TextBox();
            this.cboModType = new System.Windows.Forms.ComboBox();
            this.lblCodeToMod = new System.Windows.Forms.Label();
            this.dgvModifTransa = new System.Windows.Forms.DataGridView();
            this.tpRecap = new System.Windows.Forms.TabPage();
            this.tcBudgetMois.SuspendLayout();
            this.tpAffichage1a1.SuspendLayout();
            this.tpNewTransaction.SuspendLayout();
            this.tpDeleteTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.tpModifTransaction.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifTransa)).BeginInit();
            this.SuspendLayout();
            // 
            // tcBudgetMois
            // 
            this.tcBudgetMois.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcBudgetMois.Controls.Add(this.tpAffichage1a1);
            this.tcBudgetMois.Controls.Add(this.tpNewTransaction);
            this.tcBudgetMois.Controls.Add(this.tpDeleteTransaction);
            this.tcBudgetMois.Controls.Add(this.tpModifTransaction);
            this.tcBudgetMois.Controls.Add(this.tpRecap);
            this.tcBudgetMois.Cursor = System.Windows.Forms.Cursors.Default;
            this.tcBudgetMois.Location = new System.Drawing.Point(0, 0);
            this.tcBudgetMois.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcBudgetMois.Name = "tcBudgetMois";
            this.tcBudgetMois.SelectedIndex = 0;
            this.tcBudgetMois.Size = new System.Drawing.Size(650, 453);
            this.tcBudgetMois.TabIndex = 0;
            // 
            // tpAffichage1a1
            // 
            this.tpAffichage1a1.Controls.Add(this.dtp1a1);
            this.tpAffichage1a1.Controls.Add(this.listBox1);
            this.tpAffichage1a1.Controls.Add(this.lblValeur);
            this.tpAffichage1a1.Controls.Add(this.checkRecette);
            this.tpAffichage1a1.Controls.Add(this.checkPercu);
            this.tpAffichage1a1.Controls.Add(this.lblDescription);
            this.tpAffichage1a1.Controls.Add(this.lblType);
            this.tpAffichage1a1.Controls.Add(this.lblCode);
            this.tpAffichage1a1.Controls.Add(this.btnDernier);
            this.tpAffichage1a1.Controls.Add(this.btnSuivant);
            this.tpAffichage1a1.Controls.Add(this.btnAvant);
            this.tpAffichage1a1.Controls.Add(this.btnPremier);
            this.tpAffichage1a1.Location = new System.Drawing.Point(4, 25);
            this.tpAffichage1a1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAffichage1a1.Name = "tpAffichage1a1";
            this.tpAffichage1a1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAffichage1a1.Size = new System.Drawing.Size(642, 424);
            this.tpAffichage1a1.TabIndex = 1;
            this.tpAffichage1a1.Text = "Affichage 1 à 1";
            this.tpAffichage1a1.UseVisualStyleBackColor = true;
            // 
            // dtp1a1
            // 
            this.dtp1a1.Enabled = false;
            this.dtp1a1.Location = new System.Drawing.Point(235, 16);
            this.dtp1a1.Name = "dtp1a1";
            this.dtp1a1.Size = new System.Drawing.Size(126, 20);
            this.dtp1a1.TabIndex = 20;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 181);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(556, 199);
            this.listBox1.TabIndex = 19;
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Location = new System.Drawing.Point(232, 48);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(35, 13);
            this.lblValeur.TabIndex = 16;
            this.lblValeur.Text = "label1";
            // 
            // checkRecette
            // 
            this.checkRecette.AutoSize = true;
            this.checkRecette.Enabled = false;
            this.checkRecette.Location = new System.Drawing.Point(235, 72);
            this.checkRecette.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkRecette.Name = "checkRecette";
            this.checkRecette.Size = new System.Drawing.Size(64, 17);
            this.checkRecette.TabIndex = 15;
            this.checkRecette.Text = "Recette";
            this.checkRecette.UseVisualStyleBackColor = true;
            // 
            // checkPercu
            // 
            this.checkPercu.AutoSize = true;
            this.checkPercu.Enabled = false;
            this.checkPercu.Location = new System.Drawing.Point(235, 105);
            this.checkPercu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkPercu.Name = "checkPercu";
            this.checkPercu.Size = new System.Drawing.Size(54, 17);
            this.checkPercu.TabIndex = 14;
            this.checkPercu.Text = "Perçu";
            this.checkPercu.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(28, 108);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "label3";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(28, 72);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "label2";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(28, 27);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "label1";
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(454, 388);
            this.btnDernier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(133, 26);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(313, 388);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(133, 26);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnAvant
            // 
            this.btnAvant.Location = new System.Drawing.Point(172, 388);
            this.btnAvant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvant.Name = "btnAvant";
            this.btnAvant.Size = new System.Drawing.Size(133, 26);
            this.btnAvant.TabIndex = 1;
            this.btnAvant.Text = "<";
            this.btnAvant.UseVisualStyleBackColor = true;
            this.btnAvant.Click += new System.EventHandler(this.btnAvant_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(31, 388);
            this.btnPremier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(133, 26);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            // 
            // tpNewTransaction
            // 
            this.tpNewTransaction.Controls.Add(this.chkPercu);
            this.tpNewTransaction.Controls.Add(this.chkRecette);
            this.tpNewTransaction.Controls.Add(this.btnAjouterPersonneTransa);
            this.tpNewTransaction.Controls.Add(this.grpParticipantsTransa);
            this.tpNewTransaction.Controls.Add(this.btnAjoutTransa);
            this.tpNewTransaction.Controls.Add(this.btnAjoutType);
            this.tpNewTransaction.Controls.Add(this.cboTypeTransa);
            this.tpNewTransaction.Controls.Add(this.lblTypeTransa);
            this.tpNewTransaction.Controls.Add(this.txtMontantTransa);
            this.tpNewTransaction.Controls.Add(this.lblMontantTransa);
            this.tpNewTransaction.Controls.Add(this.txtDescriptionTransa);
            this.tpNewTransaction.Controls.Add(this.lblDescripionTransa);
            this.tpNewTransaction.Controls.Add(this.dtpTransa);
            this.tpNewTransaction.Controls.Add(this.lblDateTransa);
            this.tpNewTransaction.Location = new System.Drawing.Point(4, 25);
            this.tpNewTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpNewTransaction.Name = "tpNewTransaction";
            this.tpNewTransaction.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpNewTransaction.Size = new System.Drawing.Size(642, 424);
            this.tpNewTransaction.TabIndex = 0;
            this.tpNewTransaction.Text = "Ajout d\'une transaction";
            this.tpNewTransaction.UseVisualStyleBackColor = true;
            // 
            // chkPercu
            // 
            this.chkPercu.AutoSize = true;
            this.chkPercu.Location = new System.Drawing.Point(218, 136);
            this.chkPercu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPercu.Name = "chkPercu";
            this.chkPercu.Size = new System.Drawing.Size(54, 17);
            this.chkPercu.TabIndex = 13;
            this.chkPercu.Text = "Perçu";
            this.chkPercu.UseVisualStyleBackColor = true;
            // 
            // chkRecette
            // 
            this.chkRecette.AutoSize = true;
            this.chkRecette.Location = new System.Drawing.Point(84, 136);
            this.chkRecette.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkRecette.Name = "chkRecette";
            this.chkRecette.Size = new System.Drawing.Size(64, 17);
            this.chkRecette.TabIndex = 12;
            this.chkRecette.Text = "Recette";
            this.chkRecette.UseVisualStyleBackColor = true;
            // 
            // btnAjouterPersonneTransa
            // 
            this.btnAjouterPersonneTransa.Location = new System.Drawing.Point(551, 13);
            this.btnAjouterPersonneTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterPersonneTransa.Name = "btnAjouterPersonneTransa";
            this.btnAjouterPersonneTransa.Size = new System.Drawing.Size(84, 67);
            this.btnAjouterPersonneTransa.TabIndex = 0;
            this.btnAjouterPersonneTransa.Text = "Ajouter une personne";
            this.btnAjouterPersonneTransa.UseVisualStyleBackColor = true;
            // 
            // grpParticipantsTransa
            // 
            this.grpParticipantsTransa.Location = new System.Drawing.Point(374, 6);
            this.grpParticipantsTransa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpParticipantsTransa.Name = "grpParticipantsTransa";
            this.grpParticipantsTransa.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpParticipantsTransa.Size = new System.Drawing.Size(168, 376);
            this.grpParticipantsTransa.TabIndex = 11;
            this.grpParticipantsTransa.TabStop = false;
            this.grpParticipantsTransa.Text = "Participants : ";
            // 
            // btnAjoutTransa
            // 
            this.btnAjoutTransa.Location = new System.Drawing.Point(144, 306);
            this.btnAjoutTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjoutTransa.Name = "btnAjoutTransa";
            this.btnAjoutTransa.Size = new System.Drawing.Size(160, 74);
            this.btnAjoutTransa.TabIndex = 10;
            this.btnAjoutTransa.Text = "Ajouter";
            this.btnAjoutTransa.UseVisualStyleBackColor = true;
            this.btnAjoutTransa.Click += new System.EventHandler(this.btnAjoutTransa_Click);
            // 
            // btnAjoutType
            // 
            this.btnAjoutType.Location = new System.Drawing.Point(328, 187);
            this.btnAjoutType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjoutType.Name = "btnAjoutType";
            this.btnAjoutType.Size = new System.Drawing.Size(24, 19);
            this.btnAjoutType.TabIndex = 9;
            this.btnAjoutType.Text = "...";
            this.btnAjoutType.UseVisualStyleBackColor = true;
            // 
            // cboTypeTransa
            // 
            this.cboTypeTransa.FormattingEnabled = true;
            this.cboTypeTransa.Location = new System.Drawing.Point(199, 187);
            this.cboTypeTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTypeTransa.Name = "cboTypeTransa";
            this.cboTypeTransa.Size = new System.Drawing.Size(92, 21);
            this.cboTypeTransa.TabIndex = 8;
            // 
            // lblTypeTransa
            // 
            this.lblTypeTransa.AutoSize = true;
            this.lblTypeTransa.Location = new System.Drawing.Point(109, 187);
            this.lblTypeTransa.Name = "lblTypeTransa";
            this.lblTypeTransa.Size = new System.Drawing.Size(31, 13);
            this.lblTypeTransa.TabIndex = 7;
            this.lblTypeTransa.Text = "Type";
            // 
            // txtMontantTransa
            // 
            this.txtMontantTransa.Location = new System.Drawing.Point(199, 101);
            this.txtMontantTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontantTransa.Name = "txtMontantTransa";
            this.txtMontantTransa.Size = new System.Drawing.Size(167, 20);
            this.txtMontantTransa.TabIndex = 4;
            this.txtMontantTransa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantTransa_KeyPress);
            // 
            // lblMontantTransa
            // 
            this.lblMontantTransa.AutoSize = true;
            this.lblMontantTransa.Location = new System.Drawing.Point(33, 101);
            this.lblMontantTransa.Name = "lblMontantTransa";
            this.lblMontantTransa.Size = new System.Drawing.Size(46, 13);
            this.lblMontantTransa.TabIndex = 3;
            this.lblMontantTransa.Text = "Montant";
            // 
            // txtDescriptionTransa
            // 
            this.txtDescriptionTransa.Location = new System.Drawing.Point(199, 67);
            this.txtDescriptionTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescriptionTransa.Name = "txtDescriptionTransa";
            this.txtDescriptionTransa.Size = new System.Drawing.Size(167, 20);
            this.txtDescriptionTransa.TabIndex = 3;
            // 
            // lblDescripionTransa
            // 
            this.lblDescripionTransa.AutoSize = true;
            this.lblDescripionTransa.Location = new System.Drawing.Point(33, 67);
            this.lblDescripionTransa.Name = "lblDescripionTransa";
            this.lblDescripionTransa.Size = new System.Drawing.Size(60, 13);
            this.lblDescripionTransa.TabIndex = 2;
            this.lblDescripionTransa.Text = "Description";
            // 
            // dtpTransa
            // 
            this.dtpTransa.Location = new System.Drawing.Point(199, 34);
            this.dtpTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTransa.Name = "dtpTransa";
            this.dtpTransa.Size = new System.Drawing.Size(167, 20);
            this.dtpTransa.TabIndex = 1;
            // 
            // lblDateTransa
            // 
            this.lblDateTransa.AutoSize = true;
            this.lblDateTransa.Location = new System.Drawing.Point(33, 28);
            this.lblDateTransa.Name = "lblDateTransa";
            this.lblDateTransa.Size = new System.Drawing.Size(111, 13);
            this.lblDateTransa.TabIndex = 0;
            this.lblDateTransa.Text = "Date de la transaction";
            // 
            // tpDeleteTransaction
            // 
            this.tpDeleteTransaction.Controls.Add(this.btnSupprTransac);
            this.tpDeleteTransaction.Controls.Add(this.txtCodeToSuppr);
            this.tpDeleteTransaction.Controls.Add(this.lblCodeToSuppr);
            this.tpDeleteTransaction.Controls.Add(this.dgvTransactions);
            this.tpDeleteTransaction.Location = new System.Drawing.Point(4, 25);
            this.tpDeleteTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDeleteTransaction.Name = "tpDeleteTransaction";
            this.tpDeleteTransaction.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpDeleteTransaction.Size = new System.Drawing.Size(642, 424);
            this.tpDeleteTransaction.TabIndex = 1;
            this.tpDeleteTransaction.Text = "Suppression d\'une transaction";
            this.tpDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // btnSupprTransac
            // 
            this.btnSupprTransac.Location = new System.Drawing.Point(279, 277);
            this.btnSupprTransac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprTransac.Name = "btnSupprTransac";
            this.btnSupprTransac.Size = new System.Drawing.Size(72, 24);
            this.btnSupprTransac.TabIndex = 3;
            this.btnSupprTransac.Text = "Supprimer";
            this.btnSupprTransac.UseVisualStyleBackColor = true;
            this.btnSupprTransac.Click += new System.EventHandler(this.btnSupprTransac_Click);
            // 
            // txtCodeToSuppr
            // 
            this.txtCodeToSuppr.Location = new System.Drawing.Point(188, 280);
            this.txtCodeToSuppr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodeToSuppr.Name = "txtCodeToSuppr";
            this.txtCodeToSuppr.Size = new System.Drawing.Size(26, 20);
            this.txtCodeToSuppr.TabIndex = 2;
            this.txtCodeToSuppr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeToSuppr_KeyPress);
            // 
            // lblCodeToSuppr
            // 
            this.lblCodeToSuppr.AutoSize = true;
            this.lblCodeToSuppr.Location = new System.Drawing.Point(6, 283);
            this.lblCodeToSuppr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodeToSuppr.Name = "lblCodeToSuppr";
            this.lblCodeToSuppr.Size = new System.Drawing.Size(176, 13);
            this.lblCodeToSuppr.TabIndex = 1;
            this.lblCodeToSuppr.Text = "Code de la transaction à supprimer :";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(8, 8);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(631, 230);
            this.dgvTransactions.TabIndex = 0;
            // 
            // tpModifTransaction
            // 
            this.tpModifTransaction.Controls.Add(this.btnAnnulerMod);
            this.tpModifTransaction.Controls.Add(this.btnValidMod);
            this.tpModifTransaction.Controls.Add(this.txtCodeToMod);
            this.tpModifTransaction.Controls.Add(this.tableLayoutPanel1);
            this.tpModifTransaction.Controls.Add(this.lblCodeToMod);
            this.tpModifTransaction.Controls.Add(this.dgvModifTransa);
            this.tpModifTransaction.Location = new System.Drawing.Point(4, 25);
            this.tpModifTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpModifTransaction.Name = "tpModifTransaction";
            this.tpModifTransaction.Size = new System.Drawing.Size(642, 424);
            this.tpModifTransaction.TabIndex = 2;
            this.tpModifTransaction.Text = "Modification d\'une transaction";
            this.tpModifTransaction.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerMod
            // 
            this.btnAnnulerMod.Location = new System.Drawing.Point(518, 250);
            this.btnAnnulerMod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnulerMod.Name = "btnAnnulerMod";
            this.btnAnnulerMod.Size = new System.Drawing.Size(56, 19);
            this.btnAnnulerMod.TabIndex = 19;
            this.btnAnnulerMod.Text = "Annuler";
            this.btnAnnulerMod.UseVisualStyleBackColor = true;
            this.btnAnnulerMod.Click += new System.EventHandler(this.btnAnnulerMod_Click);
            // 
            // btnValidMod
            // 
            this.btnValidMod.Location = new System.Drawing.Point(578, 250);
            this.btnValidMod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValidMod.Name = "btnValidMod";
            this.btnValidMod.Size = new System.Drawing.Size(56, 19);
            this.btnValidMod.TabIndex = 18;
            this.btnValidMod.Text = "Valider";
            this.btnValidMod.UseVisualStyleBackColor = true;
            this.btnValidMod.Click += new System.EventHandler(this.btnValidMod_Click);
            // 
            // txtCodeToMod
            // 
            this.txtCodeToMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodeToMod.Location = new System.Drawing.Point(178, 250);
            this.txtCodeToMod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodeToMod.Name = "txtCodeToMod";
            this.txtCodeToMod.Size = new System.Drawing.Size(26, 20);
            this.txtCodeToMod.TabIndex = 17;
            this.txtCodeToMod.TextChanged += new System.EventHandler(this.txtCodeToMod_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtModMontant, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtModCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblModCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModDesc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModMontant, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModRecette, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModPercu, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModType, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkModRecette, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkModPercu, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpModDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtModDesc, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboModType, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 288);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 127);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // txtModMontant
            // 
            this.txtModMontant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModMontant.Location = new System.Drawing.Point(332, 85);
            this.txtModMontant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModMontant.Name = "txtModMontant";
            this.txtModMontant.Size = new System.Drawing.Size(76, 20);
            this.txtModMontant.TabIndex = 15;
            this.txtModMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantTransa_KeyPress);
            // 
            // txtModCode
            // 
            this.txtModCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModCode.Location = new System.Drawing.Point(9, 85);
            this.txtModCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(76, 20);
            this.txtModCode.TabIndex = 14;
            this.txtModCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeToSuppr_KeyPress);
            // 
            // lblModCode
            // 
            this.lblModCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModCode.AutoSize = true;
            this.lblModCode.Location = new System.Drawing.Point(3, 25);
            this.lblModCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModCode.Name = "lblModCode";
            this.lblModCode.Size = new System.Drawing.Size(88, 13);
            this.lblModCode.TabIndex = 3;
            this.lblModCode.Text = "CodeTransaction";
            // 
            // lblModDate
            // 
            this.lblModDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModDate.AutoSize = true;
            this.lblModDate.Location = new System.Drawing.Point(96, 25);
            this.lblModDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModDate.Name = "lblModDate";
            this.lblModDate.Size = new System.Drawing.Size(86, 13);
            this.lblModDate.TabIndex = 4;
            this.lblModDate.Text = "DateTransaction";
            // 
            // lblModDesc
            // 
            this.lblModDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModDesc.AutoSize = true;
            this.lblModDesc.Location = new System.Drawing.Point(227, 25);
            this.lblModDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModDesc.Name = "lblModDesc";
            this.lblModDesc.Size = new System.Drawing.Size(60, 13);
            this.lblModDesc.TabIndex = 5;
            this.lblModDesc.Text = "Description";
            // 
            // lblModMontant
            // 
            this.lblModMontant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModMontant.AutoSize = true;
            this.lblModMontant.Location = new System.Drawing.Point(347, 25);
            this.lblModMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModMontant.Name = "lblModMontant";
            this.lblModMontant.Size = new System.Drawing.Size(46, 13);
            this.lblModMontant.TabIndex = 6;
            this.lblModMontant.Text = "Montant";
            // 
            // lblModRecette
            // 
            this.lblModRecette.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModRecette.AutoSize = true;
            this.lblModRecette.Location = new System.Drawing.Point(413, 25);
            this.lblModRecette.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModRecette.Name = "lblModRecette";
            this.lblModRecette.Size = new System.Drawing.Size(45, 13);
            this.lblModRecette.TabIndex = 7;
            this.lblModRecette.Text = "Recette";
            // 
            // lblModPercu
            // 
            this.lblModPercu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModPercu.AutoSize = true;
            this.lblModPercu.Location = new System.Drawing.Point(463, 25);
            this.lblModPercu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModPercu.Name = "lblModPercu";
            this.lblModPercu.Size = new System.Drawing.Size(35, 13);
            this.lblModPercu.TabIndex = 8;
            this.lblModPercu.Text = "Perçu";
            // 
            // lblModType
            // 
            this.lblModType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModType.AutoSize = true;
            this.lblModType.Location = new System.Drawing.Point(550, 25);
            this.lblModType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModType.Name = "lblModType";
            this.lblModType.Size = new System.Drawing.Size(31, 13);
            this.lblModType.TabIndex = 9;
            this.lblModType.Text = "Type";
            // 
            // chkModRecette
            // 
            this.chkModRecette.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkModRecette.AutoSize = true;
            this.chkModRecette.Location = new System.Drawing.Point(428, 88);
            this.chkModRecette.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkModRecette.Name = "chkModRecette";
            this.chkModRecette.Size = new System.Drawing.Size(15, 14);
            this.chkModRecette.TabIndex = 10;
            this.chkModRecette.UseVisualStyleBackColor = true;
            // 
            // chkModPercu
            // 
            this.chkModPercu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkModPercu.AutoSize = true;
            this.chkModPercu.Location = new System.Drawing.Point(473, 88);
            this.chkModPercu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkModPercu.Name = "chkModPercu";
            this.chkModPercu.Size = new System.Drawing.Size(15, 14);
            this.chkModPercu.TabIndex = 11;
            this.chkModPercu.UseVisualStyleBackColor = true;
            // 
            // dtpModDate
            // 
            this.dtpModDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpModDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModDate.Location = new System.Drawing.Point(96, 85);
            this.dtpModDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpModDate.Name = "dtpModDate";
            this.dtpModDate.Size = new System.Drawing.Size(86, 20);
            this.dtpModDate.TabIndex = 12;
            // 
            // txtModDesc
            // 
            this.txtModDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModDesc.Location = new System.Drawing.Point(187, 85);
            this.txtModDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModDesc.Name = "txtModDesc";
            this.txtModDesc.Size = new System.Drawing.Size(140, 20);
            this.txtModDesc.TabIndex = 13;
            // 
            // cboModType
            // 
            this.cboModType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboModType.FormattingEnabled = true;
            this.cboModType.Location = new System.Drawing.Point(522, 84);
            this.cboModType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboModType.Name = "cboModType";
            this.cboModType.Size = new System.Drawing.Size(86, 21);
            this.cboModType.TabIndex = 16;
            // 
            // lblCodeToMod
            // 
            this.lblCodeToMod.AutoSize = true;
            this.lblCodeToMod.Location = new System.Drawing.Point(6, 253);
            this.lblCodeToMod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodeToMod.Name = "lblCodeToMod";
            this.lblCodeToMod.Size = new System.Drawing.Size(167, 13);
            this.lblCodeToMod.TabIndex = 2;
            this.lblCodeToMod.Text = "Code de la transaction à modifier :";
            // 
            // dgvModifTransa
            // 
            this.dgvModifTransa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifTransa.Location = new System.Drawing.Point(7, 3);
            this.dgvModifTransa.Name = "dgvModifTransa";
            this.dgvModifTransa.RowTemplate.Height = 24;
            this.dgvModifTransa.Size = new System.Drawing.Size(631, 230);
            this.dgvModifTransa.TabIndex = 1;
            // 
            // tpRecap
            // 
            this.tpRecap.Location = new System.Drawing.Point(4, 25);
            this.tpRecap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpRecap.Name = "tpRecap";
            this.tpRecap.Size = new System.Drawing.Size(642, 424);
            this.tpRecap.TabIndex = 3;
            this.tpRecap.Text = "Récapitulatif";
            this.tpRecap.UseVisualStyleBackColor = true;
            // 
            // frmBudgetMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 461);
            this.Controls.Add(this.tcBudgetMois);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBudgetMois";
            this.Text = "Budget du mois";
            this.Load += new System.EventHandler(this.frmBudgetMois_Load);
            this.tcBudgetMois.ResumeLayout(false);
            this.tpAffichage1a1.ResumeLayout(false);
            this.tpAffichage1a1.PerformLayout();
            this.tpNewTransaction.ResumeLayout(false);
            this.tpNewTransaction.PerformLayout();
            this.tpDeleteTransaction.ResumeLayout(false);
            this.tpDeleteTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.tpModifTransaction.ResumeLayout(false);
            this.tpModifTransaction.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifTransa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBudgetMois;
        private System.Windows.Forms.TabPage tpNewTransaction;
        private System.Windows.Forms.TabPage tpAffichage1a1;
        private System.Windows.Forms.TabPage tpDeleteTransaction;
        private System.Windows.Forms.Label lblDateTransa;
        private System.Windows.Forms.GroupBox grpParticipantsTransa;
        private System.Windows.Forms.Button btnAjoutTransa;
        private System.Windows.Forms.Button btnAjoutType;
        private System.Windows.Forms.ComboBox cboTypeTransa;
        private System.Windows.Forms.Label lblTypeTransa;
        private System.Windows.Forms.TextBox txtMontantTransa;
        private System.Windows.Forms.Label lblMontantTransa;
        private System.Windows.Forms.TextBox txtDescriptionTransa;
        private System.Windows.Forms.Label lblDescripionTransa;
        private System.Windows.Forms.DateTimePicker dtpTransa;
        private System.Windows.Forms.Button btnAjouterPersonneTransa;
        private System.Windows.Forms.TabPage tpModifTransaction;
        private System.Windows.Forms.TabPage tpRecap;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnAvant;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.CheckBox chkPercu;
        private System.Windows.Forms.CheckBox chkRecette;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.CheckBox checkRecette;
        private System.Windows.Forms.CheckBox checkPercu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.DataGridView dgvTransactions;

        private System.Windows.Forms.TextBox txtCodeToSuppr;
        private System.Windows.Forms.Label lblCodeToSuppr;
        private System.Windows.Forms.Button btnSupprTransac;

        private System.Windows.Forms.DateTimePicker dtp1a1;
        private System.Windows.Forms.DataGridView dgvModifTransa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblModCode;
        private System.Windows.Forms.Label lblModDate;
        private System.Windows.Forms.Label lblModDesc;
        private System.Windows.Forms.Label lblModMontant;
        private System.Windows.Forms.Label lblModRecette;
        private System.Windows.Forms.Label lblModPercu;
        private System.Windows.Forms.Label lblModType;
        private System.Windows.Forms.Label lblCodeToMod;
        private System.Windows.Forms.CheckBox chkModRecette;
        private System.Windows.Forms.CheckBox chkModPercu;
        private System.Windows.Forms.TextBox txtModMontant;
        private System.Windows.Forms.TextBox txtModCode;
        private System.Windows.Forms.DateTimePicker dtpModDate;
        private System.Windows.Forms.TextBox txtModDesc;
        private System.Windows.Forms.ComboBox cboModType;
        private System.Windows.Forms.Button btnAnnulerMod;
        private System.Windows.Forms.Button btnValidMod;
        private System.Windows.Forms.TextBox txtCodeToMod;
    }
}

