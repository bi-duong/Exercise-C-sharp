namespace ExWinForm12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coppyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int i;

            i = richTextBox1.SelectionStart;

            richTextBox1.Text = richTextBox1.Text.Remove(i, richTextBox1.SelectionLength);

            richTextBox1.SelectionStart = i;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();

            if (f.ShowDialog() == DialogResult.OK)

            {

                richTextBox1.Font = f.Font;

            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();

            if (c.ShowDialog() == DialogResult.OK)

            {

                richTextBox1.ForeColor = c.Color;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}