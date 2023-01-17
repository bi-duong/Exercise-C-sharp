using Npgsql;
using System.Data;

namespace lab01ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            NpgsqlConnection cnn;
            connetionString = "server=localhost;database=LAB_DATABASE CONNECTION_CSHARP_4LABS;uid=postgres;pwd=DvBI@185101;";
            cnn = new NpgsqlConnection(connetionString);
            try
            {
                // Initialization
                if (cnn == null)
                    cnn = new NpgsqlConnection(connetionString);
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                NpgsqlCommand sqlcom = new NpgsqlCommand($"Select count(*) from student where ClassID='{textBox1.Text}'", cnn);
                long result = (long)sqlcom.ExecuteScalar();
                textBox2.Text = result.ToString();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to MYSQL. Error: " + ex.Message);
            }
        }
    }
}