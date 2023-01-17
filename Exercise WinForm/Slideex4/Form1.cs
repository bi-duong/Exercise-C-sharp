using System.Data;

namespace Slideex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable products = new DataTable();
            products.Columns.Add("ProductTD", typeof(int));
            products.Columns.Add("ProductName", typeof(string));
            products.Columns.Add("UnitPrice", typeof(decimal));
            products.Rows.Add(1, "Mouse",19.5);
            products.Rows.Add(2, "Keyboard", 29.8);
            dataGridView1.DataSource = products;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<dynamic> products = new List<dynamic>{
            new {ProductID=3, ProductName="Speaken",UnitPrice=14.9},
            new {ProductID=4, ProductName="Monitor",UnitPrice=59.5}
            };
           dataGridView1.DataSource = products;
        }
    }
}