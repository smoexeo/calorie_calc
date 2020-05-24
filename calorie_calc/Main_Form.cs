using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace calorie_calc
{
    public partial class Main_Form : Form
    {
        public Form main_form = new Form();
        int user_id;
        string user_name;
        bool saved_sports = true;
        bool saved_products = true;
        public Main_Form()
        {
            InitializeComponent();
            Profile.Visible = false;
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            if (!saved_products||!saved_sports)
            {
                if (MessageBox.Show("Хотите ли вы сохранить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                { 
                    Save_Click(sender, e);
                }
            }
            if (Entry.Text == "Войти")
            {
                main_form = ActiveForm;
                main_form.Visible = false;
                Authentication form = new Authentication();
                form.ShowDialog();
            }
            else
            {
                Profile.Visible = false;
                Entry.Text = "Войти";
                user_id = -1;
                user_name = "";
                Reset_Click(sender, e);
            }
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.ShowDialog();
            main_form = ActiveForm;
            main_form.Visible = false;
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
            //сохранение данных
            saved_products = true;
            saved_sports = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!saved_sports || !saved_products)
            {
                if(MessageBox.Show("Хотите ли вы сохранить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Save_Click(sender, e);
                }
            }
            history_product.Rows.Clear();
            history_sport.Rows.Clear();
            //заполняешь из бд по новой дате
        }
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved_sports || !saved_products)
            {
                if (MessageBox.Show("Хотите ли вы сохранить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Save_Click(sender, e);
                }
            }
        }
    }
}
