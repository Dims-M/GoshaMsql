using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Threading;


namespace GoshaMsql
{
    /// <summary>
    /// Класс для работы со внешними программами
    /// </summary>
  public class JobProgram
    {
        // Командная строка и батники
        //http://forum.oszone.net/showthread.php?s=1d332bb88971cff2c817e87b3185ce90&t=226205
        //http://www.cyberforum.ru/csharp-beginners/thread295153.html
        //http://kbyte.ru/ru/Programming/Sources.aspx?id=962&mode=show

        //работа с автозагрузкой
       // http://kbyte.ru/ru/Programming/Sources.aspx?id=977&mode=show

        /// <summary>
        /// Тестовой запус программы
        /// </summary>
        public async void testStatrProgramm(string pathProgramma)
        {
            // string pathApp = @"C:\Users\Dmytriy\Downloads\tdsskiller.exe";
            string pathApp = pathProgramma;
            string errorLog = $"{DateTime.Now.ToString()}\t\n";

            try
            {
                 
                Process iStartProcess = new Process(); // новый процесс
               //  iStartProcess.StartInfo.FileName = @"C:\program.exe"; // путь к запускаемому файлу
                iStartProcess.StartInfo.FileName = pathProgramma; // путь к запускаемому файлу
               // iStartProcess.StartInfo.Arguments = " -i 192.168.10.12 -p 10568"; // эта строка указывается, если программа запускается с параметрами (здесь указан пример, для наглядности)
                iStartProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // эту строку указываем, если хотим запустить программу в скрытом виде
               // await Task.Run(() => iStartProcess.Start());
                iStartProcess.Start(); 
                // запускаем программу
                // iStartProcess.WaitForExit(120000); // эту строку указываем, если нам надо будет ждать завершения программы определённое время, пример: 2 мин. (указано в миллисекундах - 2 мин. * 60 сек. * 1000 м.сек.)
                //  iStartProcess.WaitForExit(20000); // эту строку указываем, если нам надо будет ждать завершения программы определённое время, пример: 2 мин. (указано в миллисекундах - 2 мин. * 60 сек. * 1000 м.сек.)
                // iStartProcess.Kill();

                // iStartProcess.Kill();
                //Process.Kill("");

                Thread.Sleep(3000);
                KillProssec(@"rufus-3.6p");
                

            }

            catch (Exception ex)
            {
                
                errorLog += $"{ex}\t\n";
                BL.WrateText(errorLog);
               
            }
           
       }

        /// <summary>
        /// закрыть процесс по имени
        /// </summary>
        /// <param name="nameProssec"></param>
        public void KillProssec(string nameProssec)
        {
            System.Diagnostics.Process.GetProcessesByName(nameProssec)[0].Kill();


        }


        public  void StartCdm()
        {
            string pathApp = @"C:\Users\Dmytriy\Downloads\tdsskiller.exe";
            string errorLog = $"{DateTime.Now.ToString()}\t\n";

            
            // создаем процесс cmd.exe с параметрами "ipconfig /all"
            //ProcessStartInfo psiOpt = new ProcessStartInfo(@"cmd.exe", pathApp);
            ProcessStartInfo psiOpt = new ProcessStartInfo(@"cmd.exe", @"/C ipconfig /all");
            // скрываем окно запущенного процесса
           // psiOpt.WindowStyle = ProcessWindowStyle.Hidden;
            psiOpt.RedirectStandardOutput = true;
            psiOpt.UseShellExecute = false;
            psiOpt.CreateNoWindow = true;
            // запускаем процесс
            Process procCommand = Process.Start(psiOpt);

            // получаем ответ запущенного процесса
            StreamReader srIncoming = procCommand.StandardOutput;
            // выводим результат
            Console.WriteLine(srIncoming.ReadToEnd());
            // закрываем процесс
            procCommand.WaitForExit();
            Console.Read();
        }

        
        public  void tesT()
        {
            string command = "ping google.com -t";
            string pathAppSours = @"\elevate\Elevate64.exe";
            string pathApp = @"C:\Users\Dmytriy\Downloads\tdsskiller.exe";
            string errorLog = $"{DateTime.Now.ToString()}\t\n";

            string temmp = @"\elevate\Elevate64.exe C:\Users\Dmytriy\Downloads\tdsskiller.exe u –y";

           // System.Diagnostics.Process.Start("cmd.exe", "/C " + command);
           // System.Diagnostics.Process.Start("cmd.exe", "start" + pathAppSours + pathApp);

            // string[] s = { "@echo off", "start \elevate\Elevate64.exe", "ping google.com -t" };
            string[] s = { "@echo off", "start mspaint.exe", "C:\\Users\\Dmytriy\\Downloads\\tdsskiller.exe" };
             System.Diagnostics.Process.Start("cmd.exe", "/C " + temmp);

        }

    }
}
