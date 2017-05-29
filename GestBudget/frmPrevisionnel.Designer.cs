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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPeriodicite = new System.Windows.Forms.ComboBox();
            this.btnAutre = new System.Windows.Forms.Button();
            this.cboPoste = new System.Windows.Forms.ComboBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblJour = new System.Windows.Forms.Label();
            this.lblPeriodicite = new System.Windows.Forms.Label();
            this.lblPoste = new System.Windows.Forms.Label();
            this.tpPostePonctuel = new System.Windows.Forms.TabPage();
            this.tpRevenu = new System.Windows.Forms.TabPage();
            this.tboJour = new System.Windows.Forms.TextBox();
            this.tboMontant = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpPosteFixe.SuspendLayout();
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
            this.tpPosteFixe.Controls.Add(this.tboMontant);
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
            this.tpPostePonctuel.Location = new System.Drawing.Point(4, 25);
            this.tpPostePonctuel.Name = "tpPostePonctuel";
            this.tpPostePonctuel.Padding = new System.Windows.Forms.Padding(3);
            this.tpPostePonctuel.Size = new System.Drawing.Size(690, 518);
            this.tpPostePonctuel.TabIndex = 1;
            this.tpPostePonctuel.Text = "Poste Ponctuel ";
            this.tpPostePonctuel.UseVisualStyleBackColor = true;
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
            // tboJour
            // 
            this.tboJour.Location = new System.Drawing.Point(203, 181);
            this.tboJour.Name = "tboJour";
            this.tboJour.Size = new System.Drawing.Size(34, 22);
            this.tboJour.TabIndex = 8;
            // 
            // tboMontant
            // 
            this.tboMontant.Location = new System.Drawing.Point(175, 251);
            this.tboMontant.Name = "tboMontant";
            this.tboMontant.Size = new System.Drawing.Size(98, 22);
            this.tboMontant.TabIndex = 9;
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
            // frmPrevisionnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrevisionnel";
            this.Text = "frmPrevisionnel";
            this.tabControl1.ResumeLayout(false);
            this.tpPosteFixe.ResumeLayout(false);
            this.tpPosteFixe.PerformLayout();
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
        private System.Windows.Forms.TextBox tboMontant;
        private System.Windows.Forms.TextBox tboJour;
    }
}