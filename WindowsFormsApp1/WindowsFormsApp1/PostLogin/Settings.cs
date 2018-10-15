using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.PostLogin
{
    public partial class Settings : Form
    {
        private Main_control main_control;
        private string[] details;
        private void Details_Updater()
        {
            username.Text = details[0];
            username.Update();
            password.Text = details[1];
            password.Update();
            email.Text = details[2];
            email.Update();
            dob.Text = details[3];
            dob.Update();
        }
        public Settings(Main_control main_control , string[] details)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.main_control = main_control;
            this.details = details;
            Details_Updater();
        }
    }
}
