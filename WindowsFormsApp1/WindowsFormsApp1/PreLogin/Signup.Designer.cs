﻿namespace WindowsFormsApp1
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
            this.Signup_button = new System.Windows.Forms.Button();
            this.bunifuCustomTextbox6 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Back_button = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.Back_button)).BeginInit();
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
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(383, 78);
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
            this.username.Location = new System.Drawing.Point(197, 124);
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
            this.password.Location = new System.Drawing.Point(197, 189);
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
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Garamond", 17F);
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(43, 131);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(147, 26);
            this.bunifuCustomTextbox1.TabIndex = 9;
            this.bunifuCustomTextbox1.Text = "Username :";
            this.bunifuCustomTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomTextbox2
            // 
            this.bunifuCustomTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.bunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox2.Font = new System.Drawing.Font("Garamond", 17F);
            this.bunifuCustomTextbox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCustomTextbox2.Location = new System.Drawing.Point(43, 196);
            this.bunifuCustomTextbox2.Name = "bunifuCustomTextbox2";
            this.bunifuCustomTextbox2.Size = new System.Drawing.Size(147, 26);
            this.bunifuCustomTextbox2.TabIndex = 9;
            this.bunifuCustomTextbox2.Text = "Password :";
            this.bunifuCustomTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomTextbox3
            // 
            this.bunifuCustomTextbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.bunifuCustomTextbox3.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox3.Font = new System.Drawing.Font("Garamond", 17F);
            this.bunifuCustomTextbox3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCustomTextbox3.Location = new System.Drawing.Point(15, 263);
            this.bunifuCustomTextbox3.Name = "bunifuCustomTextbox3";
            this.bunifuCustomTextbox3.Size = new System.Drawing.Size(164, 26);
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
            this.dob.Location = new System.Drawing.Point(197, 263);
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
            this.progress.Location = new System.Drawing.Point(443, 124);
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
            this.check.Location = new System.Drawing.Point(43, 438);
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
            this.bunifuCustomTextbox4.Location = new System.Drawing.Point(79, 438);
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
            this.email.Location = new System.Drawing.Point(197, 351);
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
            this.bunifuCustomTextbox5.Font = new System.Drawing.Font("Garamond", 17F);
            this.bunifuCustomTextbox5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCustomTextbox5.Location = new System.Drawing.Point(43, 358);
            this.bunifuCustomTextbox5.Name = "bunifuCustomTextbox5";
            this.bunifuCustomTextbox5.Size = new System.Drawing.Size(147, 26);
            this.bunifuCustomTextbox5.TabIndex = 9;
            this.bunifuCustomTextbox5.Text = "Email Id :";
            this.bunifuCustomTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Signup_button
            // 
            this.Signup_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Signup_button.FlatAppearance.BorderSize = 0;
            this.Signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup_button.Font = new System.Drawing.Font("Garamond", 15F);
            this.Signup_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Signup_button.Location = new System.Drawing.Point(471, 365);
            this.Signup_button.Name = "Signup_button";
            this.Signup_button.Size = new System.Drawing.Size(91, 44);
            this.Signup_button.TabIndex = 16;
            this.Signup_button.Text = "Sign Up";
            this.Signup_button.UseVisualStyleBackColor = true;
            this.Signup_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // bunifuCustomTextbox6
            // 
            this.bunifuCustomTextbox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.bunifuCustomTextbox6.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox6.Font = new System.Drawing.Font("Garamond", 17F);
            this.bunifuCustomTextbox6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCustomTextbox6.Location = new System.Drawing.Point(433, 287);
            this.bunifuCustomTextbox6.Multiline = true;
            this.bunifuCustomTextbox6.Name = "bunifuCustomTextbox6";
            this.bunifuCustomTextbox6.Size = new System.Drawing.Size(164, 74);
            this.bunifuCustomTextbox6.TabIndex = 9;
            this.bunifuCustomTextbox6.Text = "Fill in your details";
            this.bunifuCustomTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.Transparent;
            this.Back_button.Image = ((System.Drawing.Image)(resources.GetObject("Back_button.Image")));
            this.Back_button.ImageActive = null;
            this.Back_button.Location = new System.Drawing.Point(497, 435);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(39, 43);
            this.Back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back_button.TabIndex = 17;
            this.Back_button.TabStop = false;
            this.Back_button.Zoom = 10;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.header_text);
            this.Controls.Add(this.Signup_button);
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)(this.Back_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header_text;
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
        private System.Windows.Forms.Button Signup_button;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox6;
        private Bunifu.Framework.UI.BunifuImageButton Back_button;
    }
}