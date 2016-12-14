using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsDemo
{
    public partial class Form1 : Form
    {
        BindingList<Student> students = new BindingList<Student>();
        BindingList<string> checkedList = new BindingList<string>()
        {
            "first", "second", "third"
        };

        public Form1()
        {
            InitializeComponent();

            InitListBox();

            checkedListBox1.ItemCheck += CheckedListBox1_ItemCheck;
            checkedListBox1.Items.AddRange(checkedList.ToArray());
        }

        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            statusLabel.Text = "idx: " + e.Index + " " + e.NewValue;
        }

        private void InitListBox()
        {
            Student vasja = new Student()
            {
                FirstName = "Вася",
                LastName = "Пупкин",
                Age = 21
            };
            students.Add(vasja);

            Student masha = new Student()
            {
                FirstName = "Маша",
                LastName = "Девяткина",
                Age = 23
            };
            students.Add(masha);
            //lbStudents.Items.AddRange(students.ToArray());

            lbStudents.DataSource = students;
            lbStudents.DisplayMember = "LastName";
            lbStudents.ValueMember = "Age";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            int age = int.Parse(numAge.Value.ToString());

            Student newStudent = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };
            students.Add(newStudent);            
            //lbStudents.Items.Add(firstName);
        }

        private void lbStudents_SelectedValueChanged(object sender, EventArgs e)
        {

            
            ListBox lb = sender as ListBox;
            //MessageBox.Show(lb.SelectedIndex.ToString());
            
            try
            {
                Student selectedStudent = students[lb.SelectedIndex];
                // status
                //statusLabel.Text = selectedStudent.FirstName;
                statusLabel.Text = lb.SelectedValue.ToString() + " item " + lb.SelectedItem.GetType();
                tbFirstName.Text = selectedStudent.FirstName;
                tbLastName.Text = selectedStudent.LastName;
                numAge.Value = selectedStudent.Age;
            }
            catch
            {

            }
        }

        private void lbStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                statusLabel.Text = "";
            }
        }
    }
}
