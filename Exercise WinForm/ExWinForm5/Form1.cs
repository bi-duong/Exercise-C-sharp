namespace ExWinForm5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text))

            {

                MessageBox.Show("Đăng nhập thành công !!!");

            }

            else

            {

                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)

            {

                textBox2.PasswordChar = (char)0;

            }

            else

            {

                textBox2.PasswordChar = '*';

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

        private void Form1_Load_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Chỉ được nhập ký tự a-z và 0-9");

            toolTip1.SetToolTip(textBox2, "Chỉ được nhập ký tự từ 0-9");

            helpProvider1.HelpNamespace = "Bi Duong";
        }
    }
}