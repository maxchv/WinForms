using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitList();
            InitCombo();
        }

        private void InitCombo()
        {
            //comboBoxView.Items.Add("Details");
            //comboBoxView.Items.Add("Tile");
            //comboBoxView.Items.Add("SmallIcon");
            //comboBoxView.Items.Add("List");
            //comboBoxView.Items.Add("LargeIcon");

            comboBoxView.Items.AddRange(Enum.GetNames(typeof(View)));

            comboBoxView.SelectedIndex = 1;
            listView1.View = View.Details;
            comboBoxView.SelectedIndexChanged += ComboBoxView_SelectedIndexChanged;
        }

        private void ComboBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            View v = (View)Enum.Parse(typeof(View), comboBoxView.SelectedItem.ToString());
            listView1.View = v;
        }

        private void InitList()
        {
            ImageList largeIcons = new ImageList();
            largeIcons.ImageSize = new Size(48, 48);
            largeIcons.Images.Add(Image.FromFile("folder_open.png"));
            largeIcons.Images.Add(Image.FromFile("folder_closed.png"));
            largeIcons.Images.Add(Image.FromFile("file.png"));

            ImageList smallIcons = new ImageList();
            smallIcons.Images.Add(Image.FromFile("folder_open.png"));
            smallIcons.Images.Add(Image.FromFile("folder_closed.png"));
            smallIcons.Images.Add(Image.FromFile("file.png"));
            
            ColumnHeader column1 = listView1.Columns.Add("Column 1");
           
            ColumnHeader column2 = listView1.Columns.Add("Column 2 large text");//.Width = 150 ;
           
            listView1.Columns.Add("Column 3");//.Width = 75;

            //listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.LargeImageList = largeIcons;
            listView1.SmallImageList = smallIcons;

            ListViewItem first = listView1.Items.Add("first", 0);
            first.SubItems.Add("subitem 11");
            first.SubItems.Add("subitem 12");

            ListViewItem second = listView1.Items.Add("second", 1);
            second.SubItems.Add("subitem 21");
            second.SubItems.Add("subitem 22");

            ListViewItem third = listView1.Items.Add("third", 2);
            third.SubItems.Add("subitem 31");
            third.SubItems.Add("subitem 32");

            ListViewItem fourth = listView1.Items.Add("fourth", 0);
            fourth.SubItems.Add("subitem 41");
            fourth.SubItems.Add("subitem 42");
            
            listView1.Columns[1].Width = -2; // ColumnHeaderAutoResizeStyle.HeaderSize
            listView1.Columns[2].Width = -1; // ColumnHeaderAutoResizeStyle.ColumnContent       

            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            listView1.ColumnClick += ListView1_ColumnClick;
        }

        private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            statusLabel.Text = "Column clicked " + e.Column;
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = "";
            foreach(var item in listView1.SelectedItems)
            {
                selected += item;
            }
            statusLabel.Text = "Selected: " + selected;
        }
    }
}
