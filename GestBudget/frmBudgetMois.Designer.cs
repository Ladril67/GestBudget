namespace GestBudget
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
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnAvant = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.tpNewTransaction = new System.Windows.Forms.TabPage();
<<<<<<< HEAD
            this.grpRecettePercu = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
=======
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
            this.btnAjouterPersonneTransa = new System.Windows.Forms.Button();
            this.grpParticipantsTransa = new System.Windows.Forms.GroupBox();
            this.btnAjoutTransa = new System.Windows.Forms.Button();
            this.btnAjoutType = new System.Windows.Forms.Button();
            this.cbTypeTransa = new System.Windows.Forms.ComboBox();
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
<<<<<<< HEAD
            this.btnPercu = new System.Windows.Forms.RadioButton();
=======
            this.cbRecette = new System.Windows.Forms.CheckBox();
            this.cbPercu = new System.Windows.Forms.CheckBox();
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
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
            this.tcBudgetMois.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcBudgetMois.Name = "tcBudgetMois";
            this.tcBudgetMois.SelectedIndex = 0;
            this.tcBudgetMois.Size = new System.Drawing.Size(925, 514);
            this.tcBudgetMois.TabIndex = 0;
            // 
            // tpAffichage1a1
            // 
<<<<<<< HEAD
            this.tpAffichage1a1.Location = new System.Drawing.Point(4, 25);
            this.tpAffichage1a1.Margin = new System.Windows.Forms.Padding(2);
            this.tpAffichage1a1.Name = "tpAffichage1a1";
            this.tpAffichage1a1.Padding = new System.Windows.Forms.Padding(2);
            this.tpAffichage1a1.Size = new System.Drawing.Size(686, 389);
=======
            this.tpAffichage1a1.Controls.Add(this.btnDernier);
            this.tpAffichage1a1.Controls.Add(this.btnSuivant);
            this.tpAffichage1a1.Controls.Add(this.btnAvant);
            this.tpAffichage1a1.Controls.Add(this.btnPremier);
            this.tpAffichage1a1.Location = new System.Drawing.Point(4, 28);
            this.tpAffichage1a1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAffichage1a1.Name = "tpAffichage1a1";
            this.tpAffichage1a1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAffichage1a1.Size = new System.Drawing.Size(917, 482);
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
            this.tpAffichage1a1.TabIndex = 1;
            this.tpAffichage1a1.Text = "Affichage 1 à 1";
            this.tpAffichage1a1.UseVisualStyleBackColor = true;
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(567, 437);
            this.btnDernier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(177, 32);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(381, 437);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(177, 32);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            // 
            // btnAvant
            // 
            this.btnAvant.Location = new System.Drawing.Point(196, 437);
            this.btnAvant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvant.Name = "btnAvant";
            this.btnAvant.Size = new System.Drawing.Size(177, 32);
            this.btnAvant.TabIndex = 1;
            this.btnAvant.Text = "<";
            this.btnAvant.UseVisualStyleBackColor = true;
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(11, 437);
            this.btnPremier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(177, 32);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            // 
            // tpNewTransaction
            // 
            this.tpNewTransaction.Controls.Add(this.cbPercu);
            this.tpNewTransaction.Controls.Add(this.cbRecette);
            this.tpNewTransaction.Controls.Add(this.btnAjouterPersonneTransa);
            this.tpNewTransaction.Controls.Add(this.grpParticipantsTransa);
            this.tpNewTransaction.Controls.Add(this.btnAjoutTransa);
            this.tpNewTransaction.Controls.Add(this.btnAjoutType);
            this.tpNewTransaction.Controls.Add(this.cbTypeTransa);
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
            this.tpNewTransaction.Size = new System.Drawing.Size(917, 482);
            this.tpNewTransaction.TabIndex = 0;
            this.tpNewTransaction.Text = "Ajout d\'une transaction";
            this.tpNewTransaction.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // grpRecettePercu
            // 
            this.grpRecettePercu.Controls.Add(this.btnPercu);
            this.grpRecettePercu.Controls.Add(this.radioButton1);
            this.grpRecettePercu.Location = new System.Drawing.Point(36, 127);
            this.grpRecettePercu.Margin = new System.Windows.Forms.Padding(2);
            this.grpRecettePercu.Name = "grpRecettePercu";
            this.grpRecettePercu.Padding = new System.Windows.Forms.Padding(2);
            this.grpRecettePercu.Size = new System.Drawing.Size(276, 55);
            this.grpRecettePercu.TabIndex = 12;
            this.grpRecettePercu.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 19);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Recette";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
