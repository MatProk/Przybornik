using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przybornik
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            content.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                content.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = op.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)";
            if(sv.ShowDialog() == DialogResult.OK)
            {
                content.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = sv.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            content.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            content.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            content.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            content.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            content.Redo();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = content.SelectionFont;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                content.SelectionFont = fd.Font;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cr = new ColorDialog();
            if(cr.ShowDialog() == DialogResult.OK)
            {
                content.BackColor = cr.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ver 1.0.0\nCreated by Mateusz Prokop");
        }
    }
}
