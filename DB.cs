using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoshaMsql
{
    //http://localhost/MAMP/index.php?page=phpmyadmin&language=English
    /// <summary>
    /// Класс для работы с Базой данных
    /// </summary>
    public class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=itproger");


        /// <summary>
        /// Отрытие соединения БД
        /// </summary>
        public void openConnection()
        {//если состояния базы = неподключено.
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open(); //закрываем состояние БД
            }

        }

        /// <summary>
        /// Закрытие соединеие с БД
        /// </summary>
        public void closeConnection()
        {   //если состояния базы = неподключено.
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close(); //закрываем состояние БД
            }

        }

        /// <summary>
        /// Метод возращаюший обьет соединения
        /// </summary>
        /// <returns></returns>
        public MySqlConnection GetConnection  ()
        {
            return connection;
        }
    }
}
