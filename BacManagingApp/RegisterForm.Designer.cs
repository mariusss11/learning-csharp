namespace BacManagingApp
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registrationErrorMessage = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.LoginInfo = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstGradeNumericBox = new System.Windows.Forms.NumericUpDown();
            this.foreginLanguageGradeNumericBox = new System.Windows.Forms.NumericUpDown();
            this.profilObjectGradeNumericBox = new System.Windows.Forms.NumericUpDown();
            this.requestedObjectGradeNumericBox = new System.Windows.Forms.NumericUpDown();
            this.foreginLangugeComboBox = new System.Windows.Forms.ComboBox();
            this.profilObjectComboBox = new System.Windows.Forms.ComboBox();
            this.requestedObjectComboBox = new System.Windows.Forms.ComboBox();
            this.romanianLangugeErrorLabel = new System.Windows.Forms.Label();
            this.foreginLangugeErrorLabel = new System.Windows.Forms.Label();
            this.profileObjectErrorLabel = new System.Windows.Forms.Label();
            this.requestedObjectErrorLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstGradeNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreginLanguageGradeNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilObjectGradeNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedObjectGradeNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationErrorMessage
            // 
            this.registrationErrorMessage.AutoSize = true;
            this.registrationErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.registrationErrorMessage.Location = new System.Drawing.Point(620, 278);
            this.registrationErrorMessage.Name = "registrationErrorMessage";
            this.registrationErrorMessage.Size = new System.Drawing.Size(218, 16);
            this.registrationErrorMessage.TabIndex = 21;
            this.registrationErrorMessage.Text = "Registration failed! Please try again";
            this.registrationErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registrationErrorMessage.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(729, 297);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(109, 44);
            this.registerButton.TabIndex = 20;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 164);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(72, 16);
            this.lastNameLabel.TabIndex = 19;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(19, 183);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(165, 22);
            this.lastNameBox.TabIndex = 18;
            // 
            // LoginInfo
            // 
            this.LoginInfo.AutoSize = true;
            this.LoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginInfo.Location = new System.Drawing.Point(12, 21);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Size = new System.Drawing.Size(224, 38);
            this.LoginInfo.TabIndex = 17;
            this.LoginInfo.Text = "Register Page";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(16, 82);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(72, 16);
            this.firstNameLabel.TabIndex = 16;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(19, 101);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(165, 22);
            this.firstNameBox.TabIndex = 15;
            this.firstNameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Profil Object";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Romanian Languge";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Grades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Requested Object";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Foregin Language";
            // 
            // firstGradeNumericBox
            // 
            this.firstGradeNumericBox.Location = new System.Drawing.Point(263, 150);
            this.firstGradeNumericBox.Name = "firstGradeNumericBox";
            this.firstGradeNumericBox.Size = new System.Drawing.Size(118, 22);
            this.firstGradeNumericBox.TabIndex = 27;
            // 
            // foreginLanguageGradeNumericBox
            // 
            this.foreginLanguageGradeNumericBox.Location = new System.Drawing.Point(391, 177);
            this.foreginLanguageGradeNumericBox.Name = "foreginLanguageGradeNumericBox";
            this.foreginLanguageGradeNumericBox.Size = new System.Drawing.Size(118, 22);
            this.foreginLanguageGradeNumericBox.TabIndex = 28;
            // 
            // profilObjectGradeNumericBox
            // 
            this.profilObjectGradeNumericBox.Location = new System.Drawing.Point(544, 178);
            this.profilObjectGradeNumericBox.Name = "profilObjectGradeNumericBox";
            this.profilObjectGradeNumericBox.Size = new System.Drawing.Size(93, 22);
            this.profilObjectGradeNumericBox.TabIndex = 29;
            // 
            // requestedObjectGradeNumericBox
            // 
            this.requestedObjectGradeNumericBox.Location = new System.Drawing.Point(689, 178);
            this.requestedObjectGradeNumericBox.Name = "requestedObjectGradeNumericBox";
            this.requestedObjectGradeNumericBox.Size = new System.Drawing.Size(93, 22);
            this.requestedObjectGradeNumericBox.TabIndex = 30;
            // 
            // foreginLangugeComboBox
            // 
            this.foreginLangugeComboBox.FormattingEnabled = true;
            this.foreginLangugeComboBox.Items.AddRange(new object[] {
            "English ",
            "French"});
            this.foreginLangugeComboBox.Location = new System.Drawing.Point(391, 147);
            this.foreginLangugeComboBox.Name = "foreginLangugeComboBox";
            this.foreginLangugeComboBox.Size = new System.Drawing.Size(118, 24);
            this.foreginLangugeComboBox.TabIndex = 31;
            // 
            // profilObjectComboBox
            // 
            this.profilObjectComboBox.FormattingEnabled = true;
            this.profilObjectComboBox.Items.AddRange(new object[] {
            "Mathematics",
            "History",
            "Physical Education",
            "Arts",
            "Theatre History",
            "Music Theory"});
            this.profilObjectComboBox.Location = new System.Drawing.Point(544, 148);
            this.profilObjectComboBox.Name = "profilObjectComboBox";
            this.profilObjectComboBox.Size = new System.Drawing.Size(118, 24);
            this.profilObjectComboBox.TabIndex = 32;
            // 
            // requestedObjectComboBox
            // 
            this.requestedObjectComboBox.FormattingEnabled = true;
            this.requestedObjectComboBox.Items.AddRange(new object[] {
            "Biology",
            "Chemestry",
            "Physics",
            "Geography",
            "History",
            "Mathematics"});
            this.requestedObjectComboBox.Location = new System.Drawing.Point(689, 149);
            this.requestedObjectComboBox.Name = "requestedObjectComboBox";
            this.requestedObjectComboBox.Size = new System.Drawing.Size(118, 24);
            this.requestedObjectComboBox.TabIndex = 33;
            // 
            // romanianLangugeErrorLabel
            // 
            this.romanianLangugeErrorLabel.AutoSize = true;
            this.romanianLangugeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.romanianLangugeErrorLabel.Location = new System.Drawing.Point(262, 184);
            this.romanianLangugeErrorLabel.Name = "romanianLangugeErrorLabel";
            this.romanianLangugeErrorLabel.Size = new System.Drawing.Size(85, 16);
            this.romanianLangugeErrorLabel.TabIndex = 34;
            this.romanianLangugeErrorLabel.Text = "Invalid grade";
            this.romanianLangugeErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.romanianLangugeErrorLabel.Visible = false;
            // 
            // foreginLangugeErrorLabel
            // 
            this.foreginLangugeErrorLabel.AutoSize = true;
            this.foreginLangugeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.foreginLangugeErrorLabel.Location = new System.Drawing.Point(388, 212);
            this.foreginLangugeErrorLabel.Name = "foreginLangugeErrorLabel";
            this.foreginLangugeErrorLabel.Size = new System.Drawing.Size(146, 16);
            this.foreginLangugeErrorLabel.TabIndex = 35;
            this.foreginLangugeErrorLabel.Text = "Invalid grade or subject";
            this.foreginLangugeErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foreginLangugeErrorLabel.Visible = false;
            // 
            // profileObjectErrorLabel
            // 
            this.profileObjectErrorLabel.AutoSize = true;
            this.profileObjectErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.profileObjectErrorLabel.Location = new System.Drawing.Point(540, 212);
            this.profileObjectErrorLabel.Name = "profileObjectErrorLabel";
            this.profileObjectErrorLabel.Size = new System.Drawing.Size(146, 16);
            this.profileObjectErrorLabel.TabIndex = 36;
            this.profileObjectErrorLabel.Text = "Invalid grade or subject";
            this.profileObjectErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profileObjectErrorLabel.Visible = false;
            // 
            // requestedObjectErrorLabel
            // 
            this.requestedObjectErrorLabel.AutoSize = true;
            this.requestedObjectErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.requestedObjectErrorLabel.Location = new System.Drawing.Point(692, 212);
            this.requestedObjectErrorLabel.Name = "requestedObjectErrorLabel";
            this.requestedObjectErrorLabel.Size = new System.Drawing.Size(146, 16);
            this.requestedObjectErrorLabel.TabIndex = 37;
            this.requestedObjectErrorLabel.Text = "Invalid grade or subject";
            this.requestedObjectErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.requestedObjectErrorLabel.Visible = false;
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(16, 136);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(188, 16);
            this.firstNameErrorLabel.TabIndex = 38;
            this.firstNameErrorLabel.Text = "Please provide your first name";
            this.firstNameErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstNameErrorLabel.Visible = false;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(16, 212);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(189, 16);
            this.lastNameErrorLabel.TabIndex = 39;
            this.lastNameErrorLabel.Text = "Please provide your last name";
            this.lastNameErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastNameErrorLabel.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 350);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.requestedObjectErrorLabel);
            this.Controls.Add(this.profileObjectErrorLabel);
            this.Controls.Add(this.foreginLangugeErrorLabel);
            this.Controls.Add(this.romanianLangugeErrorLabel);
            this.Controls.Add(this.requestedObjectComboBox);
            this.Controls.Add(this.profilObjectComboBox);
            this.Controls.Add(this.foreginLangugeComboBox);
            this.Controls.Add(this.requestedObjectGradeNumericBox);
            this.Controls.Add(this.profilObjectGradeNumericBox);
            this.Controls.Add(this.foreginLanguageGradeNumericBox);
            this.Controls.Add(this.firstGradeNumericBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registrationErrorMessage);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.LoginInfo);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameBox);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.firstGradeNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreginLanguageGradeNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilObjectGradeNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedObjectGradeNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrationErrorMessage;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label LoginInfo;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown firstGradeNumericBox;
        private System.Windows.Forms.NumericUpDown foreginLanguageGradeNumericBox;
        private System.Windows.Forms.NumericUpDown profilObjectGradeNumericBox;
        private System.Windows.Forms.NumericUpDown requestedObjectGradeNumericBox;
        private System.Windows.Forms.ComboBox foreginLangugeComboBox;
        private System.Windows.Forms.ComboBox profilObjectComboBox;
        private System.Windows.Forms.ComboBox requestedObjectComboBox;
        private System.Windows.Forms.Label romanianLangugeErrorLabel;
        private System.Windows.Forms.Label foreginLangugeErrorLabel;
        private System.Windows.Forms.Label profileObjectErrorLabel;
        private System.Windows.Forms.Label requestedObjectErrorLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
    }
}