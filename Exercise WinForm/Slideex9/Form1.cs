using System.Windows.Forms;

namespace Slideex9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateMyMainMenu();
        }
        public void CreateMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            ToolStripMenuItem menuFile = new ToolStripMenuItem("&File");
            ToolStripMenuItem mnuNew = new ToolStripMenuItem("&New");
            ToolStripMenuItem mnuOpen = new ToolStripMenuItem("&Open");
            ToolStripSeparator separator =new ToolStripSeparator(); ;
            ToolStripMenuItem mnuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem mnuAbout = new ToolStripMenuItem("SAbout");
            ToolStripMenuItem mnuViewAbout = new ToolStripMenuItem("&View About");
            // mainMenu
            mainMenu.Items.AddRange(new ToolStripItem[] { menuFile, mnuAbout });
            // menuFile
            menuFile.DropDownItems.AddRange(new ToolStripItem[] {mnuNew,mnuOpen,
        separator,mnuExit});
            // mnuAbout
            mnuAbout.DropDownItems.AddRange(new ToolStripItem[] { mnuViewAbout});
            // mnuNew
            mnuNew.ShortcutKeys = (Keys)((Keys.Control | Keys.N));
            // mnuOpen
            mnuOpen.ShortcutKeys = (Keys)((Keys.Control | Keys.O));
            // mnuExit
            mnuExit.ShortcutKeys = (Keys)((Keys.Alt | Keys.X)); 
        mnuExit.Click += new EventHandler(mnuExit_Click);
            // mnuViewAbout
            mnuViewAbout.ShortcutKeys = Keys.F1; 
        mnuViewAbout.Click += new EventHandler(mnuViewDetail_Click);
        }
        //Click EventHandler
        private void mnuViewDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Windows Forms Application with .NET", "About");
        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}