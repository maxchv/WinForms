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

namespace WinFormLesson07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitTree();
        }

        private void InitTree()
        {
            ImageList imageList = new ImageList();
            treeView.ImageList = imageList;
            imageList.ImageSize = new Size(30, 30);

            treeView.ShowLines = true;
            treeView.ShowPlusMinus = true;
            treeView.ShowRootLines = true;
            treeView.ShowNodeToolTips = true;

            ToolTip toolTip = new ToolTip();
            
            string path = @"D:\shaptala\.net\WinForms\workspace\WinFormLesson07\WinFormLesson07\Images\";
            imageList.Images.AddRange(new Image[]
            {
                Image.FromFile(Path.Combine(path, "mobile.png")),
                Image.FromFile(Path.Combine(path, "tablet.png")),
                Image.FromFile(Path.Combine(path, "selected.png"))
            });

            TreeNode mobile = new TreeNode("Mobile Phones", 0, 0);
            mobile.ToolTipText = "Mobile Phones";
            
            TreeNode alcatel = mobile.Nodes.Add("Alcatel");
           
            alcatel.ContextMenuStrip = contextMenuStrip1;

            TreeNode samsung = mobile.Nodes.Add("Samsung");
            TreeNode nokia = mobile.Nodes.Add("Nokia");

            TreeNode tablets = new TreeNode("Tablets", 1, 1);
            treeView.AfterCollapse += TreeView_AfterCollapse;
            treeView.AfterExpand += TreeView_AfterExpand;
            TreeNode apple = tablets.Nodes.Add("apple", "Apple", 1, 1);
                
            treeView.Nodes.Add(mobile);
            treeView.Nodes.Add(tablets);

            treeView.NodeMouseClick += TreeView_NodeMouseClick;
            
        }

        private void TreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            statusLabel.Text += "Expanded " + e.Node;
            if (e.Node.Text == "Tablets")
            {
                e.Node.ImageIndex = 2;
            }
        }

        private void TreeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            statusLabel.Text += "Collapsed " + e.Node;
            if (e.Node.Text == "Tablets")
            {
                e.Node.ImageIndex = 1;
            }
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //statusLabel.Text = "Node " + e.Node.Text + " selected"; 
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Remove(treeView.SelectedNode);
        }
    }
}
