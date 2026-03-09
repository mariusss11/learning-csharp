using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagingApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

     
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void isFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            var oldPassword = oldPasswordTextBox.Text;
            var newPassword = newPasswordTextBox.Text;

            if (string.IsNullOrEmpty(oldPassword)) {
                var error = MessageBox.Show(
                    "Please enter your old password!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else if(string.IsNullOrEmpty(newPassword))
            {
                var error = MessageBox.Show(
                    "Please enter your new password!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else if(oldPassword.Equals(newPassword))
            {
                var error = MessageBox.Show(
                    "Your new password could not be your old password!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else
            {
                oldPasswordTextBox.Text = string.Empty;
                newPasswordTextBox.Text = string.Empty;
                var info = MessageBox.Show(
                    "Password updated succesfully!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void errorMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
