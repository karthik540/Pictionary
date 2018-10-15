using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Main_control : Form
    {
        private PostLogin.Home home;
        private PostLogin.Search search;
        private PostLogin.Settings settings;
        private PostLogin.Write write;
        private LoginForm loginform;
        private string[] details;

        public Main_control(string[] details , LoginForm loginform)
        {
            InitializeComponent();
            //Getting the details...

            this.details = details;
            this.loginform = loginform;

            //Creating the file for the user...
            
            string directory = @"C:\PersonalData\" + details[0] + ".txt";
            if (!File.Exists(directory))
            {
                File.Create(directory);
            }
            //Setting up the Main UI...
            home = new PostLogin.Home(this , write);
            search = new PostLogin.Search(this , details);
            settings = new PostLogin.Settings(this , details);
            write = new PostLogin.Write(this , details);
            MainPanel.Controls.Add(home);
            MainPanel.Controls.Add(search);
            MainPanel.Controls.Add(settings);
            MainPanel.Controls.Add(write);
            home.Show();
            search.Show();
            settings.Show();
            write.Show();
            home.BringToFront();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Menu_Button_Click_1(object sender, EventArgs e)
        {
            if (side_panel.Width == 50)
            {
                //Expanding menu bar..
                side_panel.Visible = false;
                side_panel.Width = 215;
                Panel_Animation.ShowSync(side_panel);
                Menu_Animation.ShowSync(Menu_text);
            }
            else
            {
                //Minimizing the menu bar...
                Menu_text.Hide();
                side_panel.Visible = false;
                side_panel.Width = 50;
                Panel_Animation.ShowSync(side_panel);
            }

        }

        private void Exit_option_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signout_option_Click(object sender, EventArgs e)
        {
            loginform.Login_pusher();
            this.Hide();
        }

        private void Search_option_Click(object sender, EventArgs e)
        {
            search.BringToFront();
        }

        private void Home_option_Click(object sender, EventArgs e)
        {
            home.BringToFront();
        }

        private void Settings_option_Click(object sender, EventArgs e)
        {
            settings.BringToFront();
        }

        public void Write_pusher()
        {
            write.BringToFront();
        }

        private void Write_option_Click_1(object sender, EventArgs e)
        {
            Write_pusher();
        }
    }
}
