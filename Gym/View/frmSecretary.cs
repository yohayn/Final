using Gym;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class frmSecretary : Form
    {
        public frmSecretary()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain FrmMain = new frmMain();
            FrmMain.Show();
            this.Close();
        }

        private void btnGoToFrmAddTrainee_Click(object sender, EventArgs e)
        {
            frmTraineesManagement frmtraineesManagement = new frmTraineesManagement();
            frmtraineesManagement.Show();
            this.Close();
        }
    }
}
