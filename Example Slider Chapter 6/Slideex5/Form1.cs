using System.Drawing;

namespace Slideex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       
        public void CreateMyRichTextBox()
        {
            RichTextBox rtbData = new RichTextBox();
            rtbData.Dock = DockStyle.Fill;
            rtbData.LoadFile("D:/test.txt");
            rtbData.Find("Bi Duong Van", RichTextBoxFinds.MatchCase);
            rtbData.SelectionColor = Color.Red;
            rtbData.SaveFile("D:/test.txt", RichTextBoxStreamType.RichText);
            this.Controls.Add(rtbData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateMyRichTextBox();
        }
    }
}