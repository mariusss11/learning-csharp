using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace StudentsManagingApp
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.logoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.settingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.studentsButton = new Guna.UI2.WinForms.Guna2Button();
            this.homeButton = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dashboardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.studentsButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.sidebarTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 500);
            this.panel1.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.logoutButton.BorderRadius = 10;
            this.logoutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(12, 402);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(150, 40);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.exitButton.BorderRadius = 10;
            this.exitButton.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(12, 448);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.settingsButton.BorderRadius = 10;
            this.settingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(15, 210);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(150, 40);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.studentsButton.BorderRadius = 10;
            this.studentsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.studentsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentsButton.ForeColor = System.Drawing.Color.White;
            this.studentsButton.Location = new System.Drawing.Point(15, 155);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(150, 40);
            this.studentsButton.TabIndex = 1;
            this.studentsButton.Text = "Students";
            this.studentsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.homeButton.BorderRadius = 10;
            this.homeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(15, 100);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(150, 40);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Home";
            this.homeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidebarTitle
            // 
            this.sidebarTitle.BackColor = System.Drawing.Color.Transparent;
            this.sidebarTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.sidebarTitle.ForeColor = System.Drawing.Color.White;
            this.sidebarTitle.Location = new System.Drawing.Point(22, 15);
            this.sidebarTitle.Name = "sidebarTitle";
            this.sidebarTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.sidebarTitle.Size = new System.Drawing.Size(143, 79);
            this.sidebarTitle.TabIndex = 3;
            this.sidebarTitle.Text = "Dashboard";
            this.sidebarTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.sidebarTitle.Click += new System.EventHandler(this.sidebarTitle_Click);
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.FillColor = System.Drawing.Color.Transparent;
            this.dashboardPanel.Location = new System.Drawing.Point(180, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Padding = new System.Windows.Forms.Padding(20);
            this.dashboardPanel.Size = new System.Drawing.Size(720, 500);
            this.dashboardPanel.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Panel panel1;
        private Guna2Button settingsButton;
        private Guna2Button studentsButton;
        private Guna2Button homeButton;
        private Guna2Button exitButton;
        private Guna2Panel dashboardPanel;
        private Guna2HtmlLabel sidebarTitle;
        private Guna2Button logoutButton;
    }
}