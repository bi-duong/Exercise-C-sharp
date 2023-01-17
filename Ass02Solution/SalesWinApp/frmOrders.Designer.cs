namespace SalesWinApp
{
    partial class frmOrders
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
            this.dvgData = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.grbReport = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).BeginInit();
            this.grbReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgData
            // 
            this.dvgData.AllowUserToAddRows = false;
            this.dvgData.AllowUserToDeleteRows = false;
            this.dvgData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dvgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgData.Location = new System.Drawing.Point(15, 15);
            this.dvgData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvgData.Name = "dvgData";
            this.dvgData.RowHeadersVisible = false;
            this.dvgData.RowHeadersWidth = 50;
            this.dvgData.RowTemplate.Height = 29;
            this.dvgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgData.Size = new System.Drawing.Size(1002, 510);
            this.dvgData.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1039, 35);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 74);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1182, 35);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 74);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1322, 35);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 74);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(1166, 164);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(149, 74);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "View Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // grbReport
            // 
            this.grbReport.Controls.Add(this.btnGenerate);
            this.grbReport.Controls.Add(this.label2);
            this.grbReport.Controls.Add(this.label1);
            this.grbReport.Controls.Add(this.startDatePicker);
            this.grbReport.Controls.Add(this.endDatePicker);
            this.grbReport.Location = new System.Drawing.Point(1054, 264);
            this.grbReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbReport.Name = "grbReport";
            this.grbReport.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbReport.Size = new System.Drawing.Size(369, 261);
            this.grbReport.TabIndex = 5;
            this.grbReport.TabStop = false;
            this.grbReport.Text = "Report Generator";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(46, 204);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(266, 41);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Sales Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(25, 74);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(312, 31);
            this.startDatePicker.TabIndex = 1;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(25, 165);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(312, 31);
            this.endDatePicker.TabIndex = 0;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 562);
            this.ControlBox = false;
            this.Controls.Add(this.grbReport);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dvgData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmOrders";
            this.Text = "Order Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).EndInit();
            this.grbReport.ResumeLayout(false);
            this.grbReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dvgData;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDetail;
        private GroupBox grbReport;
        private Label label1;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private Button btnGenerate;
        private Label label2;
    }
}