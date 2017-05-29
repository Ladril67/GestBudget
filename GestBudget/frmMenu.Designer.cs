namespace Pique_Sous
{
    partial class frmMenu
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
            this.btnBudgetMois = new System.Windows.Forms.Button();
            this.btnPrevisionnel = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBudgetMois
            // 
            this.btnBudgetMois.Location = new System.Drawing.Point(100, 125);
            this.btnBudgetMois.Name = "btnBudgetMois";
            this.btnBudgetMois.Size = new System.Drawing.Size(400, 50);
            this.btnBudgetMois.TabIndex = 0;
            this.btnBudgetMois.Text = "Budget mois";
            this.btnBudgetMois.UseVisualStyleBackColor = true;
            this.btnBudgetMois.Click += new System.EventHandler(this.btnBudgetMois_Click);
            // 
            // btnPrevisionnel
            // 
            this.btnPrevisionnel.Location = new System.Drawing.Point(100, 250);
            this.btnPrevisionnel.Name = "btnPrevisionnel";
            this.btnPrevisionnel.Size = new System.Drawing.Size(400, 50);
            this.btnPrevisionnel.TabIndex = 1;
            this.btnPrevisionnel.Text = "Budget prévisionnel";
            this.btnPrevisionnel.UseVisualStyleBackColor = true;
            this.btnPrevisionnel.Click += new System.EventHandler(this.btnPrevisionnel_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(490, 411);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(80, 30);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(133, 24);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(336, 44);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Menu Pique-Sous";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnPrevisionnel);
            this.Controls.Add(this.btnBudgetMois);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBudgetMois;
        private System.Windows.Forms.Button btnPrevisionnel;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblMenu;
    }
}