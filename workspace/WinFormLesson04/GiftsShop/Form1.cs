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
    public partial class Form1 : Form
    {
        BindingList<Gift> gifts = new BindingList<Gift>();
        public Form1()
        {
            InitializeComponent();

            gifts.Add(new Gift()
            {
                Id = 1,
                Name = "Дед Мороз",
                Description = "Дедушка Мороз - красный нос",
                Price = 150
            });
            gifts.Add(new Gift()
            {
                Id = 2,
                Name = "Снегурочка",
                Description = "Снегурочка - внучка Дедушки Мороза",
                Price = 450
            });
            gifts.Add(new Gift()
            {
                Id = 3,
                Name = "Елка",
                Description = "Елка пушистая",
                Price = 1500
            });

            listBoxGifts.DataSource = gifts;
            listBoxGifts.DisplayMember = "Name";
            listBoxGifts.ValueMember = "Id";
        }

        private void listBoxGifts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxGifts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GiftForm giftForm = new GiftForm(listBoxGifts.SelectedItem as Gift);
            DialogResult result = giftForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                listBoxGifts.DataSource = null;
                listBoxGifts.DataSource = gifts;
                listBoxGifts.DisplayMember = "Name";
                listBoxGifts.ValueMember = "Id";
            }
            else if(result == DialogResult.Cancel)
            {

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            GiftForm giftForm = new GiftForm();
            DialogResult result = giftForm.ShowDialog();
        }
    }
}
