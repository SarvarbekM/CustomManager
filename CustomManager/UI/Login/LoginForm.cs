using CustomManager.Properties;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (rememberCheckBox.Checked)
            {
                loginTextBox.Text = Settings.Default.Login;
                passwordTextBox.Text = Settings.Default.Password;
            }
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            SingnIn();
        }

        private async void SingnIn()
        {
            metroProgressSpinner1.Visible = true;
            string login = null;
            string password = null;
            if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                errorProvider1.SetError(loginTextBox, "Login is empty");
                //MessageBox.Show("Login is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                login = loginTextBox.Text;
            }
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                errorProvider1.SetError(passwordTextBox, "Password is empty");
                //MessageBox.Show("Password is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                password = passwordTextBox.Text;
            }

            Task<string> task = Task.Run(() => MyGlobalClass.DBManager.SignIn(login, password));
            string answer = await task;
            metroProgressSpinner1.Visible = false;
            if (answer == KEY_VALUES.OK)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(answer, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rememberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Remember_Me = rememberCheckBox.Checked;
            Settings.Default.Login = loginTextBox.Text;
            Settings.Default.Password = passwordTextBox.Text;
            Settings.Default.Save();
        }

        private void forgotLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotForm f = new ForgotForm();
            f.Show();
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.ShowDialog();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(loginTextBox, string.Empty);
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(passwordTextBox, string.Empty);
        }

        private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SingnIn();
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SingnIn();
            }
        }
    }
}
