using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandartDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(DialogResult.OK == colorDialog.ShowDialog())
            {
                label_color.BackColor = colorDialog.Color;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = false;            
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                label_font.Font = fontDialog.Font;
                label_font.ForeColor = fontDialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label_dir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.Multiselect)
                {
                    foreach(var f in openFileDialog1.FileNames)
                    {
                        Process.Start(f);
                    }
                }
                else
                {
                    label_file.Text = openFileDialog1.FileName;
                    Process.Start(openFileDialog1.FileName);
                }                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text file (*.txt) | *.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void openFileItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
