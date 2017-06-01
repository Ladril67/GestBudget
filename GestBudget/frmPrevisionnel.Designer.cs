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
            this.grpEcheances = new System.Windows.Forms.GroupBox();
            this.txtPrelevement = new System.Windows.Forms.TextBox();
            this.lblPrelevements = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.lblIntitule = new System.Windows.Forms.Label();
            this.tpRevenu = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tpPosteFixe.SuspendLayout();
            this.tpPostePonctuel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPosteFixe);
            this.tabControl1.Controls.Add(this.tpPostePonctuel);
            this.tabControl1.Controls.Add(this.tpRevenu);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 547);
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
            this.tpPosteFixe.Name = "tpPosteFixe";
            this.tpPosteFixe.Padding = new System.Windows.Forms.Padding(3);
            this.tpPosteFixe.Size = new System.Drawing.Size(690, 518);
            this.tpPosteFixe.TabIndex = 0;
            this.tpPosteFixe.Text = "Poste Fixe";
            this.tpPosteFixe.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(479, 309);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(113, 30);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(175, 248);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(98, 22);
            this.txtMontant.TabIndex = 9;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboMontant_KeyPress);
            // 
            // tboJour
            // 
            this.tboJour.Location = new System.Drawing.Point(203, 181);
            this.tboJour.Name = "tboJour";
            this.tboJour.Size = new System.Drawing.Size(34, 22);
            this.tboJour.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Le              du mois";
            // 
            // cboPeriodicite
            // 
            this.cboPeriodicite.FormattingEnabled = true;
            this.cboPeriodicite.Location = new System.Drawing.Point(175, 117);
            this.cboPeriodicite.Name = "cboPeriodicite";
            this.cboPeriodicite.Size = new System.Drawing.Size(235, 24);
            this.cboPeriodicite.TabIndex = 6;
            // 
            // btnAutre
            // 
            this.btnAutre.Location = new System.Drawing.Point(439, 40);
            this.btnAutre.Name = "btnAutre";
            this.btnAutre.Size = new System.Drawing.Size(75, 23);
            this.btnAutre.TabIndex = 5;
            this.btnAutre.Text = "Autre";
            this.btnAutre.UseVisualStyleBackColor = true;
            // 
            // cboPoste
            // 
            this.cboPoste.FormattingEnabled = true;
            this.cboPoste.Location = new System.Drawing.Point(175, 40);
            this.cboPoste.Name = "cboPoste";
            this.cboPoste.Size = new System.Drawing.Size(235, 24);
            this.cboPoste.TabIndex = 4;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(38, 251);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(67, 17);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "Montant :";
            // 
            // lblJour
            // 
            this.lblJour.AutoSize = true;
            this.lblJour.Location = new System.Drawing.Point(38, 184);
            this.lblJour.Name = "lblJour";
            this.lblJour.Size = new System.Drawing.Size(101, 17);
            this.lblJour.TabIndex = 2;
            this.lblJour.Text = "Jour du mois : ";
            // 
            // lblPeriodicite
            // 
            this.lblPeriodicite.AutoSize = true;
            this.lblPeriodicite.Location = new System.Drawing.Point(38, 124);
            this.lblPeriodicite.Name = "lblPeriodicite";
            this.lblPeriodicite.Size = new System.Drawing.Size(82, 17);
            this.lblPeriodicite.TabIndex = 1;
            this.lblPeriodicite.Text = "Périodicité :";
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.Location = new System.Drawing.Point(38, 43);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(93, 17);
            this.lblPoste.TabIndex = 0;
            this.lblPoste.Text = "Quel poste ? ";
            // 
            // tpPostePonctuel
            // 
            this.tpPostePonctuel.Controls.Add(this.grpEcheances);
            this.tpPostePonctuel.Controls.Add(this.txtPrelevement);
            this.tpPostePonctuel.Controls.Add(this.lblPrelevements);
            this.tpPostePonctuel.Controls.Add(this.txtCommentaire);
            this.tpPostePonctuel.Controls.Add(this.txtIntitule);
            this.tpPostePonctuel.Controls.Add(this.lblCommentaire);
            this.tpPostePonctuel.Controls.Add(this.lblIntitule);
            this.tpPostePonctuel.Location = new System.Drawing.Point(4, 25);
            this.tpPostePonctuel.Name = "tpPostePonctuel";
            this.tpPostePonctuel.Padding = new System.Windows.Forms.Padding(3);
            this.tpPostePonctuel.Size = new System.Drawing.Size(690, 518);
            this.tpPostePonctuel.TabIndex = 1;
            this.tpPostePonctuel.Text = "Poste Ponctuel ";
            this.tpPostePonctuel.UseVisualStyleBackColor = true;
            // 
            // grpEcheances
            // 
            this.grpEcheances.Location = new System.Drawing.Point(32, 186);
            this.grpEcheances.Name = "grpEcheances";
            this.grpEcheances.Size = new System.Drawing.Size(608, 293);
            this.grpEcheances.TabIndex = 6;
            this.grpEcheances.TabStop = false;
            this.grpEcheances.Text = "Echéances prévues";
            // 
            // txtPrelevement
            // 
            this.txtPrelevement.Location = new System.Drawing.Point(210, 139);
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
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(100, 22);
            this.txtCommentaire.TabIndex = 3;
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(153, 33);
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
            this.tpRevenu.Location = new System.Drawing.Point(4, 25);
            this.tpRevenu.Name = "tpRevenu";
            this.tpRevenu.Size = new System.Drawing.Size(690, 518);
            this.tpRevenu.TabIndex = 2;
            this.tpRevenu.Text = "Revenu";
            this.tpRevenu.UseVisualStyleBackColor = true;
            // 
            // frmPrevisionnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrevisionnel";
            this.Text = "frmPrevisionnel";
            this.Load += new System.EventHandler(this.frmPrevisionnel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPosteFixe.ResumeLayout(false);
            this.tpPosteFixe.PerformLayout();
            this.tpPostePonctuel.ResumeLayout(false);
            this.tpPostePonctuel.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpEcheances;
    }
}