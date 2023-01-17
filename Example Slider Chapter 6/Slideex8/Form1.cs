using Timer = System.Windows.Forms.Timer;

namespace Slideex8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());

            label1.Text = String.Format("{0:hh:mm:ss tt}", dt);
        }
    }
}