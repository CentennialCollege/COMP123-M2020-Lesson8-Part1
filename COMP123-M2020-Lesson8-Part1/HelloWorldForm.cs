using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_Lesson8_Part1
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method changes the text property of the WelcomeLabel depending on its initial value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            WelcomeLabel.Text = (WelcomeLabel.Text == $"Hello, {NameTextBox.Text}!") ? "Clicked!" : $"Hello, {NameTextBox.Text}!";
        }


        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ClickMeButton.Enabled = NameTextBox.Text.Length > 1;
        }

        /// <summary>
        /// The Form Load event is triggered once, when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelloWorldForm_Load(object sender, EventArgs e) 
        {
            ClickMeButton.Enabled = false;
        }

        
    }
}
