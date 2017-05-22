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
            this.tpNewTransaction = new System.Windows.Forms.TabPage();
            this.btnAjouterPersonneTransa = new System.Windows.Forms.Button();
            this.grpParticipantsTransa = new System.Windows.Forms.GroupBox();
            this.btnAjoutTransa = new System.Windows.Forms.Button();
            this.btnAjoutType = new System.Windows.Forms.Button();
            this.cbTypeTransa = new System.Windows.Forms.ComboBox();
            this.lblTypeTransa = new System.Windows.Forms.Label();
            this.rdbPerçu = new System.Windows.Forms.RadioButton();
            this.rdbRecette = new System.Windows.Forms.RadioButton();
            this.txtMontantTransa = new System.Windows.Forms.TextBox();
            this.lblMontantTransa = new System.Windows.Forms.Label();
            this.txtDescriptionTransa = new System.Windows.Forms.TextBox();
            this.lblDescripionTransa = new System.Windows.Forms.Label();
            this.dtpTransa = new System.Windows.Forms.DateTimePicker();
            this.lblDateTransa = new System.Windows.Forms.Label();
            this.tpAffichage1a1 = new System.Windows.Forms.TabPage();
            this.tpSupprTransac = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tpDeleteTransaction = new System.Windows.Forms.TabPage();
            this.grpRecettePercu = new System.Windows.Forms.GroupBox();
            this.tpModifTransaction = new System.Windows.Forms.TabPage();
            this.tpRecap = new System.Windows.Forms.TabPage();
            this.tcBudgetMois.SuspendLayout();
            this.tpNewTransaction.SuspendLayout();
            this.grpRecettePercu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBudgetMois
            // 
            this.tcBudgetMois.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcBudgetMois.Controls.Add(this.tpAffichage1a1);
            this.tcBudgetMois.Controls.Add(this.tpNewTransaction);
            this.tcBudgetMois.Controls.Add(this.tpSupprTransac);
            this.tcBudgetMois.Controls.Add(this.tabPage2);
            this.tcBudgetMois.Controls.Add(this.tabPage3);
            this.tcBudgetMois.Cursor = System.Windows.Forms.Cursors.Default;
            this.tcBudgetMois.Location = new System.Drawing.Point(0, 0);
            this.tcBudgetMois.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcBudgetMois.Controls.Add(this.tpDeleteTransaction);
            this.tcBudgetMois.Controls.Add(this.tpModifTransaction);
            this.tcBudgetMois.Controls.Add(this.tpRecap);
            this.tcBudgetMois.Cursor = System.Windows.Forms.Cursors.Default;
            this.tcBudgetMois.Location = new System.Drawing.Point(0, 0);
            this.tcBudgetMois.Margin = new System.Windows.Forms.Padding(2);
            this.tcBudgetMois.Name = "tcBudgetMois";
            this.tcBudgetMois.SelectedIndex = 0;
            this.tcBudgetMois.Size = new System.Drawing.Size(925, 514);
            this.tcBudgetMois.TabIndex = 0;
            // 
            // tpNewTransaction
            // 
            this.tpNewTransaction.Controls.Add(this.grpRecettePercu);
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
            this.tpNewTransaction.Location = new System.Drawing.Point(4, 25);
            this.tpNewTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.tpNewTransaction.Name = "tpNewTransaction";
            this.tpNewTransaction.Padding = new System.Windows.Forms.Padding(2);
            this.tpNewTransaction.Size = new System.Drawing.Size(686, 389);
            this.tpNewTransaction.TabIndex = 0;
            this.tpNewTransaction.Text = "Ajout d\'une transaction";
            this.tpNewTransaction.UseVisualStyleBackColor = true;
            // 
            // btnAjouterPersonneTransa
            // 
            this.btnAjouterPersonneTransa.Location = new System.Drawing.Point(787, 43);
            this.btnAjouterPersonneTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterPersonneTransa.Name = "btnAjouterPersonneTransa";
            this.btnAjouterPersonneTransa.Size = new System.Drawing.Size(100, 76);
            this.btnAjouterPersonneTransa.Location = new System.Drawing.Point(590, 35);
            this.btnAjouterPersonneTransa.Name = "btnAjouterPersonneTransa";
            this.btnAjouterPersonneTransa.Size = new System.Drawing.Size(75, 62);
            this.btnAjouterPersonneTransa.TabIndex = 0;
            this.btnAjouterPersonneTransa.Text = "Ajouter une personne";
            this.btnAjouterPersonneTransa.UseVisualStyleBackColor = true;
            // 
            // grpParticipantsTransa
            // 
            this.grpParticipantsTransa.Location = new System.Drawing.Point(593, 23);
            this.grpParticipantsTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpParticipantsTransa.Name = "grpParticipantsTransa";
            this.grpParticipantsTransa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpParticipantsTransa.Size = new System.Drawing.Size(173, 446);
            this.grpParticipantsTransa.Location = new System.Drawing.Point(445, 19);
            this.grpParticipantsTransa.Name = "grpParticipantsTransa";
            this.grpParticipantsTransa.Size = new System.Drawing.Size(130, 362);
            this.grpParticipantsTransa.TabIndex = 11;
            this.grpParticipantsTransa.TabStop = false;
            this.grpParticipantsTransa.Text = "Participants : ";
            this.grpParticipantsTransa.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAjoutTransa
            // 

            this.btnAjoutTransa.Location = new System.Drawing.Point(112, 324);
            this.btnAjoutTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjoutTransa.Name = "btnAjoutTransa";
            this.btnAjoutTransa.Size = new System.Drawing.Size(285, 112);
            this.btnAjoutTransa.TabIndex = 10;
            this.btnAjoutTransa.Text = "Ajouter";
            this.btnAjoutTransa.UseVisualStyleBackColor = true;
            // 
            // btnAjoutType
            // 
            this.btnAjoutType.Location = new System.Drawing.Point(435, 250);
            this.btnAjoutType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjoutType.Name = "btnAjoutType";
            this.btnAjoutType.Size = new System.Drawing.Size(43, 28);

            this.btnAjoutTransa.Location = new System.Drawing.Point(84, 263);
            this.btnAjoutTransa.Name = "btnAjoutTransa";
            this.btnAjoutTransa.Size = new System.Drawing.Size(214, 91);
            this.btnAjoutTransa.TabIndex = 10;
            this.btnAjoutTransa.Text = "Ajouter";
            this.btnAjoutTransa.UseVisualStyleBackColor = true;


            this.btnAjoutTransa.Click += new System.EventHandler(this.btnAjoutTransa_Click);

            // 
            // btnAjoutType
            // 
            this.btnAjoutType.Location = new System.Drawing.Point(326, 203);
            this.btnAjoutType.Name = "btnAjoutType";
            this.btnAjoutType.Size = new System.Drawing.Size(32, 23);

            this.btnAjoutType.TabIndex = 9;
            this.btnAjoutType.Text = "...";
            this.btnAjoutType.UseVisualStyleBackColor = true;
            // 
            // cbTypeTransa
            // 
            this.cbTypeTransa.FormattingEnabled = true;

            this.cbTypeTransa.Location = new System.Drawing.Point(265, 250);
            this.cbTypeTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTypeTransa.Name = "cbTypeTransa";
            this.cbTypeTransa.Size = new System.Drawing.Size(160, 24);
            this.cbTypeTransa.TabIndex = 8;

            this.cbTypeTransa.Location = new System.Drawing.Point(199, 203);
            this.cbTypeTransa.Name = "cbTypeTransa";
            this.cbTypeTransa.Size = new System.Drawing.Size(121, 21);
            this.cbTypeTransa.TabIndex = 8;
            // 
            // lblTypeTransa
            // 
            this.lblTypeTransa.AutoSize = true;
            this.lblTypeTransa.Location = new System.Drawing.Point(44, 209);
            this.lblTypeTransa.Name = "lblTypeTransa";

            this.lblTypeTransa.Size = new System.Drawing.Size(33, 15);

            this.lblTypeTransa.Size = new System.Drawing.Size(31, 13);

            this.lblTypeTransa.TabIndex = 7;
            this.lblTypeTransa.Text = "Type";
            // 
            // rdbPerçu
            // 
            this.rdbPerçu.AutoSize = true;

            this.rdbPerçu.Location = new System.Drawing.Point(179, 11);
            this.rdbPerçu.Name = "rdbPerçu";
            this.rdbPerçu.Size = new System.Drawing.Size(60, 19);
            this.rdbPerçu.TabIndex = 6;
            this.rdbPerçu.TabStop = true;
            this.rdbPerçu.Text = "Perçu";

            this.rdbPerçu.Location = new System.Drawing.Point(199, 167);
            this.rdbPerçu.Name = "rdbPerçu";
            this.rdbPerçu.Size = new System.Drawing.Size(85, 17);
            this.rdbPerçu.TabIndex = 6;
            this.rdbPerçu.TabStop = true;
            this.rdbPerçu.Text = "radioButton2";

            this.rdbPerçu.UseVisualStyleBackColor = true;
            // 
            // rdbRecette
            // 
            this.rdbRecette.AutoSize = true;
            this.rdbRecette.Location = new System.Drawing.Point(27, 11);
            this.rdbRecette.Name = "rdbRecette";

            this.rdbRecette.Size = new System.Drawing.Size(70, 19);

            this.rdbRecette.Size = new System.Drawing.Size(85, 17);

            this.rdbRecette.TabIndex = 5;
            this.rdbRecette.TabStop = true;
            this.rdbRecette.Text = "Recette";
            this.rdbRecette.UseVisualStyleBackColor = true;
            // 
            // txtMontantTransa

            // 
            this.txtMontantTransa.Location = new System.Drawing.Point(199, 119);
            this.txtMontantTransa.Name = "txtMontantTransa";
            this.txtMontantTransa.Size = new System.Drawing.Size(100, 20);
            this.txtMontantTransa.TabIndex = 4;

            // 
            // lblTypeTransa
            // 
            this.lblTypeTransa.AutoSize = true;
            this.lblTypeTransa.Location = new System.Drawing.Point(59, 257);
            this.lblTypeTransa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeTransa.Name = "lblTypeTransa";
            this.lblTypeTransa.Size = new System.Drawing.Size(40, 17);
            this.lblTypeTransa.TabIndex = 7;
            this.lblTypeTransa.Text = "Type";
            // 

            // rdbPerçu
            // 
            this.rdbPerçu.AutoSize = true;
            this.rdbPerçu.Location = new System.Drawing.Point(265, 206);
            this.rdbPerçu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbPerçu.Name = "rdbPerçu";
            this.rdbPerçu.Size = new System.Drawing.Size(110, 21);
            this.rdbPerçu.TabIndex = 6;
            this.rdbPerçu.TabStop = true;
            this.rdbPerçu.Text = "radioButton2";
            this.rdbPerçu.UseVisualStyleBackColor = true;

            // txtDescriptionTransa
            // 
            this.txtDescriptionTransa.Location = new System.Drawing.Point(199, 78);
            this.txtDescriptionTransa.Name = "txtDescriptionTransa";
            this.txtDescriptionTransa.Size = new System.Drawing.Size(100, 20);
            this.txtDescriptionTransa.TabIndex = 3;

            // 
            // lblDescripionTransa
            // 

            this.rdbRecette.AutoSize = true;
            this.rdbRecette.Location = new System.Drawing.Point(63, 206);
            this.rdbRecette.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbRecette.Name = "rdbRecette";
            this.rdbRecette.Size = new System.Drawing.Size(110, 21);
            this.rdbRecette.TabIndex = 5;
            this.rdbRecette.TabStop = true;
            this.rdbRecette.Text = "radioButton1";
            this.rdbRecette.UseVisualStyleBackColor = true;
            // 
            // txtMontantTransa
            // 
            this.txtMontantTransa.Location = new System.Drawing.Point(265, 146);
            this.txtMontantTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontantTransa.Name = "txtMontantTransa";
            this.txtMontantTransa.Size = new System.Drawing.Size(132, 22);
            this.txtMontantTransa.TabIndex = 4;
            // 
            // lblMontantTransa
            // 
            this.lblMontantTransa.AutoSize = true;
            this.lblMontantTransa.Location = new System.Drawing.Point(59, 153);
            this.lblMontantTransa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontantTransa.Name = "lblMontantTransa";
            this.lblMontantTransa.Size = new System.Drawing.Size(59, 17);
            this.lblMontantTransa.TabIndex = 3;
            this.lblMontantTransa.Text = "Montant";
            // 
            // txtDescriptionTransa
            // 
            this.txtDescriptionTransa.Location = new System.Drawing.Point(265, 96);
            this.txtDescriptionTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescriptionTransa.Name = "txtDescriptionTransa";
            this.txtDescriptionTransa.Size = new System.Drawing.Size(132, 22);
            this.txtDescriptionTransa.TabIndex = 3;
            // 
            // lblDescripionTransa
            // 
            this.lblDescripionTransa.AutoSize = true;
            this.lblDescripionTransa.Location = new System.Drawing.Point(59, 102);
            this.lblDescripionTransa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripionTransa.Name = "lblDescripionTransa";
            this.lblDescripionTransa.Size = new System.Drawing.Size(79, 17);
            this.lblDescripionTransa.TabIndex = 2;
            this.lblDescripionTransa.Text = "Description";
            // 
            // dtpTransa
            // 
            this.dtpTransa.Location = new System.Drawing.Point(265, 43);
            this.dtpTransa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTransa.Name = "dtpTransa";
            this.dtpTransa.Size = new System.Drawing.Size(293, 22);
            this.dtpTransa.TabIndex = 1;
            // 
            // lblDateTransa
            // 
            this.lblDateTransa.AutoSize = true;
            this.lblDateTransa.Location = new System.Drawing.Point(59, 43);
            this.lblDateTransa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTransa.Name = "lblDateTransa";
            this.lblDateTransa.Size = new System.Drawing.Size(147, 17);
            this.lblDateTransa.TabIndex = 0;
            this.lblDateTransa.Text = "Date de la transaction";
            // 
            // tpAffichage1a1
            // 
            this.tpAffichage1a1.Location = new System.Drawing.Point(4, 28);
            this.tpAffichage1a1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAffichage1a1.Name = "tpAffichage1a1";
            this.tpAffichage1a1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAffichage1a1.Size = new System.Drawing.Size(917, 482);
            this.tpAffichage1a1.TabIndex = 1;
            this.tpAffichage1a1.Text = "Affichage 1 à 1";
            this.tpAffichage1a1.UseVisualStyleBackColor = true;
            // 
            // tpSupprTransac
            // 
            this.tpSupprTransac.Location = new System.Drawing.Point(4, 28);
            this.tpSupprTransac.Name = "tpSupprTransac";
            this.tpSupprTransac.Size = new System.Drawing.Size(917, 482);
            this.tpSupprTransac.TabIndex = 2;
            this.tpSupprTransac.Text = "Suppression d\'une transaction";
            this.tpSupprTransac.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(917, 482);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(917, 482);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;

            this.lblDescripionTransa.AutoSize = true;
            this.lblDescripionTransa.Location = new System.Drawing.Point(44, 83);
            this.lblDescripionTransa.Name = "lblDescripionTransa";
            this.lblDescripionTransa.Size = new System.Drawing.Size(69, 15);
            this.lblDescripionTransa.TabIndex = 2;
            this.lblDescripionTransa.Text = "Description";
            // 
            // dtpTransa
            // 
            this.dtpTransa.Location = new System.Drawing.Point(199, 35);
            this.dtpTransa.Name = "dtpTransa";
            this.dtpTransa.Size = new System.Drawing.Size(221, 20);
            this.dtpTransa.TabIndex = 1;
            // 
            // lblDateTransa
            // 
            this.lblDateTransa.AutoSize = true;
            this.lblDateTransa.Location = new System.Drawing.Point(44, 35);
            this.lblDateTransa.Name = "lblDateTransa";
            this.lblDateTransa.Size = new System.Drawing.Size(126, 15);
            this.lblDateTransa.TabIndex = 0;
            this.lblDateTransa.Text = "Date de la transaction";
            // 
            // tpDeleteTransaction
            // 
            this.tpDeleteTransaction.Location = new System.Drawing.Point(4, 25);
            this.tpDeleteTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.tpDeleteTransaction.Name = "tpDeleteTransaction";
            this.tpDeleteTransaction.Padding = new System.Windows.Forms.Padding(2);
            this.tpDeleteTransaction.Size = new System.Drawing.Size(686, 389);
            this.tpDeleteTransaction.TabIndex = 1;
            this.tpDeleteTransaction.Text = "Suppression d\'une transaction";
            this.tpDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // grpRecettePercu
            // 
            this.grpRecettePercu.Controls.Add(this.rdbPerçu);
            this.grpRecettePercu.Controls.Add(this.rdbRecette);
            this.grpRecettePercu.Location = new System.Drawing.Point(20, 156);
            this.grpRecettePercu.Name = "grpRecettePercu";
            this.grpRecettePercu.Size = new System.Drawing.Size(368, 47);
            this.grpRecettePercu.TabIndex = 12;
            this.grpRecettePercu.TabStop = false;
            // 
            // tpModifTransaction
            // 
            this.tpModifTransaction.Location = new System.Drawing.Point(4, 25);
            this.tpModifTransaction.Name = "tpModifTransaction";
            this.tpModifTransaction.Size = new System.Drawing.Size(686, 389);
            this.tpModifTransaction.TabIndex = 2;
            this.tpModifTransaction.Text = "Modificationd \'une transaction";
            this.tpModifTransaction.UseVisualStyleBackColor = true;
            // 
            // tpRecap
            // 
            this.tpRecap.Location = new System.Drawing.Point(4, 25);
            this.tpRecap.Name = "tpRecap";
            this.tpRecap.Size = new System.Drawing.Size(686, 389);
            this.tpRecap.TabIndex = 3;
            this.tpRecap.Text = "Récapitulatif";
            this.tpRecap.UseVisualStyleBackColor = true;

            // 
            this.txtMontantTransa.Location = new System.Drawing.Point(199, 119);
            this.txtMontantTransa.Name = "txtMontantTransa";
            this.txtMontantTransa.Size = new System.Drawing.Size(100, 20);
            this.txtMontantTransa.TabIndex = 4;
            // 
            // lblMontantTransa
            // 
            this.lblMontantTransa.AutoSize = true;
            this.lblMontantTransa.Location = new System.Drawing.Point(44, 124);
            this.lblMontantTransa.Name = "lblMontantTransa";
            this.lblMontantTransa.Size = new System.Drawing.Size(46, 13);
            this.lblMontantTransa.TabIndex = 3;
            this.lblMontantTransa.Text = "Montant";
            // 
            // txtDescriptionTransa
            // 
            this.txtDescriptionTransa.Location = new System.Drawing.Point(199, 78);
            this.txtDescriptionTransa.Name = "txtDescriptionTransa";
            this.txtDescriptionTransa.Size = new System.Drawing.Size(100, 20);
            this.txtDescriptionTransa.TabIndex = 3;
            // 
            // lblDescripionTransa
            // 
            this.lblDescripionTransa.AutoSize = true;
            this.lblDescripionTransa.Location = new System.Drawing.Point(44, 83);
            this.lblDescripionTransa.Name = "lblDescripionTransa";
            this.lblDescripionTransa.Size = new System.Drawing.Size(60, 13);
            this.lblDescripionTransa.TabIndex = 2;
            this.lblDescripionTransa.Text = "Description";
            // 
            // dtpTransa
            // 
            this.dtpTransa.Location = new System.Drawing.Point(199, 35);
            this.dtpTransa.Name = "dtpTransa";
            this.dtpTransa.Size = new System.Drawing.Size(221, 20);
            this.dtpTransa.TabIndex = 1;
            // 
            // lblDateTransa
            // 
            this.lblDateTransa.AutoSize = true;
            this.lblDateTransa.Location = new System.Drawing.Point(44, 35);
            this.lblDateTransa.Name = "lblDateTransa";
            this.lblDateTransa.Size = new System.Drawing.Size(111, 13);
            this.lblDateTransa.TabIndex = 0;
            this.lblDateTransa.Text = "Date de la transaction";

            // 
            // frmBudgetMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 514);
            this.Controls.Add(this.tcBudgetMois);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);

            this.Margin = new System.Windows.Forms.Padding(2);

            this.Name = "frmBudgetMois";
            this.Text = "Budget du mois";
            this.Load += new System.EventHandler(this.frmBudgetMois_Load);
            this.tcBudgetMois.ResumeLayout(false);
            this.tpNewTransaction.ResumeLayout(false);
            this.tpNewTransaction.PerformLayout();
            this.grpRecettePercu.ResumeLayout(false);
            this.grpRecettePercu.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdbPerçu;
        private System.Windows.Forms.RadioButton rdbRecette;
        private System.Windows.Forms.TextBox txtMontantTransa;
        private System.Windows.Forms.Label lblMontantTransa;
        private System.Windows.Forms.TextBox txtDescriptionTransa;
        private System.Windows.Forms.Label lblDescripionTransa;
        private System.Windows.Forms.DateTimePicker dtpTransa;
        private System.Windows.Forms.Button btnAjouterPersonneTransa;

        private System.Windows.Forms.TabPage tpSupprTransac;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;

        private System.Windows.Forms.GroupBox grpRecettePercu;
        private System.Windows.Forms.TabPage tpModifTransaction;
        private System.Windows.Forms.TabPage tpRecap;

    }
}

