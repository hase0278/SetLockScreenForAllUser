namespace SetLockScreenForAllUser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImageView = new System.Windows.Forms.PictureBox();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.SetLockScreenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageView
            // 
            this.ImageView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImageView.Location = new System.Drawing.Point(25, 35);
            this.ImageView.Name = "ImageView";
            this.ImageView.Size = new System.Drawing.Size(580, 222);
            this.ImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageView.TabIndex = 0;
            this.ImageView.TabStop = false;
            // 
            // SelectBtn
            // 
            this.SelectBtn.Location = new System.Drawing.Point(254, 263);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(82, 23);
            this.SelectBtn.TabIndex = 1;
            this.SelectBtn.Text = "Select Image";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // SetLockScreenBtn
            // 
            this.SetLockScreenBtn.Location = new System.Drawing.Point(245, 292);
            this.SetLockScreenBtn.Name = "SetLockScreenBtn";
            this.SetLockScreenBtn.Size = new System.Drawing.Size(101, 23);
            this.SetLockScreenBtn.TabIndex = 2;
            this.SetLockScreenBtn.Text = "Set as lockscreen";
            this.SetLockScreenBtn.UseVisualStyleBackColor = true;
            this.SetLockScreenBtn.Visible = false;
            this.SetLockScreenBtn.Click += new System.EventHandler(this.SetLockScreenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(645, 337);
            this.Controls.Add(this.SetLockScreenBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.ImageView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal Lockscreen Setter";
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageView;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button SetLockScreenBtn;
    }
}

