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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cboCalendrier = new System.Windows.Forms.ComboBox();
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
            this.tpModifTransaction = new System.Windows.Forms.TabPage();
            this.tpRecap = new System.Windows.Forms.TabPage();
            this.tcBudgetMois.SuspendLayout();
            this.tpAffichage1a1.SuspendLayout();
            this.tpNewTransaction.SuspendLayout();
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
            this.tcBudgetMois.Size = new System.Drawing.Size(694, 418);
            this.tcBudgetMois.TabIndex = 0;
            // 
            // tpAffichage1a1
            // 
            this.tpAffichage1a1.Controls.Add(this.listBox1);
            this.tpAffichage1a1.Controls.Add(this.cboCalendrier);
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
            this.tpAffichage1a1.Size = new System.Drawing.Size(686, 389);
            this.tpAffichage1a1.TabIndex = 1;
            this.tpAffichage1a1.Text = "Affichage 1 à 1";
            this.tpAffichage1a1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(535, 199);
            this.listBox1.TabIndex = 19;
            // 
            // cboCalendrier
            // 
            this.cboCalendrier.FormattingEnabled = true;
            this.cboCalendrier.Location = new System.Drawing.Point(368, 19);
            this.cboCalendrier.Name = "cboCalendrier";
            this.cboCalendrier.Size = new System.Drawing.Size(190, 21);
            this.cboCalendrier.TabIndex = 17;
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Location = new System.Drawing.Point(422, 72);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(35, 13);
            this.lblValeur.TabIndex = 16;
            this.lblValeur.Text = "label1";
            // 
            // checkRecette
            // 
            this.checkRecette.AutoSize = true;
            this.checkRecette.Location = new System.Drawing.Point(494, 68);
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
            this.checkPercu.Location = new System.Drawing.Point(504, 108);
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
            this.lblDescription.Location = new System.Drawing.Point(20, 108);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "label3";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 72);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "label2";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(20, 19);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "label1";
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(425, 355);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(133, 26);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(286, 355);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(133, 26);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnAvant
            // 
            this.btnAvant.Location = new System.Drawing.Point(147, 355);
            this.btnAvant.Name = "btnAvant";
            this.btnAvant.Size = new System.Drawing.Size(133, 26);
            this.btnAvant.TabIndex = 1;
            this.btnAvant.Text = "<";
            this.btnAvant.UseVisualStyleBackColor = true;
            this.btnAvant.Click += new System.EventHandler(this.btnAvant_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(8, 355);
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
            this.tpNewTransaction.Size = new System.Drawing.Size(686, 389);
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
            this.btnAjouterPersonneTransa.Location = new System.Drawing.Point(567, 15);
            this.btnAjouterPersonneTransa.Name = "btnAjouterPersonneTransa";
            this.btnAjouterPersonneTransa.Size = new System.Drawing.Size(84, 67);
            this.btnAjouterPersonneTransa.TabIndex = 0;
            this.btnAjouterPersonneTransa.Text = "Ajouter une personne";
            this.btnAjouterPersonneTransa.UseVisualStyleBackColor = true;
            // 
            // grpParticipantsTransa
            // 
            this.grpParticipantsTransa.Location = new System.Drawing.Point(369, 15);
            this.grpParticipantsTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpParticipantsTransa.Name = "grpParticipantsTransa";
            this.grpParticipantsTransa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpParticipantsTransa.Size = new System.Drawing.Size(182, 370);
            this.grpParticipantsTransa.TabIndex = 11;
            this.grpParticipantsTransa.TabStop = false;
            this.grpParticipantsTransa.Text = "Participants : ";
            // 
            // btnAjoutTransa
            // 
            this.btnAjoutTransa.Location = new System.Drawing.Point(108, 249);
            this.btnAjoutTransa.Name = "btnAjoutTransa";
            this.btnAjoutTransa.Size = new System.Drawing.Size(160, 74);
            this.btnAjoutTransa.TabIndex = 10;
            this.btnAjoutTransa.Text = "Ajouter";
            this.btnAjoutTransa.UseVisualStyleBackColor = true;
            this.btnAjoutTransa.Click += new System.EventHandler(this.btnAjoutTransa_Click);
            // 
            // btnAjoutType
            // 
            this.btnAjoutType.Location = new System.Drawing.Point(244, 187);
            this.btnAjoutType.Name = "btnAjoutType";
            this.btnAjoutType.Size = new System.Drawing.Size(24, 19);
            this.btnAjoutType.TabIndex = 9;
            this.btnAjoutType.Text = "...";
            this.btnAjoutType.UseVisualStyleBackColor = true;
            // 
            // cboTypeTransa
            // 
            this.cboTypeTransa.FormattingEnabled = true;
            this.cboTypeTransa.Location = new System.Drawing.Point(146, 187);
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
            this.txtMontantTransa.Location = new System.Drawing.Point(149, 97);
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
            this.txtDescriptionTransa.Location = new System.Drawing.Point(149, 63);
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
            this.dtpTransa.Location = new System.Drawing.Point(149, 28);
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
            this.tpDeleteTransaction.Location = new System.Drawing.Point(4, 25);
            this.tpDeleteTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpDeleteTransaction.Name = "tpDeleteTransaction";
            this.tpDeleteTransaction.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpDeleteTransaction.Size = new System.Drawing.Size(686, 389);
            this.tpDeleteTransaction.TabIndex = 1;
            this.tpDeleteTransaction.Text = "Suppression d\'une transaction";
            this.tpDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // tpModifTransaction
            // 
            this.tpModifTransaction.Location = new System.Drawing.Point(4, 25);
            this.tpModifTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpModifTransaction.Name = "tpModifTransaction";
            this.tpModifTransaction.Size = new System.Drawing.Size(686, 389);
            this.tpModifTransaction.TabIndex = 2;
            this.tpModifTransaction.Text = "Modification d\'une transaction";
            this.tpModifTransaction.UseVisualStyleBackColor = true;
            // 
            // tpRecap
            // 
            this.tpRecap.Location = new System.Drawing.Point(4, 25);
            this.tpRecap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpRecap.Name = "tpRecap";
            this.tpRecap.Size = new System.Drawing.Size(686, 389);
            this.tpRecap.TabIndex = 3;
            this.tpRecap.Text = "Récapitulatif";
            this.tpRecap.UseVisualStyleBackColor = true;
            // 
            // frmBudgetMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 418);
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
        private System.Windows.Forms.ComboBox cboCalendrier;
        private System.Windows.Forms.Label lblValeur;
    }
}

