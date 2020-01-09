using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class ForgotForm : Form
    {
        Customer customer;
        string name;
        string surname;
        string toemail;

        public ForgotForm()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(namePL.Text))
            {
                name = namePL.Text;
            }
            else
            {
                MessageBox.Show("Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(surnamePL.Text))
            {
                surname = surnamePL.Text;
            }
            else
            {
                MessageBox.Show("Surname is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(emailPL.Text))
            {
                toemail = emailPL.Text;
            }
            else
            {
                MessageBox.Show("Email is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StartOperationAsync();
        }

        private async void StartOperationAsync()
        {
            metroProgressSpinner1.Visible = true;
            this.UseWaitCursor = true;
            Task<bool> task = Task.Run(() => StartOperation());
            bool answer = await task;
            if (answer)
            {
                MessageBox.Show("Message is sending in " + toemail, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Message is not sending, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.UseWaitCursor = false;
            metroProgressSpinner1.Visible = false;
        }

        private bool StartOperation()
        {
            bool answer = false;
            if (GetCustomer())
            {
                string from = "sarvarbek.matvapayev@gmail.com";
                string password = "KA0587391";
                int port = 25;
                string host = "smtp.gmail.com";
                string subject = "Information";
                string msg = "Your Account:\nLogin:" + customer.Login + "\nPassword:" + customer.Password;
                answer = SendEmail(from, toemail, msg, port, host, subject, password);
            }
            else
            {
                MessageBox.Show("Name or Surname is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                answer = false;
            }

            return answer;
        }

        private bool GetCustomer()
        {
            string url = MyGlobalClass.Host + "customer/readbyname.php?name=" + name + "&surname=" + surname;
            string json = MyGlobalClass.GetResponsible(url);
            return MyGlobalClass.TryConvert(json, ref customer);
        }

        private bool SendEmail(string from, string to, string msg, int port, string host, string subject, string password)
        {
            bool answer = true;
            try
            {
                MailMessage message = new MailMessage(from, to, subject, msg);
                message.BodyEncoding = UTF8Encoding.UTF8;
                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                SmtpClient smtp = new SmtpClient();
                smtp.Port = port;
                smtp.Host = host;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(from, password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception)
            {
                answer = false;
            }
            return answer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}