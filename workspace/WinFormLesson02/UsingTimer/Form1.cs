using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingTimer
{
    public partial class Form1 : Form
    {
        Timer mTimer;
        public Form1()
        {
            InitializeComponent();

            mTimer = new Timer();
            mTimer.Interval = 100;
            mTimer.Tick += MTimer_Tick;
        }

        private void MTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (!mTimer.Enabled)
            {
                progressBar1.Value = 0;
                mTimer.Start();
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            mTimer.Stop();
        }
    }
}
