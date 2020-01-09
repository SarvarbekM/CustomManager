using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GoogleMaps.LocationServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class DetailForm : Form
    {
        Product product;
        Customer customer;
        Location location;
        List<Location> listLocation;
        int item;
        public DetailForm(Product p)
        {
            InitializeComponent();
            product = p;
            item = 1;
        }
        public DetailForm(Customer c)
        {
            InitializeComponent();
            customer = c;
            item = 2;
        }
        public DetailForm(Location l)
        {
            InitializeComponent();
            location = l;
            item = 3;
        }
        public DetailForm()
        {
            InitializeComponent();
            item = 4;
        }
        public DetailForm(List<Location> ll)
        {
            InitializeComponent();
            listLocation = ll;
            item = 5;
        }

        private async Task loadTypesProduct()
        {
            List<Type_Measure> list_Measure = new List<Type_Measure>();
            List<Type_Money> list_Money = new List<Type_Money>();
            string url = MyGlobalClass.Host + "type_measure/read.php";
            string json = await MyGlobalClass.GetResponseAsync(url);
            if (MyGlobalClass.TryConvert(json, ref list_Measure))
            {
                countCombobox.DataSource = list_Measure;
                countCombobox.DisplayMember = "Type_measure_Name";
                countCombobox.ValueMember = "id_type_measure";
            }
            url = MyGlobalClass.Host + "type_money/read.php";
            json = await MyGlobalClass.GetResponseAsync(url);
            if (MyGlobalClass.TryConvert(json, ref list_Money))
            {
                costCombobox.DataSource = list_Money;
                costCombobox.DisplayMember = "Type_money_Name";
                costCombobox.ValueMember = "id_type_money";
            }
        }

        private async void DetailForm_Load(object sender, EventArgs e)
        {

            switch (item)
            {
                case 1://Product
                    {
                        customerPanel.Visible = false;
                        locationPanel.Visible = false;
                        await loadTypesProduct();
                        plCode.Text = product.Product_Code;
                        plHSCode.Text = product.HSCode;
                        plNameRU.Text = product.Product_Name_RU;
                        plNameEN.Text = product.Product_Name_EN;
                        countNumericUpDown.Value = Convert.ToDecimal(product.Measure_Count);
                        countCombobox.SelectedValue = product.type_measure_id;
                        countCombobox.SelectedItem = countCombobox.SelectedValue;
                        weightNumericUpDown.Value = Convert.ToDecimal(product.Weight);
                        //costNumericUpdown.Value = Convert.ToDecimal(product.Cost);
                        costCombobox.SelectedValue = product.type_money_id;
                        costCombobox.SelectedItem = costCombobox.SelectedValue;
                        //plModel.Text = product.Product_Model;
                        this.Width = productPanel.Width;
                        this.Height = productPanel.Height;
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    }; break;
                case 2://Customer
                    {
                        //locationPanel.Visible = false;
                        //productPanel.Visible = false;
                        //string url = MyGlobalClass.Host + "user/readonce.php?id=" + customer.user_id.ToString();
                        //string jsonString = MyGlobalClass.GetResponsible(url);
                        ////User user = new User();
                        //if (MyGlobalClass.TryConvert(jsonString, ref user))
                        //{
                        //    loginPL.Text = user.Login;
                        //    passwordPL.Text = user.Password;
                        //}
                        //namePL.Text = customer.Customer_Name;
                        //surnamePL.Text = customer.Customer_Surname;
                        //this.Width = customerPanel.Width;
                        //this.Height = customerPanel.Height;
                        //this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    }; break;
                case 3://Location
                    {
                        customerPanel.Visible = false;
                        productPanel.Visible = false;
                        latitudePL.Text = location.Latitude.ToString();
                        longitudePL.Text = location.Longitude.ToString();
                    }; break;
                case 4://Pustoy
                    {
                        customerPanel.Visible = false;
                        productPanel.Visible = false;
                    }; break;
                case 5://List Location
                    {
                        customerPanel.Visible = false;
                        productPanel.Visible = false;
                    }; break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double lat = 0;
            double lon = 0;
            if (!double.TryParse(latitudePL.Text, out lat))
            {
                MessageBox.Show("Latitude value is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return;
            }
            if (!double.TryParse(longitudePL.Text, out lon))
            {
                MessageBox.Show("Longitude value is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return;
            }
            switch (item)
            {
                case 3://Location
                    {
                        string url = MyGlobalClass.Host + "location/update.php?id=" + location.id_location.ToString() + "&lat=" + lat.ToString() + "&lon=" + lon.ToString();
                        string json = MyGlobalClass.GetResponsible(url);
                        if (json.Equals("1"))
                        {
                            MessageBox.Show("Location succesfull updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Location is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DialogResult = DialogResult.None;
                            return;
                        }
                    }; break;
                case 4://Pustoy
                    {
                        string url = MyGlobalClass.Host + "location/insert.php?lat=" + lat.ToString() + "&lon=" + lon.ToString();
                        string json = MyGlobalClass.GetResponsible(url);
                        if (json.Equals("1"))
                        {
                            MessageBox.Show("Location succesfull inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Location is not inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DialogResult = DialogResult.None;
                            return;
                        }
                    }; break;
                case 5://List Location
                    {
                        foreach (Location l in listLocation)
                        {
                            string url = MyGlobalClass.Host + "location/update.php?id=" + l.id_location.ToString() + "&lat=" + lat.ToString() + "&lon=" + lon.ToString();
                            string json = MyGlobalClass.GetResponsible(url);
                            if (!json.Equals("1"))
                            {
                                MessageBox.Show("Location is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.DialogResult = DialogResult.None;
                                return;
                            }
                        }
                        MessageBox.Show("Locations are succesfull updates", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }; break;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            double lat = 0;
            double lon = 0;
            if (!double.TryParse(latitudePL.Text, out lat))
            {
                MessageBox.Show("Latitude value is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return;
            }
            if (!double.TryParse(longitudePL.Text, out lon))
            {
                MessageBox.Show("Longitude value is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return;
            }
            try
            {
                gMapControl1.Overlays.Clear();
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                gMapControl1.Position = new PointLatLng(lat, lon);
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markersOverlay);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = vScrollBar1.Value * 2;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            double lat = 0;
            double lon = 0;
            if (!double.TryParse(latitudePL.Text, out lat))
            {
                MessageBox.Show("Latitude value is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(longitudePL.Text, out lon))
            {
                MessageBox.Show("Longitude value is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                GoogleLocationService locationService = new GoogleLocationService();                
                var point = locationService.GetAddressFromLatLang(lat, lon);
                addressPL.Text = point.Address;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
