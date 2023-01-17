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

namespace lab03ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.lAB_DATABASE_CONNECTION_CSHARP_4LABSDataSet.student);

        }
        string connetionString = "server=localhost;database=LAB_DATABASE CONNECTION_CSHARP_4LABS;uid=postgres;pwd=DvBI@185101;";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox1.Text);
        }
        public void searchData(string valueToFind)
        {

            string searchQuery = "select * from student where SName like'%" + valueToFind + "%'";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(searchQuery, connetionString);
            DataTable table = new DataTable();
            adapter.Fill(table);
            studentDataGridView.DataSource = table;

        }
    }
}
