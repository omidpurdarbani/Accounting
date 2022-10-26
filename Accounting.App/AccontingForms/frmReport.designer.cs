namespace Accounting.App
{
    partial class frmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnReportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReportRecive = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReportPay = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReportCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReportMore = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.search = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.ToDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiPrint = new Stimulsoft.Report.StiReport();
            this.toolStrip1.SuspendLayout();
            this.search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewTransaction,
            this.btnEdit,
            this.btnDelete,
            this.btnReport,
            this.btnRefresh,
            this.btnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.btnNewTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewTransaction.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(72, 59);
            this.btnNewTransaction.Text = "تراکنش جدید";
            this.btnNewTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 59);
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 59);
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReport
            // 
            this.btnReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReportAll,
            this.toolStripSeparator1,
            this.btnReportRecive,
            this.btnReportPay,
            this.btnReportCredit,
            this.btnReportMore});
            this.btnReport.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.btnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(65, 59);
            this.btnReport.Text = "گزارش ها";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnReportAll
            // 
            this.btnReportAll.Checked = true;
            this.btnReportAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnReportAll.Name = "btnReportAll";
            this.btnReportAll.Size = new System.Drawing.Size(128, 22);
            this.btnReportAll.Text = "همه";
            this.btnReportAll.Click += new System.EventHandler(this.btnReportAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // btnReportRecive
            // 
            this.btnReportRecive.Name = "btnReportRecive";
            this.btnReportRecive.Size = new System.Drawing.Size(128, 22);
            this.btnReportRecive.Text = "دریافتی ها";
            this.btnReportRecive.Click += new System.EventHandler(this.btnReportRecive_Click);
            // 
            // btnReportPay
            // 
            this.btnReportPay.Name = "btnReportPay";
            this.btnReportPay.Size = new System.Drawing.Size(128, 22);
            this.btnReportPay.Text = "پرداختی ها";
            this.btnReportPay.Click += new System.EventHandler(this.btnReportPay_Click);
            // 
            // btnReportCredit
            // 
            this.btnReportCredit.Name = "btnReportCredit";
            this.btnReportCredit.Size = new System.Drawing.Size(128, 22);
            this.btnReportCredit.Text = "بدهکاری ها";
            this.btnReportCredit.Click += new System.EventHandler(this.btnReportCredit_Click);
            // 
            // btnReportMore
            // 
            this.btnReportMore.Name = "btnReportMore";
            this.btnReportMore.Size = new System.Drawing.Size(128, 22);
            this.btnReportMore.Text = "متفرقه ها";
            this.btnReportMore.Click += new System.EventHandler(this.btnReportMore_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Accounting.App.Properties.Resources._1371476342_Refresh;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 59);
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Accounting.App.Properties.Resources._1371476276_Print;
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(44, 59);
            this.btnPrint.Text = "چاپ";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // search
            // 
            this.search.Controls.Add(this.btnFilter);
            this.search.Controls.Add(this.ToDate);
            this.search.Controls.Add(this.label4);
            this.search.Controls.Add(this.FromDate);
            this.search.Controls.Add(this.label3);
            this.search.Controls.Add(this.cbCustomer);
            this.search.Controls.Add(this.label2);
            this.search.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.search.Location = new System.Drawing.Point(12, 65);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(660, 70);
            this.search.TabIndex = 2;
            this.search.TabStop = false;
            this.search.Text = "جستجو";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Window;
            this.btnFilter.Location = new System.Drawing.Point(6, 22);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(56, 36);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "انجام";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ToDate
            // 
            this.ToDate.BackColor = System.Drawing.SystemColors.Window;
            this.ToDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDate.Location = new System.Drawing.Point(110, 30);
            this.ToDate.Mask = "0000/00/00";
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(78, 23);
            this.ToDate.TabIndex = 5;
            this.ToDate.ValidatingType = typeof(System.DateTime);
            this.ToDate.Click += new System.EventHandler(this.ToDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(194, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "تا تاریخ :";
            // 
            // FromDate
            // 
            this.FromDate.BackColor = System.Drawing.SystemColors.Window;
            this.FromDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDate.Location = new System.Drawing.Point(284, 30);
            this.FromDate.Mask = "0000/00/00";
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(76, 23);
            this.FromDate.TabIndex = 3;
            this.FromDate.ValidatingType = typeof(System.DateTime);
            this.FromDate.Click += new System.EventHandler(this.FromDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(366, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "از تاریخ :";
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(426, 32);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(139, 21);
            this.cbCustomer.TabIndex = 1;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(571, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "طرف حساب :";
            // 
            // dgReport
            // 
            this.dgReport.AllowUserToAddRows = false;
            this.dgReport.AllowUserToDeleteRows = false;
            this.dgReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReport.BackgroundColor = System.Drawing.Color.White;
            this.dgReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Type,
            this.Column4,
            this.Column5});
            this.dgReport.Location = new System.Drawing.Point(12, 141);
            this.dgReport.Name = "dgReport";
            this.dgReport.ReadOnly = true;
            this.dgReport.Size = new System.Drawing.Size(660, 308);
            this.dgReport.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerID";
            this.Column2.FillWeight = 151.548F;
            this.Column2.HeaderText = "طرف حساب";
            this.Column2.MinimumWidth = 123;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Amount";
            this.Column3.FillWeight = 91.65049F;
            this.Column3.HeaderText = "مبلغ";
            this.Column3.MinimumWidth = 74;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "TypeID";
            this.Type.HeaderText = "نوع";
            this.Type.MaxInputLength = 10;
            this.Type.MinimumWidth = 81;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateTime";
            this.Column4.FillWeight = 146.6492F;
            this.Column4.HeaderText = "تاریخ";
            this.Column4.MinimumWidth = 119;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Description";
            this.Column5.FillWeight = 10.15228F;
            this.Column5.HeaderText = "بابت";
            this.Column5.MinimumWidth = 220;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // stiPrint
            // 
            this.stiPrint.CookieContainer = null;
            this.stiPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiPrint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiPrint.ReportAlias = "Report";
            this.stiPrint.ReportGuid = "71fea810061b46a499d8267123abaa94";
            this.stiPrint.ReportName = "Report";
            this.stiPrint.ReportSource = null;
            this.stiPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiPrint.UseProgressInThread = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.dgReport);
            this.Controls.Add(this.search);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انجام";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.GroupBox search;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.MaskedTextBox ToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox FromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripButton btnNewTransaction;
        private System.Windows.Forms.ToolStripDropDownButton btnReport;
        private System.Windows.Forms.ToolStripMenuItem btnReportAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnReportRecive;
        private System.Windows.Forms.ToolStripMenuItem btnReportPay;
        private System.Windows.Forms.ToolStripMenuItem btnReportCredit;
        private System.Windows.Forms.ToolStripMenuItem btnReportMore;
        private Stimulsoft.Report.StiReport stiPrint;
    }
}