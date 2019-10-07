using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoshaMsql
{
    public partial class Form1 : MaterialForm
    {
        private string loginUser ="";
        private string passwordUser ="";



        public Form1()
        {
            InitializeComponent();
        }

        //При загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //кнопка ОК
        private void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            loginUser =    textBoxUser.Text.ToLower().ToString(); //Сохраняем в пермеменнные данные техбокса
            passwordUser = textBoxPassword.Text.ToLower().ToString();

            string tempLog = $"Событие: \t\n";

            DB db = new DB(); // для связи с БД

            DataTable table = new DataTable(); // дата сет. кеш бд 

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //Для работы с провайдером MySql

           // MySqlCommand command =  new MySqlCommand("SELECT * FROM `users` WHERE 'login' = @uL AND 'pass' = @uP", db.GetConnection());//команда sql
            //MySqlCommand command =  new MySqlCommand("SELECT * FROM `users` WHERE 'login' = @loginUser OR 'pass' = @passwordUser", db.GetConnection());//команда sql
            //MySqlCommand command =  new MySqlCommand("SELECT * FROM `users` WHERE 'login' = loginUser OR 'pass' = passwordUser", db.GetConnection());//команда sql
            MySqlCommand command =  new MySqlCommand($"SELECT * FROM `users` WHERE  `login` = {loginUser} OR `pass`= {passwordUser}", db.GetConnection());//команда sql
            //Параметры и свойства MySqlCommand
             command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser.ToString(); //Присваиваем через такую конструкцию параметр при запросе sql
             command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser.ToString(); //Присваиваем через такую конструкцию параметр при запросе sql

            adapter.SelectCommand = command; // отправляем комаду для выполнения
            adapter.Fill(table); //Обновление кеша БД

            //проверка на лоичество строк в БД
            if(table.Rows.Count > 0)
            {
                tempLog += $"Попытка авторизации...\t\nВ базе данных {table.Rows.Count} строк пользователей \t\n";
                MessageBox.Show("Автаризация");
                this.Hide(); // скрываем текущую форму
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                tempLog += $"Попытка авторизации не удалась...\t\nВ базе данных {table.Rows.Count} строк пользователей \t\n";
                MessageBox.Show("ОШИБКА при автаризации");
            }
            //BL.Test(); //Тестовой метод
            BL.WrateText(tempLog);
        }

        //кнопка выход
        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Кнопка зарегестрироватся
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaterialFlatButton3_Click(object sender, EventArgs e)
        {
            var RegForm = new RegisterForm();
            RegForm.Show();
        }

        private void MaterialFlatButton4_Click(object sender, EventArgs e)
        {
             

            string tempPath = @"1.bat";
            string pathApp = @"rufus-3.6p.exe";
            JobProgram jobProgram = new JobProgram();

             jobProgram.testStatrProgramm(tempPath);  // запуск программы. С автомачическим звакрытием через n секунд
             //jobProgram.GetFailFtp(); // получение данных с фтп
            //jobProgram.GetFailFtp2(); // получение данных с сайта
           
            // jobProgram.StartCdm(pathApp);
           // jobProgram.tesT(pathApp);




            }
        }
}
