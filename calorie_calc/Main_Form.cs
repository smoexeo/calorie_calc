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
    public partial class Main_Form : Form
    {
        bool saved_sports = false;
        bool saved_products = false;
        public Main_Form()
        {
            InitializeComponent();
            Profile.Visible = false;
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            if (!saved_products||!saved_sports)
            {
                
            }
            else
            {
                if (Entry.Text == "Войти")
                {
                    Authentication form = new Authentication();
                    form.ShowDialog();
                }
                else
                {
                    Profile.Visible = false;
                    Entry.Text = "Войти";
                }
            }
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.ShowDialog();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Хотите ли вы удалить все записи за день?", "Предупреждение",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes){
                history_product.Rows.Clear();
                history_sport.Rows.Clear();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saved_products = true;
            saved_sports = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!saved_sports || !saved_products)
            {
                if(MessageBox.Show("Хотите ли вы сохранить ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            }
            if (MessageBox.Show("", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                history_product.Rows.Clear();
                history_sport.Rows.Clear();
            }
        }
    }
}
