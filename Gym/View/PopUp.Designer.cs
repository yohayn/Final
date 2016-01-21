namespace Gym.View
{
    partial class PopUp
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
            this.popUpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // popUpLabel
            // 
            this.popUpLabel.AutoSize = true;
            this.popUpLabel.Location = new System.Drawing.Point(56, 13);
            this.popUpLabel.Name = "popUpLabel";
            this.popUpLabel.Size = new System.Drawing.Size(0, 13);
            this.popUpLabel.TabIndex = 0;
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 40);
            this.Controls.Add(this.popUpLabel);
            this.Name = "PopUp";
            this.Text = "PopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label popUpLabel;
    }
}