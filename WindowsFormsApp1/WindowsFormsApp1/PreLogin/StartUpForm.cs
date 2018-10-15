using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StartUpForm : Form
    {
        private LoginForm loginform;
        private Signup signupform;
        private void File_Creator()
        {
            if (!Directory.Exists(@"C:\PersonalData"))
            {
                Directory.CreateDirectory(@"C:\PersonalData");
            }
        }
        public StartUpForm()
        {
            InitializeComponent();
            //Creates the File..
            File_Creator();
            //Setting up the main panel...
            loginform = new LoginForm(this);
            signupform = new Signup(this);
            MainPanel.Controls.Add(loginform);
            MainPanel.Controls.Add(signupform);
            loginform.Show();
            signupform.Show();
            loginform.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
