using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calorie_calc
{
    public partial class Add : Form
    {
        public Add(string item, string act)
        {
            InitializeComponent();
            this.Name = act;
            this.button.Text = act;
            //this.item.Text = item;
        }

        private void button_Click(object sender, EventArgs e)
        {
            ((Main_Form)this.Tag).weight = Convert.ToInt32(count.Text);
            ActiveForm.Close();
        }

        private void count_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
