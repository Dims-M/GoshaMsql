﻿using System;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GoshaMsql
{
    public partial class RegisterForm : MaterialForm
    {
        private DB db;

        public RegisterForm()
        {
            InitializeComponent();

            textBoxUser.Text = "Введите логин";
            passUserFild.Text = "Пароль";
            userRegEmail.Text = "Введите почту";
            NamTtextBox.Text = "Введите Имя";
            ComentReTtextBox.Text = "При необходимости коментарий";

            textBoxUser.ForeColor = Color.Gray;
            passUserFild.ForeColor = Color.Gray;
            userRegEmail.ForeColor = Color.Gray;
            NamTtextBox.ForeColor = Color.Gray;
            ComentReTtextBox.ForeColor = Color.Gray;
        }

        //форма
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        //сохранить введенные даннын
        private void SaveRegButton_Click(object sender, EventArgs e)
        {
            string log = "";

            //проверка на заполненнность элементов
            if (textBoxUser.Text == "Введите логин" || NamTtextBox.Text == "Введите Имя")
            {
                log += "Обязательные параметры Не заполнены \t\n";
                MessageBox.Show("Обязательные параметры Не заполнены \t\n");
                BL.WrateText(log);
                return;// выход из метода.
            }

            if (IsUserExis())
            {
                return; // выход из метода.
            }

                //Логика работы с БД
                try
                {
                    string mydt = DateTime.Now.ToString();
                    db = new DB(); //контекст для работы с БД
                    //MySqlCommand command = new MySqlCommand("INSERT INTO 'users' (`id`,'login', 'pass', 'name','email', 'coment', 'AddDateTime',`DateTimeExit`) VALUES(NULL,@login, @pass, @name, @email, @coment, '' )", db.GetConnection()); // для работы с запросами БД
                    MySqlCommand command = new MySqlCommand($"INSERT INTO `users` (`login`, `pass`, `name`,`email`, `coment`, `AddDateTime`,`DateTimeExit`) VALUES('{textBoxUser.Text}', '{passUserFild.Text}', {NamTtextBox.Text}, '{userRegEmail.Text}','{ComentReTtextBox.Text}','{mydt}','')", db.GetConnection()); // для работы с запросами БД
                                                                                                                                                                                                                                                                                                                  // MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`id`, `login`, `pass`, `name`, `email`, `coment`, `AddDateTime`, `DateTimeExit`) VALUES(NULL, 'пробный', '12345', 'тест', 'fgeg@.mail.ru', 'тестовой', '2019-10-01 00:00:00', '')",db.GetConnection());

                    //параметры скл запроса
                    //command.Parameters.Add("@login",MySqlDbType.VarChar).Value = textBoxUser.Text; // присваеваем значение из тек поля вводаа логина
                    //command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passUserFild.Text;
                    //command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userRegEmail.Text;
                    //command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NamTtextBox.Text;
                    //command.Parameters.Add("@coment", MySqlDbType.VarChar).Value = ComentReTtextBox.Text;
                    //command.Parameters.Add("@AddDateTime", MySqlDbType.DateTime).Value = DateTime.Now;

                    db.openConnection(); // открытие соединения

                    if (command.ExecuteNonQuery() == 1) // выполняет результат запроса скл. С возратом значения. Если 1 то успешно
                    {
                        MessageBox.Show("Пользователь добавлен.");
                        log += $"{DateTime.Now.ToString()} - Пользователь добавлен! {textBoxUser.Text}\t\n";
                        BL.WrateText(log);
                    }

                    else
                        MessageBox.Show("Ошибка при добавлении пользователя");

                }

                catch (Exception ex)
                {
                    log += $"ОШИБКА при добавлении пользователя!! \t\n{ex}";
                    BL.WrateText(log);
                }

                db.closeConnection();// закрытие соединения

        }

        /// <summary>
        /// Кнопка выход из формы регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitRegButton_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        /// <summary>
        /// Проверяем. есть ли данны пользователей в БД
        /// </summary>
        /// <returns></returns>
       public Boolean IsUserExis()
        {
            string tempLog =$"{DateTime.Now}";
            db = new DB();  // соединение с бд

            DataTable table = new DataTable(); // дата сет. кеш бд 
            MySqlDataAdapter adapter = new MySqlDataAdapter(); //Для работы с провайдером MySql

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `users` WHERE  `login` = @uL", db.GetConnection());//команда sql

            //Параметры и свойства MySqlCommand
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBoxUser.Text; //Присваиваем через такую конструкцию параметр при запросе sql
           
            adapter.SelectCommand = command; // отправляем комаду для выполнения
            adapter.Fill(table); //Обновление кеша БД

            //проверка на лоичество строк в БД
            if (table.Rows.Count > 0)
            {
                tempLog += $"Попытка авторизации...\t\nВ в тукущей базе данных  уже присуствует такой логин\t\n {textBoxUser.Text}\t\n  Cтрок пользователей{table.Rows.Count} \t\n";
                MessageBox.Show("Автаризация не удалась\t\nУже присуствует такой логин\t\nИспользуейте другое имя ");
                return true;
            }
            else
            {
                tempLog += $"Попытка авторизации ...\t\nВ базе данных нет зарегестированного пользователя {textBoxUser.Text}\t\n Cтрок пользователей{table.Rows.Count}\t\n";
                return false;
                // MessageBox.Show("ОШИБКА при автаризации");
            }
            //BL.Test(); //Тестовой метод
            BL.WrateText(tempLog);
            return true;
        }

        //очистить поля регистрции
        private void ClearFildGerForm_Click(object sender, EventArgs e)
        {
            textBoxUser.Text = "";
            passUserFild.Text = "";
            userRegEmail.Text = "";
        }

        //Событие  и измененич формы
        private void RegisterForm_Enter(object sender, EventArgs e)
        {
            textBoxUser.Text = "";
        }
        //Событие  и измененич формы при ведении или изменении поля формы имени пользователя

        private void TextBoxUser_Enter(object sender, EventArgs e)
        {
            
            if(textBoxUser.Text == "Введите имя")
            {
                textBoxUser.Text = "";
            }
            
        }

        //Событие  и измененич формы при ведении или изменении поля формы имени пользователя
        private void PassUserFild_Enter(object sender, EventArgs e)
        {
            if (passUserFild.Text == "Пароль")
            {
                passUserFild.Text = ""; 
            }
             
        }

        
        private void UserRegEmail_Enter(object sender, EventArgs e)
        {
            if (userRegEmail.Text == "Введите почту")
            {
                userRegEmail.Text = "";
            }
             
        }

        //Обработчик события. Сработывает при выходе из формы ввода имени
        private void TextBoxUser_Leave(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
            {
                textBoxUser.Text = "Введите имя";
                textBoxUser.ForeColor = Color.Red;
            }
        }

        //Обработчик события.Сработывает при выходе из формы при вводе пароля.
        private void PassUserFild_Leave(object sender, EventArgs e)
        {
            if (passUserFild.Text == "")
            {
                passUserFild.Text = "Пароль";
                passUserFild.ForeColor = Color.Red;
            }
        }

        //Обработчик события.Сработывает при выходе из формы при вводе почты регистрации.
        private void UserRegEmail_Leave(object sender, EventArgs e)
        {
            if (userRegEmail.Text == "")
            {
                userRegEmail.Text = "Введите почту";
                userRegEmail.ForeColor = Color.Red;
            }
        }

        ////Обработчик события.Сработывает при выходе из формы при вводе имени
        private void NamTtextBox_Enter(object sender, EventArgs e)
        {
            if (userRegEmail.Text == "")
            {
                userRegEmail.Text = "Введите Имя";
                userRegEmail.ForeColor = Color.Red;
            }
        }
    }
}
