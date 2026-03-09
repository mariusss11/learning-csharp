using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace StudentsManagingApp
{
    partial class RegisterPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.LoginInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.errorMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.authButton = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.isMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.isFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.SuspendLayout();
            // 
            // LoginInfo
            // 
            this.LoginInfo.BackColor = System.Drawing.Color.Transparent;
            this.LoginInfo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LoginInfo.ForeColor = System.Drawing.Color.Black;
            this.LoginInfo.Location = new System.Drawing.Point(280, 40);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Size = new System.Drawing.Size(264, 56);
            this.LoginInfo.TabIndex = 0;
            this.LoginInfo.Text = "Register Page";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(280, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // usernameBox
            // 
            this.usernameBox.BorderRadius = 8;
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.DefaultText = "";
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameBox.Location = new System.Drawing.Point(280, 135);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PlaceholderText = "Enter username";
            this.usernameBox.SelectedText = "";
            this.usernameBox.Size = new System.Drawing.Size(200, 35);
            this.usernameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(280, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.BorderRadius = 8;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultText = "";
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordBox.Location = new System.Drawing.Point(280, 205);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.PlaceholderText = "Enter password";
            this.passwordBox.SelectedText = "";
            this.passwordBox.Size = new System.Drawing.Size(200, 35);
            this.passwordBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(280, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(280, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Where did you hear about us?";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Transparent;
            this.comboBox1.BorderRadius = 8;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox1.ItemHeight = 30;
            this.comboBox1.Items.AddRange(new object[] {
            "Friend",
            "Family member",
            "School",
            "Internet",
            "Other"});
            this.comboBox1.Location = new System.Drawing.Point(280, 335);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 36);
            this.comboBox1.TabIndex = 9;
            // 
            // errorMessage
            // 
            this.errorMessage.BackColor = System.Drawing.Color.Transparent;
            this.errorMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(280, 380);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(200, 22);
            this.errorMessage.TabIndex = 10;
            this.errorMessage.Text = "Auth failed! Please try again";
            this.errorMessage.Visible = false;
            // 
            // authButton
            // 
            this.authButton.BorderRadius = 10;
            this.authButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.authButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.authButton.ForeColor = System.Drawing.Color.White;
            this.authButton.Location = new System.Drawing.Point(280, 410);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(95, 40);
            this.authButton.TabIndex = 11;
            this.authButton.Text = "Login";
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // button1
            // 
            this.button1.BorderRadius = 10;
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(385, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Register";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isMale
            // 
            this.isMale.AutoSize = true;
            this.isMale.Depth = 0;
            this.isMale.Font = new System.Drawing.Font("Roboto", 10F);
            this.isMale.Location = new System.Drawing.Point(280, 278);
            this.isMale.Margin = new System.Windows.Forms.Padding(0);
            this.isMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.isMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.isMale.Name = "isMale";
            this.isMale.Ripple = true;
            this.isMale.Size = new System.Drawing.Size(68, 30);
            this.isMale.TabIndex = 13;
            this.isMale.TabStop = true;
            this.isMale.Text = "Male";
            this.isMale.UseVisualStyleBackColor = true;
            // 
            // isFemale
            // 
            this.isFemale.AutoSize = true;
            this.isFemale.Depth = 0;
            this.isFemale.Font = new System.Drawing.Font("Roboto", 10F);
            this.isFemale.Location = new System.Drawing.Point(393, 277);
            this.isFemale.Margin = new System.Windows.Forms.Padding(0);
            this.isFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.isFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.isFemale.Name = "isFemale";
            this.isFemale.Ripple = true;
            this.isFemale.Size = new System.Drawing.Size(87, 30);
            this.isFemale.TabIndex = 14;
            this.isFemale.TabStop = true;
            this.isFemale.Text = "Female";
            this.isFemale.UseVisualStyleBackColor = true;
            // 
            // RegisterPage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.isFemale);
            this.Controls.Add(this.isMale);
            this.Controls.Add(this.LoginInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna2TextBox usernameBox;
        private Guna2TextBox passwordBox;
        private Guna2HtmlLabel label1;
        private Guna2HtmlLabel label2;
        private Guna2HtmlLabel LoginInfo;
        private Guna2HtmlLabel label3;
        private Guna2HtmlLabel label4;
        private Guna2ComboBox comboBox1;
        private Guna2HtmlLabel errorMessage;
        private Guna2Button authButton;
        private Guna2Button button1;
        private MaterialSkin.Controls.MaterialRadioButton isMale;
        private MaterialSkin.Controls.MaterialRadioButton isFemale;
    }
}