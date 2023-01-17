namespace lab03ex2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label classidLabel;
            System.Windows.Forms.Label classnameLabel;
            System.Windows.Forms.Label yearsLabel;
            this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet = new lab03ex2.LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet();
            this.classsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classsTableAdapter = new lab03ex2.LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSetTableAdapters.classsTableAdapter();
            this.tableAdapterManager = new lab03ex2.LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSetTableAdapters.TableAdapterManager();
            this.classsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.classsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new lab03ex2.LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSetTableAdapters.studentTableAdapter();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classssTableAdapter = new lab03ex2.LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSetTableAdapters.classssTableAdapter();
            this.classidComboBox = new System.Windows.Forms.ComboBox();
            this.classnameComboBox = new System.Windows.Forms.ComboBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            classidLabel = new System.Windows.Forms.Label();
            classnameLabel = new System.Windows.Forms.Label();
            yearsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classsBindingNavigator)).BeginInit();
            this.classsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classssBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet
            // 
            this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet.DataSetName = "LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet";
            this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classsBindingSource
            // 
            this.classsBindingSource.DataMember = "classs";
            this.classsBindingSource.DataSource = this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet;
            // 
            // classsTableAdapter
            // 
            this.classsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classssTableAdapter = this.classssTableAdapter;
            this.tableAdapterManager.classsTableAdapter = this.classsTableAdapter;
            this.tableAdapterManager.studentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = lab03ex2.LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // classsBindingNavigator
            // 
            this.classsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.classsBindingNavigator.BindingSource = this.classsBindingSource;
            this.classsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.classsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.classsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.classsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.classsBindingNavigatorSaveItem});
            this.classsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.classsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.classsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.classsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.classsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.classsBindingNavigator.Name = "classsBindingNavigator";
            this.classsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.classsBindingNavigator.Size = new System.Drawing.Size(814, 38);
            this.classsBindingNavigator.TabIndex = 0;
            this.classsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // classsBindingNavigatorSaveItem
            // 
            this.classsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.classsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("classsBindingNavigatorSaveItem.Image")));
            this.classsBindingNavigatorSaveItem.Name = "classsBindingNavigatorSaveItem";
            this.classsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.classsBindingNavigatorSaveItem.Text = "Save Data";
            this.classsBindingNavigatorSaveItem.Click += new System.EventHandler(this.classsBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(627, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(42, 314);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersWidth = 62;
            this.studentDataGridView.RowTemplate.Height = 28;
            this.studentDataGridView.Size = new System.Drawing.Size(714, 220);
            this.studentDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "studentid";
            this.dataGridViewTextBoxColumn1.HeaderText = "studentid";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sname";
            this.dataGridViewTextBoxColumn2.HeaderText = "sname";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "classid";
            this.dataGridViewTextBoxColumn3.HeaderText = "classid";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // classssBindingSource
            // 
            this.classssBindingSource.DataMember = "classss";
            this.classssBindingSource.DataSource = this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet;
            // 
            // classssTableAdapter
            // 
            this.classssTableAdapter.ClearBeforeFill = true;
            // 
            // classidLabel
            // 
            classidLabel.AutoSize = true;
            classidLabel.Location = new System.Drawing.Point(110, 82);
            classidLabel.Name = "classidLabel";
            classidLabel.Size = new System.Drawing.Size(69, 20);
            classidLabel.TabIndex = 8;
            classidLabel.Text = "Class ID";
            // 
            // classidComboBox
            // 
            this.classidComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classssBindingSource, "classid", true));
            this.classidComboBox.DataSource = this.classssBindingSource;
            this.classidComboBox.DisplayMember = "classid";
            this.classidComboBox.FormattingEnabled = true;
            this.classidComboBox.Location = new System.Drawing.Point(327, 82);
            this.classidComboBox.Name = "classidComboBox";
            this.classidComboBox.Size = new System.Drawing.Size(121, 28);
            this.classidComboBox.TabIndex = 9;
            // 
            // classnameLabel
            // 
            classnameLabel.AutoSize = true;
            classnameLabel.Location = new System.Drawing.Point(82, 148);
            classnameLabel.Name = "classnameLabel";
            classnameLabel.Size = new System.Drawing.Size(94, 20);
            classnameLabel.TabIndex = 9;
            classnameLabel.Text = "Class Name";
            // 
            // classnameComboBox
            // 
            this.classnameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classssBindingSource, "classname", true));
            this.classnameComboBox.DataSource = this.classssBindingSource;
            this.classnameComboBox.DisplayMember = "classname";
            this.classnameComboBox.FormattingEnabled = true;
            this.classnameComboBox.Location = new System.Drawing.Point(327, 148);
            this.classnameComboBox.Name = "classnameComboBox";
            this.classnameComboBox.Size = new System.Drawing.Size(121, 28);
            this.classnameComboBox.TabIndex = 10;
            // 
            // yearsLabel
            // 
            yearsLabel.AutoSize = true;
            yearsLabel.Location = new System.Drawing.Point(120, 204);
            yearsLabel.Name = "yearsLabel";
            yearsLabel.Size = new System.Drawing.Size(43, 20);
            yearsLabel.TabIndex = 10;
            yearsLabel.Text = "Year";
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classssBindingSource, "years", true));
            this.yearsTextBox.Location = new System.Drawing.Point(348, 204);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(100, 26);
            this.yearsTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(814, 554);
            this.Controls.Add(yearsLabel);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(classnameLabel);
            this.Controls.Add(this.classnameComboBox);
            this.Controls.Add(classidLabel);
            this.Controls.Add(this.classidComboBox);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.classsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classsBindingNavigator)).EndInit();
            this.classsBindingNavigator.ResumeLayout(false);
            this.classsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classssBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet;
        private System.Windows.Forms.BindingSource classsBindingSource;
        private LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSetTableAdapters.classsTableAdapter classsTableAdapter;
        private LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator classsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton classsBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private LAB_DATABASE_CONNECTION_CSHARP_4LABSDataSetTableAdapters.classssTableAdapter classssTableAdapter;
        private System.Windows.Forms.BindingSource classssBindingSource;
        private System.Windows.Forms.ComboBox classidComboBox;
        private System.Windows.Forms.ComboBox classnameComboBox;
        private System.Windows.Forms.TextBox yearsTextBox;
    }
}

