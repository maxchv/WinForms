using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            new Thread(splashStart).Start();
            Thread.Sleep(5000);
            InitializeComponent();
        }

        private void splashStart()
        {
            Application.Run(new SplashForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BringToFront();
            WindowState = FormWindowState.Maximized;
        }
    }
}
