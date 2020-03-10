namespace WF_Tournoi_esport
{
    partial class frmProfilJoueur
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
            this.lblPseudo = new System.Windows.Forms.Label();
            this.btnModifierProfil = new System.Windows.Forms.Button();
            this.lblTournois = new System.Windows.Forms.Label();
            this.dtgTournoiConcourus = new System.Windows.Forms.DataGridView();
            this.cmsTournois = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seDésinscrireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblListeJeux = new System.Windows.Forms.Label();
            this.dtgListeJeux = new System.Windows.Forms.DataGridView();
            this.cmsListeJeux = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterJeu = new System.Windows.Forms.Button();
            this.btnChercherTournoi = new System.Windows.Forms.Button();
            this.chkAVenir = new System.Windows.Forms.CheckBox();
            this.btnSimuTournoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTournoiConcourus)).BeginInit();
            this.cmsTournois.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeJeux)).BeginInit();
            this.cmsListeJeux.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudo.Location = new System.Drawing.Point(6, 5);
            this.lblPseudo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(106, 31);
            this.lblPseudo.TabIndex = 0;
            this.lblPseudo.Text = "Pseudo";
            this.lblPseudo.Click += new System.EventHandler(this.lblPseudo_Click);
            // 
            // btnModifierProfil
            // 
            this.btnModifierProfil.Location = new System.Drawing.Point(12, 48);
            this.btnModifierProfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifierProfil.Name = "btnModifierProfil";
            this.btnModifierProfil.Size = new System.Drawing.Size(100, 27);
            this.btnModifierProfil.TabIndex = 1;
            this.btnModifierProfil.Text = "&Modifier profil";
            this.btnModifierProfil.UseVisualStyleBackColor = true;
            this.btnModifierProfil.Click += new System.EventHandler(this.btnModifierProfil_Click);
            // 
            // lblTournois
            // 
            this.lblTournois.AutoSize = true;
            this.lblTournois.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournois.Location = new System.Drawing.Point(6, 81);
            this.lblTournois.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTournois.Name = "lblTournois";
            this.lblTournois.Size = new System.Drawing.Size(120, 31);
            this.lblTournois.TabIndex = 2;
            this.lblTournois.Text = "Tournois";
            this.lblTournois.Click += new System.EventHandler(this.lblTournois_Click);
            // 
            // dtgTournoiConcourus
            // 
            this.dtgTournoiConcourus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTournoiConcourus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTournoiConcourus.ContextMenuStrip = this.cmsTournois;
            this.dtgTournoiConcourus.Location = new System.Drawing.Point(12, 116);
            this.dtgTournoiConcourus.Margin = new System.Windows.Forms.Padding(2);
            this.dtgTournoiConcourus.Name = "dtgTournoiConcourus";
            this.dtgTournoiConcourus.RowHeadersWidth = 82;
            this.dtgTournoiConcourus.RowTemplate.Height = 33;
            this.dtgTournoiConcourus.Size = new System.Drawing.Size(269, 324);
            this.dtgTournoiConcourus.TabIndex = 4;
            this.dtgTournoiConcourus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTournoiConcourus_CellContentClick);
            // 
            // cmsTournois
            // 
            this.cmsTournois.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDésinscrireToolStripMenuItem});
            this.cmsTournois.Name = "cmsTournois";
            this.cmsTournois.Size = new System.Drawing.Size(146, 26);
            // 
            // seDésinscrireToolStripMenuItem
            // 
            this.seDésinscrireToolStripMenuItem.Name = "seDésinscrireToolStripMenuItem";
            this.seDésinscrireToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.seDésinscrireToolStripMenuItem.Text = "Se désinscrire";
            this.seDésinscrireToolStripMenuItem.Click += new System.EventHandler(this.seDésinscrireToolStripMenuItem_Click);
            // 
            // lblListeJeux
            // 
            this.lblListeJeux.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListeJeux.AutoSize = true;
            this.lblListeJeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeJeux.Location = new System.Drawing.Point(327, 81);
            this.lblListeJeux.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListeJeux.Name = "lblListeJeux";
            this.lblListeJeux.Size = new System.Drawing.Size(165, 31);
            this.lblListeJeux.TabIndex = 6;
            this.lblListeJeux.Text = "Liste de jeux";
            this.lblListeJeux.Click += new System.EventHandler(this.lblListeJeux_Click);
            // 
            // dtgListeJeux
            // 
            this.dtgListeJeux.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgListeJeux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListeJeux.ContextMenuStrip = this.cmsListeJeux;
            this.dtgListeJeux.Location = new System.Drawing.Point(333, 114);
            this.dtgListeJeux.Margin = new System.Windows.Forms.Padding(2);
            this.dtgListeJeux.Name = "dtgListeJeux";
            this.dtgListeJeux.RowHeadersWidth = 82;
            this.dtgListeJeux.RowTemplate.Height = 33;
            this.dtgListeJeux.Size = new System.Drawing.Size(211, 326);
            this.dtgListeJeux.TabIndex = 7;
            this.dtgListeJeux.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListeJeux_CellContentClick);
            // 
            // cmsListeJeux
            // 
            this.cmsListeJeux.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsListeJeux.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.cmsListeJeux.Name = "cmsListeJeux";
            this.cmsListeJeux.Size = new System.Drawing.Size(130, 26);
            this.cmsListeJeux.Opening += new System.ComponentModel.CancelEventHandler(this.cmsListeJeux_Opening);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // btnAjouterJeu
            // 
            this.btnAjouterJeu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterJeu.Location = new System.Drawing.Point(333, 444);
            this.btnAjouterJeu.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterJeu.Name = "btnAjouterJeu";
            this.btnAjouterJeu.Size = new System.Drawing.Size(211, 36);
            this.btnAjouterJeu.TabIndex = 8;
            this.btnAjouterJeu.Text = "&Ajouter un jeu";
            this.btnAjouterJeu.UseVisualStyleBackColor = true;
            this.btnAjouterJeu.Click += new System.EventHandler(this.btnAjouterJeu_Click);
            // 
            // btnChercherTournoi
            // 
            this.btnChercherTournoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChercherTournoi.Location = new System.Drawing.Point(11, 444);
            this.btnChercherTournoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnChercherTournoi.Name = "btnChercherTournoi";
            this.btnChercherTournoi.Size = new System.Drawing.Size(269, 36);
            this.btnChercherTournoi.TabIndex = 5;
            this.btnChercherTournoi.Text = "&Rechercher des tournois";
            this.btnChercherTournoi.UseVisualStyleBackColor = true;
            this.btnChercherTournoi.Click += new System.EventHandler(this.btnChercherTournoi_Click);
            // 
            // chkAVenir
            // 
            this.chkAVenir.AutoSize = true;
            this.chkAVenir.Location = new System.Drawing.Point(128, 95);
            this.chkAVenir.Margin = new System.Windows.Forms.Padding(2);
            this.chkAVenir.Name = "chkAVenir";
            this.chkAVenir.Size = new System.Drawing.Size(58, 17);
            this.chkAVenir.TabIndex = 3;
            this.chkAVenir.Text = "à &venir";
            this.chkAVenir.UseVisualStyleBackColor = true;
            this.chkAVenir.CheckedChanged += new System.EventHandler(this.chkAVenir_CheckedChanged);
            // 
            // btnSimuTournoi
            // 
            this.btnSimuTournoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSimuTournoi.Location = new System.Drawing.Point(59, 649);
            this.btnSimuTournoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimuTournoi.Name = "btnSimuTournoi";
            this.btnSimuTournoi.Size = new System.Drawing.Size(124, 198);
            this.btnSimuTournoi.TabIndex = 9;
            this.btnSimuTournoi.Text = "SimuTournoi";
            this.btnSimuTournoi.UseVisualStyleBackColor = true;
            this.btnSimuTournoi.Click += new System.EventHandler(this.btnSimuTournoi_Click);
            // 
            // frmProfilJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 488);
            this.Controls.Add(this.btnSimuTournoi);
            this.Controls.Add(this.chkAVenir);
            this.Controls.Add(this.btnChercherTournoi);
            this.Controls.Add(this.btnAjouterJeu);
            this.Controls.Add(this.dtgListeJeux);
            this.Controls.Add(this.lblListeJeux);
            this.Controls.Add(this.dtgTournoiConcourus);
            this.Controls.Add(this.lblTournois);
            this.Controls.Add(this.btnModifierProfil);
            this.Controls.Add(this.lblPseudo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(570, 39);
            this.Name = "frmProfilJoueur";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.frmProfilJoueur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTournoiConcourus)).EndInit();
            this.cmsTournois.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeJeux)).EndInit();
            this.cmsListeJeux.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Button btnModifierProfil;
        private System.Windows.Forms.Label lblTournois;
        private System.Windows.Forms.DataGridView dtgTournoiConcourus;
        private System.Windows.Forms.Label lblListeJeux;
        private System.Windows.Forms.DataGridView dtgListeJeux;
        private System.Windows.Forms.Button btnAjouterJeu;
        private System.Windows.Forms.Button btnChercherTournoi;
        private System.Windows.Forms.CheckBox chkAVenir;
        private System.Windows.Forms.Button btnSimuTournoi;
        private System.Windows.Forms.ContextMenuStrip cmsListeJeux;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsTournois;
        private System.Windows.Forms.ToolStripMenuItem seDésinscrireToolStripMenuItem;
    }
}