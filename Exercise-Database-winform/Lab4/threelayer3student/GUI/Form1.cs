using BLL;
using DTO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StudentAccessBLL studentAccessBLL = new StudentAccessBLL();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        public void LoadStudents()
        {
            List<Student> students = studentAccessBLL.GetStudents();
            BindingSource source = new BindingSource();
            foreach (var student in students)
            {
                source.Add(student);
            }

            dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (studentAccessBLL.InsertStudent(new Student(textBox1.Text, textBox2.Text, textBox3.Text)))
            {
                LoadStudents();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (studentAccessBLL.UpdateStudent(new Student(textBox1.Text, textBox2.Text, textBox3.Text)))
            {
                LoadStudents();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (studentAccessBLL.DeleteStudent(textBox1.Text))
            {
                LoadStudents();
            }
        }
    }
}