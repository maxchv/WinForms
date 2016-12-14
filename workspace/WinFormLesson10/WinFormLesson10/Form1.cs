using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            notifyIcon1.ShowBalloonTip(1000);

            textBox1.MouseDown += TextBox1_MouseDown;
            textBox2.DragEnter += TextBox2_DragEnter;
            textBox2.DragDrop += TextBox2_DragDrop;

            label3.AllowDrop = true;
            label3.DragEnter += Label3_DragEnter;
            label3.DragDrop += Label3_DragDrop;
        }

        private void Label3_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            label3.Text = string.Join(", ", files);
        }
        
        private void Label3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TextBox2_DragDrop(object sender, DragEventArgs e)
        {
            textBox2.Text = e.Data.GetData(DataFormats.StringFormat) as string;
        }

        private void TextBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
    }
}
