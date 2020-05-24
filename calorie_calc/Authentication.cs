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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            //работа с бд
            if (true)
            {

            }
            else
            {

            }
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите ли вы войти в систему?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Enter_Click(sender, e);
            }
            ActiveForm.Close();
            //вернуться в основную форму
        }

        private void Authentication_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cancel_Click(sender, e);
            //вернуться в основную форму
        }
    }
}
