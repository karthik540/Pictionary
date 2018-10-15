namespace WindowsFormsApp1
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.header_text = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextbox2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextbox3 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dob = new Bunifu.Framework.UI.BunifuDatepicker();
            this.progress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomTextbox4 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomTextbox5 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.login_button = new System.Windows.Forms.Button();
            this.bunifuCustomTextbox6 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // header_text
            // 
            this.header_text.AutoSize = true;
            this.header_text.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_text.ForeColor = System.Drawing.Color.White;
            this.header_text.Location = new System.Drawing.Point(255, 18);
            this.header_text.Name = "header_text";
            this.header_text.Size = new System.Drawing.Size(102, 33);
            this.header_text.TabIndex = 0;
            this.header_text.Text = "Sign Up";
            this.header_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.header_text.Click += new System.EventHandler(this.header_text_Click);
            // 
            // close_button
            // 
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.Location = new System.Drawing.Point(506, 486);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(36, 36);
            this.close_button.TabIndex = 2;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(116, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to the Pictionary ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(213, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Application";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(380, 138);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(35, 423);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username.ForeColor = System.Drawing.Color.SeaGreen;
            this.username.HintForeColor = System.Drawing.Color.SkyBlue;
            this.username.HintText = "Username";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.username.LineIdleColor = System.Drawing.Color.Gray;
            this.username.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.username.LineThickness = 3;
            this.username.Location = new System.Drawing.Point(194, 184);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(182, 33);
            this.username.TabIndex = 8;
            this.username.Text = "eg : Furyswordxd540";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.SeaGreen;
            this.password.HintForeColor = System.Drawing.Color.SkyBlue;
            this.password.HintText = "abcdefg";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(194, 249);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(182, 33);
            this.password.TabIndex = 8;
            this.password.Text = "Username";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(40, 191);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(147, 22);
            this.bunifuCustomTextbox1.TabIndex = 9;
            this.bunifuCustomTextbox1.Text = "Username :";
            this.bunifuCustomTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomTextbox2
            // 
            this.bunifuCustomTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.bunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCustomTextbox2.Location = new System.Drawing.Point(40, 256);
            this.bunifuCustomTextbox2.Name = "bunifuCustomTextbox2";
            this.bunifuCustomTextbox2.Size = new System.Drawing.Size(147, 22);
            this.bunifuCustomTextbox2.TabIndex = 9;
            this.bunifuCustomTextbox2.Text = "Password :";
            this.bunifuCustomTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomTextbox3
            // 
            this.bunifuCustomTextbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.bunifuCustomTextbox3.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox3.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCustomTextbox3.Location = new System.Drawing.Point(12, 323);
            this.bunifuCustomTextbox3.Name = "bunifuCustomTextbox3";
            this.bunifuCustomTextbox3.Size = new System.Drawing.Size(164, 22);
            this.bunifuCustomTextbox3.TabIndex = 9;
            this.bunifuCustomTextbox3.Text = "Date of Birth :";
            this.bunifuCustomTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dob
            // 
            this.dob.BackColor = System.Drawing.Color.SeaGreen;
            this.dob.BorderRadius = 0;
            this.dob.ForeColor = System.Drawing.Color.White;
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dob.FormatCustom = null;
            this.dob.Location = new System.Drawing.Point(194, 323);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(182, 39);
            this.dob.TabIndex = 10;
            this.dob.Value = new System.DateTime(2018, 2, 24, 20, 48, 41, 454);
            // 
            // progress
            // 
            this.progress.animated = false;
            this.progress.animationIterval = 5;
            this.progress.animationSpeed = 300;
            this.progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress.BackgroundImage")));
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progress.ForeColor = System.Drawing.Color.SeaGreen;
            this.progress.LabelVisible = true;
            this.progress.LineProgressThickness = 8;
            this.progress.LineThickness = 5;
            this.progress.Location = new System.Drawing.Point(440, 184);
            this.progress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progress.MaxValue = 100;
            this.progress.Name = "progress";
            this.progress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.progress.Size = new System.Drawing.Size(138, 138);
            this.progress.TabIndex = 12;
            this.progress.Value = 0;
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.LightSkyBlue;
            this.check.ChechedOffColor = System.Drawing.Color.LightSkyBlue;
            this.check.Checked = false;
            this.check.CheckedOnColor = System.Drawing.Color.DeepSkyBlue;
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(40, 498);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(20, 20);
            this.check.TabIndex = 13;
            // 
            // bunifuCustomTextbox4
            // 
            this.bunifuCustomTextbox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.bunifuCustomTextbox4.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox4.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox4.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox4.Location = new System.Drawing.Point(76, 498);
            this.bunifuCustomTextbox4.Multiline = true;
            this.bunifuCustomTextbox4.Name = "bunifuCustomTextbox4";
            this.bunifuCustomTextbox4.Size = new System.Drawing.Size(272, 46);
            this.bunifuCustomTextbox4.TabIndex = 14;
            this.bunifuCustomTextbox4.Text = "I agree to the terms and policy of the Codeit Association";
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email.ForeColor = System.Drawing.Color.SeaGreen;
            this.email.HintForeColor = System.Drawing.Color.SkyBlue;
            this.email.HintText = "abc@gmail.com";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.email.LineIdleColor = System.Drawing.Color.Gray;
            this.email.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(194, 411);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(182, 33);
            this.email.TabIndex = 8;
            this.email.Text = "eg : abc@gmail.com";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomTextbox5
            // 
            this.bunifuCustomTextbox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.bunifuCustomTextbox5.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox5.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCustomTextbox5.Location = new System.Drawing.Point(40, 418);
            this.bunifuCustomTextbox5.Name = "bunifuCustomTextbox5";
            this.bunifuCustomTextbox5.Size = new System.Drawing.Size(147, 22);
            this.bunifuCustomTextbox5.TabIndex = 9;
            this.bunifuCustomTextbox5.Text = "Email Id :";
            this.bunifuCustomTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_button
            // 
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(473, 448);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(86, 32);
            this.login_button.TabIndex = 16;
            this.login_button.Text = "Sign Up";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // bunifuCustomTextbox6
            // 
            this.bunifuCustomTextbox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.bunifuCustomTextbox6.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox6.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCustomTextbox6.Location = new System.Drawing.Point(430, 347);
            this.bunifuCustomTextbox6.Multiline = true;
            this.bunifuCustomTextbox6.Name = "bunifuCustomTextbox6";
            this.bunifuCustomTextbox6.Size = new System.Drawing.Size(164, 74);
            this.bunifuCustomTextbox6.TabIndex = 9;
            this.bunifuCustomTextbox6.Text = "Fill in your details";
            this.bunifuCustomTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.header_text);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.bunifuCustomTextbox4);
            this.Controls.Add(this.check);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.bunifuCustomTextbox6);
            this.Controls.Add(this.bunifuCustomTextbox3);
            this.Controls.Add(this.bunifuCustomTextbox5);
            this.Controls.Add(this.bunifuCustomTextbox2);
            this.Controls.Add(this.bunifuCustomTextbox1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header_text;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox3;
        private Bunifu.Framework.UI.BunifuDatepicker dob;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progress;
        private Bunifu.Framework.UI.BunifuCheckbox check;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox5;
        private System.Windows.Forms.Button login_button;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox6;
    }
}