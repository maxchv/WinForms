using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
            richTextBox1.Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing 
elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex 
ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse 
cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, 
sunt in culpa qui officia deserunt mollit anim id est laborum.";

            string word = "Lorem";
            int start = richTextBox1.Find(word);
            richTextBox1.Select(start, word.Length);
            richTextBox1.SelectionColor = Color.Aqua;
            richTextBox1.Select(0, 0);
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = dlg.Font;
            }
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void indentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 30;
        }

        private void bulletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent = 30;
            richTextBox1.SelectionBullet = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(dlg.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy(); 
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
            }
        }
    }
}
