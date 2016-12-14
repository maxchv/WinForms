using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson01
{
    public partial class Form1 : Form
    {
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Some text";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            count += 1;
            btn.Text = "Жмакнул "+ count;

            btn.Location = new Point(btn.Location.X, btn.Location.Y + 10);

            //var result = MessageBox.Show("Тебе нравятся WinForms?", 
            //                             "Это тест", 
            //                             MessageBoxButtons.YesNoCancel,
            //                             MessageBoxIcon.Question,
            //                             MessageBoxDefaultButton.Button2);
            //switch (result)
            //{
            //    case DialogResult.None:
            //        break;
            //    case DialogResult.OK:
            //        break;
            //    case DialogResult.Cancel:
            //        MessageBox.Show("Подумай хорошо!");
            //        break;
            //    case DialogResult.Abort:
            //        break;
            //    case DialogResult.Retry:
            //        break;
            //    case DialogResult.Ignore:
            //        break;
            //    case DialogResult.Yes:
            //        MessageBox.Show("Да ты крут!");
            //        break;
            //    case DialogResult.No:
            //        MessageBox.Show("Иди учи WinApi!");
            //        break;
            //    default:
            //        break;
            //}
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"x: {e.X} y: {e.Y}";
        }
    }
}
