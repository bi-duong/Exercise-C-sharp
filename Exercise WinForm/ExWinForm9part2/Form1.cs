using System.Windows.Forms;

namespace ExWinForm9part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();

            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();

            textBox3.Text = monthCalendar1.MinDate.ToShortDateString();

            textBox4.Text = monthCalendar1.MaxDate.ToShortDateString();

            textBox5.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numhour;

            numhour = Convert.ToInt32((monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalDays);

            textBox6.Text = numhour.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numhour;

            numhour = Convert.ToInt32((monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalHours);

            textBox7.Text = numhour.ToString();
        }
    }
}