namespace WF_Tournoi_esport
{
    partial class frmListeTournoi
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
            this.dtgListeTournoi = new System.Windows.Forms.DataGridView();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeTournoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListeTournoi
            // 
            this.dtgListeTournoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListeTournoi.Location = new System.Drawing.Point(12, 27);
            this.dtgListeTournoi.Name = "dtgListeTournoi";
            this.dtgListeTournoi.Size = new System.Drawing.Size(294, 411);
            this.dtgListeTournoi.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(312, 15);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Liste des tournois qui correspondent à votre liste de jeux";
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(12, 444);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(294, 51);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // frmListeTournoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(331, 507);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.dtgListeTournoi);
            this.Name = "frmListeTournoi";
            this.Text = "Liste de tournois";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeTournoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListeTournoi;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnQuitter;
    }
}