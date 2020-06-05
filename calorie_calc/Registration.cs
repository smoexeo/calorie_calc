using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace calorie_calc
{
    public partial class Registration : Form
    {
        public string connectString = "Data Source=calorie-calc.database.windows.net;Initial Catalog=user1;User ID=calorie-calc;Password=ruwgib-xiHpok-carto0;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Registration()
        {
            InitializeComponent();
        }

        private void registrate_Click(object sender, EventArgs e)
        {
            if (password1.Text != "" && password.Text != "" && login.Text != "" && (gender_female.Checked || gender_male.Checked))
            {
                if (password.Text == password1.Text)
                {
                    if (CheckPassword(password.Text))
                    {
                        using (SqlConnection sConn = new SqlConnection(connectString))
                        {
                            sConn.Open();                            // Открываем подключение
                            string salt = GenerateSalt();
                            string gender;
                            if (gender_female.Checked) gender = gender_female.Text;
                            else gender = gender_male.Text;
                            string sqlExpression = "SELECT * FROM [dbo].[user] WHERE login = " + "'" + login.Text + "'";
                            SqlCommand sCommand = new SqlCommand(sqlExpression, sConn);
                            SqlDataReader reader = sCommand.ExecuteReader();
                            // ExecuteNonQuery выполняет команду и возвращает число измененных строк, т.к. INSERT то должна вернуться 1
                            if (reader.HasRows)
                            {
                                // Выводим сообщение о том, что такой пользователь уже существует
                                MessageBox.Show("Пользователь с таким логином уже существует");
                                reader.Close();
                            }
                            else
                            {
                                reader.Close();
                                string sqlExpression_1 = "INSERT INTO [dbo].[user] (login, password, salt, gender) VALUES (" + "'" + login.Text + "','" + CalcHash(password.Text + salt).ToString() + "','" + salt + "','" + gender + "')";
                                SqlCommand sCommand_1 = new SqlCommand(sqlExpression_1, sConn);
                                if (sCommand_1.ExecuteNonQuery() == 1)
                                {
                                    // Выводим сообщение о успехе
                                    MessageBox.Show("Вы зарегистрированы");
                                    // Ставим кнопку "Зарегистрироваться" в неактивное положение
                                    ActiveForm.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароль слишком простой! Пароль должен содержать не менее 8 символов, 1 заглавной буквы, 1 строчной буквы, 1 цифры и 1 специального знака(!#$%&'()*+,-./:;<=>?@[]^_`{|}~)");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        // Генератор соли
        private string GenerateSalt()
        {
            int saltSize = 20;
            // Инициализируем криптографический генератор случайных чисел
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            // Массив байтов 
            byte[] buff = new byte[saltSize];
            // Заполняем масссив байтов 
            rng.GetBytes(buff);
            // Метод BitConverter.ToString() преобразует массив байтов в 16-чное строкове представление в 
            // Ввиде шестнадцатиричных пар, разделённых дифисами, то есть был массив из 20 элементов станет 
            // строкой из 20*2 символов + 19 дифисов, и после Replace останется 40 символов поэтому, в 
            // столбец с солью в БД устанавливаем фиксированный тип char(40)
            return BitConverter.ToString(buff).Replace("-", "");
        }

        // Считаем хэш от "пароль + соль"
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
        private bool CheckPassword(string password)
        {
            bool result = true;
            if (password.Length < 8)
            {
                result = false;
            }
            Regex regex_1 = new Regex(@"[A-Z]");
            MatchCollection matches_1 = regex_1.Matches(password);
            Regex regex_2 = new Regex(@"[a-z]");
            MatchCollection matches_2 = regex_2.Matches(password);
            Regex regex_3 = new Regex(@"[0-9]");
            MatchCollection matches_3 = regex_3.Matches(password);
            Regex regex_4 = new Regex(@"[^a-zA-Z0-9]");
            MatchCollection matches_4 = regex_4.Matches(password);
            if (matches_1.Count<1||matches_2.Count<1||matches_3.Count<1||matches_4.Count<1)
            {
                result = false;
            }
            return result;
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text == "Логин...")
                login.Text = "";
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
                login.Text = "Логин...";
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Пароль...")
                password.Text = "";
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
                password.Text = "Пароль...";
        }

        private void password1_Enter(object sender, EventArgs e)
        {
            if (password1.Text == "Пароль...")
                password1.Text = "";
        }

        private void password1_Leave(object sender, EventArgs e)
        {
            if (password1.Text == "")
                password1.Text = "Пароль...";
        }
    }
}
