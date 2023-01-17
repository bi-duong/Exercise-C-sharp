namespace Slideex3
{
    public partial class Form1 : Form
    {
        private int count;
        public Form1()
        {
            InitializeComponent();
            count=0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //img();

        }
        public void img()
        {
            //ImageList list = new ImageList();
            //Image imagel = Image.FromFile(@"D:/m.jpg");
            //Image image2 = Image.FromFile(@"D:/m.jpg");
            //list.Images.AddRange(new Image[] { imagel, image2 });
            //list.ImageSize = new Size(255, 255);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count > 3)
                count = 0;
            label1.ImageIndex = count;
        }
    }
}