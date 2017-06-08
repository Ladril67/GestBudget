namespace Pique_Sous
{
    partial class frmPrevisionnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

            #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrevisionnel));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPosteFixe = new System.Windows.Forms.TabPage();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.tboJour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPeriodicite = new System.Windows.Forms.ComboBox();
            this.btnAutre = new System.Windows.Forms.Button();
            this.cboPoste = new System.Windows.Forms.ComboBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblJour = new System.Windows.Forms.Label();
            this.lblPeriodicite = new System.Windows.Forms.Label();
            this.lblPoste = new System.Windows.Forms.Label();
            this.tpPostePonctuel = new System.Windows.Forms.TabPage();
            this.btnValidePonctuel = new System.Windows.Forms.Button();
            this.lblEcheance = new System.Windows.Forms.Label();
            this.flpEcheance = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPrelevement = new System.Windows.Forms.TextBox();
            this.lblPrelevements = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.lblIntitule = new System.Windows.Forms.Label();
            this.tpRevenu = new System.Windows.Forms.TabPage();
            this.Valider = new System.Windows.Forms.Button();
            this.txtPosteRevenu = new System.Windows.Forms.TextBox();
            this.cboBeneficiaire = new System.Windows.Forms.ComboBox();
            this.txtMontantRevenu = new System.Windows.Forms.TextBox();
            this.txtJourDuMois = new System.Windows.Forms.TextBox();
            this.lblJourDuMois = new System.Windows.Forms.Label();
            this.lblJourMois = new System.Windows.Forms.Label();
            this.lblMontantRevenu = new System.Windows.Forms.Label();
            this.lblBenef = new System.Windows.Forms.Label();
            this.lblQuelPoste = new System.Windows.Forms.Label();
            this.tpModificationPoste = new System.Windows.Forms.TabPage();
            this.btnModPoste = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpPosteFixe.SuspendLayout();
            this.tpPostePonctuel.SuspendLayout();
            this.tpRevenu.SuspendLayout();
            this.tpModificationPoste.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPosteFixe);
            this.tabControl1.Controls.Add(this.tpPostePonctuel);
            this.tabControl1.Controls.Add(this.tpRevenu);
            this.tabControl1.Controls.Add(this.tpModificationPoste);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // tpPosteFixe
            // 
            this.tpPosteFixe.Controls.Add(this.btnValider);
            this.tpPosteFixe.Controls.Add(this.txtMontant);
            this.tpPosteFixe.Controls.Add(this.tboJour);
            this.tpPosteFixe.Controls.Add(this.label1);
            this.tpPosteFixe.Controls.Add(this.cboPeriodicite);
            this.tpPosteFixe.Controls.Add(this.btnAutre);
            this.tpPosteFixe.Controls.Add(this.cboPoste);
            this.tpPosteFixe.Controls.Add(this.lblMontant);
            this.tpPosteFixe.Controls.Add(this.lblJour);
            this.tpPosteFixe.Controls.Add(this.lblPeriodicite);
            this.tpPosteFixe.Controls.Add(this.lblPoste);
            this.tpPosteFixe.Location = new System.Drawing.Point(4, 25);
            this.tpPosteFixe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPosteFixe.Name = "tpPosteFixe";
            this.tpPosteFixe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPosteFixe.Size = new System.Drawing.Size(691, 517);
            this.tpPosteFixe.TabIndex = 0;
            this.tpPosteFixe.Text = "Poste Fixe";
            this.tpPosteFixe.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(479, 309);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(113, 30);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(175, 249);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(97, 22);
            this.txtMontant.TabIndex = 9;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboMontant_KeyPress);
            // 
            // tboJour
            // 
            this.tboJour.Location = new System.Drawing.Point(203, 181);
            this.tboJour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboJour.Name = "tboJour";
            this.tboJour.Size = new System.Drawing.Size(33, 22);
            this.tboJour.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Le              du mois";
            // 
            // cboPeriodicite
            // 
            this.cboPeriodicite.FormattingEnabled = true;
            this.cboPeriodicite.Location = new System.Drawing.Point(175, 117);
            this.cboPeriodicite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPeriodicite.Name = "cboPeriodicite";
            this.cboPeriodicite.Size = new System.Drawing.Size(235, 24);
            this.cboPeriodicite.TabIndex = 6;
            // 
            // btnAutre
            // 
            this.btnAutre.Location = new System.Drawing.Point(439, 39);
            this.btnAutre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutre.Name = "btnAutre";
            this.btnAutre.Size = new System.Drawing.Size(75, 23);
            this.btnAutre.TabIndex = 5;
            this.btnAutre.Text = "Autre";
            this.btnAutre.UseVisualStyleBackColor = true;
            this.btnAutre.Click += new System.EventHandler(this.btnAutre_Click);
            // 
            // cboPoste
            // 
            this.cboPoste.FormattingEnabled = true;
            this.cboPoste.Location = new System.Drawing.Point(175, 39);
            this.cboPoste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPoste.Name = "cboPoste";
            this.cboPoste.Size = new System.Drawing.Size(235, 24);
            this.cboPoste.TabIndex = 4;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(37, 251);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(67, 17);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "Montant :";
            // 
            // lblJour
            // 
            this.lblJour.AutoSize = true;
            this.lblJour.Location = new System.Drawing.Point(37, 185);
            this.lblJour.Name = "lblJour";
            this.lblJour.Size = new System.Drawing.Size(101, 17);
            this.lblJour.TabIndex = 2;
            this.lblJour.Text = "Jour du mois : ";
            // 
            // lblPeriodicite
            // 
            this.lblPeriodicite.AutoSize = true;
            this.lblPeriodicite.Location = new System.Drawing.Point(37, 124);
            this.lblPeriodicite.Name = "lblPeriodicite";
            this.lblPeriodicite.Size = new System.Drawing.Size(82, 17);
            this.lblPeriodicite.TabIndex = 1;
            this.lblPeriodicite.Text = "Périodicité :";
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.Location = new System.Drawing.Point(37, 43);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(93, 17);
            this.lblPoste.TabIndex = 0;
            this.lblPoste.Text = "Quel poste ? ";
            // 
            // tpPostePonctuel
            // 
            this.tpPostePonctuel.Controls.Add(this.btnValidePonctuel);
            this.tpPostePonctuel.Controls.Add(this.lblEcheance);
            this.tpPostePonctuel.Controls.Add(this.flpEcheance);
            this.tpPostePonctuel.Controls.Add(this.txtPrelevement);
            this.tpPostePonctuel.Controls.Add(this.lblPrelevements);
            this.tpPostePonctuel.Controls.Add(this.txtCommentaire);
            this.tpPostePonctuel.Controls.Add(this.txtIntitule);
            this.tpPostePonctuel.Controls.Add(this.lblCommentaire);
            this.tpPostePonctuel.Controls.Add(this.lblIntitule);
            this.tpPostePonctuel.Location = new System.Drawing.Point(4, 25);
            this.tpPostePonctuel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPostePonctuel.Name = "tpPostePonctuel";
            this.tpPostePonctuel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPostePonctuel.Size = new System.Drawing.Size(691, 517);
            this.tpPostePonctuel.TabIndex = 1;
            this.tpPostePonctuel.Text = "Poste Ponctuel ";
            this.tpPostePonctuel.UseVisualStyleBackColor = true;
            // 
            // btnValidePonctuel
            // 
            this.btnValidePonctuel.Location = new System.Drawing.Point(596, 486);
            this.btnValidePonctuel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidePonctuel.Name = "btnValidePonctuel";
            this.btnValidePonctuel.Size = new System.Drawing.Size(75, 23);
            this.btnValidePonctuel.TabIndex = 0;
            this.btnValidePonctuel.Text = "Valider";
            this.btnValidePonctuel.UseVisualStyleBackColor = true;
            this.btnValidePonctuel.Click += new System.EventHandler(this.btnValiderPonctuel_Click);
            // 
            // lblEcheance
            // 
            this.lblEcheance.AutoSize = true;
            this.lblEcheance.Location = new System.Drawing.Point(34, 177);
            this.lblEcheance.Name = "lblEcheance";
            this.lblEcheance.Size = new System.Drawing.Size(141, 17);
            this.lblEcheance.TabIndex = 0;
            this.lblEcheance.Text = "Echéances prévues :";
            // 
            // flpEcheance
            // 
            this.flpEcheance.Location = new System.Drawing.Point(18, 201);
            this.flpEcheance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpEcheance.Name = "flpEcheance";
            this.flpEcheance.Size = new System.Drawing.Size(653, 280);
            this.flpEcheance.TabIndex = 6;
            // 
            // txtPrelevement
            // 
            this.txtPrelevement.Location = new System.Drawing.Point(211, 139);
            this.txtPrelevement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrelevement.Name = "txtPrelevement";
            this.txtPrelevement.Size = new System.Drawing.Size(43, 22);
            this.txtPrelevement.TabIndex = 5;
            this.txtPrelevement.TextChanged += new System.EventHandler(this.txtPrelevement_TextChanged);
            this.txtPrelevement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrelevement_KeyPress);
            // 
            // lblPrelevements
            // 
            this.lblPrelevements.AutoSize = true;
            this.lblPrelevements.Location = new System.Drawing.Point(29, 142);
            this.lblPrelevements.Name = "lblPrelevements";
            this.lblPrelevements.Size = new System.Drawing.Size(175, 17);
            this.lblPrelevements.TabIndex = 4;
            this.lblPrelevements.Text = "Nombre de prélèvements :";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(153, 79);
            this.txtCommentaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(100, 22);
            this.txtCommentaire.TabIndex = 3;
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(153, 33);
            this.txtIntitule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(100, 22);
            this.txtIntitule.TabIndex = 2;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(29, 82);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(103, 17);
            this.lblCommentaire.TabIndex = 1;
            this.lblCommentaire.Text = "Commentaire : ";
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.Location = new System.Drawing.Point(29, 36);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(61, 17);
            this.lblIntitule.TabIndex = 0;
            this.lblIntitule.Text = "Intitulé : ";
            // 
            // tpRevenu
            // 
            this.tpRevenu.Controls.Add(this.Valider);
            this.tpRevenu.Controls.Add(this.txtPosteRevenu);
            this.tpRevenu.Controls.Add(this.cboBeneficiaire);
            this.tpRevenu.Controls.Add(this.txtMontantRevenu);
            this.tpRevenu.Controls.Add(this.txtJourDuMois);
            this.tpRevenu.Controls.Add(this.lblJourDuMois);
            this.tpRevenu.Controls.Add(this.lblJourMois);
            this.tpRevenu.Controls.Add(this.lblMontantRevenu);
            this.tpRevenu.Controls.Add(this.lblBenef);
            this.tpRevenu.Controls.Add(this.lblQuelPoste);
            this.tpRevenu.Location = new System.Drawing.Point(4, 25);
            this.tpRevenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRevenu.Name = "tpRevenu";
            this.tpRevenu.Size = new System.Drawing.Size(691, 517);
            this.tpRevenu.TabIndex = 2;
            this.tpRevenu.Text = "Revenu";
            this.tpRevenu.UseVisualStyleBackColor = true;
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(417, 369);
            this.Valider.Margin = new System.Windows.Forms.Padding(4);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(100, 28);
            this.Valider.TabIndex = 9;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // txtPosteRevenu
            // 
            this.txtPosteRevenu.Location = new System.Drawing.Point(185, 33);
            this.txtPosteRevenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosteRevenu.Name = "txtPosteRevenu";
            this.txtPosteRevenu.Size = new System.Drawing.Size(115, 22);
            this.txtPosteRevenu.TabIndex = 8;
            // 
            // cboBeneficiaire
            // 
            this.cboBeneficiaire.FormattingEnabled = true;
            this.cboBeneficiaire.Location = new System.Drawing.Point(140, 97);
            this.cboBeneficiaire.Margin = new System.Windows.Forms.Padding(4);
            this.cboBeneficiaire.Name = "cboBeneficiaire";
            this.cboBeneficiaire.Size = new System.Drawing.Size(160, 24);
            this.cboBeneficiaire.TabIndex = 7;
            // 
            // txtMontantRevenu
            // 
            this.txtMontantRevenu.Location = new System.Drawing.Point(185, 181);
            this.txtMontantRevenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontantRevenu.Name = "txtMontantRevenu";
            this.txtMontantRevenu.Size = new System.Drawing.Size(115, 22);
            this.txtMontantRevenu.TabIndex = 6;
            this.txtMontantRevenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantRevenu_KeyPress);
            // 
            // txtJourDuMois
            // 
            this.txtJourDuMois.Location = new System.Drawing.Point(207, 244);
            this.txtJourDuMois.Margin = new System.Windows.Forms.Padding(4);
            this.txtJourDuMois.Name = "txtJourDuMois";
            this.txtJourDuMois.Size = new System.Drawing.Size(40, 22);
            this.txtJourDuMois.TabIndex = 5;
            // 
            // lblJourDuMois
            // 
            this.lblJourDuMois.AutoSize = true;
            this.lblJourDuMois.Location = new System.Drawing.Point(181, 247);
            this.lblJourDuMois.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJourDuMois.Name = "lblJourDuMois";
            this.lblJourDuMois.Size = new System.Drawing.Size(128, 17);
            this.lblJourDuMois.TabIndex = 4;
            this.lblJourDuMois.Text = "le               du mois";
            // 
            // lblJourMois
            // 
            this.lblJourMois.AutoSize = true;
            this.lblJourMois.Location = new System.Drawing.Point(37, 247);
            this.lblJourMois.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJourMois.Name = "lblJourMois";
            this.lblJourMois.Size = new System.Drawing.Size(97, 17);
            this.lblJourMois.TabIndex = 3;
            this.lblJourMois.Text = "Jour du mois :";
            // 
            // lblMontantRevenu
            // 
            this.lblMontantRevenu.AutoSize = true;
            this.lblMontantRevenu.Location = new System.Drawing.Point(37, 185);
            this.lblMontantRevenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontantRevenu.Name = "lblMontantRevenu";
            this.lblMontantRevenu.Size = new System.Drawing.Size(67, 17);
            this.lblMontantRevenu.TabIndex = 2;
            this.lblMontantRevenu.Text = "Montant :";
            // 
            // lblBenef
            // 
            this.lblBenef.AutoSize = true;
            this.lblBenef.Location = new System.Drawing.Point(37, 101);
            this.lblBenef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBenef.Name = "lblBenef";
            this.lblBenef.Size = new System.Drawing.Size(90, 17);
            this.lblBenef.TabIndex = 1;
            this.lblBenef.Text = "Bénéficiaire :";
            // 
            // lblQuelPoste
            // 
            this.lblQuelPoste.AutoSize = true;
            this.lblQuelPoste.Location = new System.Drawing.Point(37, 37);
            this.lblQuelPoste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuelPoste.Name = "lblQuelPoste";
            this.lblQuelPoste.Size = new System.Drawing.Size(89, 17);
            this.lblQuelPoste.TabIndex = 0;
            this.lblQuelPoste.Text = "Quel poste ?";
            // 
            // tpModificationPoste
            // 
            this.tpModificationPoste.Controls.Add(this.btnModPoste);
            this.tpModificationPoste.Location = new System.Drawing.Point(4, 25);
            this.tpModificationPoste.Name = "tpModificationPoste";
            this.tpModificationPoste.Size = new System.Drawing.Size(691, 517);
            this.tpModificationPoste.TabIndex = 3;
            this.tpModificationPoste.Text = "Modification poste";
            this.tpModificationPoste.UseVisualStyleBackColor = true;
            // 
            // btnModPoste
            // 
            this.btnModPoste.Location = new System.Drawing.Point(137, 123);
            this.btnModPoste.Name = "btnModPoste";
            this.btnModPoste.Size = new System.Drawing.Size(379, 221);
            this.btnModPoste.TabIndex = 0;
            this.btnModPoste.Text = "ACCES A LA MODIFICATION DES POSTES";
            this.btnModPoste.UseVisualStyleBackColor = true;
            this.btnModPoste.Click += new System.EventHandler(this.btnModPoste_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(691, 517);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Budget prévisionnel sur l\'année";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(479, 178);
            this.button1.TabIndex = 0;
            this.button1.Text = "Afficher Le budget Prévisionnel Annuel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrevisionnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 545);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrevisionnel";
            this.Text = "Budget prévisionnel";
            this.Load += new System.EventHandler(this.frmPrevisionnel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPosteFixe.ResumeLayout(false);
            this.tpPosteFixe.PerformLayout();
            this.tpPostePonctuel.ResumeLayout(false);
            this.tpPostePonctuel.PerformLayout();
            this.tpRevenu.ResumeLayout(false);
            this.tpRevenu.PerformLayout();
            this.tpModificationPoste.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPosteFixe;
        private System.Windows.Forms.ComboBox cboPoste;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblJour;
        private System.Windows.Forms.Label lblPeriodicite;
        private System.Windows.Forms.Label lblPoste;
        private System.Windows.Forms.TabPage tpPostePonctuel;
        private System.Windows.Forms.TabPage tpRevenu;
        private System.Windows.Forms.ComboBox cboPeriodicite;
        private System.Windows.Forms.Button btnAutre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox tboJour;
        private System.Windows.Forms.Label lblIntitule;
        private System.Windows.Forms.Label lblPrelevements;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.TextBox txtIntitule;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.TextBox txtPrelevement;
        private System.Windows.Forms.Label lblJourMois;
        private System.Windows.Forms.Label lblMontantRevenu;
        private System.Windows.Forms.Label lblBenef;
        private System.Windows.Forms.Label lblQuelPoste;
        private System.Windows.Forms.TextBox txtPosteRevenu;
        private System.Windows.Forms.ComboBox cboBeneficiaire;
        private System.Windows.Forms.TextBox txtMontantRevenu;
        private System.Windows.Forms.TextBox txtJourDuMois;
        private System.Windows.Forms.Label lblJourDuMois;
        private System.Windows.Forms.FlowLayoutPanel flpEcheance;
        private System.Windows.Forms.Label lblEcheance;
        private System.Windows.Forms.Button btnValidePonctuel;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.TabPage tpModificationPoste;
        private System.Windows.Forms.Button btnModPoste;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
    }
}