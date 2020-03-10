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
    public partial class frmInscription : Form
    {
        public frmInscription()
        {
            InitializeComponent();
        }

        private void frmInscription_Load(object sender, EventArgs e)
        {
            txtNomOrganisation.Enabled = false;
        }

        private void chkOrganisateur_CheckedChanged(object sender, EventArgs e)
        {
            txtNomOrganisation.Enabled = !txtNomOrganisation.Enabled;
        }

        private void btnInscr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
