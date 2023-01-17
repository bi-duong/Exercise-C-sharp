using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace Slideex10
{
   
    public partial class Form1 : Form
    {
        int counter = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateMyMainMenu();
            IsMdiContainer=true;
        }
        public void CreateMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            ToolStripMenuItem menuFile = new ToolStripMenuItem("&File");
            ToolStripMenuItem mnuOpen = new ToolStripMenuItem("&Open");
            ToolStripSeparator separator = new ToolStripSeparator();
            ToolStripMenuItem mnuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem mnuWindow = new ToolStripMenuItem("&Window");
            // mainMenu
            mainMenu.Items.AddRange(new ToolStripItem[] { menuFile, mnuWindow });
            mainMenu.MdiWindowListItem = mnuWindow;
            // menuFile
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuOpen, separator, mnuExit });
            // mnuOpen
            mnuOpen.ShortcutKeys = (Keys)((Keys.Control | Keys.O));
            mnuOpen.Click += new EventHandler(mnuOpen_Click);
            // mnuExit
            mnuExit.ShortcutKeys = (Keys)((Keys.Alt | Keys.X));
            mnuExit.Click += new EventHandler(mnuExit_Click);
        }
        private void mnuOpen_Click(object sender, EventArgs e)
        { 
        
             Form2 childForm = new Form2();
            childForm.Text = $"ChildForm {counter++:D2}";
            childForm.MdiParent = this;
            childForm.Show();
        }//end mnuOpen_Click
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}