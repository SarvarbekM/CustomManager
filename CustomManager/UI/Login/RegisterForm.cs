using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            string name = string.Empty;
            string surname = string.Empty;
            string login = string.Empty;
            string password = string.Empty;
            string email = string.Empty;
            string phone = string.Empty;

            if (!string.IsNullOrEmpty(nameTB.Text))
            {
                name = nameTB.Text;
            }
            else
            {
                errorProvider1.SetError(nameTB, "Name is empty");
                return;
            }
            if (!string.IsNullOrEmpty(surnameTB.Text))
            {
                surname = surnameTB.Text;
            }
            else
            {
                errorProvider1.SetError(surnameTB, "Surname is empty");
                return;
            }
            if (!string.IsNullOrEmpty(loginTB.Text))
            {
                login = loginTB.Text;
            }
            else
            {
                errorProvider1.SetError(loginTB, "Login is empty");
                return;
            }

            if (!string.IsNullOrEmpty(passwordTB.Text))
            {
                password = passwordTB.Text;
            }
            else
            {
                errorProvider1.SetError(passwordTB, "Password is empty");
                return;
            }
            if (!passwordTB.Text.Equals(confirmPasswordTB.Text))
            {
                errorProvider1.SetError(confirmPasswordTB, "Passwords is not equalent");
                return;
            }
            if (!string.IsNullOrEmpty(emailTB.Text))
            {
                email = emailTB.Text;
            }
            else
            {
                errorProvider1.SetError(emailTB, "Email is empty");
                return;
            }
            if (!emailTB.Text.Equals(confirmEmailTB.Text))
            {
                errorProvider1.SetError(confirmEmailTB, "Email is not equalent");
                return;
            }
            if (!string.IsNullOrEmpty(phoneTB.Text))
            {
                phone = phoneTB.Text;
            }
            else
            {
                errorProvider1.SetError(phoneTB, "Phone is empty");
                return;
            }

            Customer customer = new Customer();
            customer.Customer_Name = name;
            customer.Customer_Surname = surname;
            customer.Email = email;
            customer.Login = login;
            customer.Password = password;
            customer.Phone = phone;
            Register(customer);
        }

        private async void Register(Customer customer)
        {
            metroProgressSpinner1.Visible = true;
            Task<string> task = Task.Run(() => MyGlobalClass.DBManager.Register(customer));
            string answer = await task;
            if (answer == KEY_VALUES.OK)
            {
                MessageBox.Show("Customer succesfull registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(answer, "Not registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            metroProgressSpinner1.Visible = false;
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            if(sender is TextBox)
            {
                errorProvider1.SetError((TextBox)sender, string.Empty);
            }
        }
    }
}
