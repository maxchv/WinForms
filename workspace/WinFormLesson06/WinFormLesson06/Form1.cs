using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            notifyIcon1.Click += NotifyIcon1_Click;
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
