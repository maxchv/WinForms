using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftsShop
{
    public partial class GiftForm : Form
    {
        public Gift Gift { get; private set; }
        public GiftForm()
        {
            InitializeComponent();
        }

        public GiftForm(Gift gift): this()
        {
            this.Gift = gift;

            labelId.Text = gift.Id.ToString();
            textBoxName.Text = gift.Name;
            textBoxDescription.Text = gift.Description;
            numericUpDownPrice.Value = gift.Price;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {            
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gift.Name = textBoxName.Text;
            
            // get description, get price
            DialogResult = DialogResult.OK;
        }
    }
}
