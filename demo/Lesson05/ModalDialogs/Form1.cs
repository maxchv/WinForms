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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Передача параметров от родительского к дочернему окна
            // через конструктор дочернего окна
            SettingsForm settingsForm = new SettingsForm(BackColor);
            settingsForm.ColorChanged += SettingsForm_ColorChanged;
            settingsForm.Show();
        }

        private void SettingsForm_ColorChanged(object sender, ColorEventArgs e)
        {
            BackColor = e.NewColor;
        }
    }
}
