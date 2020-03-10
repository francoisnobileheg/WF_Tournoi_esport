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
    public partial class frmConnexion : Form
    {
        frmInscription instanceInscri = null;

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lklInscri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (instanceInscri == null)
            {
                instanceInscri = new frmInscription();
            }
            instanceInscri.Show();
            instanceInscri.Focus();
        }
    }
}
