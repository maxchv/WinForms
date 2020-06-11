using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MenuStrip mainMenu = new MenuStrip();
            MainMenuStrip = mainMenu;

            ToolStripMenuItem fileItem = new ToolStripMenuItem("&File");
            mainMenu.Items.Add(fileItem);
            ToolStripItem openItem = fileItem.DropDownItems.Add("&Open");
            openItem.Click += OpenItem_Click;

            ToolStripMenuItem editItem = new ToolStripMenuItem("&Edit");
            mainMenu.Items.Add(editItem);
            ToolStripItem fontItem = editItem.DropDownItems.Add("&Font");
            fontItem.Click += FontItem_Click;
            
            Controls.Add(mainMenu);
        }

        private void FontItem_Click(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = textBox1.Focused ? "TextBox" : "RichTextBox";
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;

            if (textBox1.Focused)
            {
                dlg.Color = textBox1.ForeColor;
                dlg.Font = textBox1.Font;
            }
            else
            {
                dlg.Color = richTextBox1.SelectionColor;
                dlg.Font = richTextBox1.SelectionFont;
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (textBox1.Focused)
                {
                    textBox1.ForeColor = dlg.Color;
                    textBox1.Font = dlg.Font;
                }
                else
                {
                    richTextBox1.SelectionColor = dlg.Color;
                    richTextBox1.SelectionFont = dlg.Font;
                }
            }
        }

        private void OpenItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(dlg.FileName, Encoding.GetEncoding("windows-1251"));
                richTextBox1.LoadFile(dlg.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
