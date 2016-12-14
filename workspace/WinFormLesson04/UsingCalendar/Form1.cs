using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            monthCalendar1.BoldedDates = new DateTime[] { DateTime.Now.AddDays(2), DateTime.Now.AddDays(3) };
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime start = monthCalendar1.SelectionStart;
            DateTime end = monthCalendar1.SelectionEnd;
            MessageBox.Show($"selected {start} and {end}");
        }
    }
}
