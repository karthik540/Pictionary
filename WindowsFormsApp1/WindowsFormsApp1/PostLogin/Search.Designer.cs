namespace WindowsFormsApp1.PostLogin
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Menu_text = new System.Windows.Forms.Label();
            this.Search_box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Search_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Write_box = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Search_button)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Menu_text
            // 
            this.Menu_text.AutoSize = true;
            this.Menu_text.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_text.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu_text.Location = new System.Drawing.Point(200, 9);
            this.Menu_text.Name = "Menu_text";
            this.Menu_text.Size = new System.Drawing.Size(96, 36);
            this.Menu_text.TabIndex = 5;
            this.Menu_text.Text = "Search";
            this.Menu_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Search_box
            // 
            this.Search_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_box.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Search_box.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search_box.HintForeColor = System.Drawing.Color.Empty;
            this.Search_box.HintText = "";
            this.Search_box.isPassword = false;
            this.Search_box.LineFocusedColor = System.Drawing.Color.Blue;
            this.Search_box.LineIdleColor = System.Drawing.Color.Gray;
            this.Search_box.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Search_box.LineThickness = 3;
            this.Search_box.Location = new System.Drawing.Point(60, 73);
            this.Search_box.Margin = new System.Windows.Forms.Padding(4);
            this.Search_box.Name = "Search_box";
            this.Search_box.Size = new System.Drawing.Size(199, 33);
            this.Search_box.TabIndex = 7;
            this.Search_box.Text = "Enter the word";
            this.Search_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.Transparent;
            this.Search_button.Image = ((System.Drawing.Image)(resources.GetObject("Search_button.Image")));
            this.Search_button.ImageActive = null;
            this.Search_button.Location = new System.Drawing.Point(289, 73);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(33, 33);
            this.Search_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Search_button.TabIndex = 8;
            this.Search_button.TabStop = false;
            this.Search_button.Zoom = 10;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Write_box
            // 
            this.Write_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Write_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Write_box.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Write_box.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Write_box.Location = new System.Drawing.Point(60, 133);
            this.Write_box.Name = "Write_box";
            this.Write_box.Size = new System.Drawing.Size(379, 274);
            this.Write_box.TabIndex = 9;
            this.Write_box.Text = "Search a word";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(490, 460);
            this.Controls.Add(this.Write_box);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search_box);
            this.Controls.Add(this.Menu_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.Search_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label Menu_text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Search_box;
        private Bunifu.Framework.UI.BunifuImageButton Search_button;
        private System.Windows.Forms.RichTextBox Write_box;
    }
}