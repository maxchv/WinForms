using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Текстовые документы|*.txt|Rtf документы|*.rtf|Все файлы|*.*",
                FilterIndex = 1,
                Title = "Дай мне текст"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var type = dlg.FileName.ToLower().EndsWith(".rtf") ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText;
                richTextBox1.LoadFile(dlg.FileName, type);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.DefaultExt = ".rtf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var type = dlg.FileName.ToLower().EndsWith(".rtf") ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText;
                richTextBox1.SaveFile(dlg.FileName, type);
            }
        }

        private int start = -1;
        private string word;
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            word = toolStripTextBox1.Text;
            start = richTextBox1.Find(word, start+1, RichTextBoxFinds.None);
            richTextBox1.DeselectAll();
            if (start >= 0)
            {
                richTextBox1.Select(start, word.Length);
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.DeselectAll();
            }
        }
    }
}
