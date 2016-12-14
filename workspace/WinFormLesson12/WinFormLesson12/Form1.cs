using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.ContextMenuStrip = contextMenuStrip1;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = tabControl1.TabCount;
            TabPage page = new TabPage("tab " + count);
            page.MouseClick += Page_MouseClick;
            Button btn = new Button();
            btn.Text = "Тыцни меня";
            btn.Location = new Point(10, 10);
            btn.Click += Btn_Click;
            page.Controls.Add(btn);
            tabControl1.TabPages.Add(page);
        }

        private void Page_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тыц");
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.RemoveAt(tabControl1.TabCount - 1);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
        }

        private void selectedTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tabControl1?.SelectedTab?.Text);
        }
    }
}
