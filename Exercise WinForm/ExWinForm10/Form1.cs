namespace ExWinForm10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dt == DialogResult.Yes)

            {

                Application.Exit();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now.Add(new TimeSpan());

            label1.Text = String.Format("{0:hh:mm:ss tt}", dt);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());

            label2.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void hiểnThịThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void hiểnThịNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}