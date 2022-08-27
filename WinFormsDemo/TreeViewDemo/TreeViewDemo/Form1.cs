using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = new ImageList();
            treeView1.ImageList.Images.Add("folder", Image.FromFile(@"Images\folder.png"));
            treeView1.ImageList.Images.Add("file", Image.FromFile(@"Images\file.png"));
            TreeNode first = treeView1.Nodes.Add("First");
            first.Nodes.Add("...");
            TreeNode second = treeView1.Nodes.Add("Second");
            second.Nodes.Add("...");
            TreeNode third = treeView1.Nodes.Add("Third");
            third.Nodes.Add("...");
            treeView1.BeforeExpand += TreeView1_BeforeExpand;
        }

        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            toolStripStatusLabel1.Text = $"Expand {e.Node.Text}";
            e.Node.Nodes.Clear();
            for(int i=0; i<3; i++)
            {
                TreeNode n = e.Node.Nodes.Add("Subitem " + i);
                n.SelectedImageKey = "file";
                n.ImageKey = "file";
                n.Nodes.Add("...");
            }
        }
    }
}
