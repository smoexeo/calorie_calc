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
    public partial class Registration : Form
    {
        bool registered = false;
        public Registration()
        {
            InitializeComponent();
        }

        private void registrate_Click(object sender, EventArgs e)
        {
            //работа с бд
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (!registered)
            {
                if (MessageBox.Show("Хотите ли вы зарегистрироваться?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    registrate_Click(sender,e);
                }
            }
            ActiveForm.Close();
            //вернуться в форму аутентификации
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancel_Click(sender,e);
        }
    }
}
