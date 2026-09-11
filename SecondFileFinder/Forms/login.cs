using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecondFileFinder.Forms
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass=passTextBox.Text;
            if (pass == "1234")
            {
                mainPage mainPage = new mainPage();
                mainPage.Show();
                label1.Text = "Correct PIN";
                label1.ForeColor = Color.LimeGreen;
                this.Hide();

            }
            else { 
                label1.Text = "Incorrect PIN"; 
                label1.ForeColor = Color.Red;
            }
        }
    }
}
