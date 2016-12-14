using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson05
{
    public partial class Form2 : Form
    {
        private Form1 parent;
        
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.parent = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.update_label("Hello my parent");
        }

        public void update_label(string text)
        {
            label1.Text = text;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("??");
        }
    }
}
