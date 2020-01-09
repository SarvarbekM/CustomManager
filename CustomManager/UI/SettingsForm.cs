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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            nameTB.Text = MyGlobalClass.Customer.Customer_Name;
            surnameTB.Text = MyGlobalClass.Customer.Customer_Surname;
            loginTB.Text = MyGlobalClass.Customer.Login;
            passwordTB.Text = MyGlobalClass.Customer.Password;
            emailTB.Text = MyGlobalClass.Customer.Email;
            phoneTB.Text = MyGlobalClass.Customer.Phone;
        }

        private bool ChangeSettings()
        {
            string name = "";
            string surname = "";
            string login = "";
            string password = "";
            string confirmpassword = "";
            string email = "";
            string phone = "";

            if (!string.IsNullOrEmpty(nameTB.Text))
            {
                name = nameTB.Text;
            }
            else
            {
                MessageBox.Show("Name is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrEmpty(surnameTB.Text))
            {
                surname = surnameTB.Text;
            }
            else
            {
                MessageBox.Show("Surname is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrEmpty(loginTB.Text))
            {
                login = loginTB.Text;
            }
            else
            {
                MessageBox.Show("Login is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrEmpty(passwordTB.Text))
            {
                password = passwordTB.Text;
            }
            else
            {
                MessageBox.Show("Password is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrEmpty(confirmPasswordTB.Text))
            {
                confirmpassword = confirmPasswordTB.Text;
            }
            else
            {
                MessageBox.Show("Confirm Password is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!password.Equals(confirmpassword))
            {
                MessageBox.Show("Passwords not equalent, please check the password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!string.IsNullOrEmpty(emailTB.Text))
            {
                email = emailTB.Text;
            }
            else
            {
                MessageBox.Show("Email is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrEmpty(phoneTB.Text))
            {
                phone = phoneTB.Text;
            }
            else
            {
                MessageBox.Show("Phone is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string url = MyGlobalClass.Host + "customer/update.php?id=" + MyGlobalClass.Customer.id_customer + "&login=" + login + "&pass=" + password + 
                " &role_id=" + MyGlobalClass.Customer.role_id+ "&name="+name+ "&surname="+surname+ "&email="+email+ "&phone="+phone;
            string json = MyGlobalClass.GetResponsible(url);
            if(json.Equals("1"))
            {
                MyGlobalClass.Customer.Customer_Name = name;
                MyGlobalClass.Customer.Customer_Surname = surname;
                return true;
            }
            else
            {
                MessageBox.Show("User settings is not updated,please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async void ChangeSettingsAsync()
        {
            metroProgressSpinner1.Visible = true;
            Task<bool> task = Task.Run(() => ChangeSettings());
            bool answer = await task;
            if (answer)
            {
                MessageBox.Show("User settings succesfull changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            metroProgressSpinner1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTB.PasswordChar = viewPassChB.Checked ? '\0' : '*';
            confirmPasswordTB.PasswordChar = viewPassChB.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            ChangeSettingsAsync();
        }
    }
}
