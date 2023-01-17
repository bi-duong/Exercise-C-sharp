using Npgsql;
using System.Data;

namespace lab01ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connetionString = "server=localhost;database=LAB_DATABASE CONNECTION_CSHARP_4LABS;uid=postgres;pwd=DvBI@185101;";
        NpgsqlConnection cnn = null;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            if (cnn == null)
                cnn = new NpgsqlConnection(connetionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();

            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"select* from classs where ClassID = '{textBox1.Text}'";
            command.Connection = cnn;
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader.GetString(0);
                textBox3.Text = reader.GetString(1);
                textBox4.Text = reader.GetInt32(2).ToString();
            }
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (cnn == null)
                cnn = new NpgsqlConnection(connetionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"select * from student where ClassID='{textBox1.Text}'", cnn);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classID = reader.GetString(2);
                ListViewItem item = new ListViewItem(studentID);

                item.SubItems.Add(name);
                item.SubItems.Add(classID);
                listView1.Items.Add(item);
            }
            cnn.Close();
        }
    }
}