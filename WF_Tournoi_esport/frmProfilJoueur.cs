using System;
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
    public partial class frmProfilJoueur : Form
    {
        public frmProfilJoueur()
        {
            InitializeComponent();
        }

        private void frmProfilJoueur_Load(object sender, EventArgs e)
        {

        }

        private void btnModifierProfil_Click(object sender, EventArgs e)
        {
            frmModifierProfilJoueur frmMP = new frmModifierProfilJoueur();
            frmMP.ShowDialog();
        }

        private void btnAjouterJeu_Click(object sender, EventArgs e)
        {
            frmAjouterJeu frmAJ = new frmAjouterJeu();
            frmAJ.ShowDialog();
        }

        private void btnSimuTournoi_Click(object sender, EventArgs e)
        {
            frmTournoi frmT = new frmTournoi();
            frmT.Show();
            frmT.MdiParent = this.MdiParent;
        }

        private void lblTournois_Click(object sender, EventArgs e)
        {

        }

        private void dtgTournoiConcourus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblListeJeux_Click(object sender, EventArgs e)
        {

        }

        private void dtgListeJeux_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChercherTournoi_Click(object sender, EventArgs e)
        {

        }

        private void chkAVenir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmsListeJeux_Opening(object sender, CancelEventArgs e)
        {

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblPseudo_Click(object sender, EventArgs e)
        {

        }
    }
}
