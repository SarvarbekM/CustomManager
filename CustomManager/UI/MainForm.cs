using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class MainForm : Form
    {
        ProductForm productForm;
        ContractForm contractForm;
        SettingsForm settingsForm;
        FEACNForm feacnForm;
        StatisticsForm statistcForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            accountDDBTN.Text = string.Format("{0} {1}", MyGlobalClass.Customer.Customer_Name, MyGlobalClass.Customer.Customer_Surname);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CLoseSubForms();
        }

        private void CLoseSubForms()
        {
            foreach (var item in bodyPanel.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            bool answer = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form == productForm)
                {
                    answer = true;
                }
            }
            if (!answer)
            {
                productForm = new ProductForm();
                productForm.TopLevel = false;
                productForm.TopMost = false;
                bodyPanel.Controls.Add(productForm);
            }
            productForm.Show();
            productForm.Activate();
            productForm.BringToFront();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            bool answer = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form == contractForm)
                {
                    answer = true;
                }
            }
            if (!answer)
            {
                contractForm = new ContractForm();
                contractForm.TopLevel = false;
                contractForm.TopMost = false;
                bodyPanel.Controls.Add(contractForm);
            }
            contractForm.Show();
            contractForm.Activate();
            contractForm.BringToFront();
            //Adorner.RemoveBadgeFrom(contractBTN);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            bool answer = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form == settingsForm)
                {
                    answer = true;
                }
            }
            if (!answer)
            {
                settingsForm = new SettingsForm();
                settingsForm.TopLevel = false;
                settingsForm.TopMost = false;
                bodyPanel.Controls.Add(settingsForm);
            }
            settingsForm.Show();
            settingsForm.Activate();
            settingsForm.BringToFront();
        }

        private void feacnBTN_Click(object sender, EventArgs e)
        {
            bool answer = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form == feacnForm)
                {
                    answer = true;
                }
            }
            if (!answer)
            {
                feacnForm = new FEACNForm();
                feacnForm.TopLevel = false;
                feacnForm.TopMost = false;
                bodyPanel.Controls.Add(feacnForm);
            }
            feacnForm.Show();
            feacnForm.Activate();
            feacnForm.BringToFront();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CLoseSubForms();
            Application.Restart();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SettingsForm f = new SettingsForm();
            f.ShowDialog();
        }

        private void statisitcsBTN_Click(object sender, EventArgs e)
        {
            bool answer = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form == statistcForm)
                {
                    answer = true;
                }
            }
            if (!answer)
            {
                statistcForm = new StatisticsForm();
                statistcForm.TopLevel = false;
                statistcForm.TopMost = false;
                bodyPanel.Controls.Add(statistcForm);
            }
            statistcForm.Show();
            statistcForm.Activate();
            statistcForm.BringToFront();
        }
    }
}