=======
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
            // btnAjouterPersonneTransa
            // 
            this.btnAjouterPersonneTransa.Location = new System.Drawing.Point(589, 34);
            this.btnAjouterPersonneTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterPersonneTransa.Name = "btnAjouterPersonneTransa";
            this.btnAjouterPersonneTransa.Size = new System.Drawing.Size(75, 62);
            this.btnAjouterPersonneTransa.TabIndex = 0;
            this.btnAjouterPersonneTransa.Text = "Ajouter une personne";
            this.btnAjouterPersonneTransa.UseVisualStyleBackColor = true;
            // 
            // grpParticipantsTransa
            // 
            this.grpParticipantsTransa.Location = new System.Drawing.Point(445, 18);
            this.grpParticipantsTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpParticipantsTransa.Name = "grpParticipantsTransa";
            this.grpParticipantsTransa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpParticipantsTransa.Size = new System.Drawing.Size(131, 362);
            this.grpParticipantsTransa.TabIndex = 11;
            this.grpParticipantsTransa.TabStop = false;
            this.grpParticipantsTransa.Text = "Participants : ";
            this.grpParticipantsTransa.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAjoutTransa
            // 
            this.btnAjoutTransa.Location = new System.Drawing.Point(108, 263);
            this.btnAjoutTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjoutTransa.Name = "btnAjoutTransa";
            this.btnAjoutTransa.Size = new System.Drawing.Size(213, 91);
            this.btnAjoutTransa.TabIndex = 10;
            this.btnAjoutTransa.Text = "Ajouter";
            this.btnAjoutTransa.UseVisualStyleBackColor = true;
            this.btnAjoutTransa.Click += new System.EventHandler(this.btnAjoutTransa_Click);
            // 
            // btnAjoutType
            // 
            this.btnAjoutType.Location = new System.Drawing.Point(325, 230);
            this.btnAjoutType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjoutType.Name = "btnAjoutType";
            this.btnAjoutType.Size = new System.Drawing.Size(32, 23);
            this.btnAjoutType.TabIndex = 9;
            this.btnAjoutType.Text = "...";
            this.btnAjoutType.UseVisualStyleBackColor = true;
            // 
            // cbTypeTransa
            // 
            this.cbTypeTransa.FormattingEnabled = true;
            this.cbTypeTransa.Location = new System.Drawing.Point(195, 230);
            this.cbTypeTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTypeTransa.Name = "cbTypeTransa";
            this.cbTypeTransa.Size = new System.Drawing.Size(121, 24);
            this.cbTypeTransa.TabIndex = 8;
            // 
            // lblTypeTransa
            // 
            this.lblTypeTransa.AutoSize = true;
            this.lblTypeTransa.Location = new System.Drawing.Point(145, 230);
            this.lblTypeTransa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeTransa.Name = "lblTypeTransa";
<<<<<<< HEAD
            this.lblTypeTransa.Size = new System.Drawing.Size(33, 15);
=======
            this.lblTypeTransa.Size = new System.Drawing.Size(40, 17);
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
            this.lblTypeTransa.TabIndex = 7;
            this.lblTypeTransa.Text = "Type";
            // 
            // txtMontantTransa
            // 
            this.txtMontantTransa.Location = new System.Drawing.Point(199, 119);
            this.txtMontantTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontantTransa.Name = "txtMontantTransa";
            this.txtMontantTransa.Size = new System.Drawing.Size(100, 22);
            this.txtMontantTransa.TabIndex = 4;
            // 
            // lblMontantTransa
            // 
            this.lblMontantTransa.AutoSize = true;
            this.lblMontantTransa.Location = new System.Drawing.Point(44, 124);
            this.lblMontantTransa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontantTransa.Name = "lblMontantTransa";
<<<<<<< HEAD
            this.lblMontantTransa.Size = new System.Drawing.Size(52, 15);
=======
            this.lblMontantTransa.Size = new System.Drawing.Size(59, 17);
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
            this.lblMontantTransa.TabIndex = 3;
            this.lblMontantTransa.Text = "Montant";
            // 
            // txtDescriptionTransa
            // 
            this.txtDescriptionTransa.Location = new System.Drawing.Point(199, 78);
            this.txtDescriptionTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescriptionTransa.Name = "txtDescriptionTransa";
            this.txtDescriptionTransa.Size = new System.Drawing.Size(100, 22);
            this.txtDescriptionTransa.TabIndex = 3;
            // 
            // lblDescripionTransa
            // 
            this.lblDescripionTransa.AutoSize = true;
            this.lblDescripionTransa.Location = new System.Drawing.Point(44, 82);
            this.lblDescripionTransa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripionTransa.Name = "lblDescripionTransa";
<<<<<<< HEAD
            this.lblDescripionTransa.Size = new System.Drawing.Size(69, 15);
=======
            this.lblDescripionTransa.Size = new System.Drawing.Size(79, 17);
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
            this.lblDescripionTransa.TabIndex = 2;
            this.lblDescripionTransa.Text = "Description";
            // 
            // dtpTransa
            // 
            this.dtpTransa.Location = new System.Drawing.Point(199, 34);
            this.dtpTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
