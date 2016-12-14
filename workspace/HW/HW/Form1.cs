using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = 1;
            FormGenerator<Student> formGenerator = new FormGenerator<Student>();
            formGenerator.ShowDialog(student);
            DialogResult.OK

        }
    }
}
