using Gym.View;
using GYM;
using System;
using System.Windows.Forms;

namespace Gym
{
    public partial class frmAddTrainee : Form
    {
        public frmAddTrainee()
        {
            InitializeComponent();
        }


        private void btnInsertToDB_Click_1(object sender, EventArgs e)
        {
                            PopUp pop = new PopUp();

           if (!MyController.checkIfUserExists(txtBoxTraineeID.Text))
           {
            MyController.InsertTrainee(txtBoxTraineeID.Text, txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxAge.Text, txtBoxCity.Text);
           pop.popUpLabel.Text = "Trainee added succesfully.";
           }
           else
            {
                pop.popUpLabel.Text = "User with the same ID already exists.";
            }
           pop.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTraineesManagement sec = new frmTraineesManagement();
            sec.Show();
            this.Close();
        }

    }
}
