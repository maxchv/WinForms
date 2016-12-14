using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormDemo
{   
    class MyForm: Form
    {
        public MyForm(string title)
        {
            Text = title;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new MyForm("Привет окошки"));            
        }
    }
}
