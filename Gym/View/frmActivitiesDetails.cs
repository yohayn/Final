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
    public partial class frmActivitiesDetails : Form
    {
        public frmActivitiesDetails()
        {
            InitializeComponent();
            frmActivitiesDetails_Load();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmTrainee frmTrainee = new frmTrainee();
            frmTrainee.Show();
            this.Close();
        }

        //when entering the page. load the listbox items as the name of the class
        private void frmActivitiesDetails_Load()
        {
         

            List<string> myList = MyController.getClassesNamesList();
            listBox1.DataSource = myList;

            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            string className = listBox1.SelectedValue.ToString();

            DataRow datarow = MyController.getClassDetailsRow(className);

            txtBoxDay.Text = datarow["Day"].ToString();
            txtBoxHour.Text = datarow["Hour"].ToString();
            txtBoxGuide.Text = datarow["Guide"].ToString();
        }
    }
}
