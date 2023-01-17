using Npgsql;
using System.Data;

namespace lab01ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connetionString = "server=localhost;database=LAB_DATABASE CONNECTION_CSHARP_4LABS;uid=postgres;pwd=DvBI@185101;";
        NpgsqlConnection cnn = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (cnn == null)
                cnn = new NpgsqlConnection(connetionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            NpgsqlCommand command = new NpgsqlCommand("select * from classs", cnn);
            listBox1.ClearSelected();
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string name = reader.GetString(1);
                int year = reader.GetInt32(2);
                string line = id + "-" + name + "-" + year.ToString();
                listBox1.Items.Add(line);
            }
            cnn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (listBox1.SelectedIndex == -1) return;
            string line = listBox1.SelectedItem.ToString();
            string[] array = line.Split('-');
            string classID = array[0];

            if (cnn == null)
                cnn = new NpgsqlConnection(connetionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"Select * from student where ClassID = '{classID}'", cnn);


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
    }
}