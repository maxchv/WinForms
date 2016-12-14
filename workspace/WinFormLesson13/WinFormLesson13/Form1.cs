using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildWindow win = new ChildWindow();

            win.MdiParent = this;

            win.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void minimazeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form child in MdiChildren)
            {
                child.WindowState = FormWindowState.Minimized;
            }
        }

        private void maximazeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
