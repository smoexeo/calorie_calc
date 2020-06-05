using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calorie_calc
{
    public partial class Add : Form
    {
         public string connectString = "Data Source=calorie-calc.database.windows.net;Initial Catalog=user1;User ID=calorie-calc;Password=ruwgib-xiHpok-carto0;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        int user_id;
        DateTime date;
        public Add(int user_id1,DateTime date1)
        {
            InitializeComponent();
            bd();
            count.TextChanged += count_TextChanged;
            user_id = user_id1;
            date = date1;        
        }
        int rowcount;
        //заполнение dgv
        public void bd()
        {
            product.Columns.Add("id", "");
            product.Columns.Add("name", "название");
            product.Columns.Add("calories", "каллории");
            product.Columns.Add("count", "количество (гр. или мин.)");
            product.Columns.Add("type", "");
            
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comand_product = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = @"select * from [dbo].[product]"
                };
                var reader = comand_product.ExecuteReader();
                while (reader.Read())
                {
                    product.Rows.Add(reader["id_product"], reader["name"], reader["calories"],"0","product");
                }

                var comand_sport = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = @"select * from [dbo].[sport];"
                };reader.Close();
                var reader1 = comand_sport.ExecuteReader();
                while (reader1.Read())
                {
                    product.Rows.Add(reader1["id_sport"], reader1["name"], Convert.ToInt32(reader1["calories"])*-1,"0","sport");
                }
                reader1.Close();
                conn.Close();
            }
            rowcount = product.RowCount;
            product.Columns[0].Visible = false;
            product.Columns[4].Visible = false;
        }
        //добавление/обновление базы данных
        private void button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                
                for (int i = 0; i < rowcount - 1; i++)
                {
                    //выделенные
                    if (Convert.ToInt32(product.Rows[i].Cells[3].Value)>0)
                    { 
                         // продукты
                        if ((product.Rows[i].Cells[4].Value).ToString() == "product")
                        {
                            string check = "select * from [dbo].[history_product] where id_user="+ (user_id).ToString()+" and date='" + date.ToString("yyyyMMdd")+"' and id_product="+(product.Rows[i].Cells[0].Value).ToString()+";";
                            var comand = new SqlCommand()
                            {
                                Connection=conn,
                                CommandText=check
                            };
                            int flag = 0;
                            var reader = comand.ExecuteReader();
                            if (reader.HasRows)
                                flag = 1;
                                                          
                            reader.Close();
                            if(flag==1)
                            {
                                string query = "update [dbo].[history_product] set weight=weight+" + (product.Rows[i].Cells[3].Value).ToString() + " where id_user=" + (user_id).ToString() + " and date='" + date.ToString("yyyyMMdd") + "' and id_product=" + (product.Rows[i].Cells[0].Value).ToString() + ";";
                                comand.CommandText = query;
                                comand.ExecuteNonQuery();
                                
                            }
                            else
                            {
                                string query = "insert into [dbo].[history_product] (id_user,date,id_product,weight) values (" + (user_id).ToString() + ",'" + date.ToString("yyyyMMdd") + "'," + (product.Rows[i].Cells[0].Value).ToString() + "," + (product.Rows[i].Cells[3].Value).ToString() + ");";
                                comand.CommandText = query;
                                comand.ExecuteNonQuery();
                                
                            }
                           
                            
                        }
                        else//спорт
                        {
                            string check = "select * from [dbo].[history_sport] where id_user=" + (user_id).ToString() + " and date='" + date.ToString("yyyyMMdd") + "' and id_sport=" + (product.Rows[i].Cells[0].Value).ToString() + ";";
                            var comand = new SqlCommand()
                            {
                                Connection = conn,
                                CommandText = check
                            };
                            int flag = 0;
                            var reader = comand.ExecuteReader();
                            if (reader.HasRows)
                                flag = 1;

                            reader.Close();
                            if (flag == 1)
                            {
                                string query = "update [dbo].[history_sport] set time=time+" + (product.Rows[i].Cells[3].Value).ToString() + " where id_user=" + (user_id).ToString() + " and date='" + date.ToString("yyyyMMdd") + "' and id_sport=" + (product.Rows[i].Cells[0].Value).ToString() + ";";
                                comand.CommandText = query;
                                comand.ExecuteNonQuery();

                            }
                            else
                            {
                                string query = "insert into [dbo].[history_sport] (id_user,date,id_sport,time) values (" + (user_id).ToString() + ",'" + date.ToString("yyyyMMdd") + "'," + (product.Rows[i].Cells[0].Value).ToString() + "," + (product.Rows[i].Cells[3].Value).ToString() + ");";
                                comand.CommandText = query;
                                comand.ExecuteNonQuery();

                            }
                            
                        }product.Rows[i].Cells[3].Value = 0;

                    }
                }
                conn.Close();
                Close();
            }
        }

        //поиск
        private void count_TextChanged(object sender, EventArgs e)
        {

            if (count.Text != "")                
            for (int i = 0; i < rowcount-1; i++)
             {
                 product.Rows[i].Visible = false;
                 
                 if(product.Rows[i].Cells[1].Value != null && (product.Rows[i].Cells[1].Value).ToString().Contains(count.Text))
                     {
                     product.Rows[i].Visible = true;
                     
                 }
             }
            else
            {
                for (int i = 0; i < product.RowCount; i++)
                {
                    product.Rows[i].Visible = true;
                }
            }
        }

        
        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
