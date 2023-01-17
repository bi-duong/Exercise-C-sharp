namespace SalesWinApp
{
    partial class frmProducts
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
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.txtMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.txtMinPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).BeginInit();
            this.grbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPrice)).BeginInit();
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
            this.dvgData.Location = new System.Drawing.Point(12, 16);
            this.dvgData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvgData.Name = "dvgData";
            this.dvgData.RowHeadersVisible = false;
            this.dvgData.RowHeadersWidth = 50;
            this.dvgData.RowTemplate.Height = 29;
            this.dvgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgData.Size = new System.Drawing.Size(952, 485);
            this.dvgData.TabIndex = 0;
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.txtStock);
            this.grbFilter.Controls.Add(this.txtMaxPrice);
            this.grbFilter.Controls.Add(this.txtMinPrice);
            this.grbFilter.Controls.Add(this.label5);
            this.grbFilter.Controls.Add(this.btnClear);
            this.grbFilter.Controls.Add(this.txtProductName);
            this.grbFilter.Controls.Add(this.txtProductID);
            this.grbFilter.Controls.Add(this.label4);
            this.grbFilter.Controls.Add(this.label3);
            this.grbFilter.Controls.Add(this.label2);
            this.grbFilter.Controls.Add(this.label1);
            this.grbFilter.Location = new System.Drawing.Point(1004, 14);
            this.grbFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFilter.Size = new System.Drawing.Size(355, 402);
            this.grbFilter.TabIndex = 1;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filter";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(145, 275);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(188, 31);
            this.txtStock.TabIndex = 14;
            this.txtStock.ValueChanged += new System.EventHandler(this.txtStock_ValueChanged);
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.DecimalPlaces = 4;
            this.txtMaxPrice.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtMaxPrice.Location = new System.Drawing.Point(145, 218);
            this.txtMaxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(188, 31);
            this.txtMaxPrice.TabIndex = 13;
            this.txtMaxPrice.ValueChanged += new System.EventHandler(this.txtMaxPrice_ValueChanged);
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.DecimalPlaces = 4;
            this.txtMinPrice.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtMinPrice.Location = new System.Drawing.Point(145, 160);
            this.txtMinPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(188, 31);
            this.txtMinPrice.TabIndex = 12;
            this.txtMinPrice.ValueChanged += new System.EventHandler(this.txtMinPrice_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Min In Stock";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(101, 339);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 36);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear filter";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(145, 106);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(184, 31);
            this.txtProductName.TabIndex = 6;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(145, 49);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(184, 31);
            this.txtProductID.TabIndex = 4;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1004, 435);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 66);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1130, 435);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 66);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(1256, 435);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 66);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 581);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbFilter);
            this.Controls.Add(this.dvgData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProducts";
            this.Text = "Product Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).EndInit();
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dvgData;
        private GroupBox grbFilter;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClear;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label5;
        private NumericUpDown txtStock;
        private NumericUpDown txtMaxPrice;
        private NumericUpDown txtMinPrice;
    }
}