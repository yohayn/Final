namespace Gym
{
    partial class frmTraineesManagement
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
            this.btnGoBack = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddTrainee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(42, 212);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 9;
            this.btnGoBack.Text = "back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(92, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "הפק דו\"ח מתאמנים";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "מחיקת מתאמן";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "עדכון פרטי מתאמן";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddTrainee
            // 
            this.btnAddTrainee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddTrainee.Location = new System.Drawing.Point(92, 26);
            this.btnAddTrainee.Name = "btnAddTrainee";
            this.btnAddTrainee.Size = new System.Drawing.Size(150, 23);
            this.btnAddTrainee.TabIndex = 5;
            this.btnAddTrainee.Text = "רישום מתאמן";
            this.btnAddTrainee.UseVisualStyleBackColor = false;
            this.btnAddTrainee.Click += new System.EventHandler(this.btnAddTrainee_Click);
            // 
            // frmTraineesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddTrainee);
            this.Name = "frmTraineesManagement";
            this.Text = "TraineesManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddTrainee;
    }
}