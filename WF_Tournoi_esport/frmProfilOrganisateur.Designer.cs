﻿namespace WF_Tournoi_esport
{
    partial class frmProfilOrganisateur
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
            this.dtgTournoiOrganise = new System.Windows.Forms.DataGridView();
            this.cmsTournoi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsrModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrSupprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTournoiOrganise = new System.Windows.Forms.Label();
            this.btnCreerTournoi = new System.Windows.Forms.Button();
            this.btnSimuTournoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTournoiOrganise)).BeginInit();
            this.cmsTournoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgTournoiOrganise
            // 
            this.dtgTournoiOrganise.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTournoiOrganise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTournoiOrganise.ContextMenuStrip = this.cmsTournoi;
            this.dtgTournoiOrganise.Location = new System.Drawing.Point(6, 38);
            this.dtgTournoiOrganise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgTournoiOrganise.Name = "dtgTournoiOrganise";
            this.dtgTournoiOrganise.RowHeadersWidth = 82;
            this.dtgTournoiOrganise.RowTemplate.Height = 33;
            this.dtgTournoiOrganise.Size = new System.Drawing.Size(408, 348);
            this.dtgTournoiOrganise.TabIndex = 1;
            // 
            // cmsTournoi
            // 
            this.cmsTournoi.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsTournoi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrModifier,
            this.tsrSupprimer});
            this.cmsTournoi.Name = "cmsTournoi";
            this.cmsTournoi.Size = new System.Drawing.Size(130, 48);
            // 
            // tsrModifier
            // 
            this.tsrModifier.Name = "tsrModifier";
            this.tsrModifier.Size = new System.Drawing.Size(129, 22);
            this.tsrModifier.Text = "Modifier";
            this.tsrModifier.Click += new System.EventHandler(this.tsrModifier_Click);
            // 
            // tsrSupprimer
            // 
            this.tsrSupprimer.Name = "tsrSupprimer";
            this.tsrSupprimer.Size = new System.Drawing.Size(129, 22);
            this.tsrSupprimer.Text = "Supprimer";
            // 
            // lblTournoiOrganise
            // 
            this.lblTournoiOrganise.AutoSize = true;
            this.lblTournoiOrganise.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournoiOrganise.Location = new System.Drawing.Point(6, 4);
            this.lblTournoiOrganise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTournoiOrganise.Name = "lblTournoiOrganise";
            this.lblTournoiOrganise.Size = new System.Drawing.Size(245, 31);
            this.lblTournoiOrganise.TabIndex = 0;
            this.lblTournoiOrganise.Text = "Tournois organisés";
            // 
            // btnCreerTournoi
            // 
            this.btnCreerTournoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreerTournoi.Location = new System.Drawing.Point(6, 389);
            this.btnCreerTournoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreerTournoi.Name = "btnCreerTournoi";
            this.btnCreerTournoi.Size = new System.Drawing.Size(408, 41);
            this.btnCreerTournoi.TabIndex = 3;
            this.btnCreerTournoi.Text = "Créer un tournoi";
            this.btnCreerTournoi.UseVisualStyleBackColor = true;
            this.btnCreerTournoi.Click += new System.EventHandler(this.btnCreerTournoi_Click);
            // 
            // btnSimuTournoi
            // 
            this.btnSimuTournoi.Location = new System.Drawing.Point(96, 170);
            this.btnSimuTournoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSimuTournoi.Name = "btnSimuTournoi";
            this.btnSimuTournoi.Size = new System.Drawing.Size(166, 81);
            this.btnSimuTournoi.TabIndex = 2;
            this.btnSimuTournoi.Text = "SimuTournoi";
            this.btnSimuTournoi.UseVisualStyleBackColor = true;
            this.btnSimuTournoi.Click += new System.EventHandler(this.btnSimuTournoi_Click);
            // 
            // frmProfilOrganisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 437);
            this.Controls.Add(this.btnSimuTournoi);
            this.Controls.Add(this.btnCreerTournoi);
            this.Controls.Add(this.lblTournoiOrganise);
            this.Controls.Add(this.dtgTournoiOrganise);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(438, 476);
            this.Name = "frmProfilOrganisateur";
            this.Text = "Profil Organisateur";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTournoiOrganise)).EndInit();
            this.cmsTournoi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTournoiOrganise;
        private System.Windows.Forms.Label lblTournoiOrganise;
        private System.Windows.Forms.Button btnCreerTournoi;
        private System.Windows.Forms.ContextMenuStrip cmsTournoi;
        private System.Windows.Forms.ToolStripMenuItem tsrModifier;
        private System.Windows.Forms.ToolStripMenuItem tsrSupprimer;
        private System.Windows.Forms.Button btnSimuTournoi;
    }
}