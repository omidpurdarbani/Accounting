using Accounting.DataLayer.Bank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App.Transaction
{
    public partial class frmNewTransaction : Form
    {


        SqlBank db= new SqlBank();

        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns=false;
            dgvCustomers.DataSource = db.Customer_Repository.GetNameCustomers();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.DataSource=db.Customer_Repository.GetNameCustomers(txtFilter.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
        }

        private void rbPay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbRecive.Checked || rbCredit.Checked || rbMore.Checked)
                {
                    int type =0;

                    if (rbRecive.Checked)
                        type = 1;

                    if (rbPay.Checked)
                        type = 2;

                    if (rbCredit.Checked)
                        type = 3;

                    if(rbMore.Checked)
                        type = 4;


                    DataLayer.Bank.Accounting accounting = new DataLayer.Bank.Accounting()
                    {

                        Amount = float.Parse(numAmount.Value.ToString()),
                        CustomerID = db.Customer_Repository.GetCustomerIdByName(txtName.Text),
                        Description = txtDescription.Text,
                        DateTime = DateTime.Now,
                        TypeID = type
                         
                    };

                    db.AccountingRepository.Insert(accounting);
                    db.Save();
                    RtlMessageBox.Show("عملیات با موفقیت انجام شد");
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش خود را انتخاب کنید !");
                }
            }
        }
    }
}
