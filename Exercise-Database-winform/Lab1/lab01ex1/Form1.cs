using Npgsql;
namespace lab01ex1
{
    public partial class Form1 : Form
    {

        NpgsqlConnection conn = null;
        string connetionString = "server=localhost;database=LAB_DATABASE CONNECTION_CSHARP_4LABS;uid=postgres;pwd=DvBI@185101;";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Initialization
                conn = new NpgsqlConnection(connetionString);

                // Open connection
                conn.Open();

                MessageBox.Show("Successfully connected to PostgreSQL.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to PostgreSQL. Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Successfully Disconnected to PostgreSQL.");
            }
        }
    }
}