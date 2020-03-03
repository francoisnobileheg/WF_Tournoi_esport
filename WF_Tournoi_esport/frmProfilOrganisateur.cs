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
    public partial class frmProfilOrganisateur : Form
    {
        public frmProfilOrganisateur()
        {
            InitializeComponent();
        }

        private void btnCreerTournoi_Click(object sender, EventArgs e)
        {
            frmCreaModifTournoi frmCMT = new frmCreaModifTournoi();
            frmCMT.ShowDialog();
        }

        private void tsrModifier_Click(object sender, EventArgs e)
        {
            frmCreaModifTournoi frmCMT = new frmCreaModifTournoi();
            frmCMT.ShowDialog();
        }

        private void btnSimuTournoi_Click(object sender, EventArgs e)
        {
            frmTournoi frmT = new frmTournoi();
            frmT.Text = "Modifier le tournoi .........";
            frmT.Show();
        }
    }
}
