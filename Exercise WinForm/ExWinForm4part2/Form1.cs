namespace ExWinForm4part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Yellow")

            {

                label2.BackColor = Color.Red;

                label2.ForeColor = Color.Yellow;

            }

            if (comboBox1.Text == "Red")

            {

                label2.BackColor = Color.Yellow;

                label2.ForeColor = Color.Red;

            }

            if (comboBox1.Text == "Blue")

            {

                label2.BackColor = Color.Yellow;

                label2.ForeColor = Color.Blue;

            }

            if (comboBox1.Text == "Black")

            {

                label2.BackColor = Color.White;

                label2.ForeColor = Color.Black;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)

            {

                Application.Exit();

            }
        }
    }
}