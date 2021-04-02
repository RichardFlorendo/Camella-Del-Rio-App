namespace WindowsFormsApp1
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.loginin_button = new System.Windows.Forms.Button();
            this.fpassowrd_linklb = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.username_tb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username_tb.BackColor = System.Drawing.Color.LightGray;
            this.username_tb.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.ForeColor = System.Drawing.Color.DimGray;
            this.username_tb.Location = new System.Drawing.Point(110, 143);
            this.username_tb.MaximumSize = new System.Drawing.Size(350, 40);
            this.username_tb.MinimumSize = new System.Drawing.Size(350, 40);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(350, 61);
            this.username_tb.TabIndex = 0;
            this.username_tb.Text = "Username";
            // 
            // password_tb
            // 
            this.password_tb.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.password_tb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password_tb.BackColor = System.Drawing.Color.LightGray;
            this.password_tb.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.ForeColor = System.Drawing.Color.DimGray;
            this.password_tb.Location = new System.Drawing.Point(110, 265);
            this.password_tb.MaximumSize = new System.Drawing.Size(350, 40);
            this.password_tb.MinimumSize = new System.Drawing.Size(350, 40);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(350, 61);
            this.password_tb.TabIndex = 2;
            this.password_tb.Text = "password";
            this.password_tb.UseSystemPasswordChar = true;
            // 
            // loginin_button
            // 
            this.loginin_button.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.loginin_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginin_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginin_button.BackColor = System.Drawing.Color.Transparent;
            this.loginin_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginin_button.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginin_button.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.loginin_button.Location = new System.Drawing.Point(179, 352);
            this.loginin_button.Name = "loginin_button";
            this.loginin_button.Size = new System.Drawing.Size(134, 49);
            this.loginin_button.TabIndex = 4;
            this.loginin_button.Text = "Login";
            this.loginin_button.UseVisualStyleBackColor = false;
            this.loginin_button.Click += new System.EventHandler(this.loginin_button_Click);
            // 
            // fpassowrd_linklb
            // 
            this.fpassowrd_linklb.ActiveLinkColor = System.Drawing.Color.Aquamarine;
            this.fpassowrd_linklb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fpassowrd_linklb.BackColor = System.Drawing.Color.Transparent;
            this.fpassowrd_linklb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fpassowrd_linklb.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpassowrd_linklb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fpassowrd_linklb.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.fpassowrd_linklb.Location = new System.Drawing.Point(135, 497);
            this.fpassowrd_linklb.Name = "fpassowrd_linklb";
            this.fpassowrd_linklb.Size = new System.Drawing.Size(233, 32);
            this.fpassowrd_linklb.TabIndex = 7;
            this.fpassowrd_linklb.TabStop = true;
            this.fpassowrd_linklb.Text = "Forgot your password?";
            this.fpassowrd_linklb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fpassowrd_linklb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fpassowrd_linklb_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 74);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(31, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 74);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 553);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fpassowrd_linklb);
            this.Controls.Add(this.loginin_button);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "login_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camella Del Rio Hitup";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button loginin_button;
        private System.Windows.Forms.LinkLabel fpassowrd_linklb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

