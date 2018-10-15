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
        private System.Threading.Thread animationthread;

        public Signup(StartUpForm startupform)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.startupform = startupform;
            //animationthread = new System.Threading.Thread(animate_progress_bar);
            //animationthread.Start();
        }

        private void header_text_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Close button.
        {
            this.SendToBack();
        }
        /*
       private void animate_progress_bar()
        {
            MethodInvoker mi = delegate()
            {
                if (username.Text != "")
                {
                    for (int i = 1; i < 50; i++)
                    {
                        Thread.Sleep(10);
                        this.progress.Value += i;
                        this.progress.Update();
                    }
                }
                if (password.Text != "")
                {
                    for (int i = 1; i < 50; i++)
                    {
                        Thread.Sleep(10);
                        this.progress.Value += i;
                        this.progress.Update();
                    }
                }
            };
            while(true)
            {
                mi.Invoke();
            }
        }
        */

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
                string content = username.Text + ":" + password.Text + Environment.NewLine;
                string dir = @"C:\Users\Kartik\Desktop\main.txt";
                File.AppendAllText(dir, content);
                this.SendToBack();
                MessageBox.Show("Login Susccessful", "Message");
            }else
            {
                MessageBox.Show("Fill in the details !","Error");
            }
                
            
        }
    }
}
