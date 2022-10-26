
using Accounting.App;
using Accounting.Business;
using Accounting.DataLayer.Bank;
using Accounting.Utility.Convertor;
using Accounting.ViewModels.Accounting;
using System;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        void report()
        {
            ReciveViewModel reciveViewModel = Account.ReportFomMain();
            lblBalance.Text = reciveViewModel.Balance.ToString("#,0");
            lblPay.Text = reciveViewModel.Pay.ToString("#,0");
            lblRecive.Text = reciveViewModel.Recive.ToString("#,0");
            lblCredit.Text = reciveViewModel.Credit.ToString("#,0");
            lblMore.Text = reciveViewModel.More.ToString("#,0");
            ReciveViewModel reciveViewModelthismonth = Account.ReportFomMainThisMonth();
            lblThisMBalance.Text = reciveViewModelthismonth.Balance.ToString("#,0");
            lblThisMPay.Text = reciveViewModelthismonth.Pay.ToString("#,0");
            lblThisMRecive.Text = reciveViewModelthismonth.Recive.ToString("#,0");
            lblThisMCredit.Text = reciveViewModelthismonth.Credit.ToString("#,0");
            lblThisMMore.Text = reciveViewModelthismonth.More.ToString("#,0");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin fr = new frmLogin();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                date.Text = DateTime.Now.ToShamsi();
                time.Text = DateTime.Now.ToString("HH:mm:ss");
                report();
                this.Show();
                RtlMessageBox.Show("خوش آمدید");
              
            }
            else
            {
                Application.Exit();
            }

        }


        private void btnCustomers_Click(object sender, EventArgs e)

        {
            frmCustomers c = new frmCustomers();
            if (c.ShowDialog() == DialogResult.OK)
            {
                report();
            }
            else
            {
                report();
            }
            

        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

       

        private void btnReportAll_Click(object sender, EventArgs e)
        {
            frmReport frmReportAll = new frmReport();
            if (frmReportAll.ShowDialog()==DialogResult.OK)
            {
                report();
            }
            else
            {
                report();
            }
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShamsi();
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void تنظیماتورودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Id = 1;
            frmLogin.txtUserPassword.UseSystemPasswordChar = false;
            frmLogin.StartPosition = FormStartPosition.CenterParent;
            if(frmLogin.ShowDialog()==DialogResult.OK)
            {
                report();
            }
            else
            {
                report();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}