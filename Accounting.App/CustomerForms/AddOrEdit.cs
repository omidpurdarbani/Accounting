using Accounting.DataLayer.Bank;
using System;
using System.IO;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App.Customers
{
    public partial class AddOrEdit : Form
    {
        public int customerId = 0;


        SqlBank db = new SqlBank();

        public AddOrEdit()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog c = new OpenFileDialog();
            c.Filter = "Image Files|*.img;*.jpg;*.png;*.gif;";

            if (c.ShowDialog() == DialogResult.OK)
            {
                pcCustomers.ImageLocation = c.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomers.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!(Directory.Exists(path)))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustomers.Image.Save(path + ImageName);
                Accounting.DataLayer.Bank.Customers c = new Accounting.DataLayer.Bank.Customers()
                {
                    FullName = NameCustomer.Text,
                    Email = EmailCustomers.Text,
                    Mobile = MobileCustomer.Text,
                    Address = AdressCustomer.Text,
                    CustomerImage = ImageName
                };

                if (customerId == 0)
                {
                    db.Customer_Repository.InsertCustomer(c);
                }
                else
                {
                    c.CustomerID = customerId;
                    db.Customer_Repository.UpdateCustomer(c);
                }

                db.Save();
                RtlMessageBox.Show("عملیات با موفقیت انجام شد");
                DialogResult = DialogResult.OK;


            
        }



        private void AddOrEdit_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MobileCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddOrEdit_Load(object sender, EventArgs e)
        {

            if (customerId != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
                var customer = db.Customer_Repository.GetCustomerById(customerId);

                NameCustomer.Text = customer.FullName;
                MobileCustomer.Text = customer.Mobile;
                EmailCustomers.Text = customer.Email;
                AdressCustomer.Text = customer.Address;
                pcCustomers.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
            }

        }
    }
}
