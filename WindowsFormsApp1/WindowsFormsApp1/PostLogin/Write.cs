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

namespace WindowsFormsApp1.PostLogin
{
    public partial class Write : Form
    {
        Main_control main_control;
        string[] details;

        public Write(Main_control main_control , string[] details)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.main_control = main_control;
            this.details = details;
            Write_box.Hide();
            Tick.Hide();
        }

        private void Text_updater()
        {
            string directory = @"C:\PersonalData\" + details[0] + ".txt";
            string content = Write_box.Text;
            string[] main_content = content.Split('`');
            for(int i = 0;i < main_content.Length; i++)
            {
                content = main_content[i] + Environment.NewLine;
                File.AppendAllText(directory, content);
            }
            Write_box.Text = "Successfully Updated \n Format : \nKeyword : Description or Meaning";
            Write_box.Update();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Write_box.Show();
            Tick.Show();
        }

        private void Tick_Click(object sender, EventArgs e)
        {
            Text_updater();
        }
    }
}
