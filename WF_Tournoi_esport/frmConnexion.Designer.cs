namespace WF_Tournoi_esport
{
    partial class frmConnexion
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPseudoConnect = new System.Windows.Forms.TextBox();
            this.txtMdpConnect = new System.Windows.Forms.TextBox();
            this.lblPseudoConnect = new System.Windows.Forms.Label();
            this.lblMdpConnect = new System.Windows.Forms.Label();
            this.lklInscri = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnect.Location = new System.Drawing.Point(11, 78);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(355, 56);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Se &connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPseudoConnect
            // 
            this.txtPseudoConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPseudoConnect.Location = new System.Drawing.Point(91, 16);
            this.txtPseudoConnect.Margin = new System.Windows.Forms.Padding(2);
            this.txtPseudoConnect.Name = "txtPseudoConnect";
            this.txtPseudoConnect.Size = new System.Drawing.Size(275, 20);
            this.txtPseudoConnect.TabIndex = 1;
            // 
            // txtMdpConnect
            // 
            this.txtMdpConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMdpConnect.Location = new System.Drawing.Point(91, 46);
            this.txtMdpConnect.Margin = new System.Windows.Forms.Padding(2);
            this.txtMdpConnect.Name = "txtMdpConnect";
            this.txtMdpConnect.Size = new System.Drawing.Size(275, 20);
            this.txtMdpConnect.TabIndex = 3;
            this.txtMdpConnect.UseSystemPasswordChar = true;
            // 
            // lblPseudoConnect
            // 
            this.lblPseudoConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPseudoConnect.AutoSize = true;
            this.lblPseudoConnect.Location = new System.Drawing.Point(39, 17);
            this.lblPseudoConnect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPseudoConnect.Name = "lblPseudoConnect";
            this.lblPseudoConnect.Size = new System.Drawing.Size(49, 13);
            this.lblPseudoConnect.TabIndex = 0;
            this.lblPseudoConnect.Text = "&Pseudo :";
            // 
            // lblMdpConnect
            // 
            this.lblMdpConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMdpConnect.AutoSize = true;
            this.lblMdpConnect.Location = new System.Drawing.Point(11, 48);
            this.lblMdpConnect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMdpConnect.Name = "lblMdpConnect";
            this.lblMdpConnect.Size = new System.Drawing.Size(77, 13);
            this.lblMdpConnect.TabIndex = 2;
            this.lblMdpConnect.Text = "&Mot de passe :";
            // 
            // lklInscri
            // 
            this.lklInscri.AutoSize = true;
            this.lklInscri.Location = new System.Drawing.Point(145, 156);
            this.lklInscri.Name = "lklInscri";
            this.lklInscri.Size = new System.Drawing.Size(100, 13);
            this.lklInscri.TabIndex = 5;
            this.lklInscri.TabStop = true;
            this.lklInscri.Text = "Pas encore &inscrit ?";
            this.lklInscri.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklInscri_LinkClicked);
            // 
            // frmConnexion
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 178);
            this.Controls.Add(this.lklInscri);
            this.Controls.Add(this.lblMdpConnect);
            this.Controls.Add(this.lblPseudoConnect);
            this.Controls.Add(this.txtMdpConnect);
            this.Controls.Add(this.txtPseudoConnect);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(303, 217);
            this.Name = "frmConnexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPseudoConnect;
        private System.Windows.Forms.TextBox txtMdpConnect;
        private System.Windows.Forms.Label lblPseudoConnect;
        private System.Windows.Forms.Label lblMdpConnect;
        private System.Windows.Forms.LinkLabel lklInscri;
    }
}