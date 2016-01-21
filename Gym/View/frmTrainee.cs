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
    public partial class frmTrainee : Form
    {
        public frmTrainee()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnGoToFrmShop_Click(object sender, EventArgs e)
        {
           PurchaseItemsForm itemsForm = new PurchaseItemsForm();
            itemsForm.Show();
            this.Close();
        }

        private void btnGoToFrmActivities_Click(object sender, EventArgs e)
        {
            frmActivitiesDetails activitiesDetailsForm = new frmActivitiesDetails();
            activitiesDetailsForm.Show();
            this.Close();


        }
    }
}
