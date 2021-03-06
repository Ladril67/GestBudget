﻿namespace Pique_Sous
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificationPoste));
            this.lblPostePeriod = new System.Windows.Forms.Label();
            this.lblPosteEcheance = new System.Windows.Forms.Label();
            this.lblPosteRevenu = new System.Windows.Forms.Label();
            this.dgvPeriod = new System.Windows.Forms.DataGridView();
            this.dgvRevenu = new System.Windows.Forms.DataGridView();
            this.dgvEcheance = new System.Windows.Forms.DataGridView();
            this.cmsPoste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcheance)).BeginInit();
            this.cmsPoste.SuspendLayout();
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
            this.dgvPeriod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriod.Location = new System.Drawing.Point(15, 29);
            this.dgvPeriod.Name = "dgvPeriod";
            this.dgvPeriod.RowTemplate.Height = 24;
            this.dgvPeriod.Size = new System.Drawing.Size(558, 253);
            this.dgvPeriod.TabIndex = 3;
            this.dgvPeriod.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPeriod_CellMouseClick);
            // 
            // dgvRevenu
            // 
            this.dgvRevenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenu.Location = new System.Drawing.Point(12, 305);
            this.dgvRevenu.Name = "dgvRevenu";
            this.dgvRevenu.RowTemplate.Height = 24;
            this.dgvRevenu.Size = new System.Drawing.Size(558, 253);
            this.dgvRevenu.TabIndex = 4;
            this.dgvRevenu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRevenu_CellMouseClick);
            // 
            // dgvEcheance
            // 
            this.dgvEcheance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEcheance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEcheance.Location = new System.Drawing.Point(596, 29);
            this.dgvEcheance.Name = "dgvEcheance";
            this.dgvEcheance.RowTemplate.Height = 24;
            this.dgvEcheance.Size = new System.Drawing.Size(558, 253);
            this.dgvEcheance.TabIndex = 5;
            this.dgvEcheance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEcheance_CellClick);
            // 
            // cmsPoste
            // 
            this.cmsPoste.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPoste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.cmsPoste.Name = "cmsPeriod";
            this.cmsPoste.Size = new System.Drawing.Size(154, 56);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
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
            this.cmsPoste.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmsPoste;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}