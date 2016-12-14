using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = trackBar1.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(numericUpDown1.Value);

            monthCalendar1.AddMonthlyBoldedDate(DateTime.Now);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
       //     MessageBox.Show("DateChanged: " +
       //monthCalendar1.SelectionRange.ToString());
        }

        private void monthCalendar1_DockChanged(object sender, EventArgs e)
        {
          
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("SelectedDate: " +
      monthCalendar1.SelectionRange.ToString());
        }
    }
}
