namespace Gym
{
    partial class frmTrainee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGoToFrmActivities = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGoToFrmShop = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToFrmActivities
            // 
            this.btnGoToFrmActivities.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoToFrmActivities.Location = new System.Drawing.Point(236, 265);
            this.btnGoToFrmActivities.Name = "btnGoToFrmActivities";
            this.btnGoToFrmActivities.Size = new System.Drawing.Size(152, 60);
            this.btnGoToFrmActivities.TabIndex = 9;
            this.btnGoToFrmActivities.Text = "צפייה בפעילויות חדר הכושר";
            this.btnGoToFrmActivities.UseVisualStyleBackColor = false;
            this.btnGoToFrmActivities.Click += new System.EventHandler(this.btnGoToFrmActivities_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 60);
            this.button2.TabIndex = 8;
            this.button2.Text = "ניהול תכנית אימונים";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "עדכון נתונים אישיים";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGoToFrmShop
            // 
            this.btnGoToFrmShop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoToFrmShop.Location = new System.Drawing.Point(236, 22);
            this.btnGoToFrmShop.Name = "btnGoToFrmShop";
            this.btnGoToFrmShop.Size = new System.Drawing.Size(152, 60);
            this.btnGoToFrmShop.TabIndex = 6;
            this.btnGoToFrmShop.Text = "מוצרים לרכישה";
            this.btnGoToFrmShop.UseVisualStyleBackColor = false;
            this.btnGoToFrmShop.Click += new System.EventHandler(this.btnGoToFrmShop_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(41, 380);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 5;
            this.btnGoBack.Text = "back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // frmTrainee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.btnGoToFrmActivities);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoToFrmShop);
            this.Controls.Add(this.btnGoBack);
            this.Name = "frmTrainee";
            this.Text = "Trainee Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToFrmActivities;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGoToFrmShop;
        private System.Windows.Forms.Button btnGoBack;
    }
}