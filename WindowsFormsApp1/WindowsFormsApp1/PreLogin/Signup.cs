using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Signup : Form
    {
        private StartUpForm startupform;

        public Signup(StartUpForm startupform)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.startupform = startupform;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if ((username.Text != "" || username.Text != "eg : Furyblade540") && password.Text != "" && check.Checked == true)
            {
                for (int i = 1; i <= 100; i++)
                {
                    Thread.Sleep(10);
                    progress.Value = i;
                    progress.Update();
                }
                string content = username.Text + ":" + password.Text +":" + email.Text +":" + dob.Value + Environment.NewLine;
                string dir = @"C:\PersonalData\main.txt";
                File.AppendAllText(dir, content);
                this.SendToBack();
                MessageBox.Show("Signup Susccessful", "Message");
            }else
            {
                MessageBox.Show("Fill in the details !","Error");
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
