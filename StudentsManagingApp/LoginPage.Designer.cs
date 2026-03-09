using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace StudentsManagingApp
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.LoginInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.authButton = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // LoginInfo
            // 
            this.LoginInfo.BackColor = System.Drawing.Color.Transparent;
            this.LoginInfo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LoginInfo.ForeColor = System.Drawing.Color.Black;
            this.LoginInfo.Location = new System.Drawing.Point(300, 60);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Size = new System.Drawing.Size(212, 56);
            this.LoginInfo.TabIndex = 0;
            this.LoginInfo.Text = "Login Page";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(300, 150);
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
            this.usernameBox.Location = new System.Drawing.Point(300, 175);
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
            this.label2.Location = new System.Drawing.Point(300, 220);
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
            this.passwordBox.Location = new System.Drawing.Point(300, 245);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.PlaceholderText = "Enter password";
            this.passwordBox.SelectedText = "";
            this.passwordBox.Size = new System.Drawing.Size(200, 35);
            this.passwordBox.TabIndex = 4;
            // 
            // errorMessage
            // 
            this.errorMessage.BackColor = System.Drawing.Color.Transparent;
            this.errorMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(300, 287);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(200, 22);
            this.errorMessage.TabIndex = 5;
            this.errorMessage.Text = "Auth failed! Please try again";
            this.errorMessage.Visible = false;
            // 
            // authButton
            // 
            this.authButton.BorderRadius = 10;
            this.authButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.authButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.authButton.ForeColor = System.Drawing.Color.White;
            this.authButton.Location = new System.Drawing.Point(300, 320);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(95, 40);
            this.authButton.TabIndex = 6;
            this.authButton.Text = "Login";
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // button1
            // 
            this.button1.BorderRadius = 10;
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(405, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginPage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna2TextBox usernameBox;
        private Guna2HtmlLabel label1;
        private Guna2HtmlLabel LoginInfo;
        private Guna2HtmlLabel label2;
        private Guna2TextBox passwordBox;
        private Guna2Button authButton;
        private Guna2HtmlLabel errorMessage;
        private Guna2Button button1;
    }
}