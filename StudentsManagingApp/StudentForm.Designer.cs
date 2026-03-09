using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace StudentsManagingApp
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddStudent = new Guna.UI2.WinForms.Guna2Panel();
            this.addStudentButton = new Guna.UI2.WinForms.Guna2Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxGrade = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAddTitle = new System.Windows.Forms.Label();
            this.panelTable = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTableTitle = new System.Windows.Forms.Label();
            this.dashboardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panelAddStudent.SuspendLayout();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dashboardPanel.SuspendLayout();
            this.SuspendLayout();

            // label1 - Page Title
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Students";

            // panelAddStudent
            this.panelAddStudent.BorderRadius = 10;
            this.panelAddStudent.Controls.Add(this.labelAddTitle);
            this.panelAddStudent.Controls.Add(this.labelName);
            this.panelAddStudent.Controls.Add(this.labelEmail);
            this.panelAddStudent.Controls.Add(this.labelGrade);
            this.panelAddStudent.Controls.Add(this.textBoxName);
            this.panelAddStudent.Controls.Add(this.textBoxEmail);
            this.panelAddStudent.Controls.Add(this.textBoxGrade);
            this.panelAddStudent.Controls.Add(this.addStudentButton);
            this.panelAddStudent.FillColor = System.Drawing.Color.Transparent;
            this.panelAddStudent.Location = new System.Drawing.Point(7, 67);
            this.panelAddStudent.Name = "panelAddStudent";
            this.panelAddStudent.Size = new System.Drawing.Size(604, 130);
            this.panelAddStudent.TabIndex = 0;

            // labelAddTitle
            this.labelAddTitle.AutoSize = true;
            this.labelAddTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelAddTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelAddTitle.Location = new System.Drawing.Point(18, 10);
            this.labelAddTitle.Name = "labelAddTitle";
            this.labelAddTitle.TabIndex = 0;
            this.labelAddTitle.Text = "Add Student";

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelName.Location = new System.Drawing.Point(18, 50);
            this.labelName.Name = "labelName";
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";

            // labelEmail
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelEmail.Location = new System.Drawing.Point(178, 50);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";

            // labelGrade
            this.labelGrade.AutoSize = true;
            this.labelGrade.BackColor = System.Drawing.Color.Transparent;
            this.labelGrade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelGrade.Location = new System.Drawing.Point(338, 50);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.TabIndex = 3;
            this.labelGrade.Text = "Grade";

            // textBoxName
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxName.Location = new System.Drawing.Point(18, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Full name";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(140, 36);
            this.textBoxName.TabIndex = 4;

            // textBoxEmail
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.DefaultText = "";
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxEmail.Location = new System.Drawing.Point(178, 78);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "Email address";
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.Size = new System.Drawing.Size(140, 36);
            this.textBoxEmail.TabIndex = 5;

            // textBoxGrade
            this.textBoxGrade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxGrade.DefaultText = "";
            this.textBoxGrade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxGrade.Location = new System.Drawing.Point(338, 78);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.PlaceholderText = "Grade";
            this.textBoxGrade.SelectedText = "";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 36);
            this.textBoxGrade.TabIndex = 6;

            // addStudentButton
            this.addStudentButton.BorderRadius = 10;
            this.addStudentButton.FillColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.addStudentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addStudentButton.ForeColor = System.Drawing.Color.White;
            this.addStudentButton.Location = new System.Drawing.Point(458, 78);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(130, 36);
            this.addStudentButton.TabIndex = 7;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);

            // panelTable
            this.panelTable.BorderRadius = 10;
            this.panelTable.Controls.Add(this.labelTableTitle);
            this.panelTable.Controls.Add(this.dataGridView1);
            this.panelTable.FillColor = System.Drawing.Color.Transparent;
            this.panelTable.Location = new System.Drawing.Point(7, 205);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(604, 220);
            this.panelTable.TabIndex = 1;

            // labelTableTitle
            this.labelTableTitle.AutoSize = true;
            this.labelTableTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTableTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTableTitle.Location = new System.Drawing.Point(18, 10);
            this.labelTableTitle.Name = "labelTableTitle";
            this.labelTableTitle.TabIndex = 0;
            this.labelTableTitle.Text = "Students List";

            // dataGridView1
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(570, 160);
            this.dataGridView1.TabIndex = 1;

            // dashboardPanel
            this.dashboardPanel.Controls.Add(this.panelAddStudent);
            this.dashboardPanel.Controls.Add(this.panelTable);
            this.dashboardPanel.Controls.Add(this.label1);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.FillColor = System.Drawing.Color.Transparent;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(621, 450);
            this.dashboardPanel.TabIndex = 0;

            // StudentForm
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.dashboardPanel);
            this.Name = "StudentForm";
            this.Text = "Students";
            this.panelAddStudent.ResumeLayout(false);
            this.panelAddStudent.PerformLayout();
            this.panelTable.ResumeLayout(false);
            this.panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna2Panel panelAddStudent;
        private Guna2Button addStudentButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGrade;
        private Guna2TextBox textBoxName;
        private Guna2TextBox textBoxEmail;
        private Guna2TextBox textBoxGrade;
        private System.Windows.Forms.Label labelAddTitle;
        private Guna2Panel panelTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTableTitle;
        private Guna2Panel dashboardPanel;
    }
}