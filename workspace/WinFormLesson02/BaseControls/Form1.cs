using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseControls
{
    public partial class Form1 : Form
    {
        Label myLabel;
        public Form1()
        {
            InitializeComponent();
            CreateControls();            
        }

        private void CreateControls()
        {
            myLabel = new Label();
            myLabel.Text = "label 2";
            Image homer = Image.FromFile("homer.png");            
            myLabel.Image = homer;
            myLabel.Size = new Size(homer.Width, homer.Height);
            myLabel.Location = new Point(50, 50);
            Controls.Add(myLabel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Checked button 1");
            else if (radioButton2.Checked)
                MessageBox.Show("Checked button 2");
            else if (radioButton3.Checked)
                MessageBox.Show("Checked button 3");
            else if (radioButton4.Checked)
                MessageBox.Show("Checked button 4");
            else
                MessageBox.Show("Checked nothing");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
            textBox1.ReadOnly = !checkBox1.Checked;
        }

        private void button_cut_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void button_paste_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void button_undo_Click(object sender, EventArgs e)
        {            
            textBox1.Undo();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked;
        }
    }
}
