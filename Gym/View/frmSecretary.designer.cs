namespace GYM
{
    partial class frmSecretary
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
            this.btnGoToFrmAddTrainee = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToFrmAddTrainee
            // 
            this.btnGoToFrmAddTrainee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoToFrmAddTrainee.Location = new System.Drawing.Point(137, 27);
            this.btnGoToFrmAddTrainee.Name = "btnGoToFrmAddTrainee";
            this.btnGoToFrmAddTrainee.Size = new System.Drawing.Size(119, 32);
            this.btnGoToFrmAddTrainee.TabIndex = 0;
            this.btnGoToFrmAddTrainee.Text = "ניהול מתאמנים";
            this.btnGoToFrmAddTrainee.UseVisualStyleBackColor = false;
            this.btnGoToFrmAddTrainee.Click += new System.EventHandler(this.btnGoToFrmAddTrainee_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "ניהול מדריכים";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "ניהול מלאי";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "ניהול פעילויות";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 32);
            this.button5.TabIndex = 4;
            this.button5.Text = "ניהול הודעות";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(32, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 393);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGoToFrmAddTrainee);
            this.Name = "frmSecretary";
            this.Text = "frnSecretary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToFrmAddTrainee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBack;
    }
}