namespace ExWinForm9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;

            int dayofmonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayofmonth);

        


    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar == ' ') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))

            {

                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");

            }

            else if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrEmpty(textBox2.Text) || !string.IsNullOrEmpty(textBox3.Text) == true)

            {

                MessageBox.Show("Chúc mừng bạn: " + textBox1.Text + "\nSố Điện Thoại: " + textBox2.Text + "\nEmail: " + textBox3.Text + "\nThời gian lựa chọn: " + dateTimePicker1.Value.ToShortDateString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}