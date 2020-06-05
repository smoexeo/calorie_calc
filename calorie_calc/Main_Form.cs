﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace calorie_calc
{
    public partial class Main_Form : Form
    {
        public string connectString = "Data Source=calorie-calc.database.windows.net;Initial Catalog=user1;User ID=calorie-calc;Password=ruwgib-xiHpok-carto0;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int user_id = -1;
        private readonly string user_name;
        public int weight;
        private readonly bool new_rows_pr = false, new_rows_sp = false;
        public Main_Form(string name, int id, string button_name)
        {
            InitializeComponent();
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            Authentication form = new Authentication
            {
                Tag = this
            };
            Hide();
            form.ShowDialog();
            Show();
            Main_Form_Load(sender, e);
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Hide();
            Profile form = new Profile(user_id);
            form.ShowDialog();
            Show();
            Main_Form_Load(sender, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Main_Form_Load(sender, e);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

            if (user_id == -1)
            {
                Entry.Enabled = true;
                Profile.Enabled = false;
                Entry.Show();
                Profile.Hide();
                add.Enabled = false;
                result.Text = "Войдите, чтобы добавить продукты или активности";
            }
            else
            {
                Entry.Enabled = false;
                Profile.Enabled = true;
                Entry.Hide();
                Profile.Show();
                add.Enabled = true;

                using (SqlConnection sConn = new SqlConnection(connectString))
                {
                    sConn.Open();

                    using (SqlCommand sCommand = new SqlCommand
                    {
                        Connection = sConn,
                        CommandText = @"SELECT product.id_product,name,weight,calories FROM [dbo].[history_product],[dbo].[product] WHERE id_user = " + user_id.ToString() + " and date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' and history_product.id_product = product.id_product"

                    })
                    {
                        SqlDataReader reader = sCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            product.Rows.Add(reader["id_product"], reader["name"], reader["weight"], double.Parse(reader["calories"] + "") * double.Parse(reader["weight"] + "")) / 100;
                        }
                        reader.Close();
                    }

                    using (SqlCommand sCommand = new SqlCommand
                    {
                        Connection = sConn,
                        CommandText = @"SELECT sport.id_sport,name,time,calories FROM [dbo].[history_sport],[dbo].[sport] WHERE id_user = '" + user_id.ToString() + "' and date = '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "' and history_sport.id_sport = sport.id_sport"

                    })
                    {
                        SqlDataReader reader = sCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            product.Rows.Add(reader["id_sport"], reader["name"], "-" + reader["calories"], "-" + (double.Parse(reader["calories"]) * double.Parse(reader["time"])));
                        }
                        reader.Close();
                    }

                    sConn.Close();
                }

                double sum_plus = 0, sum_minus = 0, sum;
                for (int i = 0; i < product.RowCount; i++)
                {
                    double value = double.Parse(product["Kalories", i].Value + "");
                    if (value < 0)
                    {
                        sum_minus += value;
                    }
                    else
                    {
                        sum_plus += value;
                    }
                }

                sum = sum_plus + sum_minus;
                string mark;
                if (sum <= 300 && sum >= -300)
                {
                    mark = "Вес стабилен!";
                }
                else if (sum >= 0)
                {
                    mark = "Набираешь вес!";
                }
                else
                {
                    mark = "Сбрасываешь вес!";
                }

                result.Text = "Результат: +" + sum_plus + " " + sum_minus + " = " + sum + "ккал. Итог: " + mark;
            }

        }

        private void add_product_Click(object sender, EventArgs e)
        {
            Add form = new Add(user_id, dateTimePicker1.Value);
            {
                Tag = this;
            };
            Hide();
            form.ShowDialog();
            Main_Form_Load(sender, e);
            Show();
        }
    }
}
