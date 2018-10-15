namespace WindowsFormsApp1
{
    partial class Main_control
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_control));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.top_panel = new System.Windows.Forms.Panel();
            this.header_text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit_button = new System.Windows.Forms.Button();
            this.side_panel = new System.Windows.Forms.Panel();
            this.Write_option = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Menu_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Exit_option = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Signout_option = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Settings_option = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Search_option = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Home_option = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Menu_text = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Menu_Animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Panel_Animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.header_text);
            this.top_panel.Controls.Add(this.pictureBox1);
            this.top_panel.Controls.Add(this.Exit_button);
            this.Panel_Animation.SetDecoration(this.top_panel, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Animation.SetDecoration(this.top_panel, BunifuAnimatorNS.DecorationType.None);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(700, 40);
            this.top_panel.TabIndex = 0;
            // 
            // header_text
            // 
            this.header_text.AutoSize = true;
            this.Menu_Animation.SetDecoration(this.header_text, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animation.SetDecoration(this.header_text, BunifuAnimatorNS.DecorationType.None);
            this.header_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_text.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_text.ForeColor = System.Drawing.Color.White;
            this.header_text.Location = new System.Drawing.Point(43, 0);
            this.header_text.Name = "header_text";
            this.header_text.Size = new System.Drawing.Size(131, 36);
            this.header_text.TabIndex = 1;
            this.header_text.Text = "Pictionary";
            this.header_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Menu_Animation.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animation.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Exit_button
            // 
            this.Menu_Animation.SetDecoration(this.Exit_button, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animation.SetDecoration(this.Exit_button, BunifuAnimatorNS.DecorationType.None);
            this.Exit_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_button.FlatAppearance.BorderSize = 0;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.Exit_button.Location = new System.Drawing.Point(664, 0);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(36, 40);
            this.Exit_button.TabIndex = 2;
            this.Exit_button.Text = "X";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.side_panel.Controls.Add(this.Write_option);
            this.side_panel.Controls.Add(this.Menu_Button);
            this.side_panel.Controls.Add(this.Exit_option);
            this.side_panel.Controls.Add(this.Signout_option);
            this.side_panel.Controls.Add(this.Settings_option);
            this.side_panel.Controls.Add(this.Search_option);
            this.side_panel.Controls.Add(this.Home_option);
            this.side_panel.Controls.Add(this.Menu_text);
            this.Panel_Animation.SetDecoration(this.side_panel, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Animation.SetDecoration(this.side_panel, BunifuAnimatorNS.DecorationType.None);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 40);
            this.side_panel.Name = "side_panel";
            this.side_panel.Padding = new System.Windows.Forms.Padding(2);
            this.side_panel.Size = new System.Drawing.Size(215, 460);
            this.side_panel.TabIndex = 1;
            // 
            // Write_option
            // 
            this.Write_option.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Write_option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Write_option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Write_option.BorderRadius = 0;
            this.Write_option.ButtonText = "   Write";
            this.Write_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Animation.SetDecoration(this.Write_option, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Animation.SetDecoration(this.Write_option, BunifuAnimatorNS.DecorationType.None);
            this.Write_option.DisabledColor = System.Drawing.Color.Gray;
            this.Write_option.Iconcolor = System.Drawing.Color.Transparent;
            this.Write_option.Iconimage = ((System.Drawing.Image)(resources.GetObject("Write_option.Iconimage")));
            this.Write_option.Iconimage_right = null;
            this.Write_option.Iconimage_right_Selected = null;
            this.Write_option.Iconimage_Selected = null;
            this.Write_option.IconMarginLeft = 0;
            this.Write_option.IconMarginRight = 0;
            this.Write_option.IconRightVisible = true;
            this.Write_option.IconRightZoom = 0D;
            this.Write_option.IconVisible = true;
            this.Write_option.IconZoom = 90D;
            this.Write_option.IsTab = false;
            this.Write_option.Location = new System.Drawing.Point(-2, 118);
            this.Write_option.Name = "Write_option";
            this.Write_option.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Write_option.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Write_option.OnHoverTextColor = System.Drawing.Color.White;
            this.Write_option.selected = false;
            this.Write_option.Size = new System.Drawing.Size(217, 49);
            this.Write_option.TabIndex = 0;
            this.Write_option.Text = "   Write";
            this.Write_option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Write_option.Textcolor = System.Drawing.Color.White;
            this.Write_option.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Write_option.Click += new System.EventHandler(this.Write_option_Click_1);
            // 
            // Menu_Button
            // 
            this.Menu_Button.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Animation.SetDecoration(this.Menu_Button, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Animation.SetDecoration(this.Menu_Button, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu_Button.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Button.Image")));
            this.Menu_Button.ImageActive = null;
            this.Menu_Button.Location = new System.Drawing.Point(161, 2);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(52, 38);
            this.Menu_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Menu_Button.TabIndex = 4;
            this.Menu_Button.TabStop = false;
            this.Menu_Button.Zoom = 10;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click_1);
            // 
            // Exit_option
            // 
            this.Exit_option.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Exit_option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Exit_option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_option.BorderRadius = 0;
            this.Exit_option.ButtonText = "   Exit";
            this.Exit_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Animation.SetDecoration(this.Exit_option, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Animation.SetDecoration(this.Exit_option, BunifuAnimatorNS.DecorationType.None);
            this.Exit_option.DisabledColor = System.Drawing.Color.Gray;
            this.Exit_option.Iconcolor = System.Drawing.Color.Transparent;
            this.Exit_option.Iconimage = ((System.Drawing.Image)(resources.GetObject("Exit_option.Iconimage")));
            this.Exit_option.Iconimage_right = null;
            this.Exit_option.Iconimage_right_Selected = null;
            this.Exit_option.Iconimage_Selected = null;
            this.Exit_option.IconMarginLeft = 0;
            this.Exit_option.IconMarginRight = 0;
            this.Exit_option.IconRightVisible = true;
            this.Exit_option.IconRightZoom = 0D;
            this.Exit_option.IconVisible = true;
            this.Exit_option.IconZoom = 90D;
            this.Exit_option.IsTab = false;
            this.Exit_option.Location = new System.Drawing.Point(-2, 338);
            this.Exit_option.Name = "Exit_option";
            this.Exit_option.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Exit_option.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Exit_option.OnHoverTextColor = System.Drawing.Color.White;
            this.Exit_option.selected = false;
            this.Exit_option.Size = new System.Drawing.Size(215, 49);
            this.Exit_option.TabIndex = 2;
            this.Exit_option.Text = "   Exit";
            this.Exit_option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_option.Textcolor = System.Drawing.Color.White;
            this.Exit_option.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_option.Click += new System.EventHandler(this.Exit_option_Click);
            // 
            // Signout_option
            // 
            this.Signout_option.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Signout_option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Signout_option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Signout_option.BorderRadius = 0;
            this.Signout_option.ButtonText = "   Sign out";
            this.Signout_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Animation.SetDecoration(this.Signout_option, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Animation.SetDecoration(this.Signout_option, BunifuAnimatorNS.DecorationType.None);
            this.Signout_option.DisabledColor = System.Drawing.Color.Gray;
            this.Signout_option.Iconcolor = System.Drawing.Color.Transparent;
            this.Signout_option.Iconimage = ((System.Drawing.Image)(resources.GetObject("Signout_option.Iconimage")));
            this.Signout_option.Iconimage_right = null;
            this.Signout_option.Iconimage_right_Selected = null;
            this.Signout_option.Iconimage_Selected = null;
            this.Signout_option.IconMarginLeft = 0;
            this.Signout_option.IconMarginRight = 0;
            this.Signout_option.IconRightVisible = true;
            this.Signout_option.IconRightZoom = 0D;
            this.Signout_option.IconVisible = true;
            this.Signout_option.IconZoom = 90D;
            this.Signout_option.IsTab = false;
            this.Signout_option.Location = new System.Drawing.Point(-2, 283);
            this.Signout_option.Name = "Signout_option";
            this.Signout_option.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Signout_option.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Signout_option.OnHoverTextColor = System.Drawing.Color.White;
            this.Signout_option.selected = false;
            this.Signout_option.Size = new System.Drawing.Size(215, 49);
            this.Signout_option.TabIndex = 2;
            this.Signout_option.Text = "   Sign out";
            this.Signout_option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Signout_option.Textcolor = System.Drawing.Color.White;
            this.Signout_option.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signout_option.Click += new System.EventHandler(this.Signout_option_Click);
            // 
            // Settings_option
            // 
            this.Settings_option.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Settings_option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Settings_option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings_option.BorderRadius = 0;
            this.Settings_option.ButtonText = "   Settings";
            this.Settings_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Animation.SetDecoration(this.Settings_option, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Animation.SetDecoration(this.Settings_option, BunifuAnimatorNS.DecorationType.None);
            this.Settings_option.DisabledColor = System.Drawing.Color.Gray;
            this.Settings_option.Iconcolor = System.Drawing.Color.Transparent;
            this.Settings_option.Iconimage = ((System.Drawing.Image)(resources.GetObject("Settings_option.Iconimage")));
            this.Settings_option.Iconimage_right = null;
            this.Settings_option.Iconimage_right_Selected = null;
            this.Settings_option.Iconimage_Selected = null;
            this.Settings_option.IconMarginLeft = 0;
            this.Settings_option.IconMarginRight = 0;
            this.Settings_option.IconRightVisible = true;
            this.Settings_option.IconRightZoom = 0D;
            this.Settings_option.IconVisible = true;
            this.Settings_option.IconZoom = 90D;
            this.Settings_option.IsTab = false;
            this.Settings_option.Location = new System.Drawing.Point(-2, 228);
            this.Settings_option.Name = "Settings_option";
            this.Settings_option.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Settings_option.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Settings_option.OnHoverTextColor = System.Drawing.Color.White;
            this.Settings_option.selected = false;
            this.Settings_option.Size = new System.Drawing.Size(215, 49);
            this.Settings_option.TabIndex = 2;
            this.Settings_option.Text = "   Settings";
            this.Settings_option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_option.Textcolor = System.Drawing.Color.White;
            this.Settings_option.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_option.Click += new System.EventHandler(this.Settings_option_Click);
            // 
            // Search_option
            // 
            this.Search_option.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Search_option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Search_option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search_option.BorderRadius = 0;
            this.Search_option.ButtonText = "   Search";
            this.Search_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Animation.SetDecoration(this.Search_option, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Animation.SetDecoration(this.Search_option, BunifuAnimatorNS.DecorationType.None);
            this.Search_option.DisabledColor = System.Drawing.Color.Gray;
            this.Search_option.Iconcolor = System.Drawing.Color.Transparent;
            this.Search_option.Iconimage = ((System.Drawing.Image)(resources.GetObject("Search_option.Iconimage")));
            this.Search_option.Iconimage_right = null;
            this.Search_option.Iconimage_right_Selected = null;
            this.Search_option.Iconimage_Selected = null;
            this.Search_option.IconMarginLeft = 0;
            this.Search_option.IconMarginRight = 0;
            this.Search_option.IconRightVisible = true;
            this.Search_option.IconRightZoom = 0D;
            this.Search_option.IconVisible = true;
            this.Search_option.IconZoom = 90D;
            this.Search_option.IsTab = false;
            this.Search_option.Location = new System.Drawing.Point(-2, 173);
            this.Search_option.Name = "Search_option";
            this.Search_option.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Search_option.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Search_option.OnHoverTextColor = System.Drawing.Color.White;
            this.Search_option.selected = false;
            this.Search_option.Size = new System.Drawing.Size(215, 49);
            this.Search_option.TabIndex = 2;
            this.Search_option.Text = "   Search";
            this.Search_option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search_option.Textcolor = System.Drawing.Color.White;
            this.Search_option.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_option.Click += new System.EventHandler(this.Search_option_Click);
            // 
            // Home_option
            // 
            this.Home_option.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Home_option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Home_option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home_option.BorderRadius = 0;
            this.Home_option.ButtonText = "   Home";
            this.Home_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Animation.SetDecoration(this.Home_option, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Animation.SetDecoration(this.Home_option, BunifuAnimatorNS.DecorationType.None);
            this.Home_option.DisabledColor = System.Drawing.Color.Gray;
            this.Home_option.Iconcolor = System.Drawing.Color.Transparent;
            this.Home_option.Iconimage = ((System.Drawing.Image)(resources.GetObject("Home_option.Iconimage")));
            this.Home_option.Iconimage_right = null;
            this.Home_option.Iconimage_right_Selected = null;
            this.Home_option.Iconimage_Selected = null;
            this.Home_option.IconMarginLeft = 0;
            this.Home_option.IconMarginRight = 0;
            this.Home_option.IconRightVisible = true;
            this.Home_option.IconRightZoom = 0D;
            this.Home_option.IconVisible = true;
            this.Home_option.IconZoom = 90D;
            this.Home_option.IsTab = false;
            this.Home_option.Location = new System.Drawing.Point(0, 63);
            this.Home_option.Name = "Home_option";
            this.Home_option.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Home_option.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Home_option.OnHoverTextColor = System.Drawing.Color.White;
            this.Home_option.selected = false;
            this.Home_option.Size = new System.Drawing.Size(215, 49);
            this.Home_option.TabIndex = 2;
            this.Home_option.Text = "   Home";
            this.Home_option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_option.Textcolor = System.Drawing.Color.White;
            this.Home_option.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_option.Click += new System.EventHandler(this.Home_option_Click);
            // 
            // Menu_text
            // 
            this.Menu_text.AutoSize = true;
            this.Menu_Animation.SetDecoration(this.Menu_text, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animation.SetDecoration(this.Menu_text, BunifuAnimatorNS.DecorationType.None);
            this.Menu_text.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_text.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_text.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu_text.Location = new System.Drawing.Point(2, 2);
            this.Menu_text.Name = "Menu_text";
            this.Menu_text.Size = new System.Drawing.Size(159, 36);
            this.Menu_text.TabIndex = 2;
            this.Menu_text.Text = "Menu         ";
            this.Menu_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.top_panel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Menu_Animation
            // 
            this.Menu_Animation.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.Menu_Animation.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.Menu_Animation.DefaultAnimation = animation3;
            // 
            // MainPanel
            // 
            this.Panel_Animation.SetDecoration(this.MainPanel, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Animation.SetDecoration(this.MainPanel, BunifuAnimatorNS.DecorationType.None);
            this.MainPanel.Location = new System.Drawing.Point(213, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(486, 460);
            this.MainPanel.TabIndex = 2;
            // 
            // Panel_Animation
            // 
            this.Panel_Animation.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.Panel_Animation.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.Panel_Animation.DefaultAnimation = animation4;
            // 
            // Main_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.side_panel);
            this.Controls.Add(this.top_panel);
            this.Menu_Animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_control";
            this.Text = "Pictionary";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.side_panel.ResumeLayout(false);
            this.side_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label header_text;
        private System.Windows.Forms.Panel side_panel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuFlatButton Exit_option;
        private Bunifu.Framework.UI.BunifuFlatButton Signout_option;
        private Bunifu.Framework.UI.BunifuFlatButton Settings_option;
        private Bunifu.Framework.UI.BunifuFlatButton Search_option;
        private Bunifu.Framework.UI.BunifuFlatButton Home_option;
        private BunifuAnimatorNS.BunifuTransition Panel_Animation;
        private BunifuAnimatorNS.BunifuTransition Menu_Animation;
        private Bunifu.Framework.UI.BunifuImageButton Menu_Button;
        private System.Windows.Forms.Label Menu_text;
        private System.Windows.Forms.Panel MainPanel;
        private Bunifu.Framework.UI.BunifuFlatButton Write_option;
    }
}