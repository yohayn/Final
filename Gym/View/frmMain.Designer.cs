namespace Gym
{
    partial class frmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoTofrmTrainee = new System.Windows.Forms.Button();
            this.btnGoTofrmManager = new System.Windows.Forms.Button();
            this.btnGoTofrmSecretary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(5, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Manager";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Trainee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Secretary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Please choose wanted interface";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome WorkIT Gym application";
            // 
            // btnGoTofrmTrainee
            // 
            this.btnGoTofrmTrainee.Image = global::Gym.Properties.Resources.Trainee;
            this.btnGoTofrmTrainee.Location = new System.Drawing.Point(305, 123);
            this.btnGoTofrmTrainee.Name = "btnGoTofrmTrainee";
            this.btnGoTofrmTrainee.Size = new System.Drawing.Size(204, 314);
            this.btnGoTofrmTrainee.TabIndex = 12;
            this.btnGoTofrmTrainee.Text = "Trainee";
            this.btnGoTofrmTrainee.UseVisualStyleBackColor = true;
            this.btnGoTofrmTrainee.Click += new System.EventHandler(this.btnGoTofrmTrainee_Click);
            // 
            // btnGoTofrmManager
            // 
            this.btnGoTofrmManager.Image = global::Gym.Properties.Resources.Manager;
            this.btnGoTofrmManager.Location = new System.Drawing.Point(554, 157);
            this.btnGoTofrmManager.Name = "btnGoTofrmManager";
            this.btnGoTofrmManager.Size = new System.Drawing.Size(188, 247);
            this.btnGoTofrmManager.TabIndex = 11;
            this.btnGoTofrmManager.UseVisualStyleBackColor = true;
            this.btnGoTofrmManager.Click += new System.EventHandler(this.btnGoTofrmManager_Click);
            // 
            // btnGoTofrmSecretary
            // 
            this.btnGoTofrmSecretary.Image = global::Gym.Properties.Resources.secretary;
            this.btnGoTofrmSecretary.Location = new System.Drawing.Point(5, 167);
            this.btnGoTofrmSecretary.Name = "btnGoTofrmSecretary";
            this.btnGoTofrmSecretary.Size = new System.Drawing.Size(258, 198);
            this.btnGoTofrmSecretary.TabIndex = 10;
            this.btnGoTofrmSecretary.UseVisualStyleBackColor = true;
            this.btnGoTofrmSecretary.Click += new System.EventHandler(this.btnGoTofrmSecretary_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 627);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoTofrmTrainee);
            this.Controls.Add(this.btnGoTofrmManager);
            this.Controls.Add(this.btnGoTofrmSecretary);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoTofrmTrainee;
        private System.Windows.Forms.Button btnGoTofrmManager;
        private System.Windows.Forms.Button btnGoTofrmSecretary;
    }
}