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
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {


            MyController.purchaseItem(this.ItemNumber.Text);

            this.textBoxQuantity.Text = MyController.getQuantity(this.ItemNumber.Text).ToString();
            int num = Convert.ToInt16(textBoxQuantity.Text);
            if (Convert.ToInt16(num) <= 0)
                this.buttonPurchase.Enabled = false;
        }


    }
}
