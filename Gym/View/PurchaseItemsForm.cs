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
    public partial class PurchaseItemsForm : Form
    {
        public PurchaseItemsForm()
        {
            InitializeComponent();
        }
          private void button2_ClickPowder(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            item.ItemNumber.Enabled = false;
            item.textBoxNameItem.Enabled = false; ;
            item.textBoxQuantity.Enabled = false;
            item.Price.Enabled = false;
            item.ItemNumber.Text = "1";

             DataTable db= MyController.GetData(item.ItemNumber.Text); 
             item.Price.Text= db.Rows[0]["Price"].ToString();
             item.textBoxNameItem.Text = db.Rows[0]["Item Name"].ToString();
            string path = AppDomain.CurrentDomain.BaseDirectory;
            item.pictureBox1.ImageLocation= @path+"אבקה.png";
            string quantity = MyController.getQuantity(item.ItemNumber.Text);

            item.textBoxQuantity.Text = quantity;
            if (Convert.ToInt16(quantity) <= 0)
                item.buttonPurchase.Enabled = false;
            item.Show();

        }

        private void click_rubberBands(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            item.ItemNumber.Enabled = false;
            item.textBoxNameItem.Enabled = false; ;
            item.textBoxQuantity.Enabled = false;
            item.Price.Enabled = false;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            item.ItemNumber.Text = "2";
            DataTable db = MyController.GetData(item.ItemNumber.Text);
            item.Price.Text = db.Rows[0]["Price"].ToString();
            item.textBoxNameItem.Text = db.Rows[0]["Item Name"].ToString();
            string quantity = MyController.getQuantity(item.ItemNumber.Text);

            item.textBoxQuantity.Text = quantity;
            if (Convert.ToInt16(quantity) <= 0)
                item.buttonPurchase.Enabled = false;

            item.pictureBox1.ImageLocation = @path + "גומיות.jpg";
            item.Show();
        }

        private void clickShirt(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            item.ItemNumber.Enabled = false;
            item.textBoxNameItem.Enabled = false; ;
            item.textBoxQuantity.Enabled = false;
            item.Price.Enabled = false;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            item.ItemNumber.Text = "3";
            DataTable db = MyController.GetData(item.ItemNumber.Text);
            item.Price.Text = db.Rows[0]["Price"].ToString();
            item.textBoxNameItem.Text = db.Rows[0]["Item Name"].ToString();
            string quantity = MyController.getQuantity(item.ItemNumber.Text);

            item.textBoxQuantity.Text = quantity;
            if (Convert.ToInt16(quantity) <= 0)
                item.buttonPurchase.Enabled = false;

            item.pictureBox1.ImageLocation = @path + "דרייפיט.jpg";
            item.Show();
        }

        private void clickDilgit(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            item.ItemNumber.Enabled = false;
            item.textBoxNameItem.Enabled = false; ;
            item.textBoxQuantity.Enabled = false;
            item.Price.Enabled = false;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            item.ItemNumber.Text = "4";
            DataTable db = MyController.GetData(item.ItemNumber.Text);
            item.Price.Text = db.Rows[0]["Price"].ToString();
            item.textBoxNameItem.Text = db.Rows[0]["Item Name"].ToString();
            string quantity = MyController.getQuantity(item.ItemNumber.Text);

            item.textBoxQuantity.Text = quantity;
            if (Convert.ToInt16(quantity) <= 0)
                item.buttonPurchase.Enabled = false;

            item.pictureBox1.ImageLocation = @path + "דלגית.jpg";
            item.Show();
        }

        private void clickWeights(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            item.ItemNumber.Enabled = false;
            item.textBoxNameItem.Enabled = false; ;
            item.textBoxQuantity.Enabled = false;
            item.Price.Enabled = false;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            item.ItemNumber.Text = "5";
            DataTable db = MyController.GetData(item.ItemNumber.Text);
            item.Price.Text = db.Rows[0]["Price"].ToString();
            item.textBoxNameItem.Text = db.Rows[0]["Item Name"].ToString();
            string quantity = MyController.getQuantity(item.ItemNumber.Text);

            item.textBoxQuantity.Text = quantity;
            if (Convert.ToInt16(quantity) <= 0)
                item.buttonPurchase.Enabled = false;

            item.pictureBox1.ImageLocation = @path + "משקוליות יד.jpg";
            item.Show();
        }

        private void ClickBelt(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            item.ItemNumber.Enabled = false;
            item.textBoxNameItem.Enabled = false; ;
            item.textBoxQuantity.Enabled = false;
            item.Price.Enabled = false;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            item.ItemNumber.Text = "6";
            DataTable db = MyController.GetData(item.ItemNumber.Text);
            item.Price.Text = db.Rows[0]["Price"].ToString();
            item.textBoxNameItem.Text = db.Rows[0]["Item Name"].ToString();
            string quantity = MyController.getQuantity(item.ItemNumber.Text);

            item.textBoxQuantity.Text = quantity;
            if (Convert.ToInt16(quantity) <= 0)
                item.buttonPurchase.Enabled = false;

            item.pictureBox1.ImageLocation = @path +  "חגורה קטנה.png";
            item.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmTrainee TRAINEE = new frmTrainee();
            TRAINEE.Show();
            this.Close();
        }
    }

    
}
