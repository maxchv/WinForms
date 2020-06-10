using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDialogs
{
    public class ColorEventArgs : EventArgs
    {
        public Color NewColor { get; set; }
    }

    public partial class SettingsForm : Form
    {
        public event EventHandler<ColorEventArgs> ColorChanged; 

        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(Color backColor)
        {
            InitializeComponent();

            BackColor = backColor;
            trackBar_red.Value = backColor.R;
            trackBar_green.Value = backColor.G;
            trackBar_blue.Value = backColor.B;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            ColorChanged?.Invoke(this, new ColorEventArgs{NewColor = NewColor });
        }

        private void trackBar_red_ValueChanged(object sender, EventArgs e)
        {
            BackColor = NewColor;
        }

        private Color NewColor => Color.FromArgb(trackBar_red.Value, trackBar_green.Value, trackBar_blue.Value);

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
