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

namespace BacManagingApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Console.Write("Registing a new student...");

            var firstName = String.Empty;
            var lastName = String.Empty;

            var firstGrade = 0.00;

            var foreginLanguge = String.Empty;
            var foreginLangugeGrade = 0.00;

            var profilObject = String.Empty;
            var profilObjectGrade = 0.00;

            var requestedObject = String.Empty;
            var requestedObjectGrade = 0.00;

            if (!string.IsNullOrWhiteSpace(firstNameBox.Text))
            {
                firstNameErrorLabel.Visible = false;
                firstName = firstNameBox.Text;
            } else
            {
                firstNameErrorLabel.Visible = true;
            }

            if (!string.IsNullOrWhiteSpace(lastNameBox.Text))
            {
                lastNameErrorLabel.Visible = false;
                lastName = lastNameBox.Text;
            }
            else
            {
                lastNameErrorLabel.Visible = true;
            }

            if (firstGradeNumericBox.Value > 0 && firstGradeNumericBox.Value <= 10)
            {
                firstGrade = (double)firstGradeNumericBox.Value;
                romanianLangugeErrorLabel.Visible = false;
            }
            else
            {
                romanianLangugeErrorLabel.Visible = true;
            }

            if (
                foreginLanguageGradeNumericBox.Value > 0 &&
                foreginLanguageGradeNumericBox.Value <= 10 &&
                !string.IsNullOrEmpty(foreginLangugeComboBox.Text)
            )
            {
                foreginLangugeGrade = (double)foreginLanguageGradeNumericBox.Value;
                foreginLangugeErrorLabel.Visible = false;
            }
            else
            {
                foreginLangugeErrorLabel.Visible = true;
            }

            if (
                profilObjectGradeNumericBox.Value > 0 &&
                profilObjectGradeNumericBox.Value <= 10 &&
                !string.IsNullOrEmpty(profilObjectComboBox.Text)
            )
            {
                profilObjectGrade = (double)profilObjectGradeNumericBox.Value;
                profileObjectErrorLabel.Visible = false;
            }
            else
            {
                profileObjectErrorLabel.Visible = true;
            }




            if (
                requestedObjectGradeNumericBox.Value > 0 &&
                requestedObjectGradeNumericBox.Value <= 10 &&
                !string.IsNullOrEmpty(requestedObjectComboBox.Text)
            )
            {
                profilObjectGrade = (double)requestedObjectGradeNumericBox.Value;
                requestedObjectErrorLabel.Visible = false;
            }
            else
            {
                requestedObjectErrorLabel.Visible = true;
            }





            Console.WriteLine("Register finished!");
        }
    }
}
