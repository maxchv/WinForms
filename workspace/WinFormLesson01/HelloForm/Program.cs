using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Form window = new Form();
            window.Text = "Hello Window";
            window.ShowDialog();
        }
    }
}
