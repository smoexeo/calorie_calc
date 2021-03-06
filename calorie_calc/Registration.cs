﻿using System;
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
            if (password.Text == password1.Text)
            {
                using (SqlConnection sConn = new SqlConnection(connectString))
                {
                    sConn.Open();                            // Открываем подключение
                    string salt = GenerateSalt();
                    string gender;
                    if (gender_female.Checked) gender = gender_female.Text;
                    else gender = gender_male.Text;
                    string sqlExpression = "INSERT INTO [dbo].[user] (login, password, salt, gender) VALUES (" + "'" + login.Text + "','" + CalcHash(password.Text + salt).ToString() + "','" + salt + "','" + gender + "')";
                    SqlCommand sCommand = new SqlCommand(sqlExpression, sConn);

                    // ExecuteNonQuery выполняет команду и возвращает число измененных строк, т.к. INSERT то должна вернуться 1
                    if (sCommand.ExecuteNonQuery() == 1)
                    {
                        // Выводим сообщение о успехе
                        MessageBox.Show("Вы зарегистрированы");
                        // Ставим кнопку "Зарегистрироваться" в неактивное положение
                        ActiveForm.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
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
    }
}
