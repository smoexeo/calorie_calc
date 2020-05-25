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
        int food_calorie = 0;
        int sport_calorie = 0;
        public int weight;
        bool new_rows_pr = false,new_rows_sp = false;
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
            add_product.Enabled = false;
            delete_product.Enabled = false;
            add_sport.Enabled = false;
            delete_sport.Enabled = false;
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
                using (SqlConnection sConn = new SqlConnection(connectString))
                {
                    sConn.Open();
                    string sqlExpression = "DELETE history_product WHERE id_user = " + user_id.ToString() + " and date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'";
                    SqlCommand sCommand = new SqlCommand(sqlExpression, sConn);
                    if (sCommand.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Нечего удалять");
                    }
                    sqlExpression = "DELETE history_sport WHERE id_user = " + user_id.ToString() + " and date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "'";
                    sCommand = new SqlCommand(sqlExpression, sConn);
                    if (sCommand.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Нечего удалять");
                    }
                    Main_Form_Load(sender, e);
                    sConn.Close();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Main_Form_Load(sender, e);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            string query;
            SqlDataAdapter dadapter;
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            if (!new_rows_pr && !new_rows_sp)
            {
                //заполнение продуктов
                query = "SELECT id_product, name,calories FROM product";
                dadapter = new SqlDataAdapter(query, myConnection);
                DataSet ds_product = new DataSet();
                dadapter.Fill(ds_product, "product");
                product.DataSource = ds_product;
                product.DataMember = "product";
                product.Columns[0].Visible = false;
                //заполнение спорта
                DataSet ds_sport = new DataSet();
                query = "SELECT id_sport,name,calories FROM sport";
                dadapter = new SqlDataAdapter(query, myConnection);
                dadapter.Fill(ds_sport, "sport");
                sport.DataSource = ds_sport;
                sport.DataMember = "sport";
                sport.Columns[0].Visible = false;
            }
            if (user_id != -1)
            {
                add_product.Enabled = true;
                delete_product.Enabled = true;
                add_sport.Enabled = true;
                delete_sport.Enabled = true;
                //заполнение истории продуктов
                DataSet ds_history_product = new DataSet();
                query = "SELECT product.id_product,name,weight,calories FROM [dbo].[history_product],[dbo].[product] WHERE id_user = " + user_id.ToString()+ " and date = '"+ dateTimePicker1.Value.Date.ToString("yyyyMMdd")+ "' and history_product.id_product = product.id_product";
                dadapter = new SqlDataAdapter(query, myConnection);
                dadapter.Fill(ds_history_product, "history_product");
                history_product.DataSource = ds_history_product;
                history_product.DataMember = "history_product";
                history_product.Columns[0].Visible = false;
                history_product.Columns[3].Visible = false;
                //заполнение истории спорта
                DataSet ds_history_sport = new DataSet();
                query = @"SELECT sport.id_sport,name,time,calories FROM [dbo].[history_sport],[dbo].[sport] WHERE id_user = '" + user_id.ToString() + "' and date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' and history_sport.id_sport = sport.id_sport";
                dadapter = new SqlDataAdapter(query, myConnection);
                dadapter.Fill(ds_history_sport, "history_sport");
                history_sport.DataSource = ds_history_sport;
                history_sport.DataMember = "history_sport";
                history_sport.Columns[0].Visible = false;
                history_sport.Columns[3].Visible = false;
            }
            //for(int i = 0; i < history_product.Rows.Count; i++)
            //{
            //    food_calorie += Convert.ToInt32(history_product.Rows[i].Cells[2].Value) * Convert.ToInt32(history_product.Rows[i].Cells[3]) / 100;
            //}
            //for (int i = 0; i < history_sport.Rows.Count; i++)
            //{
            //    sport_calorie += Convert.ToInt32(history_sport.Rows[i].Cells[2].Value) * Convert.ToInt32(history_sport.Rows[i].Cells[3]) / 60;
            //}
            product_cal.Text = food_calorie.ToString() + " ккал";
            sport_cal.Text = (-sport_calorie).ToString()+ " ккал";
            total.Text = (food_calorie-sport_calorie).ToString() + " ккал";
            myConnection.Close();
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            if (product.SelectedRows.Count != 0)
            {
                Add form = new Add(product.SelectedRows[0].Cells[1].Value.ToString(),"Добавить");
                form.Tag = this;
                form.ShowDialog();
                using (SqlConnection sConn = new SqlConnection(connectString))
                {
                    sConn.Open();
                    string sqlExpression = "INSERT INTO [dbo].[history_product] (id_user,date,id_product,weight) VALUES (" + user_id+ ",'" + dateTimePicker1.Value.Date.ToString("yyyyMMdd")+"','"+ product.SelectedRows[0].Cells[0].Value + "'," + weight+ ")";
                    SqlCommand sCommand = new SqlCommand(sqlExpression, sConn);
                    if (sCommand.ExecuteNonQuery() == 1)
                    {
                        Main_Form_Load(sender, e);
                    }
                    sConn.Close();
                }
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
                Add form = new Add(history_product.SelectedRows[0].Cells[1].Value.ToString(), "Удалить");
                form.Tag = this;
                form.ShowDialog();
                string sqlExpression;
                if (Convert.ToInt32(history_product.SelectedRows[0].Cells[2].Value.ToString()) <= weight)
                {
                    sqlExpression = "DELETE history_product WHERE id_user = " + user_id.ToString() + " and date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' and id_product ="+history_product.SelectedRows[0].Cells[0].Value;
                }
                else 
                {
                    sqlExpression = "UPDATE history_product SET weight=" + weight+ " WHERE id_user = " + user_id.ToString() + " and date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' and id_product =" + history_product.SelectedRows[0].Cells[0].Value;
                }
                using (SqlConnection sConn = new SqlConnection(connectString))
                {
                    sConn.Open();
                    SqlCommand sCommand = new SqlCommand(sqlExpression, sConn);
                    if (sCommand.ExecuteNonQuery() == 1)
                    {
                        Main_Form_Load(sender, e);
                    }
                    sConn.Close();
                }
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
                Add form = new Add(history_sport.SelectedRows[0].Cells[1].Value.ToString(), "Удалить");
                form.Tag = this;
                form.ShowDialog();
                string sqlExpression;
                if (Convert.ToInt32(history_sport.SelectedRows[0].Cells[2].Value.ToString()) <= weight)
                {
                    sqlExpression = "DELETE history_sport WHERE id_user = " + user_id.ToString() + " and date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' and id_product =" + history_sport.SelectedRows[0].Cells[0].Value;
                }
                else
                {
                    sqlExpression = "UPDATE history_sport SET weight=" + weight + " WHERE id_user = " + user_id.ToString() + " and date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' and id_product =" + history_sport.SelectedRows[0].Cells[0].Value;
                }
                using (SqlConnection sConn = new SqlConnection(connectString))
                {
                    sConn.Open();
                    SqlCommand sCommand = new SqlCommand(sqlExpression, sConn);
                    if (sCommand.ExecuteNonQuery() == 1)
                    {
                        Main_Form_Load(sender, e);
                    }
                    sConn.Close();
                }
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
                Add form = new Add(sport.SelectedRows[0].Cells[1].Value.ToString(), "Добавить");
                form.Tag = this;
                form.ShowDialog();
                using (SqlConnection sConn = new SqlConnection(connectString))
                {
                    sConn.Open();
                    string sqlExpression = "INSERT INTO [dbo].[history_sport] (id_user,date,id_sport,time) VALUES (" + user_id + ",'" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "','" + sport.SelectedRows[0].Cells[0].Value + "'," + weight+ ")";
                    SqlCommand sCommand = new SqlCommand(sqlExpression, sConn);
                    if (sCommand.ExecuteNonQuery() == 1)
                    {
                        Main_Form_Load(sender, e);
                    }
                    sConn.Close();
                }
            }
            else
            {
                MessageBox.Show("Выберите физическую активность");
            }
        }

        private void product_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if (new_rows_pr)
            //{
            //    using (SqlConnection sConn = new SqlConnection(connectString))
            //    {
            //        sConn.Open();
            //        string sqlExpression = "INSERT INTO [dbo].[product] (name,calories) VALUES (" + "'" + product.SelectedRows[0].Cells[0].Value + "'," + product.SelectedRows[0].Cells[1].Value + ")";
            //        SqlCommand sCommand = new SqlCommand(sqlExpression, sConn);
            //        sConn.Close();
            //    }
            //}
        }
        private void sport_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if (new_rows_sp)
            //{
            //    using (SqlConnection sConn = new SqlConnection(connectString))
            //    {
            //        sConn.Open();
            //        string sqlExpression = "INSERT INTO [dbo].[sport] (name,calories) VALUES (" + "'" + product.SelectedRows[0].Cells[0].Value + "'," + product.SelectedRows[0].Cells[1].Value + ")";
            //        SqlCommand sCommand = new SqlCommand(sqlExpression, sConn);
            //        sConn.Close();
            //    }
            //}
        }
    }
}
