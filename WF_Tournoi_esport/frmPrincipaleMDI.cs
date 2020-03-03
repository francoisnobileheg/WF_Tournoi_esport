﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Tournoi_esport
{
    public partial class frmPrincipaleMDI : Form
    {
        public frmPrincipaleMDI()
        {
            InitializeComponent();
        }

        private void tsrHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsrVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tsrCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsrProfilJoueur_Click(object sender, EventArgs e)
        {
            frmProfilJoueur frmPJ = new frmProfilJoueur();
            frmPJ.Show();
            frmPJ.MdiParent = this;
        }

        private void tsrProfilOrganisateur_Click(object sender, EventArgs e)
        {
            frmProfilOrganisateur frmPO = new frmProfilOrganisateur();
            frmPO.Show();
            frmPO.MdiParent = this;
        }

        private void frmConnexionInscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexInscri frmCI = new frmConnexInscri();
            frmCI.Show();
        }
    }
}