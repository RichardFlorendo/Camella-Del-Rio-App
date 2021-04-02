namespace WindowsFormsApp1
{
    partial class pm_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pm_form));
            this.greet_lb = new System.Windows.Forms.Label();
            this.namepm_lb = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greet_lb
            // 
            this.greet_lb.AutoSize = true;
            this.greet_lb.BackColor = System.Drawing.Color.Transparent;
            this.greet_lb.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_lb.Location = new System.Drawing.Point(22, 27);
            this.greet_lb.Name = "greet_lb";
            this.greet_lb.Size = new System.Drawing.Size(125, 35);
            this.greet_lb.TabIndex = 0;
            this.greet_lb.Text = "Welcome";
            // 
            // namepm_lb
            // 
            this.namepm_lb.AutoSize = true;
            this.namepm_lb.BackColor = System.Drawing.Color.Transparent;
            this.namepm_lb.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namepm_lb.Location = new System.Drawing.Point(142, 27);
            this.namepm_lb.Name = "namepm_lb";
            this.namepm_lb.Size = new System.Drawing.Size(164, 35);
            this.namepm_lb.TabIndex = 1;
            this.namepm_lb.Text = "name of pm!";
            // 
            // search_button
            // 
            this.search_button.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_button.Location = new System.Drawing.Point(1010, 12);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(56, 47);
            this.search_button.TabIndex = 3;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // pm_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 736);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.namepm_lb);
            this.Controls.Add(this.greet_lb);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pm_form";
            this.Text = "Camella Del Rio Hitup";
            this.Load += new System.EventHandler(this.pm_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greet_lb;
        private System.Windows.Forms.Label namepm_lb;
        private System.Windows.Forms.Button search_button;
    }
}