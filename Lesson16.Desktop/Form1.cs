using Lesson16.Console;

namespace Lesson16.Desktop
{
    public partial class Form1 : Form
    {
        private UserRegistration userRegistration;
        public Form1()
        {
            InitializeComponent();
            userRegistration= new UserRegistration();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            if(userRegistration.AuthenticateUser(textBoxLogin.Text,textBoxPassword.Text))
            {
                LCForm lCForm = new LCForm();
                lCForm.Show();
                this.Hide();
            }
        }
    }
}
