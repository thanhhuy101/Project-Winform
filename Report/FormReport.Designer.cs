namespace Report
{
    partial class FormReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vw_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.huynhhuu_foodDataSet = new Report.huynhhuu_foodDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_report = new System.Windows.Forms.Button();
            this.vw_ReportTableAdapter = new Report.huynhhuu_foodDataSetTableAdapters.vw_ReportTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huynhhuu_foodDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_ReportBindingSource
            // 
            this.vw_ReportBindingSource.DataMember = "vw_Report";
            this.vw_ReportBindingSource.DataSource = this.huynhhuu_foodDataSet;
            // 
            // huynhhuu_foodDataSet
            // 
            this.huynhhuu_foodDataSet.DataSetName = "huynhhuu_foodDataSet";
            this.huynhhuu_foodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DSFood";
            reportDataSource1.Value = this.vw_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report.Report.rpt_Food.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(94, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(827, 302);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_report
            // 
            this.btn_report.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_report.Location = new System.Drawing.Point(963, 125);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(120, 73);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "Load Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // vw_ReportTableAdapter
            // 
            this.vw_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order ID";
            // 
            // txt_orderID
            // 
            this.txt_orderID.Location = new System.Drawing.Point(290, 23);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(243, 22);
            this.txt_orderID.TabIndex = 3;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 450);
            this.Controls.Add(this.txt_orderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huynhhuu_foodDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.BindingSource vw_ReportBindingSource;
        private huynhhuu_foodDataSet huynhhuu_foodDataSet;
        private huynhhuu_foodDataSetTableAdapters.vw_ReportTableAdapter vw_ReportTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_orderID;
    }
}

