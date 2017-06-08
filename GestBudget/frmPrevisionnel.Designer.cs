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
            this.txtPosteRevenu = new System.Windows.Forms.TextBox();
            this.cboBeneficiaire = new System.Windows.Forms.ComboBox();
            this.txtMontantRevenu = new System.Windows.Forms.TextBox();
            this.txtJourDuMois = new System.Windows.Forms.TextBox();
            this.lblJourDuMois = new System.Windows.Forms.Label();
            this.lblJourMois = new System.Windows.Forms.Label();
            this.lblMontantRevenu = new System.Windows.Forms.Label();
            this.lblBenef = new System.Windows.Forms.Label();
            this.lblQuelPoste = new System.Windows.Forms.Label();

            this.Valider = new System.Windows.Forms.Button();


            this.tabControl1.SuspendLayout();
            this.tpPosteFixe.SuspendLayout();
            this.tpPostePonctuel.SuspendLayout();
            this.tpRevenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPosteFixe);
            this.tabControl1.Controls.Add(this.tpPostePonctuel);
            this.tabControl1.Controls.Add(this.tpRevenu);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 444);
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
            this.tpPosteFixe.Location = new System.Drawing.Point(4, 22);
            this.tpPosteFixe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPosteFixe.Name = "tpPosteFixe";
            this.tpPosteFixe.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPosteFixe.Size = new System.Drawing.Size(516, 418);
            this.tpPosteFixe.TabIndex = 0;
            this.tpPosteFixe.Text = "Poste Fixe";
            this.tpPosteFixe.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(359, 251);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(85, 24);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(131, 202);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(74, 20);
            this.txtMontant.TabIndex = 9;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboMontant_KeyPress);
            // 
            // tboJour
            // 
            this.tboJour.Location = new System.Drawing.Point(152, 147);
            this.tboJour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboJour.Name = "tboJour";
            this.tboJour.Size = new System.Drawing.Size(26, 20);
            this.tboJour.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Le              du mois";
            // 
            // cboPeriodicite
            // 
            this.cboPeriodicite.FormattingEnabled = true;
            this.cboPeriodicite.Location = new System.Drawing.Point(131, 95);
            this.cboPeriodicite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPeriodicite.Name = "cboPeriodicite";
            this.cboPeriodicite.Size = new System.Drawing.Size(177, 21);
            this.cboPeriodicite.TabIndex = 6;
            // 
            // btnAutre
            // 
            this.btnAutre.Location = new System.Drawing.Point(329, 32);
            this.btnAutre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAutre.Name = "btnAutre";
            this.btnAutre.Size = new System.Drawing.Size(56, 19);
            this.btnAutre.TabIndex = 5;
            this.btnAutre.Text = "Autre";
            this.btnAutre.UseVisualStyleBackColor = true;
            this.btnAutre.Click += new System.EventHandler(this.btnAutre_Click);
            // 
            // cboPoste
            // 
            this.cboPoste.FormattingEnabled = true;
            this.cboPoste.Location = new System.Drawing.Point(131, 32);
            this.cboPoste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPoste.Name = "cboPoste";
            this.cboPoste.Size = new System.Drawing.Size(177, 21);
            this.cboPoste.TabIndex = 4;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(28, 204);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(52, 13);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "Montant :";
            // 
            // lblJour
            // 
            this.lblJour.AutoSize = true;
            this.lblJour.Location = new System.Drawing.Point(28, 150);
            this.lblJour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJour.Name = "lblJour";
            this.lblJour.Size = new System.Drawing.Size(75, 13);
            this.lblJour.TabIndex = 2;
            this.lblJour.Text = "Jour du mois : ";
            // 
            // lblPeriodicite
            // 
            this.lblPeriodicite.AutoSize = true;
            this.lblPeriodicite.Location = new System.Drawing.Point(28, 101);
            this.lblPeriodicite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodicite.Name = "lblPeriodicite";
            this.lblPeriodicite.Size = new System.Drawing.Size(62, 13);
            this.lblPeriodicite.TabIndex = 1;
            this.lblPeriodicite.Text = "Périodicité :";
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.Location = new System.Drawing.Point(28, 35);
            this.lblPoste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(70, 13);
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
            this.tpPostePonctuel.Location = new System.Drawing.Point(4, 22);
            this.tpPostePonctuel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPostePonctuel.Name = "tpPostePonctuel";
            this.tpPostePonctuel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPostePonctuel.Size = new System.Drawing.Size(516, 418);
            this.tpPostePonctuel.TabIndex = 1;
            this.tpPostePonctuel.Text = "Poste Ponctuel ";
            this.tpPostePonctuel.UseVisualStyleBackColor = true;
            // 

            // btnValidePonctuel
            // 
            this.btnValidePonctuel.Location = new System.Drawing.Point(406, 394);
            this.btnValidePonctuel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValidePonctuel.Name = "btnValidePonctuel";
            this.btnValidePonctuel.Size = new System.Drawing.Size(56, 19);
            this.btnValidePonctuel.TabIndex = 0;
            this.btnValidePonctuel.Text = "Valider";
            this.btnValidePonctuel.UseVisualStyleBackColor = true;
            this.btnValidePonctuel.Click += new System.EventHandler(this.btnValiderPonctuel_Click);
            // 
            // lblEcheance
            // 
            this.lblEcheance.AutoSize = true;
            this.lblEcheance.Location = new System.Drawing.Point(33, 158);
            this.lblEcheance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEcheance.Name = "lblEcheance";
            this.lblEcheance.Size = new System.Drawing.Size(108, 13);

            // lblEcheance
            // 
            this.lblEcheance.AutoSize = true;
            this.lblEcheance.Location = new System.Drawing.Point(44, 194);
            this.lblEcheance.Name = "lblEcheance";
            this.lblEcheance.Size = new System.Drawing.Size(141, 17);

            this.lblEcheance.TabIndex = 0;
            this.lblEcheance.Text = "Echéances prévues :";
            // 
            // flpEcheance
            // 

            this.flpEcheance.Location = new System.Drawing.Point(24, 174);
            this.flpEcheance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpEcheance.Name = "flpEcheance";
            this.flpEcheance.Size = new System.Drawing.Size(460, 208);

            this.flpEcheance.Location = new System.Drawing.Point(32, 214);
            this.flpEcheance.Name = "flpEcheance";
            this.flpEcheance.Size = new System.Drawing.Size(614, 276);

            this.flpEcheance.TabIndex = 6;
            // 
            // txtPrelevement
            // 
            this.txtPrelevement.Location = new System.Drawing.Point(158, 113);
            this.txtPrelevement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrelevement.Name = "txtPrelevement";
            this.txtPrelevement.Size = new System.Drawing.Size(33, 20);
            this.txtPrelevement.TabIndex = 5;
            this.txtPrelevement.TextChanged += new System.EventHandler(this.txtPrelevement_TextChanged);
            this.txtPrelevement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrelevement_KeyPress);
            // 
            // lblPrelevements
            // 
            this.lblPrelevements.AutoSize = true;
            this.lblPrelevements.Location = new System.Drawing.Point(22, 115);
            this.lblPrelevements.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrelevements.Name = "lblPrelevements";
            this.lblPrelevements.Size = new System.Drawing.Size(131, 13);
            this.lblPrelevements.TabIndex = 4;
            this.lblPrelevements.Text = "Nombre de prélèvements :";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(115, 64);
            this.txtCommentaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(76, 20);
            this.txtCommentaire.TabIndex = 3;
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(115, 27);
            this.txtIntitule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(76, 20);
            this.txtIntitule.TabIndex = 2;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(22, 67);
            this.lblCommentaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(77, 13);
            this.lblCommentaire.TabIndex = 1;
            this.lblCommentaire.Text = "Commentaire : ";
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.Location = new System.Drawing.Point(22, 29);
            this.lblIntitule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(47, 13);
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
            this.tpRevenu.Location = new System.Drawing.Point(4, 22);
            this.tpRevenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpRevenu.Name = "tpRevenu";
            this.tpRevenu.Size = new System.Drawing.Size(516, 418);
            this.tpRevenu.TabIndex = 2;
            this.tpRevenu.Text = "Revenu";
            this.tpRevenu.UseVisualStyleBackColor = true;
            // 
            // txtPosteRevenu
            // 
            this.txtPosteRevenu.Location = new System.Drawing.Point(139, 27);
            this.txtPosteRevenu.Name = "txtPosteRevenu";
            this.txtPosteRevenu.Size = new System.Drawing.Size(87, 20);
            this.txtPosteRevenu.TabIndex = 8;
            // 
            // cboBeneficiaire
            // 
            this.cboBeneficiaire.FormattingEnabled = true;
            this.cboBeneficiaire.Location = new System.Drawing.Point(105, 79);
            this.cboBeneficiaire.Name = "cboBeneficiaire";
            this.cboBeneficiaire.Size = new System.Drawing.Size(121, 21);
            this.cboBeneficiaire.TabIndex = 7;
            // 
            // txtMontantRevenu
            // 
            this.txtMontantRevenu.Location = new System.Drawing.Point(139, 147);
            this.txtMontantRevenu.Name = "txtMontantRevenu";
            this.txtMontantRevenu.Size = new System.Drawing.Size(87, 20);
            this.txtMontantRevenu.TabIndex = 6;
            this.txtMontantRevenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantRevenu_KeyPress);
            // 
            // txtJourDuMois
            // 
            this.txtJourDuMois.Location = new System.Drawing.Point(155, 198);
            this.txtJourDuMois.Name = "txtJourDuMois";
            this.txtJourDuMois.Size = new System.Drawing.Size(31, 20);
            this.txtJourDuMois.TabIndex = 5;
            this.txtJourDuMois.TextChanged += new System.EventHandler(this.txtJourDuMois_TextChanged);
            this.txtJourDuMois.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJourDuMois_KeyPress);
            // 
            // lblJourDuMois
            // 
            this.lblJourDuMois.AutoSize = true;
            this.lblJourDuMois.Location = new System.Drawing.Point(136, 201);
            this.lblJourDuMois.Name = "lblJourDuMois";
            this.lblJourDuMois.Size = new System.Drawing.Size(96, 13);
            this.lblJourDuMois.TabIndex = 4;
            this.lblJourDuMois.Text = "le               du mois";
            // 
            // lblJourMois
            // 
            this.lblJourMois.AutoSize = true;
            this.lblJourMois.Location = new System.Drawing.Point(28, 201);
            this.lblJourMois.Name = "lblJourMois";
            this.lblJourMois.Size = new System.Drawing.Size(72, 13);
            this.lblJourMois.TabIndex = 3;
            this.lblJourMois.Text = "Jour du mois :";
            // 
            // lblMontantRevenu
            // 
            this.lblMontantRevenu.AutoSize = true;
            this.lblMontantRevenu.Location = new System.Drawing.Point(28, 150);
            this.lblMontantRevenu.Name = "lblMontantRevenu";
            this.lblMontantRevenu.Size = new System.Drawing.Size(52, 13);
            this.lblMontantRevenu.TabIndex = 2;
            this.lblMontantRevenu.Text = "Montant :";
            // 
            // lblBenef
            // 
            this.lblBenef.AutoSize = true;
            this.lblBenef.Location = new System.Drawing.Point(28, 82);
            this.lblBenef.Name = "lblBenef";
            this.lblBenef.Size = new System.Drawing.Size(68, 13);
            this.lblBenef.TabIndex = 1;
            this.lblBenef.Text = "Bénéficiaire :";
            // 
            // lblQuelPoste
            // 
            this.lblQuelPoste.AutoSize = true;
            this.lblQuelPoste.Location = new System.Drawing.Point(28, 30);
            this.lblQuelPoste.Name = "lblQuelPoste";
            this.lblQuelPoste.Size = new System.Drawing.Size(67, 13);
            this.lblQuelPoste.TabIndex = 0;
            this.lblQuelPoste.Text = "Quel poste ?";
            // 

            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(313, 300);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 9;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 


            // frmPrevisionnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 443);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}