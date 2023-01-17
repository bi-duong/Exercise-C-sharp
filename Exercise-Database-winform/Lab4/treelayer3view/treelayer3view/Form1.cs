using BLL;
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace treelayer3view
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
            
        }
        public void LoadStudents()
        {
            List<Student> students = studentAccessBLL.GetStudents();
            
            foreach (Student s in students)
            {
                ListViewItem item = new ListViewItem(s.ID.ToString());
                item.SubItems.Add(s.Name);
                item.SubItems.Add(s.ClassID.ToString());
                listView.Items.Add(item);
            }
            
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}