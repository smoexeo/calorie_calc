using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;

namespace calorie_calc
{

    public partial class Authentication : Form
    {
        public string connectString = "Data Source=calorie-calc.database.windows.net;Initial Catalog=user1;User ID=calorie-calc;Password=ruwgib-xiHpok-carto0;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Authentication()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            using (SqlConnection sConn = new SqlConnection(connectString))
            {
                // Открываем подключение
                sConn.Open();
                // Создаем команду 
                string sqlExpression = "SELECT * FROM [dbo].[user] WHERE login = '" + login.Text + "'";
                SqlCommand sCommand = new SqlCommand(sqlExpression, sConn);

                // Инициализируем ридер
                SqlDataReader reader = sCommand.ExecuteReader();
                // Если можно сдвинуться на строчку ниже то польхователь с таким логином найден
                if (reader.Read())
                {
                    // Берем значения из полей
                    string passwordHash = (string)reader["password"];
                    string salt = (string)reader["salt"];
                    //string name = (string)reader["name"];
                    //((Main_Form)this.Tag).user_name = name;
                    int user_id = (int)reader["id_user"];
                    // Если хэш от строки (пароль из поля + соль) совпали с ранее хэшированным то пароль верный
                    if (passwordHash == CalcHash(password.Text + salt))
                    {
                        ((Main_Form)this.Tag).user_id = user_id;
                        ActiveForm.Close();
                    }
                    else status.Text="Неверный пароль";
                }
                else status.Text = "Пользователь с таким логином не найден";
            }
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
        private string CalcHash(string text)
        {
            // Инициализируем экземляр класса вычисления хэша
            // SHA1 имеет выпускные данные в 160 бит то есть 20 байт, и аналогично соли вернется строка из 40 символов
            // пожтому в БД в графу пароль с хэшем ставим фиксированный тип char(40)
            using (SHA1CryptoServiceProvider SHA1 = new SHA1CryptoServiceProvider())
            {
                return BitConverter.ToString(SHA1.ComputeHash(Encoding.UTF8.GetBytes(text))).Replace("-", "");
            }
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if(login.Text=="Логин...")
            login.Text = "";
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text=="Пароль...")
            password.Text = "";
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
                login.Text = "Логин...";
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
                password.Text = "Пароль...";
        }
    }
}
