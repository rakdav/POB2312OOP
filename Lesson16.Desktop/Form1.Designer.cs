namespace Lesson16.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxLogin = new TextBox();
            label2 = new Label();
            textBoxPassword = new TextBox();
            buttonIn = new Button();
            labelRegister = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите логин";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(12, 27);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Ваш логин";
            textBoxLogin.Size = new Size(237, 23);
            textBoxLogin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Введите пароль";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 71);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Ваш пароль";
            textBoxPassword.Size = new Size(237, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonIn
            // 
            buttonIn.Location = new Point(88, 116);
            buttonIn.Name = "buttonIn";
            buttonIn.Size = new Size(75, 23);
            buttonIn.TabIndex = 4;
            buttonIn.Text = "Вход";
            buttonIn.UseVisualStyleBackColor = true;
            buttonIn.Click += buttonIn_Click;
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Location = new Point(88, 151);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(76, 15);
            labelRegister.TabIndex = 5;
            labelRegister.Text = "Регистрация";
            labelRegister.Click += labelRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 184);
            Controls.Add(labelRegister);
            Controls.Add(buttonIn);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxLogin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxLogin;
        private Label label2;
        private TextBox textBoxPassword;
        private Button buttonIn;
        private Label labelRegister;
    }
}
