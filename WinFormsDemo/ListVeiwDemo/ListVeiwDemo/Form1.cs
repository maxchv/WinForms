using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListVeiwDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //listView1.MouseWheel += ListView1_MouseWheel;

            

            listView1.LargeImageList = new ImageList();
            listView1.SmallImageList = new ImageList();
            
            listView1.LargeImageList.Images.Add("folder", Image.FromFile(@"Images\folder.png"));
            listView1.LargeImageList.Images.Add("file", Image.FromFile(@"Images\file.png"));
            listView1.LargeImageList.ImageSize = new Size(64, 64);
            listView1.SmallImageList.Images.Add("folder", Image.FromFile(@"Images\folder.png"));
            listView1.SmallImageList.Images.Add("file", Image.FromFile(@"Images\file.png"));
            listView1.SmallImageList.ImageSize = new Size(32, 32);

            var item = listView1.Items.Add("Первый", "folder");
            item.SubItems.Add("4кб");
            item.SubItems.Add("pdf");

            var item2 = listView1.Items.Add("Второй", "folder");
            item2.SubItems.Add("4кб");
            item2.SubItems.Add("xml");

            var item3 = listView1.Items.Add("Третий", "file");
            item3.SubItems.Add("4кб");
            item3.SubItems.Add("avi");

            listView1.Columns.Add("Название", 300);
            listView1.Columns.Add("Размер", 100);
            listView1.Columns.Add("Тип", 100);

            View[] views = Enum.GetValues(typeof(View)) as View[];
            foreach(View view in views)
            {
                var menuItem = viewToolStripMenuItem.DropDownItems.Add($"{view}");
                menuItem.Click += MenuItem_Click;
            }

            listView1.FullRowSelect = true; // выделение строки в детализированном виде

            listView1.ItemSelectionChanged += ListView1_ItemSelectionChanged; // событие выбора элемента

            listView1.GridLines = true; // отображение сетки
        }

        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(e.IsSelected)
            {
                toolStripStatusLabel1.Text = e.Item.Text;
            }
        }

        //private void ListView1_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    var oldSize = listView1.LargeImageList.ImageSize;
        //    listView1.LargeImageList.ImageSize = new Size(oldSize.Width + 8, oldSize.Height + 8);
        //}

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            listView1.View = (View)Enum.Parse(typeof(View), item.Text); ;
        }
    }
}
