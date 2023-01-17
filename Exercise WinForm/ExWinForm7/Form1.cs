namespace ExWinForm7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = textBox1.Text;
                listView1.Items.Add(item);

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (textBox2.Text));
                item.SubItems.Add(subitem);

                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus
                    ();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Bạn muốn xóa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                    listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else MessageBox.Show("Xóa lỗi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}