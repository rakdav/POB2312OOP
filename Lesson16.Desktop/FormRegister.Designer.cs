namespace Lesson16.Desktop
{
    partial class FormRegister
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
            textBoxLogin = new TextBox();
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            textBoxLastName = new TextBox();
            dateTimePickerBirth = new DateTimePicker();
            label1 = new Label();
            buttonOK = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(19, 19);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Введите логин";
            textBoxLogin.Size = new Size(344, 23);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(20, 56);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите имя";
            textBoxName.Size = new Size(343, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(20, 179);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Введите пароль";
            textBoxPassword.Size = new Size(344, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(21, 136);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Введите email";
            textBoxEmail.Size = new Size(342, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(21, 96);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Введите вашу фамилию";
            textBoxLastName.Size = new Size(343, 23);
            textBoxLastName.TabIndex = 4;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(19, 229);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(345, 23);
            dateTimePickerBirth.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 211);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 6;
            label1.Text = "Выберите дату рождения";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(19, 278);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(155, 23);
            buttonOK.TabIndex = 7;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(192, 278);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(171, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 333);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(label1);
            Controls.Add(dateTimePickerBirth);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(textBoxLogin);
            Name = "FormRegister";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxLastName;
        private DateTimePicker dateTimePickerBirth;
        private Label label1;
        private Button buttonOK;
        private Button buttonCancel;
    }
}