using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson16
{
    public partial class SplashForm : Form
    {
        Timer timer = new Timer();
        public SplashForm()
        {
            InitializeComponent();

            progressBar1.Value = 0;
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();     
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if(progressBar1.Value == 100)
            {
                Close();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
