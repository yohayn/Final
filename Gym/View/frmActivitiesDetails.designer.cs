namespace Gym
{
    partial class frmActivitiesDetails
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDay = new System.Windows.Forms.TextBox();
            this.txtBoxHour = new System.Windows.Forms.TextBox();
            this.txtBoxGuide = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(12, 332);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 6;
            this.btnGoBack.Text = "back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(647, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 160);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(260, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Day";
            // 
            // txtBoxDay
            // 
            this.txtBoxDay.Location = new System.Drawing.Point(221, 96);
            this.txtBoxDay.Name = "txtBoxDay";
            this.txtBoxDay.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDay.TabIndex = 11;
            // 
            // txtBoxHour
            // 
            this.txtBoxHour.Location = new System.Drawing.Point(342, 96);
            this.txtBoxHour.Name = "txtBoxHour";
            this.txtBoxHour.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHour.TabIndex = 12;
            // 
            // txtBoxGuide
            // 
            this.txtBoxGuide.Location = new System.Drawing.Point(468, 96);
            this.txtBoxGuide.Name = "txtBoxGuide";
            this.txtBoxGuide.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGuide.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(377, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(489, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Guide";
            // 
            // frmActivitiesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxGuide);
            this.Controls.Add(this.txtBoxHour);
            this.Controls.Add(this.txtBoxDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGoBack);
            this.Name = "frmActivitiesDetails";
            this.Text = "frmActivitiesDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDay;
        private System.Windows.Forms.TextBox txtBoxHour;
        private System.Windows.Forms.TextBox txtBoxGuide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}