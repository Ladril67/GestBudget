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
            this.lvPersonne = new System.Windows.Forms.ListView();
            this.dtp1a1 = new System.Windows.Forms.DateTimePicker();
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
            this.lblSupprPers = new System.Windows.Forms.Label();
            this.btnSupprPers = new System.Windows.Forms.Button();
            this.txtPrenomNewPers = new System.Windows.Forms.TextBox();
            this.txtNomNewPers = new System.Windows.Forms.TextBox();
            this.lblPrenomNewPers = new System.Windows.Forms.Label();
            this.lblNomNewPers = new System.Windows.Forms.Label();
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
            this.grpCriteres = new System.Windows.Forms.GroupBox();
            this.cboRecapRecette = new System.Windows.Forms.ComboBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.cboRecapPercu = new System.Windows.Forms.ComboBox();
            this.txtRecapMontant = new System.Windows.Forms.TextBox();
            this.cboRecapLib = new System.Windows.Forms.ComboBox();
            this.dtpRecapDate = new System.Windows.Forms.DateTimePicker();
            this.chkRecapRecette = new System.Windows.Forms.CheckBox();
            this.chkRecapPercu = new System.Windows.Forms.CheckBox();
            this.chkRecapMontant = new System.Windows.Forms.CheckBox();
            this.chkRecapLibelle = new System.Windows.Forms.CheckBox();
            this.chkRecapDate = new System.Windows.Forms.CheckBox();
            this.dgvRecapitulatif = new System.Windows.Forms.DataGridView();
            this.dtpReca = new System.Windows.Forms.DateTimePicker();
            this.btnCreeReca = new System.Windows.Forms.Button();
            this.tcBudgetMois.SuspendLayout();
            this.tpAffichage1a1.SuspendLayout();
            this.tpNewTransaction.SuspendLayout();
            this.tpDeleteTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.tpModifTransaction.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifTransa)).BeginInit();
            this.tpRecap.SuspendLayout();
            this.grpCriteres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecapitulatif)).BeginInit();
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
            this.tcBudgetMois.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcBudgetMois.Name = "tcBudgetMois";
            this.tcBudgetMois.SelectedIndex = 0;
            this.tcBudgetMois.Size = new System.Drawing.Size(872, 572);
            this.tcBudgetMois.TabIndex = 0;
            // 
            // tpAffichage1a1
            // 
            this.tpAffichage1a1.Controls.Add(this.lvPersonne);
            this.tpAffichage1a1.Controls.Add(this.dtp1a1);
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
            this.tpAffichage1a1.Location = new System.Drawing.Point(4, 28);
            this.tpAffichage1a1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAffichage1a1.Name = "tpAffichage1a1";
            this.tpAffichage1a1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAffichage1a1.Size = new System.Drawing.Size(864, 540);
            this.tpAffichage1a1.TabIndex = 1;
            this.tpAffichage1a1.Text = "Affichage 1 à 1";
            this.tpAffichage1a1.UseVisualStyleBackColor = true;
            // 
            // lvPersonne
            // 
            this.lvPersonne.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvPersonne.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvPersonne.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPersonne.Location = new System.Drawing.Point(61, 168);
            this.lvPersonne.Margin = new System.Windows.Forms.Padding(5);
            this.lvPersonne.Name = "lvPersonne";
            this.lvPersonne.Size = new System.Drawing.Size(738, 309);
            this.lvPersonne.TabIndex = 100;
            this.lvPersonne.UseCompatibleStateImageBehavior = false;
            // 
            // dtp1a1
            // 
            this.dtp1a1.Enabled = false;
            this.dtp1a1.Location = new System.Drawing.Point(313, 20);
            this.dtp1a1.Margin = new System.Windows.Forms.Padding(4);
            this.dtp1a1.Name = "dtp1a1";
            this.dtp1a1.Size = new System.Drawing.Size(167, 22);
            this.dtp1a1.TabIndex = 20;
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Location = new System.Drawing.Point(309, 59);
            this.lblValeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(46, 17);
            this.lblValeur.TabIndex = 16;
            this.lblValeur.Text = "label1";
            // 
            // checkRecette
            // 
            this.checkRecette.AutoSize = true;
            this.checkRecette.Enabled = false;
            this.checkRecette.Location = new System.Drawing.Point(313, 89);
            this.checkRecette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkRecette.Name = "checkRecette";
            this.checkRecette.Size = new System.Drawing.Size(79, 21);
            this.checkRecette.TabIndex = 15;
            this.checkRecette.Text = "Recette";
            this.checkRecette.UseVisualStyleBackColor = true;
            // 
            // checkPercu
            // 
            this.checkPercu.AutoSize = true;
            this.checkPercu.Enabled = false;
            this.checkPercu.Location = new System.Drawing.Point(312, 129);
            this.checkPercu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPercu.Name = "checkPercu";
            this.checkPercu.Size = new System.Drawing.Size(67, 21);
            this.checkPercu.TabIndex = 14;
            this.checkPercu.Text = "Perçu";
            this.checkPercu.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(37, 133);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(46, 17);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "label3";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(37, 89);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(46, 17);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "label2";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(37, 33);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 17);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "label1";
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(622, 487);
            this.btnDernier.Margin = new System.Windows.Forms.Padding(5);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(177, 32);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(435, 487);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(177, 32);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnAvant
            // 
            this.btnAvant.Location = new System.Drawing.Point(248, 487);
            this.btnAvant.Margin = new System.Windows.Forms.Padding(5);
            this.btnAvant.Name = "btnAvant";
            this.btnAvant.Size = new System.Drawing.Size(177, 32);
            this.btnAvant.TabIndex = 1;
            this.btnAvant.Text = "<";
            this.btnAvant.UseVisualStyleBackColor = true;
            this.btnAvant.Click += new System.EventHandler(this.btnAvant_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(61, 487);
            this.btnPremier.Margin = new System.Windows.Forms.Padding(5);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(177, 32);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // tpNewTransaction
            // 
            this.tpNewTransaction.Controls.Add(this.lblSupprPers);
            this.tpNewTransaction.Controls.Add(this.btnSupprPers);
            this.tpNewTransaction.Controls.Add(this.txtPrenomNewPers);
            this.tpNewTransaction.Controls.Add(this.txtNomNewPers);
            this.tpNewTransaction.Controls.Add(this.lblPrenomNewPers);
            this.tpNewTransaction.Controls.Add(this.lblNomNewPers);
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
            this.tpNewTransaction.Location = new System.Drawing.Point(4, 28);
            this.tpNewTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpNewTransaction.Name = "tpNewTransaction";
            this.tpNewTransaction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpNewTransaction.Size = new System.Drawing.Size(864, 540);
            this.tpNewTransaction.TabIndex = 0;
            this.tpNewTransaction.Text = "Ajout d\'une transaction";
            this.tpNewTransaction.UseVisualStyleBackColor = true;
            // 
            // lblSupprPers
            // 
            this.lblSupprPers.Location = new System.Drawing.Point(668, 276);
            this.lblSupprPers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupprPers.Name = "lblSupprPers";
            this.lblSupprPers.Size = new System.Drawing.Size(155, 70);
            this.lblSupprPers.TabIndex = 19;
            this.lblSupprPers.Text = "Supprime toutes les personnes selectionnées :";
            // 
            // btnSupprPers
            // 
            this.btnSupprPers.Location = new System.Drawing.Point(672, 352);
            this.btnSupprPers.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSupprPers.Name = "btnSupprPers";
            this.btnSupprPers.Size = new System.Drawing.Size(149, 71);
            this.btnSupprPers.TabIndex = 18;
            this.btnSupprPers.Text = "Supprimer une personne";
            this.btnSupprPers.UseVisualStyleBackColor = true;
            this.btnSupprPers.Click += new System.EventHandler(this.btnSupprPers_Click);
            // 
            // txtPrenomNewPers
            // 
            this.txtPrenomNewPers.Location = new System.Drawing.Point(671, 154);
            this.txtPrenomNewPers.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenomNewPers.Name = "txtPrenomNewPers";
            this.txtPrenomNewPers.Size = new System.Drawing.Size(149, 22);
            this.txtPrenomNewPers.TabIndex = 17;
            // 
            // txtNomNewPers
            // 
            this.txtNomNewPers.Location = new System.Drawing.Point(673, 60);
            this.txtNomNewPers.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomNewPers.Name = "txtNomNewPers";
            this.txtNomNewPers.Size = new System.Drawing.Size(148, 22);
            this.txtNomNewPers.TabIndex = 16;
            // 
            // lblPrenomNewPers
            // 
            this.lblPrenomNewPers.AutoSize = true;
            this.lblPrenomNewPers.Location = new System.Drawing.Point(669, 109);
            this.lblPrenomNewPers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenomNewPers.Name = "lblPrenomNewPers";
            this.lblPrenomNewPers.Size = new System.Drawing.Size(69, 17);
            this.lblPrenomNewPers.TabIndex = 15;
            this.lblPrenomNewPers.Text = "Prénom : ";
            // 
            // lblNomNewPers
            // 
            this.lblNomNewPers.AutoSize = true;
            this.lblNomNewPers.Location = new System.Drawing.Point(671, 17);
            this.lblNomNewPers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomNewPers.Name = "lblNomNewPers";
            this.lblNomNewPers.Size = new System.Drawing.Size(45, 17);
            this.lblNomNewPers.TabIndex = 14;
            this.lblNomNewPers.Text = "Nom :";
            // 
            // chkPercu
            // 
            this.chkPercu.AutoSize = true;
            this.chkPercu.Location = new System.Drawing.Point(244, 167);
            this.chkPercu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPercu.Name = "chkPercu";
            this.chkPercu.Size = new System.Drawing.Size(67, 21);
            this.chkPercu.TabIndex = 13;
            this.chkPercu.Text = "Perçu";
            this.chkPercu.UseVisualStyleBackColor = true;
            // 
            // chkRecette
            // 
            this.chkRecette.AutoSize = true;
            this.chkRecette.Location = new System.Drawing.Point(112, 167);
            this.chkRecette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRecette.Name = "chkRecette";
            this.chkRecette.Size = new System.Drawing.Size(79, 21);
            this.chkRecette.TabIndex = 12;
            this.chkRecette.Text = "Recette";
            this.chkRecette.UseVisualStyleBackColor = true;
            // 
            // btnAjouterPersonneTransa
            // 
            this.btnAjouterPersonneTransa.Location = new System.Drawing.Point(671, 189);
            this.btnAjouterPersonneTransa.Margin = new System.Windows.Forms.Padding(5);
            this.btnAjouterPersonneTransa.Name = "btnAjouterPersonneTransa";
            this.btnAjouterPersonneTransa.Size = new System.Drawing.Size(149, 65);
            this.btnAjouterPersonneTransa.TabIndex = 0;
            this.btnAjouterPersonneTransa.Text = "Ajouter une personne";
            this.btnAjouterPersonneTransa.UseVisualStyleBackColor = true;
            this.btnAjouterPersonneTransa.Click += new System.EventHandler(this.btnAjouterPersonneTransa_Click);
            // 
            // grpParticipantsTransa
            // 
            this.grpParticipantsTransa.Location = new System.Drawing.Point(458, 7);
            this.grpParticipantsTransa.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grpParticipantsTransa.Name = "grpParticipantsTransa";
            this.grpParticipantsTransa.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grpParticipantsTransa.Size = new System.Drawing.Size(201, 463);
            this.grpParticipantsTransa.TabIndex = 11;
            this.grpParticipantsTransa.TabStop = false;
            this.grpParticipantsTransa.Text = "Participants : ";
            // 
            // btnAjoutTransa
            // 
            this.btnAjoutTransa.Location = new System.Drawing.Point(121, 308);
            this.btnAjoutTransa.Margin = new System.Windows.Forms.Padding(5);
            this.btnAjoutTransa.Name = "btnAjoutTransa";
            this.btnAjoutTransa.Size = new System.Drawing.Size(213, 91);
            this.btnAjoutTransa.TabIndex = 10;
            this.btnAjoutTransa.Text = "Ajouter";
            this.btnAjoutTransa.UseVisualStyleBackColor = true;
            this.btnAjoutTransa.Click += new System.EventHandler(this.btnAjoutTransa_Click);
            // 
            // btnAjoutType
            // 
            this.btnAjoutType.Location = new System.Drawing.Point(373, 227);
            this.btnAjoutType.Margin = new System.Windows.Forms.Padding(5);
            this.btnAjoutType.Name = "btnAjoutType";
            this.btnAjoutType.Size = new System.Drawing.Size(32, 23);
            this.btnAjoutType.TabIndex = 9;
            this.btnAjoutType.Text = "...";
            this.btnAjoutType.UseVisualStyleBackColor = true;
            // 
            // cboTypeTransa
            // 
            this.cboTypeTransa.FormattingEnabled = true;
            this.cboTypeTransa.Location = new System.Drawing.Point(213, 227);
            this.cboTypeTransa.Margin = new System.Windows.Forms.Padding(5);
            this.cboTypeTransa.Name = "cboTypeTransa";
            this.cboTypeTransa.Size = new System.Drawing.Size(121, 24);
            this.cboTypeTransa.TabIndex = 8;
            // 
            // lblTypeTransa
            // 
            this.lblTypeTransa.AutoSize = true;
            this.lblTypeTransa.Location = new System.Drawing.Point(145, 230);
            this.lblTypeTransa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeTransa.Name = "lblTypeTransa";
            this.lblTypeTransa.Size = new System.Drawing.Size(40, 17);
            this.lblTypeTransa.TabIndex = 7;
            this.lblTypeTransa.Text = "Type";
            // 
            // txtMontantTransa
            // 
            this.txtMontantTransa.Location = new System.Drawing.Point(213, 121);
            this.txtMontantTransa.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontantTransa.Name = "txtMontantTransa";
            this.txtMontantTransa.Size = new System.Drawing.Size(221, 22);
            this.txtMontantTransa.TabIndex = 4;
            this.txtMontantTransa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantTransa_KeyPress);
            // 
            // lblMontantTransa
            // 
            this.lblMontantTransa.AutoSize = true;
            this.lblMontantTransa.Location = new System.Drawing.Point(44, 124);
            this.lblMontantTransa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontantTransa.Name = "lblMontantTransa";
            this.lblMontantTransa.Size = new System.Drawing.Size(59, 17);
            this.lblMontantTransa.TabIndex = 3;
            this.lblMontantTransa.Text = "Montant";
            // 
            // txtDescriptionTransa
            // 
            this.txtDescriptionTransa.Location = new System.Drawing.Point(213, 79);
            this.txtDescriptionTransa.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescriptionTransa.Name = "txtDescriptionTransa";
            this.txtDescriptionTransa.Size = new System.Drawing.Size(221, 22);
            this.txtDescriptionTransa.TabIndex = 3;
            // 
            // lblDescripionTransa
            // 
            this.lblDescripionTransa.AutoSize = true;
            this.lblDescripionTransa.Location = new System.Drawing.Point(44, 82);
            this.lblDescripionTransa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripionTransa.Name = "lblDescripionTransa";
            this.lblDescripionTransa.Size = new System.Drawing.Size(79, 17);
            this.lblDescripionTransa.TabIndex = 2;
            this.lblDescripionTransa.Text = "Description";
            // 
            // dtpTransa
            // 
            this.dtpTransa.Location = new System.Drawing.Point(213, 34);
            this.dtpTransa.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTransa.Name = "dtpTransa";
            this.dtpTransa.Size = new System.Drawing.Size(221, 22);
            this.dtpTransa.TabIndex = 1;
            // 
            // lblDateTransa
            // 
            this.lblDateTransa.AutoSize = true;
            this.lblDateTransa.Location = new System.Drawing.Point(44, 34);
            this.lblDateTransa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTransa.Name = "lblDateTransa";
            this.lblDateTransa.Size = new System.Drawing.Size(147, 17);
            this.lblDateTransa.TabIndex = 0;
            this.lblDateTransa.Text = "Date de la transaction";
            // 
            // tpDeleteTransaction
            // 
            this.tpDeleteTransaction.Controls.Add(this.btnSupprTransac);
            this.tpDeleteTransaction.Controls.Add(this.txtCodeToSuppr);
            this.tpDeleteTransaction.Controls.Add(this.lblCodeToSuppr);
            this.tpDeleteTransaction.Controls.Add(this.dgvTransactions);
            this.tpDeleteTransaction.Location = new System.Drawing.Point(4, 28);
            this.tpDeleteTransaction.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tpDeleteTransaction.Name = "tpDeleteTransaction";
            this.tpDeleteTransaction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDeleteTransaction.Size = new System.Drawing.Size(864, 540);
            this.tpDeleteTransaction.TabIndex = 1;
            this.tpDeleteTransaction.Text = "Suppression d\'une transaction";
            this.tpDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // btnSupprTransac
            // 
            this.btnSupprTransac.Location = new System.Drawing.Point(372, 341);
            this.btnSupprTransac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprTransac.Name = "btnSupprTransac";
            this.btnSupprTransac.Size = new System.Drawing.Size(96, 30);
            this.btnSupprTransac.TabIndex = 3;
            this.btnSupprTransac.Text = "Supprimer";
            this.btnSupprTransac.UseVisualStyleBackColor = true;
            this.btnSupprTransac.Click += new System.EventHandler(this.btnSupprTransac_Click);
            // 
            // txtCodeToSuppr
            // 
            this.txtCodeToSuppr.Location = new System.Drawing.Point(251, 345);
            this.txtCodeToSuppr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodeToSuppr.Name = "txtCodeToSuppr";
            this.txtCodeToSuppr.Size = new System.Drawing.Size(33, 22);
            this.txtCodeToSuppr.TabIndex = 2;
            this.txtCodeToSuppr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeToSuppr_KeyPress);
            // 
            // lblCodeToSuppr
            // 
            this.lblCodeToSuppr.AutoSize = true;
            this.lblCodeToSuppr.Location = new System.Drawing.Point(8, 348);
            this.lblCodeToSuppr.Name = "lblCodeToSuppr";
            this.lblCodeToSuppr.Size = new System.Drawing.Size(237, 17);
            this.lblCodeToSuppr.TabIndex = 1;
            this.lblCodeToSuppr.Text = "Code de la transaction à supprimer :";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(11, 10);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(841, 283);
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
            this.tpModifTransaction.Location = new System.Drawing.Point(4, 28);
            this.tpModifTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpModifTransaction.Name = "tpModifTransaction";
            this.tpModifTransaction.Size = new System.Drawing.Size(864, 540);
            this.tpModifTransaction.TabIndex = 2;
            this.tpModifTransaction.Text = "Modification d\'une transaction";
            this.tpModifTransaction.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerMod
            // 
            this.btnAnnulerMod.Location = new System.Drawing.Point(691, 308);
            this.btnAnnulerMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnulerMod.Name = "btnAnnulerMod";
            this.btnAnnulerMod.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerMod.TabIndex = 19;
            this.btnAnnulerMod.Text = "Annuler";
            this.btnAnnulerMod.UseVisualStyleBackColor = true;
            this.btnAnnulerMod.Click += new System.EventHandler(this.btnAnnulerMod_Click);
            // 
            // btnValidMod
            // 
            this.btnValidMod.Location = new System.Drawing.Point(771, 308);
            this.btnValidMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidMod.Name = "btnValidMod";
            this.btnValidMod.Size = new System.Drawing.Size(75, 23);
            this.btnValidMod.TabIndex = 18;
            this.btnValidMod.Text = "Valider";
            this.btnValidMod.UseVisualStyleBackColor = true;
            this.btnValidMod.Click += new System.EventHandler(this.btnValidMod_Click);
            // 
            // txtCodeToMod
            // 
            this.txtCodeToMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodeToMod.Location = new System.Drawing.Point(238, 311);
            this.txtCodeToMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodeToMod.Name = "txtCodeToMod";
            this.txtCodeToMod.Size = new System.Drawing.Size(33, 22);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 354);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 156);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // txtModMontant
            // 
            this.txtModMontant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModMontant.Location = new System.Drawing.Point(439, 105);
            this.txtModMontant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModMontant.Name = "txtModMontant";
            this.txtModMontant.Size = new System.Drawing.Size(100, 22);
            this.txtModMontant.TabIndex = 15;
            this.txtModMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantTransa_KeyPress);
            // 
            // txtModCode
            // 
            this.txtModCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModCode.Location = new System.Drawing.Point(12, 105);
            this.txtModCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(100, 22);
            this.txtModCode.TabIndex = 14;
            this.txtModCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeToSuppr_KeyPress);
            // 
            // lblModCode
            // 
            this.lblModCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModCode.AutoSize = true;
            this.lblModCode.Location = new System.Drawing.Point(4, 30);
            this.lblModCode.Name = "lblModCode";
            this.lblModCode.Size = new System.Drawing.Size(116, 17);
            this.lblModCode.TabIndex = 3;
            this.lblModCode.Text = "CodeTransaction";
            // 
            // lblModDate
            // 
            this.lblModDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModDate.AutoSize = true;
            this.lblModDate.Location = new System.Drawing.Point(127, 30);
            this.lblModDate.Name = "lblModDate";
            this.lblModDate.Size = new System.Drawing.Size(113, 17);
            this.lblModDate.TabIndex = 4;
            this.lblModDate.Text = "DateTransaction";
            // 
            // lblModDesc
            // 
            this.lblModDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModDesc.AutoSize = true;
            this.lblModDesc.Location = new System.Drawing.Point(300, 30);
            this.lblModDesc.Name = "lblModDesc";
            this.lblModDesc.Size = new System.Drawing.Size(79, 17);
            this.lblModDesc.TabIndex = 5;
            this.lblModDesc.Text = "Description";
            // 
            // lblModMontant
            // 
            this.lblModMontant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModMontant.AutoSize = true;
            this.lblModMontant.Location = new System.Drawing.Point(459, 30);
            this.lblModMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModMontant.Name = "lblModMontant";
            this.lblModMontant.Size = new System.Drawing.Size(59, 17);
            this.lblModMontant.TabIndex = 6;
            this.lblModMontant.Text = "Montant";
            // 
            // lblModRecette
            // 
            this.lblModRecette.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModRecette.AutoSize = true;
            this.lblModRecette.Location = new System.Drawing.Point(545, 30);
            this.lblModRecette.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModRecette.Name = "lblModRecette";
            this.lblModRecette.Size = new System.Drawing.Size(57, 17);
            this.lblModRecette.TabIndex = 7;
            this.lblModRecette.Text = "Recette";
            // 
            // lblModPercu
            // 
            this.lblModPercu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModPercu.AutoSize = true;
            this.lblModPercu.Location = new System.Drawing.Point(607, 30);
            this.lblModPercu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModPercu.Name = "lblModPercu";
            this.lblModPercu.Size = new System.Drawing.Size(45, 17);
            this.lblModPercu.TabIndex = 8;
            this.lblModPercu.Text = "Perçu";
            // 
            // lblModType
            // 
            this.lblModType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModType.AutoSize = true;
            this.lblModType.Location = new System.Drawing.Point(727, 30);
            this.lblModType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModType.Name = "lblModType";
            this.lblModType.Size = new System.Drawing.Size(40, 17);
            this.lblModType.TabIndex = 9;
            this.lblModType.Text = "Type";
            // 
            // chkModRecette
            // 
            this.chkModRecette.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkModRecette.AutoSize = true;
            this.chkModRecette.Location = new System.Drawing.Point(564, 108);
            this.chkModRecette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkModRecette.Name = "chkModRecette";
            this.chkModRecette.Size = new System.Drawing.Size(18, 17);
            this.chkModRecette.TabIndex = 10;
            this.chkModRecette.UseVisualStyleBackColor = true;
            // 
            // chkModPercu
            // 
            this.chkModPercu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkModPercu.AutoSize = true;
            this.chkModPercu.Location = new System.Drawing.Point(620, 108);
            this.chkModPercu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkModPercu.Name = "chkModPercu";
            this.chkModPercu.Size = new System.Drawing.Size(18, 17);
            this.chkModPercu.TabIndex = 11;
            this.chkModPercu.UseVisualStyleBackColor = true;
            // 
            // dtpModDate
            // 
            this.dtpModDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpModDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModDate.Location = new System.Drawing.Point(127, 105);
            this.dtpModDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpModDate.Name = "dtpModDate";
            this.dtpModDate.Size = new System.Drawing.Size(113, 22);
            this.dtpModDate.TabIndex = 12;
            // 
            // txtModDesc
            // 
            this.txtModDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModDesc.Location = new System.Drawing.Point(247, 105);
            this.txtModDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModDesc.Name = "txtModDesc";
            this.txtModDesc.Size = new System.Drawing.Size(185, 22);
            this.txtModDesc.TabIndex = 13;
            // 
            // cboModType
            // 
            this.cboModType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboModType.FormattingEnabled = true;
            this.cboModType.Location = new System.Drawing.Point(691, 104);
            this.cboModType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboModType.Name = "cboModType";
            this.cboModType.Size = new System.Drawing.Size(113, 24);
            this.cboModType.TabIndex = 16;
            // 
            // lblCodeToMod
            // 
            this.lblCodeToMod.AutoSize = true;
            this.lblCodeToMod.Location = new System.Drawing.Point(8, 311);
            this.lblCodeToMod.Name = "lblCodeToMod";
            this.lblCodeToMod.Size = new System.Drawing.Size(224, 17);
            this.lblCodeToMod.TabIndex = 2;
            this.lblCodeToMod.Text = "Code de la transaction à modifier :";
            // 
            // dgvModifTransa
            // 
            this.dgvModifTransa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModifTransa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifTransa.Location = new System.Drawing.Point(9, 4);
            this.dgvModifTransa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvModifTransa.Name = "dgvModifTransa";
            this.dgvModifTransa.RowTemplate.Height = 24;
            this.dgvModifTransa.Size = new System.Drawing.Size(841, 283);
            this.dgvModifTransa.TabIndex = 1;
            // 
            // tpRecap
            // 
            this.tpRecap.Controls.Add(this.grpCriteres);
            this.tpRecap.Controls.Add(this.dgvRecapitulatif);
            this.tpRecap.Controls.Add(this.dtpReca);
            this.tpRecap.Controls.Add(this.btnCreeReca);
            this.tpRecap.Location = new System.Drawing.Point(4, 28);
            this.tpRecap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRecap.Name = "tpRecap";
            this.tpRecap.Size = new System.Drawing.Size(864, 540);
            this.tpRecap.TabIndex = 3;
            this.tpRecap.Text = "Récapitulatif";
            this.tpRecap.UseVisualStyleBackColor = true;
            // 
            // grpCriteres
            // 
            this.grpCriteres.Controls.Add(this.cboRecapRecette);
            this.grpCriteres.Controls.Add(this.btnRechercher);
            this.grpCriteres.Controls.Add(this.cboRecapPercu);
            this.grpCriteres.Controls.Add(this.txtRecapMontant);
            this.grpCriteres.Controls.Add(this.cboRecapLib);
            this.grpCriteres.Controls.Add(this.dtpRecapDate);
            this.grpCriteres.Controls.Add(this.chkRecapRecette);
            this.grpCriteres.Controls.Add(this.chkRecapPercu);
            this.grpCriteres.Controls.Add(this.chkRecapMontant);
            this.grpCriteres.Controls.Add(this.chkRecapLibelle);
            this.grpCriteres.Controls.Add(this.chkRecapDate);
            this.grpCriteres.Location = new System.Drawing.Point(11, 375);
            this.grpCriteres.Margin = new System.Windows.Forms.Padding(4);
            this.grpCriteres.Name = "grpCriteres";
            this.grpCriteres.Padding = new System.Windows.Forms.Padding(4);
            this.grpCriteres.Size = new System.Drawing.Size(845, 161);
            this.grpCriteres.TabIndex = 16;
            this.grpCriteres.TabStop = false;
            this.grpCriteres.Text = "Liste des critères";
            // 
            // cboRecapRecette
            // 
            this.cboRecapRecette.FormattingEnabled = true;
            this.cboRecapRecette.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboRecapRecette.Location = new System.Drawing.Point(609, 83);
            this.cboRecapRecette.Margin = new System.Windows.Forms.Padding(4);
            this.cboRecapRecette.Name = "cboRecapRecette";
            this.cboRecapRecette.Size = new System.Drawing.Size(207, 24);
            this.cboRecapRecette.TabIndex = 12;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(706, 119);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(131, 41);
            this.btnRechercher.TabIndex = 15;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // cboRecapPercu
            // 
            this.cboRecapPercu.FormattingEnabled = true;
            this.cboRecapPercu.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboRecapPercu.Location = new System.Drawing.Point(593, 39);
            this.cboRecapPercu.Margin = new System.Windows.Forms.Padding(4);
            this.cboRecapPercu.Name = "cboRecapPercu";
            this.cboRecapPercu.Size = new System.Drawing.Size(223, 24);
            this.cboRecapPercu.TabIndex = 11;
            // 
            // txtRecapMontant
            // 
            this.txtRecapMontant.Location = new System.Drawing.Point(128, 128);
            this.txtRecapMontant.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecapMontant.Name = "txtRecapMontant";
            this.txtRecapMontant.Size = new System.Drawing.Size(249, 22);
            this.txtRecapMontant.TabIndex = 10;
            this.txtRecapMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantTransa_KeyPress);
            // 
            // cboRecapLib
            // 
            this.cboRecapLib.FormattingEnabled = true;
            this.cboRecapLib.Location = new System.Drawing.Point(121, 80);
            this.cboRecapLib.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboRecapLib.Name = "cboRecapLib";
            this.cboRecapLib.Size = new System.Drawing.Size(256, 24);
            this.cboRecapLib.TabIndex = 9;
            // 
            // dtpRecapDate
            // 
            this.dtpRecapDate.Location = new System.Drawing.Point(112, 40);
            this.dtpRecapDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRecapDate.Name = "dtpRecapDate";
            this.dtpRecapDate.Size = new System.Drawing.Size(265, 22);
            this.dtpRecapDate.TabIndex = 5;
            // 
            // chkRecapRecette
            // 
            this.chkRecapRecette.AutoSize = true;
            this.chkRecapRecette.Location = new System.Drawing.Point(521, 83);
            this.chkRecapRecette.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecapRecette.Name = "chkRecapRecette";
            this.chkRecapRecette.Size = new System.Drawing.Size(87, 21);
            this.chkRecapRecette.TabIndex = 4;
            this.chkRecapRecette.Text = "Recette :";
            this.chkRecapRecette.UseVisualStyleBackColor = true;
            // 
            // chkRecapPercu
            // 
            this.chkRecapPercu.AutoSize = true;
            this.chkRecapPercu.Location = new System.Drawing.Point(521, 41);
            this.chkRecapPercu.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecapPercu.Name = "chkRecapPercu";
            this.chkRecapPercu.Size = new System.Drawing.Size(75, 21);
            this.chkRecapPercu.TabIndex = 3;
            this.chkRecapPercu.Text = "Perçu :";
            this.chkRecapPercu.UseVisualStyleBackColor = true;
            // 
            // chkRecapMontant
            // 
            this.chkRecapMontant.AutoSize = true;
            this.chkRecapMontant.Location = new System.Drawing.Point(31, 130);
            this.chkRecapMontant.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecapMontant.Name = "chkRecapMontant";
            this.chkRecapMontant.Size = new System.Drawing.Size(89, 21);
            this.chkRecapMontant.TabIndex = 2;
            this.chkRecapMontant.Text = "Montant :";
            this.chkRecapMontant.UseVisualStyleBackColor = true;
            // 
            // chkRecapLibelle
            // 
            this.chkRecapLibelle.AutoSize = true;
            this.chkRecapLibelle.Location = new System.Drawing.Point(31, 83);
            this.chkRecapLibelle.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecapLibelle.Name = "chkRecapLibelle";
            this.chkRecapLibelle.Size = new System.Drawing.Size(79, 21);
            this.chkRecapLibelle.TabIndex = 1;
            this.chkRecapLibelle.Text = "Libellé :";
            this.chkRecapLibelle.UseVisualStyleBackColor = true;
            // 
            // chkRecapDate
            // 
            this.chkRecapDate.AutoSize = true;
            this.chkRecapDate.Location = new System.Drawing.Point(31, 41);
            this.chkRecapDate.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecapDate.Name = "chkRecapDate";
            this.chkRecapDate.Size = new System.Drawing.Size(68, 21);
            this.chkRecapDate.TabIndex = 0;
            this.chkRecapDate.Text = "Date :";
            this.chkRecapDate.UseVisualStyleBackColor = true;
            // 
            // dgvRecapitulatif
            // 
            this.dgvRecapitulatif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecapitulatif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecapitulatif.Location = new System.Drawing.Point(11, 94);
            this.dgvRecapitulatif.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecapitulatif.Name = "dgvRecapitulatif";
            this.dgvRecapitulatif.RowTemplate.Height = 24;
            this.dgvRecapitulatif.Size = new System.Drawing.Size(845, 274);
            this.dgvRecapitulatif.TabIndex = 14;
            // 
            // dtpReca
            // 
            this.dtpReca.Location = new System.Drawing.Point(5, 5);
            this.dtpReca.Margin = new System.Windows.Forms.Padding(5);
            this.dtpReca.Name = "dtpReca";
            this.dtpReca.Size = new System.Drawing.Size(281, 22);
            this.dtpReca.TabIndex = 13;
            // 
            // btnCreeReca
            // 
            this.btnCreeReca.Location = new System.Drawing.Point(5, 44);
            this.btnCreeReca.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreeReca.Name = "btnCreeReca";
            this.btnCreeReca.Size = new System.Drawing.Size(284, 41);
            this.btnCreeReca.TabIndex = 12;
            this.btnCreeReca.Text = "Crée Recapitulatif";
            this.btnCreeReca.UseVisualStyleBackColor = true;
            this.btnCreeReca.Click += new System.EventHandler(this.btnCreeReca_Click);
            // 
            // frmBudgetMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 576);
            this.Controls.Add(this.tcBudgetMois);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tpRecap.ResumeLayout(false);
            this.grpCriteres.ResumeLayout(false);
            this.grpCriteres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecapitulatif)).EndInit();
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
        private System.Windows.Forms.ListView lvPersonne;
        private System.Windows.Forms.Button btnCreeReca;
        private System.Windows.Forms.DateTimePicker dtpReca;
        private System.Windows.Forms.TextBox txtPrenomNewPers;
        private System.Windows.Forms.TextBox txtNomNewPers;
        private System.Windows.Forms.Label lblPrenomNewPers;
        private System.Windows.Forms.Label lblNomNewPers;
        private System.Windows.Forms.Label lblSupprPers;
        private System.Windows.Forms.Button btnSupprPers;
        private System.Windows.Forms.DataGridView dgvRecapitulatif;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.GroupBox grpCriteres;
        private System.Windows.Forms.CheckBox chkRecapRecette;
        private System.Windows.Forms.CheckBox chkRecapPercu;
        private System.Windows.Forms.CheckBox chkRecapMontant;
        private System.Windows.Forms.CheckBox chkRecapLibelle;
        private System.Windows.Forms.CheckBox chkRecapDate;
        private System.Windows.Forms.TextBox txtRecapMontant;
        private System.Windows.Forms.ComboBox cboRecapLib;
        private System.Windows.Forms.DateTimePicker dtpRecapDate;
        private System.Windows.Forms.ComboBox cboRecapPercu;
        private System.Windows.Forms.ComboBox cboRecapRecette;
    }
}

