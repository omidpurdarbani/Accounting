using Accounting.App.Customers;
using Accounting.DataLayer.Bank;
using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();

        }
        void BindGrid()
        {
            using (SqlBank db = new SqlBank())
            {
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = db.Customer_Repository.GetAllCustomers();
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            BindGrid();
            txtFilter.Text = null;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (SqlBank db = new SqlBank())
            {
                dgCustomers.DataSource = db.Customer_Repository.GetCustomersByFilter(txtFilter.Text);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            AddOrEdit fr = new AddOrEdit();
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {

                BindGrid();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFilter_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {


                int CustomerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());

                AddOrEdit fr = new AddOrEdit();

                fr.customerId = CustomerId;

                if (fr.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();

                }





            }
            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید!");
            }
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgCustomers.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show($" آیا از حذف {dgCustomers.CurrentRow.Cells[1].Value.ToString()} مطمان هستید؟ ", "هشدار", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int CustomerID = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                        using (SqlBank db = new SqlBank())
                        {
                            db.Customer_Repository.DeleteCustomerById(CustomerID);
                            db.Save();
                        }
                        BindGrid();
                        RtlMessageBox.Show("عملیات با موفقیت انجام شد");
                    }


                }
                else
                {
                    RtlMessageBox.Show("لطفا شخصی را انتخاب کنید!");
                }
            }
            catch (DbUpdateException)
            {

                RtlMessageBox.Show($"شخص مورد نظر شما در تراکنشی مورد استفاده قرار  گرفته است");

                if (dgCustomers.CurrentRow != null)
                {
                    DialogResult result = RtlMessageBox.Show($" آیا از حذف تمامی تراکنش ها و شخص {dgCustomers.CurrentRow.Cells[1].Value.ToString()} مطمان هستید؟ ", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {


                        using (SqlBank db = new SqlBank())
                        {


                            int ID = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                            var r = db.AccountingRepository.Get((c => c.CustomerID == ID)).ToList();
                            foreach (var item in r)
                            {
                                db.AccountingRepository.Delete(item);
                            }
                            db.Customer_Repository.DeleteCustomerById(ID);

                            db.Save();
                            RtlMessageBox.Show("عملیات با موفقیت انجام شد");
                            
                        }
                    }

                }
                else
                {
                    RtlMessageBox.Show("لطفا شخصی را انتخاب کنید!");
                }

            }
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {


            if (dgCustomers.CurrentRow != null)
            {
                DialogResult result = RtlMessageBox.Show($"آیا از حذف تمامی تراکنش های{dgCustomers.CurrentRow.Cells[1].Value.ToString()} مطمان هستید؟ ", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {


                    using (SqlBank db = new SqlBank())
                    {


                        int ID = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                        var r = db.AccountingRepository.Get((c => c.CustomerID == ID)).ToList();
                        foreach (var item in r)
                        {
                            db.AccountingRepository.Delete(item);
                        }
                        db.Save();
                        RtlMessageBox.Show("عملیات با موفقیت انجام شد");
                    }
                }

            }
            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید!");
            }


        }

        private void dgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
