using GYM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class frmTraineesManagement : Form
    {
        public frmTraineesManagement()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmSecretary frmSecretary = new frmSecretary();
            frmSecretary.Show();
            this.Close();
        }

        private void btnAddTrainee_Click(object sender, EventArgs e)
        {
            frmAddTrainee addTraineeForm = new frmAddTrainee();
            addTraineeForm.Show();
            this.Close();
        }

        
    }
}
