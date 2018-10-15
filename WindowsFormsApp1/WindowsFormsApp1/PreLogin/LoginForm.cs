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
    public partial class LoginForm : Form
    {
        private StartUpForm startupform;
        private string[] details;
        private Main_control main_control;
        public LoginForm(StartUpForm startupform)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.startupform = startupform; 
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Fill in the details", "Error");
            }
            else
            {
                if (login_checker() == true)
                {
                    Main_control obj = new Main_control(details , this);
                    main_control = obj;
                    main_control.Show();
                    startupform.Hide();
                }
            }
        }

        public void Login_pusher()
        {
            startupform.Show();
        }

        public bool login_checker()
        {
            string directory = @"C:\PersonalData\main.txt";

            if(!File.Exists(directory))
            {
                MessageBox.Show("Create an Account First !!");
                return false;
            }
            string[] temp = File.ReadAllLines(directory);


            if (Dropdown.selectedValue == "I am Robot")
            {
                MessageBox.Show("Your a Robot");
                return false;
            }
            foreach (string line in temp)
            {
                string[] checker;
                checker = line.Split(':');
                if (checker[0] == username.Text && checker[1] == password.Text && Dropdown.selectedValue == "I am not a Robot")
                {
                    details = checker;
                    MessageBox.Show("Login Successful !");
                    return true;
                }
            }
            MessageBox.Show("Username or password is Incorrect");
            return false;

        }

        private void signup_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SendToBack();
        }

    }
}
