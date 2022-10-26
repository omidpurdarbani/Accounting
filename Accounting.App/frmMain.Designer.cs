namespace Accounting.App
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.تنظیماتورودToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.date = new System.Windows.Forms.ToolStripStatusLabel();
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblThisMMore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblThisMCredit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblThisMBalance = new System.Windows.Forms.Label();
            this.lblThisMPay = new System.Windows.Forms.Label();
            this.lblThisMRecive = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRecive = new System.Windows.Forms.Label();
            this.lblMore = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1030, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تنظیماتورودToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // تنظیماتورودToolStripMenuItem
            // 
            this.تنظیماتورودToolStripMenuItem.Name = "تنظیماتورودToolStripMenuItem";
            this.تنظیماتورودToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.تنظیماتورودToolStripMenuItem.Text = "تنظیمات ورود";
            this.تنظیماتورودToolStripMenuItem.Click += new System.EventHandler(this.تنظیماتورودToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnCustomers});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1030, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 59);
            this.toolStripButton1.Text = "طرف حساب";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::Accounting.App.Properties.Resources.list2;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(44, 59);
            this.btnCustomers.Text = "گزارش";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnReportAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.date,
            this.time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1030, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // date
            // 
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 17);
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources.Accounting;
            this.pictureBox1.Location = new System.Drawing.Point(0, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMore);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblCredit);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblPay);
            this.groupBox1.Controls.Add(this.lblRecive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(355, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 223);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblThisMMore);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblThisMCredit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblThisMBalance);
            this.groupBox2.Controls.Add(this.lblThisMPay);
            this.groupBox2.Controls.Add(this.lblThisMRecive);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(355, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 212);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "گزارش های این ماه";
            // 
            // lblThisMMore
            // 
            this.lblThisMMore.Location = new System.Drawing.Point(10, 136);
            this.lblThisMMore.Name = "lblThisMMore";
            this.lblThisMMore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThisMMore.Size = new System.Drawing.Size(521, 34);
            this.lblThisMMore.TabIndex = 9;
            this.lblThisMMore.Text = "0";
            this.lblThisMMore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "متفرقه :";
            // 
            // lblThisMCredit
            // 
            this.lblThisMCredit.Location = new System.Drawing.Point(10, 102);
            this.lblThisMCredit.Name = "lblThisMCredit";
            this.lblThisMCredit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThisMCredit.Size = new System.Drawing.Size(521, 34);
            this.lblThisMCredit.TabIndex = 7;
            this.lblThisMCredit.Text = "0";
            this.lblThisMCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "بدهی ها :";
            // 
            // lblThisMBalance
            // 
            this.lblThisMBalance.Location = new System.Drawing.Point(10, 171);
            this.lblThisMBalance.Name = "lblThisMBalance";
            this.lblThisMBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThisMBalance.Size = new System.Drawing.Size(521, 34);
            this.lblThisMBalance.TabIndex = 5;
            this.lblThisMBalance.Text = "0";
            this.lblThisMBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblThisMPay
            // 
            this.lblThisMPay.Location = new System.Drawing.Point(10, 68);
            this.lblThisMPay.Name = "lblThisMPay";
            this.lblThisMPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThisMPay.Size = new System.Drawing.Size(521, 34);
            this.lblThisMPay.TabIndex = 4;
            this.lblThisMPay.Text = "0";
            this.lblThisMPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblThisMRecive
            // 
            this.lblThisMRecive.Location = new System.Drawing.Point(10, 35);
            this.lblThisMRecive.Name = "lblThisMRecive";
            this.lblThisMRecive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThisMRecive.Size = new System.Drawing.Size(521, 34);
            this.lblThisMRecive.TabIndex = 3;
            this.lblThisMRecive.Text = "0";
            this.lblThisMRecive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(537, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "مانده :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(537, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "دریافتی ها :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(537, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "پرداختی ها :";
            // 
            // lblPay
            // 
            this.lblPay.Location = new System.Drawing.Point(14, 65);
            this.lblPay.Name = "lblPay";
            this.lblPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPay.Size = new System.Drawing.Size(517, 34);
            this.lblPay.TabIndex = 4;
            this.lblPay.Text = "0";
            this.lblPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(14, 168);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBalance.Size = new System.Drawing.Size(517, 34);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "0";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "مانده :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(537, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "بدهی ها :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "دریافتی ها :";
            // 
            // lblCredit
            // 
            this.lblCredit.Location = new System.Drawing.Point(14, 99);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCredit.Size = new System.Drawing.Size(517, 34);
            this.lblCredit.TabIndex = 7;
            this.lblCredit.Text = "0";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "پرداختی ها :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(537, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 23);
            this.label13.TabIndex = 8;
            this.label13.Text = "متفرقه :";
            // 
            // lblRecive
            // 
            this.lblRecive.Location = new System.Drawing.Point(14, 32);
            this.lblRecive.Name = "lblRecive";
            this.lblRecive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRecive.Size = new System.Drawing.Size(517, 34);
            this.lblRecive.TabIndex = 3;
            this.lblRecive.Text = "0";
            this.lblRecive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMore
            // 
            this.lblMore.Location = new System.Drawing.Point(14, 133);
            this.lblMore.Name = "lblMore";
            this.lblMore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMore.Size = new System.Drawing.Size(517, 34);
            this.lblMore.TabIndex = 9;
            this.lblMore.Text = "0";
            this.lblMore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel date;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem تنظیماتورودToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblThisMMore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblThisMCredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblThisMBalance;
        private System.Windows.Forms.Label lblThisMPay;
        private System.Windows.Forms.Label lblThisMRecive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMore;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblRecive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}