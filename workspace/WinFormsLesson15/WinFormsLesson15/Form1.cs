using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLesson15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            citiesCombo1.SetCityEvent += CitiesCombo1_SetCityEvent;
        }

        private void CitiesCombo1_SetCityEvent(object sender, EventArgs e)
        {
            MessageBox.Show(citiesCombo1.SelectedCity);
        }

        private void citiesCombo1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All files|*.*|Video mp4|*.mp4";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = dlg.FileName;                               
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Acrobat Reader|*.pdf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.LoadFile(dlg.FileName);
            }
        }
    }
}
