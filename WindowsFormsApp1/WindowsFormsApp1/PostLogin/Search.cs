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

namespace WindowsFormsApp1.PostLogin
{
    public partial class Search : Form
    {
        private Main_control main_control;
        string[] details;
        string display;

        public Search(Main_control main_control , String[] details)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.main_control = main_control;
            this.details = details;
        }

        private void Word_finder(string word)
        {
            string directory = @"C:\PersonalData\" + details[0] + ".txt";
            string[] content = File.ReadAllLines(directory);
            
            
            for(int i = 0;i < content.Length; i++)
            {
                string[] list = content[i].Split(':');   
                if (list[0].Equals(word))
                {
                    display = list[1];
                }
            }
            Write_box.Text = display;
            Write_box.Update();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            Word_finder(Search_box.Text);            
        }
    }
}
