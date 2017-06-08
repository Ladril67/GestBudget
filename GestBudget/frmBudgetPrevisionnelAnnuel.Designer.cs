namespace Pique_Sous
{
    partial class frmBudgetPrevisionnelAnnuel
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
            this.dgvPrevisionnelAnnuel = new System.Windows.Forms.DataGridView();
            this.Poste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Janvier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Février = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avril = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juillet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Août = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Septembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Novembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Décembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevisionnelAnnuel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrevisionnelAnnuel
            // 
            this.dgvPrevisionnelAnnuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrevisionnelAnnuel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Poste,
            this.Janvier,
            this.Février,
            this.Mars,
            this.Avril,
            this.Mai,
            this.Juin,
            this.Juillet,
            this.Août,
            this.Septembre,
            this.Novembre,
            this.Décembre});
            this.dgvPrevisionnelAnnuel.Location = new System.Drawing.Point(0, 2);
            this.dgvPrevisionnelAnnuel.Name = "dgvPrevisionnelAnnuel";
            this.dgvPrevisionnelAnnuel.RowTemplate.Height = 24;
            this.dgvPrevisionnelAnnuel.Size = new System.Drawing.Size(1137, 656);
            this.dgvPrevisionnelAnnuel.TabIndex = 0;
            // 
            // Poste
            // 
            this.Poste.Frozen = true;
            this.Poste.HeaderText = "Poste : ";
            this.Poste.Name = "Poste";
            // 
            // Janvier
            // 
            this.Janvier.HeaderText = "Janvier";
            this.Janvier.Name = "Janvier";
            // 
            // Février
            // 
            this.Février.HeaderText = "Février";
            this.Février.Name = "Février";
            // 
            // Mars
            // 
            this.Mars.HeaderText = "Mars";
            this.Mars.Name = "Mars";
            // 
            // Avril
            // 
            this.Avril.HeaderText = "Avril";
            this.Avril.Name = "Avril";
            // 
            // Mai
            // 
            this.Mai.HeaderText = "Mai";
            this.Mai.Name = "Mai";
            // 
            // Juin
            // 
            this.Juin.HeaderText = "Juin";
            this.Juin.Name = "Juin";
            // 
            // Juillet
            // 
            this.Juillet.HeaderText = "Juillet";
            this.Juillet.Name = "Juillet";
            // 
            // Août
            // 
            this.Août.HeaderText = "Août";
            this.Août.Name = "Août";
            // 
            // Septembre
            // 
            this.Septembre.HeaderText = "Septembre";
            this.Septembre.Name = "Septembre";
            // 
            // Novembre
            // 
            this.Novembre.HeaderText = "Septembre";
            this.Novembre.Name = "Novembre";
            // 
            // Décembre
            // 
            this.Décembre.HeaderText = "Décembre";
            this.Décembre.Name = "Décembre";
            // 
            // frmBudgetPrevisionnelAnnuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 670);
            this.Controls.Add(this.dgvPrevisionnelAnnuel);
            this.Name = "frmBudgetPrevisionnelAnnuel";
            this.Text = "frmBudgetPrevisionnelAnnuel";
            this.Load += new System.EventHandler(this.frmBudgetPrevisionnelAnnuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevisionnelAnnuel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrevisionnelAnnuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Janvier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Février;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avril;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juillet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Août;
        private System.Windows.Forms.DataGridViewTextBoxColumn Septembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Novembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Décembre;
    }
}