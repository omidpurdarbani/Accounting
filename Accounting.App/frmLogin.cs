using Accounting.DataLayer.Bank;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmLogin : Form
    {
        public int Id = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                if (txtUserName.Text != "" && txtUserPassword.Text != "")
                {

                    using (SqlBank db = new SqlBank())
                    {
                        Login user = db.LoginDB.Get(c => c.UserName == txtUserName.Text).ToList().FirstOrDefault();

                        if (user != null)
                        {
                            string pass = txtUserPassword.Text;
                            string Realpass = user.UserPassword;
                            string username=txtUserName.Text;
                            string Realuser =user.UserName;
                            if (username==Realuser)
                            {

                            
                            if (pass == Realpass)
                            {
                                DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                RtlMessageBox.Show("کلمه عبور صحیح نمی باشد");
                            }
                            }
                            else
                            {
                                RtlMessageBox.Show("نام کاربری صحیح نمی باشد");
                            }
                        }
                        else
                        {
                            RtlMessageBox.Show("کاربر پیدا نشد");
                        }

                    }




                }
                else
                {

                    if (txtUserName.Text == "" && txtUserPassword.Text == "")
                    {
                        RtlMessageBox.Show("لطفا نام کاربری و کلمه عبور را وارد نمایید");
                    }
                    else
                    {
                        if (txtUserName.Text == "")

                        {
                            RtlMessageBox.Show("لطفا نام کاربری را وارد نمایید");
                        }


                        if (txtUserPassword.Text == "")
                        {
                            RtlMessageBox.Show("لطفا کلمه عبور را وارد نمایید");

                        }
                    }


                }
            }
            else
            {
                SqlBank db = new SqlBank();

                Login user = db.LoginDB.Get(c => c.UserName == txtUserName.Text).ToList().FirstOrDefault();
                int loginID = user.UserID;
                Login up = new Login()
                {
                    UserID = loginID,
                    UserName = txtUserName.Text,
                    UserPassword = txtUserPassword.Text
                };
                db.Dispose();
                db = new SqlBank();
                db.LoginDB.Update(up);
                db.Save();
                RtlMessageBox.Show("عملیات با موفقیت انجام شد");
                db.Dispose();
                DialogResult = DialogResult.OK;

            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                txtUserName.Text = "";
                txtUserPassword.Text = "";
            }
            else
            {
                this.Text = "تنظیمات ورود";
                btnEnter.Text = "ویرایش";
                using (SqlBank db = new SqlBank())
                {
                    Login user = db.LoginDB.Get().ToList().FirstOrDefault();
                    txtUserName.Text = user.UserName;
                    txtUserPassword.Text = user.UserPassword;
                }

            }



        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
               btnEnter_Click(sender,null);
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter_Click(sender, null);
            }
        }

        private void txtUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter_Click(sender, null);
            }
        }
    }
}
