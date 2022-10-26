using Accounting.DataLayer.Bank;
using Accounting.Utility.Convertor;
using Accounting.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Accounting.App
{
    public partial class frmReport : Form
    {
        public int TypeID = 0;

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            DataGridViewCellStyle style = dgReport.ColumnHeadersDefaultCellStyle;
            style.Font = new Font(dgReport.Font, FontStyle.Bold);
            using (SqlBank db = new SqlBank())
            {
                List<ListCustomerModelView> list = new List<ListCustomerModelView>();
                list.Add(new ListCustomerModelView
                {
                    CustomerID = 0,
                    FullName = " "

                });
                list.AddRange(db.Customer_Repository.GetNameCustomers());
                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerId";
            }
            Filter();

        }



        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }


        void Filter()
        {




            switch (TypeID)
            {
                case 0:
                    this.Text = "همه گزارش ها";
                    break;
                case 1:
                    this.Text = "گزارش دریافتی ها";
                    break;
                case 2:
                    this.Text = "گزارش پرداختی ها";
                    break;
                case 3:
                    this.Text = "گزارش بدهکاری ها";
                    break;
                case 4:
                    this.Text = "گزارش متفرقه ها";
                    break;
                default:
                    break;
            }

            using (SqlBank db = new SqlBank())
            {


                DateTime? startDate;
                DateTime? endDate;


                var result = db.AccountingRepository.Get(a => a.TypeID == TypeID);

                if (TypeID == 0)
                {
                    result = db.AccountingRepository.Get();
                }


                if ((int)cbCustomer.SelectedValue != 0)
                {
                    if (TypeID == 0)
                    {
                        result = db.AccountingRepository.Get(a => a.CustomerID == (int)cbCustomer.SelectedValue);
                    }
                    else
                    {
                        result = db.AccountingRepository.Get(a => a.TypeID == TypeID && a.CustomerID == (int)cbCustomer.SelectedValue);
                    }


                }
                try
                {
                    if (FromDate.Text != "    /  /")
                    {

                        startDate = Convert.ToDateTime(FromDate.Text);
                        startDate = DateConvertor.ToMiladi(startDate.Value);
                        result = result.Where(r => r.DateTime >= startDate).ToList();

                    }

                    if (ToDate.Text != "    /  /")
                    {

                        endDate = Convert.ToDateTime(ToDate.Text);
                        endDate = DateConvertor.ToMiladi(endDate.Value);
                        result = result.Where(r => r.DateTime <= endDate).ToList();

                    }
                }
                catch (FormatException)
                {

                    RtlMessageBox.Show("تاریخ را اشتباه وارد کرده اید");
                }




                dgReport.AutoGenerateColumns = false;
                dgReport.Rows.Clear();
                foreach (var item in result)
                {
                    var customer = db.Customer_Repository.GetCustomerNameById(item.CustomerID);

                    var type = db.AccountingTypeRepository.GetEntityById(item.TypeID);


                    dgReport.Rows.Add(item.ID, customer, item.Amount, type.TypeTitle, item.DateTime.ToShamsi(), item.Description);

                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                DialogResult dialogResult = RtlMessageBox.Show("آیا از حذف این تراکنش مطمان هستید ؟", "هشدار", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlBank db = new SqlBank())
                    {
                        dgReport.Rows.Clear();
                        db.AccountingRepository.Delete(db.AccountingRepository.GetEntityById(id));
                        db.Save();

                    }
                    Filter();
                }




            }
            else
            {
                RtlMessageBox.Show("لطفا تراکنشی را انتخاب نمایید");


            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {

                frmNewTransaction frmNewTransaction = new frmNewTransaction();
                frmNewTransaction.customerID = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());

                if (frmNewTransaction.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا تراکنشی برای ویرایش انتخاب کنید");
            }


        }
        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            frmNewTransaction frmNewTransaction = new frmNewTransaction();
            if (frmNewTransaction.ShowDialog() == DialogResult.OK)
            {
                Filter();
            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnReportAll_Click(object sender, EventArgs e)
        {
            btnReportAll.Checked = true;
            btnReportRecive.Checked = false;
            btnReportPay.Checked = false;
            btnReportCredit.Checked = false;
            btnReportMore.Checked = false;
            TypeID = 0;
            Filter();
        }

        private void btnReportRecive_Click(object sender, EventArgs e)
        {
            btnReportAll.Checked = false;
            btnReportRecive.Checked = true;
            btnReportPay.Checked = false;
            btnReportCredit.Checked = false;
            btnReportMore.Checked = false;
            TypeID = 1;
            Filter();

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnReportPay_Click(object sender, EventArgs e)
        {
            btnReportAll.Checked = false;
            btnReportRecive.Checked = false;
            btnReportPay.Checked = true;
            btnReportCredit.Checked = false;
            btnReportMore.Checked = false;
            TypeID = 2;
            Filter();
        }

        private void btnReportCredit_Click(object sender, EventArgs e)
        {
            btnReportAll.Checked = false;
            btnReportRecive.Checked = false;
            btnReportPay.Checked = false;
            btnReportCredit.Checked = true;
            btnReportMore.Checked = false;
            TypeID = 3;
            Filter();
        }

        private void btnReportMore_Click(object sender, EventArgs e)
        {
            btnReportAll.Checked = false;
            btnReportRecive.Checked = false;
            btnReportPay.Checked = false;
            btnReportCredit.Checked = false;
            btnReportMore.Checked = true;
            TypeID = 4;
            Filter();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FromDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FromDate_Click(object sender, EventArgs e)
        {
            FromDate.SelectAll();
        }

        private void ToDate_Click(object sender, EventArgs e)
        {
            ToDate.SelectAll();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Customer");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Description");
            foreach (DataGridViewRow item in dgReport.Rows)
            {

                dataTable.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[5].Value.ToString()
                    );

            }
            stiPrint.Load(Application.StartupPath+ "/Report.mrt");
            stiPrint.RegData("DT", dataTable);
            stiPrint.Show();


        }
    }
}
