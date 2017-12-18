using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCotrolsLibrary
{
    public partial class CitiesCombo: UserControl
    {
        public string SelectedCity
        {
            get
            {
                return comboBox1.SelectedItem?.ToString();
            }
        }

        public event EventHandler SetCityEvent;

        public CitiesCombo()
        {
            InitializeComponent();
            InitCities();
        }

        protected virtual void InitCities()
        {
            comboBox1.Items.Add("Днепр");
            comboBox1.Items.Add("Киев");
            comboBox1.Items.Add("Одесса");
            comboBox1.Items.Add("Львов");
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SetCityEvent != null)
            {
                SetCityEvent(sender, e);
            }
        }
    }
}
