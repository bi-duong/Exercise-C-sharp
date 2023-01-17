using System.Xml.Linq;

namespace ExWinForm8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool t = false;

            if (!string.IsNullOrEmpty(textBox1.Text))

            {

                TreeNode Node = new TreeNode();

                Node.Text = textBox1.Text;

                foreach (TreeNode nodex in treeView1.Nodes)

                {

                    if (string.Equals(Node.Text, nodex.Text))

                    {

                        MessageBox.Show("Node đã tồn tại");

                        t = true;

                    }

                }

                if (t == false) treeView1.Nodes.Add(Node);

                textBox1.Clear();

                textBox1.Focus();

            }

            else

                MessageBox.Show("Node không được để trống");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))

            {

                if (treeView1.SelectedNode != null)

                {

                    TreeNode Subnode = new TreeNode();

                    Subnode.Text = textBox1.Text;

                    treeView1.SelectedNode.Nodes.Add(Subnode);
                    textBox1.Clear();

                    textBox1.Focus();

                }

                else

                    MessageBox.Show("Bạn chưa chọn vị trí tạo Node con");

            }

            else

                MessageBox.Show("Node không được để trống");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)

                treeView1.SelectedNode.Remove();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = treeView1.GetNodeCount(true);

            MessageBox.Show("Tổng số Node của TreeView : " + n);
        }
    }
}