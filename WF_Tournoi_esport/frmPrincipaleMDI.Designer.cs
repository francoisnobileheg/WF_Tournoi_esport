namespace WF_Tournoi_esport
{
    partial class frmPrincipaleMDI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsrAffichage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrFenetre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrProfilJoueur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrProfilOrganisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.frmConnexionInscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrAffichage,
            this.tsrFenetre});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mnsPrincipal.Size = new System.Drawing.Size(686, 24);
            this.mnsPrincipal.TabIndex = 0;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // tsrAffichage
            // 
            this.tsrAffichage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrHorizontal,
            this.tsrVertical,
            this.tsrCascade});
            this.tsrAffichage.Name = "tsrAffichage";
            this.tsrAffichage.Size = new System.Drawing.Size(70, 22);
            this.tsrAffichage.Text = "&Affichage";
            // 
            // tsrHorizontal
            // 
            this.tsrHorizontal.Name = "tsrHorizontal";
            this.tsrHorizontal.Size = new System.Drawing.Size(129, 22);
            this.tsrHorizontal.Text = "&Horizontal";
            this.tsrHorizontal.Click += new System.EventHandler(this.tsrHorizontal_Click);
            // 
            // tsrVertical
            // 
            this.tsrVertical.Name = "tsrVertical";
            this.tsrVertical.Size = new System.Drawing.Size(129, 22);
            this.tsrVertical.Text = "&Vertical";
            this.tsrVertical.Click += new System.EventHandler(this.tsrVertical_Click);
            // 
            // tsrCascade
            // 
            this.tsrCascade.Name = "tsrCascade";
            this.tsrCascade.Size = new System.Drawing.Size(129, 22);
            this.tsrCascade.Text = "&Cascade";
            this.tsrCascade.Click += new System.EventHandler(this.tsrCascade_Click);
            // 
            // tsrFenetre
            // 
            this.tsrFenetre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrProfilJoueur,
            this.tsrProfilOrganisateur,
            this.frmConnexionInscriptionToolStripMenuItem});
            this.tsrFenetre.Name = "tsrFenetre";
            this.tsrFenetre.Size = new System.Drawing.Size(58, 22);
            this.tsrFenetre.Text = "Fenêtre";
            // 
            // tsrProfilJoueur
            // 
            this.tsrProfilJoueur.Name = "tsrProfilJoueur";
            this.tsrProfilJoueur.Size = new System.Drawing.Size(188, 22);
            this.tsrProfilJoueur.Text = "ProfilJoueur";
            this.tsrProfilJoueur.Click += new System.EventHandler(this.tsrProfilJoueur_Click);
            // 
            // tsrProfilOrganisateur
            // 
            this.tsrProfilOrganisateur.Name = "tsrProfilOrganisateur";
            this.tsrProfilOrganisateur.Size = new System.Drawing.Size(188, 22);
            this.tsrProfilOrganisateur.Text = "ProfilOrganisateur";
            this.tsrProfilOrganisateur.Click += new System.EventHandler(this.tsrProfilOrganisateur_Click);
            // 
            // frmConnexionInscriptionToolStripMenuItem
            // 
            this.frmConnexionInscriptionToolStripMenuItem.Name = "frmConnexionInscriptionToolStripMenuItem";
            this.frmConnexionInscriptionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.frmConnexionInscriptionToolStripMenuItem.Text = "ConnexionInscription";
            this.frmConnexionInscriptionToolStripMenuItem.Click += new System.EventHandler(this.frmConnexionInscriptionToolStripMenuItem_Click);
            // 
            // frmPrincipaleMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 464);
            this.Controls.Add(this.mnsPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipaleMDI";
            this.Text = "Principale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipaleMDI_Load);
            this.Shown += new System.EventHandler(this.frmPrincipaleMDI_Shown);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsrAffichage;
        private System.Windows.Forms.ToolStripMenuItem tsrHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsrVertical;
        private System.Windows.Forms.ToolStripMenuItem tsrCascade;
        private System.Windows.Forms.ToolStripMenuItem tsrFenetre;
        private System.Windows.Forms.ToolStripMenuItem tsrProfilJoueur;
        private System.Windows.Forms.ToolStripMenuItem tsrProfilOrganisateur;
        private System.Windows.Forms.ToolStripMenuItem frmConnexionInscriptionToolStripMenuItem;
    }
}

