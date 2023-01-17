namespace ExWinForm13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text))

            {

                MessageBox.Show("You have not entered full information !!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else

            {

                // tạo mới một ListViewItem

                ListViewItem lstvItem = new ListViewItem();

                lstvItem.Text = textBox1.Text;

                ListViewItem.ListViewSubItem lstvsub = new ListViewItem.ListViewSubItem(lstvItem, textBox2.Text);

                ListViewItem.ListViewSubItem lstvsub1 = new ListViewItem.ListViewSubItem(lstvItem, textBox3.Text);

                // thêm các thông tin vào các cột tương ứng trong ListView

                lstvItem.SubItems.Add(lstvsub);

                lstvItem.SubItems.Add(lstvsub1);

                listView1.Items.Add(lstvItem);

                MessageBox.Show("You have successfuly added your account", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // sau khi thêm thông tin ta sẽ xóa các thông tin đã nhập ở các ô textbox để có thể nhập và thêm mới tài khoản khác.

                textBox2.Clear();

                textBox3.Clear();

                textBox1.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)

            {

                MessageBox.Show("You have not selected the item you want to delete", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (listView1.SelectedIndices.Count > 0)

            {

                DialogResult dl = MessageBox.Show("Bạn muốn xóa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dl == DialogResult.OK)

                    listView1.Items.Remove(listView1.SelectedItems[0]);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dt == DialogResult.Yes)

            {

                Application.Exit();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want Open Application", "Ask client", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)

                Dispose();

        }
    }
}