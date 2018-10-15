namespace WindowsFormsApp1.PostLogin
{
    partial class Home
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Get_started_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(165, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(68, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to the Pictionary ";
            // 
            // Get_started_button
            // 
            this.Get_started_button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Get_started_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(94)))), ((int)(((byte)(175)))));
            this.Get_started_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Get_started_button.BorderRadius = 7;
            this.Get_started_button.ButtonText = "                  Get Started";
            this.Get_started_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Get_started_button.DisabledColor = System.Drawing.Color.Gray;
            this.Get_started_button.Iconcolor = System.Drawing.Color.Transparent;
            this.Get_started_button.Iconimage = null;
            this.Get_started_button.Iconimage_right = null;
            this.Get_started_button.Iconimage_right_Selected = null;
            this.Get_started_button.Iconimage_Selected = null;
            this.Get_started_button.IconMarginLeft = 0;
            this.Get_started_button.IconMarginRight = 0;
            this.Get_started_button.IconRightVisible = true;
            this.Get_started_button.IconRightZoom = 0D;
            this.Get_started_button.IconVisible = true;
            this.Get_started_button.IconZoom = 90D;
            this.Get_started_button.IsTab = false;
            this.Get_started_button.Location = new System.Drawing.Point(154, 239);
            this.Get_started_button.Name = "Get_started_button";
            this.Get_started_button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(94)))), ((int)(((byte)(175)))));
            this.Get_started_button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(156)))), ((int)(((byte)(232)))));
            this.Get_started_button.OnHoverTextColor = System.Drawing.Color.Black;
            this.Get_started_button.selected = false;
            this.Get_started_button.Size = new System.Drawing.Size(174, 39);
            this.Get_started_button.TabIndex = 6;
            this.Get_started_button.Text = "                  Get Started";
            this.Get_started_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Get_started_button.Textcolor = System.Drawing.Color.White;
            this.Get_started_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_started_button.Click += new System.EventHandler(this.Get_started_button_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(490, 460);
            this.ControlBox = false;
            this.Controls.Add(this.Get_started_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton Get_started_button;
    }
}