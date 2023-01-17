using Npgsql;
using System.Data;

namespace lab01ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connetionString = "server=localhost;database=LAB_DATABASE CONNECTION_CSHARP_4LABS;uid=postgres;pwd=DvBI@185101;";
        NpgsqlConnection cnn = null;
        int result = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (cnn == null)
                cnn = new NpgsqlConnection(connetionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = cnn;
            command.CommandText = "insert into student(StudentID,SName,ClassID)" +
                "values(@StudentID,@SName,@ClassID)";
            NpgsqlParameter parameter1 = new NpgsqlParameter("@StudentID", textBox1.Text);
            command.Parameters.Add(parameter1);
            NpgsqlParameter parameter2 = new NpgsqlParameter("@SName", textBox2.Text);
            command.Parameters.Add(parameter2);
            NpgsqlParameter parameter3 = new NpgsqlParameter("ClassID", textBox3.Text);
            command.Parameters.Add(parameter3);

            try
            {
                result = command.ExecuteNonQuery();
                MessageBox.Show("\nInsert a sucesfull!!!!!!");
                //using ExecuteNonQuery if SQL command=insert, update or delete
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInsert a record failed!!!!!!");
            }

            if (result > 0)
            {
                ViewlistofStudent();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ViewlistofStudent();
        }
        private void ViewlistofStudent()
        {
            listView1.Items.Clear();

            if (cnn == null)
                cnn = new NpgsqlConnection(connetionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select * from student ", cnn);


            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classIDRow = reader.GetString(2);
                ListViewItem item = listView1.Items.Add(studentID);
                item.SubItems.Add(name);
                item.SubItems.Add(classIDRow);

            }
            cnn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cnn == null)
                cnn = new NpgsqlConnection(connetionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"update student set SName='{textBox2.Text}',ClassID='{textBox3.Text}' where StudentID='{textBox1.Text}'", cnn);
            try
            {
                result = command.ExecuteNonQuery();
                MessageBox.Show("\nUpdate a sucesfull!!!!!!");
                //using ExecuteNonQuery if SQL command=insert, update or delete
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUpdate a record failed!!!!!!");
            }

            if (result > 0)
            {
                ViewlistofStudent();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cnn == null)
                cnn = new NpgsqlConnection(connetionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"delete from student where StudentID='{textBox1.Text}'", cnn);
            try
            {
                result = command.ExecuteNonQuery();
                MessageBox.Show("\nDelete a sucesfull!!!!!!");
                //using ExecuteNonQuery if SQL command=insert, update or delete
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nDelete a record failed!!!!!!");
            }

            if (result > 0)
            {
                ViewlistofStudent();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}