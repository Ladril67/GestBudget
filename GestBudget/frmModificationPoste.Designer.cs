namespace Pique_Sous
{
    partial class frmModificationPoste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificationPoste));
            this.lblPostePeriod = new System.Windows.Forms.Label();
            this.lblPosteEcheance = new System.Windows.Forms.Label();
            this.lblPosteRevenu = new System.Windows.Forms.Label();
            this.dgvPeriod = new System.Windows.Forms.DataGridView();
            this.dgvRevenu = new System.Windows.Forms.DataGridView();
            this.dgvEcheance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcheance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPostePeriod
            // 
            this.lblPostePeriod.AutoSize = true;
            this.lblPostePeriod.Location = new System.Drawing.Point(12, 9);
            this.lblPostePeriod.Name = "lblPostePeriod";
            this.lblPostePeriod.Size = new System.Drawing.Size(158, 17);
            this.lblPostePeriod.TabIndex = 0;
            this.lblPostePeriod.Text = "Poste à périodicité fixe :";
            // 
            // lblPosteEcheance
            // 
            this.lblPosteEcheance.AutoSize = true;
            this.lblPosteEcheance.Location = new System.Drawing.Point(593, 9);
            this.lblPosteEcheance.Name = "lblPosteEcheance";
            this.lblPosteEcheance.Size = new System.Drawing.Size(144, 17);
            this.lblPosteEcheance.TabIndex = 1;
            this.lblPosteEcheance.Text = "Postes à échéances :";
            // 
            // lblPosteRevenu
            // 
            this.lblPosteRevenu.AutoSize = true;
            this.lblPosteRevenu.Location = new System.Drawing.Point(12, 285);
            this.lblPosteRevenu.Name = "lblPosteRevenu";
            this.lblPosteRevenu.Size = new System.Drawing.Size(129, 17);
            this.lblPosteRevenu.TabIndex = 2;
            this.lblPosteRevenu.Text = "Postes \"Revenus\" :";
            // 
            // dgvPeriod
            // 
            this.dgvPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriod.Location = new System.Drawing.Point(15, 29);
            this.dgvPeriod.Name = "dgvPeriod";
            this.dgvPeriod.RowTemplate.Height = 24;
            this.dgvPeriod.Size = new System.Drawing.Size(558, 253);
            this.dgvPeriod.TabIndex = 3;
            // 
            // dgvRevenu
            // 
            this.dgvRevenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenu.Location = new System.Drawing.Point(15, 310);
            this.dgvRevenu.Name = "dgvRevenu";
            this.dgvRevenu.RowTemplate.Height = 24;
            this.dgvRevenu.Size = new System.Drawing.Size(558, 253);
            this.dgvRevenu.TabIndex = 4;
            // 
            // dgvEcheance
            // 
            this.dgvEcheance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEcheance.Location = new System.Drawing.Point(596, 29);
            this.dgvEcheance.Name = "dgvEcheance";
            this.dgvEcheance.RowTemplate.Height = 24;
            this.dgvEcheance.Size = new System.Drawing.Size(558, 253);
            this.dgvEcheance.TabIndex = 5;
            // 
            // frmModificationPoste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 575);
            this.Controls.Add(this.dgvEcheance);
            this.Controls.Add(this.dgvRevenu);
            this.Controls.Add(this.dgvPeriod);
            this.Controls.Add(this.lblPosteRevenu);
            this.Controls.Add(this.lblPosteEcheance);
            this.Controls.Add(this.lblPostePeriod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificationPoste";
            this.Text = "Modification des postes";
            this.Load += new System.EventHandler(this.frmModificationPoste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcheance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPostePeriod;
        private System.Windows.Forms.Label lblPosteEcheance;
        private System.Windows.Forms.Label lblPosteRevenu;
        private System.Windows.Forms.DataGridView dgvPeriod;
        private System.Windows.Forms.DataGridView dgvRevenu;
        private System.Windows.Forms.DataGridView dgvEcheance;
    }
}