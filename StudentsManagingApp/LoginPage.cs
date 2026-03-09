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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void authButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Auth button clicked");

            string username = usernameBox.Text;

            string password = passwordBox.Text;

            if (username == "admin" && password == "password") {
                errorMessage.Hide();
                Dashboard dashboard= new Dashboard();
                dashboard.Show();
                this.Hide();
            } else
            {
                errorMessage.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
