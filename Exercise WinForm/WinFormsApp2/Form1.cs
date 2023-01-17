namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn mở chương trình", "Hỏi người dùng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)

                Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên của bạn là: " + textBox1.Text);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)

            //Lưu ý: bật KeyPreview == true trước khi chạy Form

            {

                // gán nội dung "Hello Freetuts.net" vào ô TextBox

                textBox1.Text = "Hello Bi Duong !!!";

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                MessageBox.Show("Bạn vừa click chuột trái");

            }

            if (e.Button == MouseButtons.Right)

            {

                MessageBox.Show("Bạn vừa click chuột phải");

            }

            if (e.Button == MouseButtons.Middle)

            {

                MessageBox.Show("Bạn vừa click chuột giữa");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng chương trình", "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)

            {

                Application.Exit();

            }
        }
    }
}