using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GoshaMsql
{
    /// <summary>
    /// Класс для работы со внешними программами
    /// </summary>
  public  class JobProgram
    {
        
        /// <summary>
        /// Тестовой запус программы
        /// </summary>
        public void testStatrProgramm()
        {
            try
            {
                string pathApp = @"C:\Users\Dmytriy\Downloads\tdsskiller.exe";
                string errorLog = $"{DateTime.Now.ToString()}\t\n";

                Process iStartProcess = new Process(); // новый процесс
               //  iStartProcess.StartInfo.FileName = @"C:\program.exe"; // путь к запускаемому файлу
                iStartProcess.StartInfo.FileName = pathApp; // путь к запускаемому файлу
              iStartProcess.StartInfo.Arguments = " -i 192.168.10.12 -p 10568"; // эта строка указывается, если программа запускается с параметрами (здесь указан пример, для наглядности)
                iStartProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // эту строку указываем, если хотим запустить программу в скрытом виде
                iStartProcess.Start(); // запускаем программу
               // iStartProcess.WaitForExit(120000); // эту строку указываем, если нам надо будет ждать завершения программы определённое время, пример: 2 мин. (указано в миллисекундах - 2 мин. * 60 сек. * 1000 м.сек.)
                iStartProcess.WaitForExit(200); // эту строку указываем, если нам надо будет ждать завершения программы определённое время, пример: 2 мин. (указано в миллисекундах - 2 мин. * 60 сек. * 1000 м.сек.)
            
            }

            catch (Exception ex)
            {
                errorLog += $"{ex}\t\n";
            }
           
       }



    }
}