<<<<<<< HEAD
            this.lblDateTransa.Size = new System.Drawing.Size(126, 15);
=======
            this.lblDateTransa.Size = new System.Drawing.Size(147, 17);
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
            this.lblDateTransa.TabIndex = 0;
            this.lblDateTransa.Text = "Date de la transaction";
            // 
            // tpDeleteTransaction
            // 
            this.tpDeleteTransaction.Location = new System.Drawing.Point(4, 28);
            this.tpDeleteTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDeleteTransaction.Name = "tpDeleteTransaction";
            this.tpDeleteTransaction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDeleteTransaction.Size = new System.Drawing.Size(917, 482);
            this.tpDeleteTransaction.TabIndex = 1;
            this.tpDeleteTransaction.Text = "Suppression d\'une transaction";
            this.tpDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // tpModifTransaction
            // 
<<<<<<< HEAD
            this.tpModifTransaction.Location = new System.Drawing.Point(4, 25);
            this.tpModifTransaction.Margin = new System.Windows.Forms.Padding(2);
=======
            this.tpModifTransaction.Location = new System.Drawing.Point(4, 28);
            this.tpModifTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
            this.tpModifTransaction.Name = "tpModifTransaction";
            this.tpModifTransaction.Size = new System.Drawing.Size(917, 482);
            this.tpModifTransaction.TabIndex = 2;
            this.tpModifTransaction.Text = "Modificationd \'une transaction";
            this.tpModifTransaction.UseVisualStyleBackColor = true;
            // 
            // tpRecap
            // 
<<<<<<< HEAD
            this.tpRecap.Location = new System.Drawing.Point(4, 25);
            this.tpRecap.Margin = new System.Windows.Forms.Padding(2);
=======
            this.tpRecap.Location = new System.Drawing.Point(4, 28);
            this.tpRecap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
            this.tpRecap.Name = "tpRecap";
            this.tpRecap.Size = new System.Drawing.Size(917, 482);
            this.tpRecap.TabIndex = 3;
            this.tpRecap.Text = "Récapitulatif";
            this.tpRecap.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // btnPercu
            // 
            this.btnPercu.AutoSize = true;
            this.btnPercu.Location = new System.Drawing.Point(162, 18);
            this.btnPercu.Name = "btnPercu";
            this.btnPercu.Size = new System.Drawing.Size(60, 19);
            this.btnPercu.TabIndex = 8;
            this.btnPercu.TabStop = true;
            this.btnPercu.Text = "Perçu";
            this.btnPercu.UseVisualStyleBackColor = true;
=======
            // cbRecette
            // 
            this.cbRecette.AutoSize = true;
            this.cbRecette.Location = new System.Drawing.Point(60, 172);
            this.cbRecette.Name = "cbRecette";
            this.cbRecette.Size = new System.Drawing.Size(79, 21);
            this.cbRecette.TabIndex = 12;
            this.cbRecette.Text = "Recette";
            this.cbRecette.UseVisualStyleBackColor = true;
            // 
            // cbPercu
            // 
            this.cbPercu.AutoSize = true;
            this.cbPercu.Location = new System.Drawing.Point(238, 172);
            this.cbPercu.Name = "cbPercu";
            this.cbPercu.Size = new System.Drawing.Size(67, 21);
            this.cbPercu.TabIndex = 13;
            this.cbPercu.Text = "Perçu";
            this.cbPercu.UseVisualStyleBackColor = true;
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
            // 
            // frmBudgetMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 514);
            this.Controls.Add(this.tcBudgetMois);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBudgetMois";
            this.Text = "Budget du mois";
            this.Load += new System.EventHandler(this.frmBudgetMois_Load);
            this.tcBudgetMois.ResumeLayout(false);
            this.tpAffichage1a1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbTypeTransa;
        private System.Windows.Forms.Label lblTypeTransa;
        private System.Windows.Forms.TextBox txtMontantTransa;
        private System.Windows.Forms.Label lblMontantTransa;
        private System.Windows.Forms.TextBox txtDescriptionTransa;
        private System.Windows.Forms.Label lblDescripionTransa;
        private System.Windows.Forms.DateTimePicker dtpTransa;
        private System.Windows.Forms.Button btnAjouterPersonneTransa;
        private System.Windows.Forms.TabPage tpModifTransaction;
        private System.Windows.Forms.TabPage tpRecap;
<<<<<<< HEAD
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton btnPercu;
=======
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnAvant;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.CheckBox cbPercu;
        private System.Windows.Forms.CheckBox cbRecette;
>>>>>>> c2f03505122d76b0449160b6b35436b3ccec955d
    }
}

