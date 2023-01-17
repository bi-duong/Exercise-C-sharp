using Npgsql;
using System.Data;

namespace lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connetionString = "server=localhost;database=LAB_DATABASE CONNECTION_CSHARP_4LABS;uid=postgres;pwd=DvBI@185101;";
        NpgsqlConnection cnn = null;
        DataSet ds = null;
        NpgsqlDataAdapter adapter;
        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new NpgsqlDataAdapter("select * from student", connetionString);
            NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "Student");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = 0;
            DataRow row = ds.Tables[0].NewRow();
            row[0] = textBox1.Text;
            row["SName"] = textBox2.Text;
            row[2] = textBox3.Text;
            ds.Tables[0].Rows.Add(row);
            try
            {
                adapter.Update(ds, "Student");

                //using ExecuteNonQuery if SQL command=insert, update or delete
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInsert a record failed!!!!!!");
            }
            if (result > 0)
            {
                MessageBox.Show("\nInsert a sucesfull!!!!!!");
            }
        }
        int postion = -1;
        private void button3_Click(object sender, EventArgs e)
        {
            if (postion == -1)
            {
                MessageBox.Show("No row is selected!");
                return;
            }
            DataRow row = ds.Tables[0].Rows[postion];
            row.BeginEdit();
            row[0] = textBox1.Text;
            row[1] = textBox2.Text;
            row[2] = textBox3.Text;
            row.EndEdit();
            int result = adapter.Update(ds.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("\nUpdate a sucesfull!!!!!!");
            }
            else
            {
                MessageBox.Show("\nUpdate a faild!!!!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (postion == -1)
            {

                return;
            }
            DataRow row = ds.Tables[0].Rows[postion];
            row.Delete();
            int result = adapter.Update(ds.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("\nDelete a sucesfull!!!!!!");
            }
            else
            {
                MessageBox.Show("\nDelete a faild!!!!!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            postion = e.RowIndex;
            if (postion == -1)
            {
                MessageBox.Show("No row is selected!");
                return;
            }
            DataRow row = ds.Tables[0].Rows[postion];
            textBox1.Text = row[0].ToString();
            textBox2.Text = row["SName"].ToString();
            textBox3.Text = row[2].ToString();
        }
    }
}