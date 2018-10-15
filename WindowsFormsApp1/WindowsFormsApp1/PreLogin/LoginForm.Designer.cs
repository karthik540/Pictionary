namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.signup_link = new System.Windows.Forms.LinkLabel();
            this.signup_textbox = new System.Windows.Forms.TextBox();
            this.Dropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // signup_link
            // 
            this.signup_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.signup_link.AutoSize = true;
            this.signup_link.Cursor = System.Windows.Forms.Cursors.Default;
            this.signup_link.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.signup_link.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.signup_link.Location = new System.Drawing.Point(332, 480);
            this.signup_link.Name = "signup_link";
            this.signup_link.Size = new System.Drawing.Size(59, 17);
            this.signup_link.TabIndex = 16;
            this.signup_link.TabStop = true;
            this.signup_link.Text = "Sign Up";
            this.signup_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.signup_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_link_LinkClicked);
            // 
            // signup_textbox
            // 
            this.signup_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.signup_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_textbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_textbox.ForeColor = System.Drawing.Color.SkyBlue;
            this.signup_textbox.Location = new System.Drawing.Point(175, 480);
            this.signup_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.signup_textbox.Name = "signup_textbox";
            this.signup_textbox.Size = new System.Drawing.Size(154, 15);
            this.signup_textbox.TabIndex = 15;
            this.signup_textbox.Text = "Don\'t have an account ?";
            // 
            // Dropdown
            // 
            this.Dropdown.BackColor = System.Drawing.Color.Transparent;
            this.Dropdown.BorderRadius = 3;
            this.Dropdown.DisabledColor = System.Drawing.Color.Gray;
            this.Dropdown.ForeColor = System.Drawing.Color.White;
            this.Dropdown.Items = new string[] {
        "I am Robot",
        "I am not a Robot"};
            this.Dropdown.Location = new System.Drawing.Point(395, 420);
            this.Dropdown.Name = "Dropdown";
            this.Dropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Dropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Dropdown.selectedIndex = 0;
            this.Dropdown.Size = new System.Drawing.Size(217, 35);
            this.Dropdown.TabIndex = 14;
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.username.HintForeColor = System.Drawing.Color.SkyBlue;
            this.username.HintText = "Username";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.username.LineIdleColor = System.Drawing.Color.Gray;
            this.username.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.username.LineThickness = 3;
            this.username.Location = new System.Drawing.Point(120, 300);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(379, 33);
            this.username.TabIndex = 13;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // login_button
            // 
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(255, 420);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(86, 32);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Member Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.SkyBlue;
            this.password.HintForeColor = System.Drawing.Color.SkyBlue;
            this.password.HintText = "abcdefg";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(120, 350);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(379, 33);
            this.password.TabIndex = 17;
            this.password.Text = "Username";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.password);
            this.Controls.Add(this.signup_link);
            this.Controls.Add(this.signup_textbox);
            this.Controls.Add(this.Dropdown);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.SkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.LinkLabel signup_link;
        private System.Windows.Forms.TextBox signup_textbox;
        private Bunifu.Framework.UI.BunifuDropdown Dropdown;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
    }
}