namespace ExWinForm6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Enabled == true)

            {

                progressBar1.Enabled = false;

                timer2.Start();

                timer1.Start();

            }

            else

            {

                progressBar1.Enabled = true;

                timer2.Stop();

                timer1.Stop();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());

            label2.Text = String.Format("{0:hh:mm:ss tt}", dt);

            label3.Text = String.Format("{0:dd/MM/yyyy}", dt);

        


    }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            progressBar1.Increment(1);

            label4.Text = "Connecting to from " + progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)

            {

                timer2.Enabled = false;

                frm.ShowDialog();

            }
        }
    }
}