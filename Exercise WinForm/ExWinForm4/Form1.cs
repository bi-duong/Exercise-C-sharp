namespace ExWinForm4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))

            {

                listBox1.Items.Add(textBox1.Text);

                textBox2.Text = listBox1.Items.Count.ToString();

                textBox1.Clear();

                textBox1.Focus();

            }

            else

                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);

            if (listBox1.SelectedItems.Count != 0)

            {

                listBox1.Items.Remove(listBox1.SelectedItems[0]);

            }

            textBox2.Text = (a - 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);

            listBox1.Items.RemoveAt(0);

            textBox2.Text = (a - 1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            textBox2.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);

            textBox2.Text = (a - 1).ToString();
        }
    }
}