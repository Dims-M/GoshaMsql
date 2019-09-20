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
        MySqlConnection connection = new MySqlConnection("sever=localhost;port=3306;username=root;password=root;database=");

    }
}
