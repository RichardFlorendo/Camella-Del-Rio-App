namespace WindowsFormsApp1
{
    partial class signin_form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin_form1));
            this.fname_lb = new System.Windows.Forms.Label();
            this.fname_tb = new System.Windows.Forms.TextBox();
            this.mname_lb = new System.Windows.Forms.Label();
            this.mname_tb = new System.Windows.Forms.TextBox();
            this.lname_lb = new System.Windows.Forms.Label();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.address_lb = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.cnumber_lb = new System.Windows.Forms.Label();
            this.cnumber_tb = new System.Windows.Forms.TextBox();
            this.tnumber_lb = new System.Windows.Forms.Label();
            this.tnumber_tb = new System.Windows.Forms.TextBox();
            this.next_button1 = new System.Windows.Forms.Button();
            this.signup_lb1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.BackColor = System.Drawing.Color.Transparent;
            this.fname_lb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_lb.Location = new System.Drawing.Point(75, 74);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(115, 24);
            this.fname_lb.TabIndex = 0;
            this.fname_lb.Text = "First Name:";
            // 
            // fname_tb
            // 
            this.fname_tb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_tb.Location = new System.Drawing.Point(280, 74);
            this.fname_tb.MaximumSize = new System.Drawing.Size(415, 24);
            this.fname_tb.MinimumSize = new System.Drawing.Size(415, 24);
            this.fname_tb.Name = "fname_tb";
            this.fname_tb.Size = new System.Drawing.Size(415, 32);
            this.fname_tb.TabIndex = 1;
            // 
            // mname_lb
            // 
            this.mname_lb.AutoSize = true;
            this.mname_lb.BackColor = System.Drawing.Color.Transparent;
            this.mname_lb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mname_lb.Location = new System.Drawing.Point(75, 133);
            this.mname_lb.Name = "mname_lb";
            this.mname_lb.Size = new System.Drawing.Size(140, 24);
            this.mname_lb.TabIndex = 2;
            this.mname_lb.Text = "Middle Name:";
            // 
            // mname_tb
            // 
            this.mname_tb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mname_tb.Location = new System.Drawing.Point(280, 133);
            this.mname_tb.MaximumSize = new System.Drawing.Size(415, 24);
            this.mname_tb.MinimumSize = new System.Drawing.Size(415, 24);
            this.mname_tb.Name = "mname_tb";
            this.mname_tb.Size = new System.Drawing.Size(415, 32);
            this.mname_tb.TabIndex = 3;
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.BackColor = System.Drawing.Color.Transparent;
            this.lname_lb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lb.Location = new System.Drawing.Point(75, 197);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(112, 24);
            this.lname_lb.TabIndex = 4;
            this.lname_lb.Text = "Last Name:";
            this.lname_lb.Click += new System.EventHandler(this.lname_tb_Click);
            // 
            // lname_tb
            // 
            this.lname_tb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_tb.Location = new System.Drawing.Point(280, 197);
            this.lname_tb.MaximumSize = new System.Drawing.Size(415, 24);
            this.lname_tb.MinimumSize = new System.Drawing.Size(415, 24);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.Size = new System.Drawing.Size(415, 32);
            this.lname_tb.TabIndex = 5;
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.BackColor = System.Drawing.Color.Transparent;
            this.address_lb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lb.Location = new System.Drawing.Point(75, 405);
            this.address_lb.Name = "address_lb";
            this.address_lb.Size = new System.Drawing.Size(89, 24);
            this.address_lb.TabIndex = 6;
            this.address_lb.Text = "Address:";
            // 
            // address_tb
            // 
            this.address_tb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_tb.Location = new System.Drawing.Point(280, 405);
            this.address_tb.MaximumSize = new System.Drawing.Size(415, 24);
            this.address_tb.MinimumSize = new System.Drawing.Size(415, 24);
            this.address_tb.Multiline = true;
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(415, 24);
            this.address_tb.TabIndex = 7;
            // 
            // cnumber_lb
            // 
            this.cnumber_lb.AutoSize = true;
            this.cnumber_lb.BackColor = System.Drawing.Color.Transparent;
            this.cnumber_lb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnumber_lb.Location = new System.Drawing.Point(75, 266);
            this.cnumber_lb.Name = "cnumber_lb";
            this.cnumber_lb.Size = new System.Drawing.Size(166, 24);
            this.cnumber_lb.TabIndex = 8;
            this.cnumber_lb.Text = "Contact Number:";
            // 
            // cnumber_tb
            // 
            this.cnumber_tb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnumber_tb.Location = new System.Drawing.Point(280, 266);
            this.cnumber_tb.MaximumSize = new System.Drawing.Size(415, 24);
            this.cnumber_tb.MinimumSize = new System.Drawing.Size(415, 24);
            this.cnumber_tb.Name = "cnumber_tb";
            this.cnumber_tb.Size = new System.Drawing.Size(415, 32);
            this.cnumber_tb.TabIndex = 9;
            // 
            // tnumber_lb
            // 
            this.tnumber_lb.AutoSize = true;
            this.tnumber_lb.BackColor = System.Drawing.Color.Transparent;
            this.tnumber_lb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnumber_lb.Location = new System.Drawing.Point(75, 335);
            this.tnumber_lb.Name = "tnumber_lb";
            this.tnumber_lb.Size = new System.Drawing.Size(191, 24);
            this.tnumber_lb.TabIndex = 10;
            this.tnumber_lb.Text = "Telephone Number:";
            // 
            // tnumber_tb
            // 
            this.tnumber_tb.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnumber_tb.Location = new System.Drawing.Point(280, 335);
            this.tnumber_tb.MaximumSize = new System.Drawing.Size(415, 24);
            this.tnumber_tb.MinimumSize = new System.Drawing.Size(415, 24);
            this.tnumber_tb.Name = "tnumber_tb";
            this.tnumber_tb.Size = new System.Drawing.Size(415, 32);
            this.tnumber_tb.TabIndex = 11;
            // 
            // next_button1
            // 
            this.next_button1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.next_button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.next_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next_button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button1.Location = new System.Drawing.Point(674, 476);
            this.next_button1.Name = "next_button1";
            this.next_button1.Size = new System.Drawing.Size(121, 41);
            this.next_button1.TabIndex = 12;
            this.next_button1.Text = "Next";
            this.next_button1.UseVisualStyleBackColor = false;
            this.next_button1.Click += new System.EventHandler(this.next_button1_Click);
            // 
            // signup_lb1
            // 
            this.signup_lb1.AutoSize = true;
            this.signup_lb1.BackColor = System.Drawing.Color.Transparent;
            this.signup_lb1.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_lb1.ForeColor = System.Drawing.Color.Black;
            this.signup_lb1.Location = new System.Drawing.Point(12, 9);
            this.signup_lb1.Name = "signup_lb1";
            this.signup_lb1.Size = new System.Drawing.Size(202, 32);
            this.signup_lb1.TabIndex = 13;
            this.signup_lb1.Text = "Sign Up Form:";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(93, 476);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 14;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // signin_form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 557);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.signup_lb1);
            this.Controls.Add(this.next_button1);
            this.Controls.Add(this.tnumber_tb);
            this.Controls.Add(this.tnumber_lb);
            this.Controls.Add(this.cnumber_tb);
            this.Controls.Add(this.cnumber_lb);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.address_lb);
            this.Controls.Add(this.lname_tb);
            this.Controls.Add(this.lname_lb);
            this.Controls.Add(this.mname_tb);
            this.Controls.Add(this.mname_lb);
            this.Controls.Add(this.fname_tb);
            this.Controls.Add(this.fname_lb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signin_form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camella Del Rio Hitup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fname_lb;
        private System.Windows.Forms.TextBox fname_tb;
        private System.Windows.Forms.Label mname_lb;
        private System.Windows.Forms.TextBox mname_tb;
        private System.Windows.Forms.Label lname_lb;
        private System.Windows.Forms.TextBox lname_tb;
        private System.Windows.Forms.Label address_lb;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.Label cnumber_lb;
        private System.Windows.Forms.TextBox cnumber_tb;
        private System.Windows.Forms.Label tnumber_lb;
        private System.Windows.Forms.TextBox tnumber_tb;
        private System.Windows.Forms.Button next_button1;
        private System.Windows.Forms.Label signup_lb1;
        private System.Windows.Forms.Button back_button;
    }
}