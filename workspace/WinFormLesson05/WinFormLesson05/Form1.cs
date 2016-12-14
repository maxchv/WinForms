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
    public partial class Form1 : Form
    {
        public Form2 form { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form = new Form2(this);
            form.Show();
            MessageBox.Show("Closed");
        }

        public void update_label(string text)
        {
            label1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.update_label("Greet child");
        }
    }
}
