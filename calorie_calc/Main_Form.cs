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
using System.Data.SqlClient;
using System.Configuration;


namespace calorie_calc
{
    public partial class Main_Form : Form
    {
        public string connectString = "Data Source=calorie-calc.database.windows.net;Initial Catalog=user1;User ID=calorie-calc;Password=ruwgib-xiHpok-carto0;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int user_id=-1;
        public string user_name;
        string current_date;
        int food_calorie = 0;
        int sport_calorie = 0;
        public int weight;
        public Main_Form(string name, int id, string button_name)
        {
            InitializeComponent();
            Profile.Visible = false;
            this.user_name = name;
            this.user_id = id;
            Entry.Text = button_name;
            total.Text = (food_calorie - sport_calorie).ToString()+" ккал";
            product_cal.Text = food_calorie.ToString() + " ккал";
            sport_cal.Text = (-sport_calorie).ToString() + " ккал";
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            if (Entry.Text == "Войти")
            {
                Authentication form = new Authentication();
                form.Tag = this;
                form.ShowDialog();
                Main_Form_Load(sender, e);
            }
            //else
            //{
            //    Profile.Visible = false;
            //    Entry.Text = "Войти";
            //    user_id = -1;
            //    user_name = "";
            //    Reset_Click(sender, e);
            //}
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
                sport.Rows.Clear();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            history_product.Rows.Clear();
            history_sport.Rows.Clear();
            current_date = dateTimePicker1.Value.ToString();
            Main_Form_Load(sender, e);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            current_date = dateTimePicker1.Value.ToString();
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            //заполнение продуктов
            string query = "SELECT name,calories FROM product";
            SqlDataAdapter dadapter = new SqlDataAdapter(query, myConnection);
            DataSet ds_product = new DataSet();
            dadapter.Fill(ds_product, "product");
            product.DataSource = ds_product;
            product.DataMember = "product";
            //заполнение спорта
            DataSet ds_sport = new DataSet();
            query = "SELECT name,calories FROM sport";
            dadapter = new SqlDataAdapter(query, myConnection);
            dadapter.Fill(ds_sport, "sport");
            sport.DataSource = ds_sport;
            sport.DataMember = "sport";
            if (user_id != -1)
            {
                //заполнение истории продуктов
                DataSet ds_history_product = new DataSet();
                query = "SELECT * FROM [dbo].[history_product] WHERE id_user = '" + user_id.ToString()+ "' and date = '"+current_date+"'";
                dadapter = new SqlDataAdapter(query, myConnection);
                dadapter.Fill(ds_history_product, "history_product");
                history_product.DataSource = ds_history_product;
                history_product.DataMember = "history_product";
                //заполнение истории спорта
                DataSet ds_history_sport = new DataSet();
                query = @"SELECT * FROM history_sport id_user=@user_id and date=@current_date";
                dadapter = new SqlDataAdapter(query, myConnection);
                dadapter.Fill(ds_history_sport, "history_sport");
                sport.DataSource = ds_history_sport;
                sport.DataMember = "history_sport";
            }
            myConnection.Close();
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            if (product.SelectedRows.Count != 0)
            {
                Add form = new Add(product.SelectedRows[0].Cells[0].Value.ToString(),"Добавить");
                form.Tag = this;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите продукт");
            }
        }

        private void delete_product_Click(object sender, EventArgs e)
        {
            if (history_product.SelectedRows.Count != 0)
            {
                Add form = new Add(history_product.SelectedRows[0].Cells[0].Value.ToString(), "Удалить");
                form.Tag = this;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите продукт");
            }
        }

        private void delete_sport_Click(object sender, EventArgs e)
        {
            if (history_sport.SelectedRows.Count != 0)
            {
                Add form = new Add(history_sport.SelectedRows[0].Cells[0].Value.ToString(), "Удалить");
                form.Tag = this;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите физическую активность");
            }
        }

        private void add_sport_Click(object sender, EventArgs e)
        {
            if (sport.SelectedRows.Count != 0)
            {
                Add form = new Add(sport.SelectedRows[0].Cells[0].Value.ToString(), "Добавить");
                form.Tag = this;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите физическую активность");
            }
        }
    }
}
