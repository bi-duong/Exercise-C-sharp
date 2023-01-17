namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadCategories()
        {
            var categories = ManageCategories.Instance.GetCategories();
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", categories, "CategoryID");
            textBox2.DataBindings.Add("Text", categories, "CategoryName");
            dataGridView1.DataSource = categories;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { CategoryName = textBox2.Text };
                ManageCategories.Instance.InsertCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Category");
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
                var category = new Category
                {
                    CategoryID = int.Parse(textBox1.Text),
                    CategoryName = textBox2.Text
                };
                ManageCategories.Instance.UpdateCategory(category);
                LoadCategories();
            }
        catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Category");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { CategoryID = int.Parse(textBox1.Text) };
                ManageCategories.Instance.DeleteCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Category");
            }
        }
    }
}