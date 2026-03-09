using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace StudentsManagingApp
{
    partial class SettingsForm
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
            this.panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.changePasswordButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dashboardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Settings";
            // 
            // panel4
            // 
            this.panel4.BorderRadius = 10;
            this.panel4.Controls.Add(this.changePasswordButton);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.oldPasswordTextBox);
            this.panel4.Controls.Add(this.newPasswordTextBox);
            this.panel4.FillColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(7, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 166);
            this.panel4.TabIndex = 1;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BorderRadius = 10;
            this.changePasswordButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.changePasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.Location = new System.Drawing.Point(365, 81);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(153, 38);
            this.changePasswordButton.TabIndex = 12;
            this.changePasswordButton.Text = "Change password";
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Change Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(26, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Old password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(191, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "New password";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldPasswordTextBox.DefaultText = "";
            this.oldPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.oldPasswordTextBox.Location = new System.Drawing.Point(26, 81);
            this.oldPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.PasswordChar = '*';
            this.oldPasswordTextBox.PlaceholderText = "Old password";
            this.oldPasswordTextBox.SelectedText = "";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(129, 36);
            this.oldPasswordTextBox.TabIndex = 3;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasswordTextBox.DefaultText = "";
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newPasswordTextBox.Location = new System.Drawing.Point(191, 81);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.PlaceholderText = "New password";
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.Size = new System.Drawing.Size(129, 36);
            this.newPasswordTextBox.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BorderRadius = 10;
            this.panel5.Controls.Add(this.materialRadioButton1);
            this.panel5.Controls.Add(this.radioButton2);
            this.panel5.Controls.Add(this.radioButton1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.FillColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(7, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(604, 122);
            this.panel5.TabIndex = 0;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialRadioButton1.Checked = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(26, 75);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(50, 30);
            this.materialRadioButton1.TabIndex = 17;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "All";
            this.materialRadioButton1.UseVisualStyleBackColor = false;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Depth = 0;
            this.radioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButton2.Location = new System.Drawing.Point(264, 75);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Ripple = true;
            this.radioButton2.Size = new System.Drawing.Size(106, 30);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Important";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.isFemale_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Depth = 0;
            this.radioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButton1.Location = new System.Drawing.Point(111, 75);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Ripple = true;
            this.radioButton1.Size = new System.Drawing.Size(139, 30);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Do not disturb";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Notification Settings";
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.panel5);
            this.dashboardPanel.Controls.Add(this.panel4);
            this.dashboardPanel.Controls.Add(this.label1);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.FillColor = System.Drawing.Color.Transparent;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(621, 373);
            this.dashboardPanel.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(621, 373);
            this.Controls.Add(this.dashboardPanel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Guna2Panel panel4;
        private Guna2Button changePasswordButton;
        private Label label2;
        private Label label4;
        private Label label5;
        private Guna2TextBox oldPasswordTextBox;
        private Guna2TextBox newPasswordTextBox;
        private Guna2Panel panel5;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton radioButton2;
        private MaterialSkin.Controls.MaterialRadioButton radioButton1;
        private Label label3;
        private Guna2Panel dashboardPanel;
    }
}