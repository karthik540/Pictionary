namespace WindowsFormsApp1.PostLogin
{
    partial class Write
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Write));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Menu_text = new System.Windows.Forms.Label();
            this.Add_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Tick = new Bunifu.Framework.UI.BunifuImageButton();
            this.Write_box = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Add_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).BeginInit();
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
            this.Menu_text.Location = new System.Drawing.Point(206, 9);
            this.Menu_text.Name = "Menu_text";
            this.Menu_text.Size = new System.Drawing.Size(83, 36);
            this.Menu_text.TabIndex = 4;
            this.Menu_text.Text = "Write";
            this.Menu_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.Transparent;
            this.Add_button.Image = ((System.Drawing.Image)(resources.GetObject("Add_button.Image")));
            this.Add_button.ImageActive = null;
            this.Add_button.Location = new System.Drawing.Point(428, 398);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(50, 50);
            this.Add_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Add_button.TabIndex = 5;
            this.Add_button.TabStop = false;
            this.Add_button.Zoom = 10;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Tick
            // 
            this.Tick.BackColor = System.Drawing.Color.Transparent;
            this.Tick.Image = ((System.Drawing.Image)(resources.GetObject("Tick.Image")));
            this.Tick.ImageActive = null;
            this.Tick.Location = new System.Drawing.Point(372, 398);
            this.Tick.Name = "Tick";
            this.Tick.Size = new System.Drawing.Size(50, 50);
            this.Tick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tick.TabIndex = 6;
            this.Tick.TabStop = false;
            this.Tick.Zoom = 10;
            this.Tick.Click += new System.EventHandler(this.Tick_Click);
            // 
            // Write_box
            // 
            this.Write_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Write_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Write_box.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Write_box.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Write_box.Location = new System.Drawing.Point(56, 93);
            this.Write_box.Name = "Write_box";
            this.Write_box.Size = new System.Drawing.Size(379, 274);
            this.Write_box.TabIndex = 10;
            this.Write_box.Text = "Keyword : Description or Meaning`";
            // 
            // Write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(490, 460);
            this.Controls.Add(this.Write_box);
            this.Controls.Add(this.Tick);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Menu_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Write";
            this.Text = "Write";
            ((System.ComponentModel.ISupportInitialize)(this.Add_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton Add_button;
        private System.Windows.Forms.Label Menu_text;
        private Bunifu.Framework.UI.BunifuImageButton Tick;
        private System.Windows.Forms.RichTextBox Write_box;
    }
}