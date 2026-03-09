using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace StudentsManagingApp
{
    partial class HomeForm
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
            this.dashboardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelStats = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTotalStudents = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTotalTitle = new System.Windows.Forms.Label();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.panelPassing = new Guna.UI2.WinForms.Guna2Panel();
            this.labelPassingTitle = new System.Windows.Forms.Label();
            this.labelPassingCount = new System.Windows.Forms.Label();
            this.panelFailing = new Guna.UI2.WinForms.Guna2Panel();
            this.labelFailingTitle = new System.Windows.Forms.Label();
            this.labelFailingCount = new System.Windows.Forms.Label();
            this.panelAverage = new Guna.UI2.WinForms.Guna2Panel();
            this.labelAverageTitle = new System.Windows.Forms.Label();
            this.labelAverageCount = new System.Windows.Forms.Label();
            this.dashboardPanel.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelTotalStudents.SuspendLayout();
            this.panelPassing.SuspendLayout();
            this.panelFailing.SuspendLayout();
            this.panelAverage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.labelTitle);
            this.dashboardPanel.Controls.Add(this.labelWelcome);
            this.dashboardPanel.Controls.Add(this.panelStats);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.FillColor = System.Drawing.Color.Transparent;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(621, 450);
            this.dashboardPanel.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(10, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(137, 54);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Home";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.labelWelcome.Location = new System.Drawing.Point(13, 65);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(464, 28);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome back! Here\'s an overview of your students.";
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.panelTotalStudents);
            this.panelStats.Controls.Add(this.panelPassing);
            this.panelStats.Controls.Add(this.panelFailing);
            this.panelStats.Controls.Add(this.panelAverage);
            this.panelStats.FillColor = System.Drawing.Color.Transparent;
            this.panelStats.Location = new System.Drawing.Point(7, 110);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(604, 160);
            this.panelStats.TabIndex = 2;
            // 
            // panelTotalStudents
            // 
            this.panelTotalStudents.BorderRadius = 10;
            this.panelTotalStudents.Controls.Add(this.labelTotalTitle);
            this.panelTotalStudents.Controls.Add(this.labelTotalCount);
            this.panelTotalStudents.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.panelTotalStudents.Location = new System.Drawing.Point(0, 0);
            this.panelTotalStudents.Name = "panelTotalStudents";
            this.panelTotalStudents.Size = new System.Drawing.Size(135, 100);
            this.panelTotalStudents.TabIndex = 0;
            // 
            // labelTotalTitle
            // 
            this.labelTotalTitle.AutoSize = true;
            this.labelTotalTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTotalTitle.ForeColor = System.Drawing.Color.White;
            this.labelTotalTitle.Location = new System.Drawing.Point(15, 15);
            this.labelTotalTitle.Name = "labelTotalTitle";
            this.labelTotalTitle.Size = new System.Drawing.Size(117, 23);
            this.labelTotalTitle.TabIndex = 0;
            this.labelTotalTitle.Text = "Total Students";
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.AutoSize = true;
            this.labelTotalCount.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCount.ForeColor = System.Drawing.Color.White;
            this.labelTotalCount.Location = new System.Drawing.Point(15, 45);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(86, 41);
            this.labelTotalCount.TabIndex = 1;
            this.labelTotalCount.Text = "1900";
            // 
            // panelPassing
            // 
            this.panelPassing.BorderRadius = 10;
            this.panelPassing.Controls.Add(this.labelPassingTitle);
            this.panelPassing.Controls.Add(this.labelPassingCount);
            this.panelPassing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panelPassing.Location = new System.Drawing.Point(155, 0);
            this.panelPassing.Name = "panelPassing";
            this.panelPassing.Size = new System.Drawing.Size(135, 100);
            this.panelPassing.TabIndex = 1;
            // 
            // labelPassingTitle
            // 
            this.labelPassingTitle.AutoSize = true;
            this.labelPassingTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelPassingTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPassingTitle.ForeColor = System.Drawing.Color.White;
            this.labelPassingTitle.Location = new System.Drawing.Point(15, 15);
            this.labelPassingTitle.Name = "labelPassingTitle";
            this.labelPassingTitle.Size = new System.Drawing.Size(66, 23);
            this.labelPassingTitle.TabIndex = 0;
            this.labelPassingTitle.Text = "Passing";
            // 
            // labelPassingCount
            // 
            this.labelPassingCount.AutoSize = true;
            this.labelPassingCount.BackColor = System.Drawing.Color.Transparent;
            this.labelPassingCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassingCount.ForeColor = System.Drawing.Color.White;
            this.labelPassingCount.Location = new System.Drawing.Point(15, 45);
            this.labelPassingCount.Name = "labelPassingCount";
            this.labelPassingCount.Size = new System.Drawing.Size(86, 41);
            this.labelPassingCount.TabIndex = 1;
            this.labelPassingCount.Text = "1800";
            // 
            // panelFailing
            // 
            this.panelFailing.BorderRadius = 10;
            this.panelFailing.Controls.Add(this.labelFailingTitle);
            this.panelFailing.Controls.Add(this.labelFailingCount);
            this.panelFailing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelFailing.Location = new System.Drawing.Point(310, 0);
            this.panelFailing.Name = "panelFailing";
            this.panelFailing.Size = new System.Drawing.Size(135, 100);
            this.panelFailing.TabIndex = 2;
            // 
            // labelFailingTitle
            // 
            this.labelFailingTitle.AutoSize = true;
            this.labelFailingTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelFailingTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFailingTitle.ForeColor = System.Drawing.Color.White;
            this.labelFailingTitle.Location = new System.Drawing.Point(15, 15);
            this.labelFailingTitle.Name = "labelFailingTitle";
            this.labelFailingTitle.Size = new System.Drawing.Size(58, 23);
            this.labelFailingTitle.TabIndex = 0;
            this.labelFailingTitle.Text = "Failing";
            // 
            // labelFailingCount
            // 
            this.labelFailingCount.AutoSize = true;
            this.labelFailingCount.BackColor = System.Drawing.Color.Transparent;
            this.labelFailingCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFailingCount.ForeColor = System.Drawing.Color.White;
            this.labelFailingCount.Location = new System.Drawing.Point(15, 45);
            this.labelFailingCount.Name = "labelFailingCount";
            this.labelFailingCount.Size = new System.Drawing.Size(69, 41);
            this.labelFailingCount.TabIndex = 1;
            this.labelFailingCount.Text = "100";
            // 
            // panelAverage
            // 
            this.panelAverage.BorderRadius = 10;
            this.panelAverage.Controls.Add(this.labelAverageTitle);
            this.panelAverage.Controls.Add(this.labelAverageCount);
            this.panelAverage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.panelAverage.Location = new System.Drawing.Point(465, 0);
            this.panelAverage.Name = "panelAverage";
            this.panelAverage.Size = new System.Drawing.Size(135, 100);
            this.panelAverage.TabIndex = 3;
            // 
            // labelAverageTitle
            // 
            this.labelAverageTitle.AutoSize = true;
            this.labelAverageTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelAverageTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelAverageTitle.ForeColor = System.Drawing.Color.White;
            this.labelAverageTitle.Location = new System.Drawing.Point(15, 15);
            this.labelAverageTitle.Name = "labelAverageTitle";
            this.labelAverageTitle.Size = new System.Drawing.Size(94, 23);
            this.labelAverageTitle.TabIndex = 0;
            this.labelAverageTitle.Text = "Avg. Grade";
            // 
            // labelAverageCount
            // 
            this.labelAverageCount.AutoSize = true;
            this.labelAverageCount.BackColor = System.Drawing.Color.Transparent;
            this.labelAverageCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverageCount.ForeColor = System.Drawing.Color.White;
            this.labelAverageCount.Location = new System.Drawing.Point(15, 45);
            this.labelAverageCount.Name = "labelAverageCount";
            this.labelAverageCount.Size = new System.Drawing.Size(76, 41);
            this.labelAverageCount.TabIndex = 1;
            this.labelAverageCount.Text = "N/A";
            // 
            // HomeForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.dashboardPanel);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelTotalStudents.ResumeLayout(false);
            this.panelTotalStudents.PerformLayout();
            this.panelPassing.ResumeLayout(false);
            this.panelPassing.PerformLayout();
            this.panelFailing.ResumeLayout(false);
            this.panelFailing.PerformLayout();
            this.panelAverage.ResumeLayout(false);
            this.panelAverage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Panel dashboardPanel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelWelcome;
        private Guna2Panel panelStats;
        private Guna2Panel panelTotalStudents;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.Label labelTotalTitle;
        private Guna2Panel panelPassing;
        private System.Windows.Forms.Label labelPassingCount;
        private System.Windows.Forms.Label labelPassingTitle;
        private Guna2Panel panelFailing;
        private System.Windows.Forms.Label labelFailingCount;
        private System.Windows.Forms.Label labelFailingTitle;
        private Guna2Panel panelAverage;
        private System.Windows.Forms.Label labelAverageCount;
        private System.Windows.Forms.Label labelAverageTitle;
    }
}