using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet.classss' table. You can move, or remove it, as needed.
            this.classssTableAdapter.Fill(this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet.classss);
            // TODO: This line of code loads data into the 'lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet.student);
            // TODO: This line of code loads data into the 'lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet.classs' table. You can move, or remove it, as needed.
            this.classsTableAdapter.Fill(this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet.classs);

        }

        private void classsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet);

        }
        string connetionString = "server=localhost;database=LAB_DATABASE CONNECTION_CSHARP_4LABS;uid=postgres;pwd=DvBI@185101;";
        string str;
        private void button1_Click(object sender, EventArgs e)
        {
            str = $"select *from student where ClassID='{classidComboBox.Text}'";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(str, connetionString);
            DataTable table = new DataTable();
            adapter.Fill(table);
            studentDataGridView.DataSource = table;
        }
    }
}
