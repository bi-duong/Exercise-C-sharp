using System.Text;

namespace Slideex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            String name = textBox2.Text;
            String phone = textBox3.Text;
            string gender = (radioButton1.Checked ? "Male" : "female");
            
            string de = comboBox1.Text;
            StringBuilder buil = new StringBuilder();
            buil.Append($"Employee ID: {id}\n");
            buil.Append($"Employee Name: {name}\n");
            buil.Append($"Employee Phone: {phone}\n");
            buil.Append($"Employee Gender: {gender}\n");
            buil.Append($"Employee Degree: {de}\n");
            MessageBox.Show(buil.ToString(), "Employee Details");
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