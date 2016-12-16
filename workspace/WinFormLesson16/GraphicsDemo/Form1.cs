using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphicsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayChart();
        }

        private void DisplayChart()
        {
            chart1.Series["Students"].Points.AddXY("Вася", 15);
            chart1.Series["Students"].Points.AddXY("Маша", 25);
            chart1.Series["Students"].Points.AddXY("Рима", 31);
            chart1.Series["Students"].Points.AddXY("Петя", 23);

            chart1.Series["Marks"].Points.AddXY("Вася", 12);
            chart1.Series["Marks"].Points.AddXY("Маша", 10);
            chart1.Series["Marks"].Points.AddXY("Рима",11);
            chart1.Series["Marks"].Points.AddXY("Петя", 9);

            Series series = chart1.Series.Add("Test");
            series.ChartType = SeriesChartType.Column;
            series.Points.AddXY("a1", 5);
            series.Points.AddXY("a2", 15);
            series.Points.AddXY("a3", 25);
        }
    }
}
