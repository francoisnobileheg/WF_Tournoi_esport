namespace WF_Tournoi_esport
{
    partial class frmInscription
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomOrganisation = new System.Windows.Forms.TextBox();
            this.chkOrganisateur = new System.Windows.Forms.CheckBox();
            this.lblNomInscr = new System.Windows.Forms.Label();
            this.lblPrenomInscr = new System.Windows.Forms.Label();
            this.lblEmailInscr = new System.Windows.Forms.Label();
            this.lblConfirmMdpInscr = new System.Windows.Forms.Label();
            this.lblMdpInscr = new System.Windows.Forms.Label();
            this.lblPseudoInscr = new System.Windows.Forms.Label();
            this.txtConfirmMdpInscr = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtEmailInscr = new System.Windows.Forms.TextBox();
            this.txtPseudoInscr = new System.Windows.Forms.TextBox();
            this.txtNomInscr = new System.Windows.Forms.TextBox();
            this.txtPrenomInscr = new System.Windows.Forms.TextBox();
            this.btnInscr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom de l\'&organisation :";
            // 
            // txtNomOrganisation
            // 
            this.txtNomOrganisation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomOrganisation.Location = new System.Drawing.Point(160, 245);
            this.txtNomOrganisation.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomOrganisation.Name = "txtNomOrganisation";
            this.txtNomOrganisation.Size = new System.Drawing.Size(209, 20);
            this.txtNomOrganisation.TabIndex = 14;
            // 
            // chkOrganisateur
            // 
            this.chkOrganisateur.AutoSize = true;
            this.chkOrganisateur.Location = new System.Drawing.Point(160, 224);
            this.chkOrganisateur.Margin = new System.Windows.Forms.Padding(2);
            this.chkOrganisateur.Name = "chkOrganisateur";
            this.chkOrganisateur.Size = new System.Drawing.Size(86, 17);
            this.chkOrganisateur.TabIndex = 12;
            this.chkOrganisateur.Text = "&Organisateur";
            this.chkOrganisateur.UseVisualStyleBackColor = true;
            this.chkOrganisateur.CheckedChanged += new System.EventHandler(this.chkOrganisateur_CheckedChanged);
            // 
            // lblNomInscr
            // 
            this.lblNomInscr.AutoSize = true;
            this.lblNomInscr.Location = new System.Drawing.Point(122, 61);
            this.lblNomInscr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomInscr.Name = "lblNomInscr";
            this.lblNomInscr.Size = new System.Drawing.Size(35, 13);
            this.lblNomInscr.TabIndex = 2;
            this.lblNomInscr.Text = "&Nom :";
            // 
            // lblPrenomInscr
            // 
            this.lblPrenomInscr.AutoSize = true;
            this.lblPrenomInscr.Location = new System.Drawing.Point(107, 27);
            this.lblPrenomInscr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenomInscr.Name = "lblPrenomInscr";
            this.lblPrenomInscr.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomInscr.TabIndex = 0;
            this.lblPrenomInscr.Text = "&Prénom :";
            // 
            // lblEmailInscr
            // 
            this.lblEmailInscr.AutoSize = true;
            this.lblEmailInscr.Location = new System.Drawing.Point(76, 129);
            this.lblEmailInscr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailInscr.Name = "lblEmailInscr";
            this.lblEmailInscr.Size = new System.Drawing.Size(78, 13);
            this.lblEmailInscr.TabIndex = 6;
            this.lblEmailInscr.Text = "&Adresse email :";
            // 
            // lblConfirmMdpInscr
            // 
            this.lblConfirmMdpInscr.AutoSize = true;
            this.lblConfirmMdpInscr.Location = new System.Drawing.Point(23, 198);
            this.lblConfirmMdpInscr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmMdpInscr.Name = "lblConfirmMdpInscr";
            this.lblConfirmMdpInscr.Size = new System.Drawing.Size(134, 13);
            this.lblConfirmMdpInscr.TabIndex = 10;
            this.lblConfirmMdpInscr.Text = "&Confirmer le mot de passe :";
            // 
            // lblMdpInscr
            // 
            this.lblMdpInscr.AutoSize = true;
            this.lblMdpInscr.Location = new System.Drawing.Point(79, 163);
            this.lblMdpInscr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMdpInscr.Name = "lblMdpInscr";
            this.lblMdpInscr.Size = new System.Drawing.Size(77, 13);
            this.lblMdpInscr.TabIndex = 8;
            this.lblMdpInscr.Text = "&Mot de passe :";
            // 
            // lblPseudoInscr
            // 
            this.lblPseudoInscr.AutoSize = true;
            this.lblPseudoInscr.Location = new System.Drawing.Point(107, 95);
            this.lblPseudoInscr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPseudoInscr.Name = "lblPseudoInscr";
            this.lblPseudoInscr.Size = new System.Drawing.Size(49, 13);
            this.lblPseudoInscr.TabIndex = 4;
            this.lblPseudoInscr.Text = "P&seudo :";
            // 
            // txtConfirmMdpInscr
            // 
            this.txtConfirmMdpInscr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmMdpInscr.Location = new System.Drawing.Point(160, 195);
            this.txtConfirmMdpInscr.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmMdpInscr.Name = "txtConfirmMdpInscr";
            this.txtConfirmMdpInscr.Size = new System.Drawing.Size(209, 20);
            this.txtConfirmMdpInscr.TabIndex = 11;
            this.txtConfirmMdpInscr.UseSystemPasswordChar = true;
            // 
            // txtMdp
            // 
            this.txtMdp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMdp.Location = new System.Drawing.Point(160, 161);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(2);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(209, 20);
            this.txtMdp.TabIndex = 9;
            this.txtMdp.UseSystemPasswordChar = true;
            // 
            // txtEmailInscr
            // 
            this.txtEmailInscr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailInscr.Location = new System.Drawing.Point(160, 127);
            this.txtEmailInscr.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailInscr.Name = "txtEmailInscr";
            this.txtEmailInscr.Size = new System.Drawing.Size(209, 20);
            this.txtEmailInscr.TabIndex = 7;
            // 
            // txtPseudoInscr
            // 
            this.txtPseudoInscr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPseudoInscr.Location = new System.Drawing.Point(160, 93);
            this.txtPseudoInscr.Margin = new System.Windows.Forms.Padding(2);
            this.txtPseudoInscr.Name = "txtPseudoInscr";
            this.txtPseudoInscr.Size = new System.Drawing.Size(209, 20);
            this.txtPseudoInscr.TabIndex = 5;
            // 
            // txtNomInscr
            // 
            this.txtNomInscr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomInscr.Location = new System.Drawing.Point(160, 60);
            this.txtNomInscr.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomInscr.Name = "txtNomInscr";
            this.txtNomInscr.Size = new System.Drawing.Size(209, 20);
            this.txtNomInscr.TabIndex = 3;
            // 
            // txtPrenomInscr
            // 
            this.txtPrenomInscr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrenomInscr.Location = new System.Drawing.Point(160, 26);
            this.txtPrenomInscr.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenomInscr.Name = "txtPrenomInscr";
            this.txtPrenomInscr.Size = new System.Drawing.Size(209, 20);
            this.txtPrenomInscr.TabIndex = 1;
            // 
            // btnInscr
            // 
            this.btnInscr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInscr.Location = new System.Drawing.Point(26, 279);
            this.btnInscr.Margin = new System.Windows.Forms.Padding(2);
            this.btnInscr.Name = "btnInscr";
            this.btnInscr.Size = new System.Drawing.Size(343, 56);
            this.btnInscr.TabIndex = 15;
            this.btnInscr.Text = "S\'&inscrire";
            this.btnInscr.UseVisualStyleBackColor = true;
            this.btnInscr.Click += new System.EventHandler(this.btnInscr_Click);
            // 
            // frmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomOrganisation);
            this.Controls.Add(this.chkOrganisateur);
            this.Controls.Add(this.lblNomInscr);
            this.Controls.Add(this.lblPrenomInscr);
            this.Controls.Add(this.lblEmailInscr);
            this.Controls.Add(this.lblConfirmMdpInscr);
            this.Controls.Add(this.lblMdpInscr);
            this.Controls.Add(this.lblPseudoInscr);
            this.Controls.Add(this.txtConfirmMdpInscr);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtEmailInscr);
            this.Controls.Add(this.txtPseudoInscr);
            this.Controls.Add(this.txtNomInscr);
            this.Controls.Add(this.txtPrenomInscr);
            this.Controls.Add(this.btnInscr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInscription";
            this.Text = "Inscription";
            this.Load += new System.EventHandler(this.frmInscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomOrganisation;
        private System.Windows.Forms.CheckBox chkOrganisateur;
        private System.Windows.Forms.Label lblNomInscr;
        private System.Windows.Forms.Label lblPrenomInscr;
        private System.Windows.Forms.Label lblEmailInscr;
        private System.Windows.Forms.Label lblConfirmMdpInscr;
        private System.Windows.Forms.Label lblMdpInscr;
        private System.Windows.Forms.Label lblPseudoInscr;
        private System.Windows.Forms.TextBox txtConfirmMdpInscr;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtEmailInscr;
        private System.Windows.Forms.TextBox txtPseudoInscr;
        private System.Windows.Forms.TextBox txtNomInscr;
        private System.Windows.Forms.TextBox txtPrenomInscr;
        private System.Windows.Forms.Button btnInscr;
    }
}