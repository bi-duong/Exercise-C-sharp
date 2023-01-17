using System.Drawing;
using System.Windows.Forms;

namespace Slideex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayImage();
        }
        private void DisplayImage()
        {
            PictureBox imageControl = new PictureBox();
            imageControl.Width = 500;

            imageControl.Height = 500;

            imageControl.Location = new Point(190, 100);

            Bitmap image = new Bitmap("D:/m.jpg");
            imageControl.SizeMode = PictureBoxSizeMode.StretchImage;
            imageControl.Image = (Image)image;
            Controls.Add(imageControl);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            DisplayImage();
        }
    }
}