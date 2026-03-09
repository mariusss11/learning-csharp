using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacManagingApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void authButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Auth button clicked");

            string username = usernameBox.Text;

            string password = passwordBox.Text;

            if (username == "admin" && password == "password")
            {
                errorMessage.Hide();

                DialogResult result = MessageBox.Show(
                    "Autentificat cu succes!",
                    "Mesaj de succes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                if (result == DialogResult.OK)
                {
                    Console.Write("Ok was clicked!");
                    
                }
            }
            else
            {
                errorMessage.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }
    }
}
