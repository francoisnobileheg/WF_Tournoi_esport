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

        private void btnChercherTournoi_Click(object sender, EventArgs e)
        {
            frmListeTournoi frmLstTournoi = new frmListeTournoi();
            frmLstTournoi.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous vraiment supprimer ce jeu de votre liste ?",
                "Supprimer un jeu", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        private void seDésinscrireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous vraiment vous désinscrire de ce tournoi ?",
                "Se désinscrire", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }
    }
}
