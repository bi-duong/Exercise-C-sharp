namespace ExWinForm11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());

            label1.Text = String.Format("{0:hh:mm:ss tt}", dt);
        }

        private void displayDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());

            label2.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void menuExitCrlTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dt == DialogResult.Yes)

            {

                Application.Exit();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}