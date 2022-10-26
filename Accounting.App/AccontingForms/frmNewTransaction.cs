using Accounting.App.Customers;
using Accounting.DataLayer.Bank;
using Accounting.Utility.Convertor;
using System;
using System.Linq;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmNewTransaction : Form
    {
        public int customerID = 0;
        SqlBank db = new SqlBank();
        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            mDate.Text = DateTime.Now.ToShamsi();

            dgvCustomeers.AutoGenerateColumns = false;
            dgvCustomeers.DataSource = db.Customer_Repository.GetNameCustomers();
            if (customerID != 0)
            {
                using (SqlBank db = new SqlBank())
                {

                    var account = db.AccountingRepository.GetEntityById(customerID);

                    txtName.Text = db.Customer_Repository.GetCustomerNameById(account.CustomerID);
                    mDate.Text = account.DateTime.ToShamsi().ToString();
                    txtAmount.Value = decimal.Parse(account.Amount.ToString());
                    txtDescription.Text = account.Description;
                    switch (account.TypeID)
                    {
                        case 1:
                            rbRecive.Checked = true;
                            break;

                        case 2:
                            rbPay.Checked = true;
                            break;

                        case 3:
                            rbCredit.Checked = true;
                            break;
                        case 4:
                            rbMore.Checked = true;
                            break;

                        default:
                            break;

                    }
                }
                this.Text = "ویرایش";
                btnSave.Text= "ویرایش";
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomeers.AutoGenerateColumns = false;
            dgvCustomeers.DataSource = db.Customer_Repository.GetNameCustomers(txtFilter.Text);
        }

        private void dgvCustomeers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomeers.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbRecive.Checked || rbCredit.Checked || rbMore.Checked)
                {

                    int type = 0;
                    if (rbRecive.Checked)
                    {
                        type = 1;
                    }
                    if (rbPay.Checked)
                    {
                        type = 2;
                    }
                    if (rbCredit.Checked)
                    {
                        type = 3;
                    }
                    if (rbMore.Checked)
                    {
                        type = 4;
                    }
                    DateTime date;
                    if (mDate.Text== "1400/02/30" )
                    {
                        date = Convert.ToDateTime("2021/05/20");
                    }
                    else if (mDate.Text == "1400/02/29")
                    {
                        date = Convert.ToDateTime("2021/05/19");
                    }
                    else
                    {
                        date = Convert.ToDateTime(mDate.Text).ToMiladi();
                    }
                    DataLayer.Bank.Accounting accounting = new DataLayer.Bank.Accounting()
                    {
                        Amount = int.Parse(txtAmount.Value.ToString()),
                        CustomerID = db.Customer_Repository.GetCustomerIdByName(txtName.Text),
                        TypeID = type,
                       
                        DateTime =date,
                        Description = txtDescription.Text

                    };
                    if (customerID==0)
                    {
                        db.AccountingRepository.Insert(accounting);
                    }
                    else
                    {
                        accounting.ID= customerID;
                        db.AccountingRepository.Update(accounting);
                    }
                    db.Save();
                    RtlMessageBox.Show("عملیات با موفقیت انجام شد");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
                }
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            RtlMessageBox.Show("برای ابزار ها و امکانات بیشتر میتوانید به بخش طرف حساب در صفحه اصلی مراجعه فرمایید","هشدار");
            AddOrEdit frm=new AddOrEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                frmNewTransaction_Load(sender,e);
            }
        }

        private void mDate_Click(object sender, EventArgs e)
        {
            mDate.SelectAll();
        }
    }
}
