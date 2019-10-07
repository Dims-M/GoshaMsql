using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Net;

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
           // string errorLog = $"{DateTime.Now.ToString()}\t\n";
            string errorLog = $"t\n";

            try
            {
                 
                Process iStartProcess = new Process(); // новый процесс
               //  iStartProcess.StartInfo.FileName = @"C:\program.exe"; // путь к запускаемому файлу
                iStartProcess.StartInfo.FileName = pathProgramma; // путь к запускаемому файлу
               // iStartProcess.StartInfo.Arguments = " -i 192.168.10.12 -p 10568"; // эта строка указывается, если программа запускается с параметрами (здесь указан пример, для наглядности)
                iStartProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // эту строку указываем, если хотим запустить программу в скрытом виде
                await Task.Run(() => iStartProcess.Start());
               // iStartProcess.Start(); 
                // запускаем программу
                // iStartProcess.WaitForExit(120000); // эту строку указываем, если нам надо будет ждать завершения программы определённое время, пример: 2 мин. (указано в миллисекундах - 2 мин. * 60 сек. * 1000 м.сек.)
                
                Thread.Sleep(3000);
                await Task.Run(() => KillProssec(@"rufus-3.6p"));
                // KillProssec(@"rufus-3.6p");
                errorLog += $"Программа удачно запущена{pathProgramma} И остановлена через 3 секунды\t\n";
                BL.WrateText(errorLog);
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

        /// <summary>
        /// Получение файла c ftp
        /// </summary>
        public void GetFailFtp()
        {
            string serFtp =    "ftp://testkkm.000webhostapp.com/text.txt";
                              // "http://testkkm.000webhostapp.com/1/rufus-3.6p.txt";
             // string serFtp = "ftp://b91790o4@free5.beget.com//temp/test.txt";
             // string serFtp = "ftp://b91790o4@free5.beget.com//WhatsApp5.jpeg";
            string loggin = null;
            // string loggin = "b91790o4_temp";
            //string loggin = "b91790o4_ftp";
            //string loggin = "b91790o4_temp";

            string pass = null;

            // Создаем объект FtpWebRequest
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serFtp);
            // устанавливаем метод на загрузку файлов
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // если требуется логин и пароль, устанавливаем их
            request.Credentials = new NetworkCredential(loggin, pass);
            //request.EnableSsl = true; // если используется ssl

            // получаем ответ от сервера в виде объекта FtpWebResponse
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            // получаем поток ответа
            Stream responseStream = response.GetResponseStream();

            // сохраняем файл в дисковой системе
            // создаем поток для сохранения файла
            FileStream fs = new FileStream("rufus-3.6p.exe", FileMode.Create);

            //Буфер для считываемых данных
            byte[] buffer = new byte[64];
            int size = 0;

            while ((size = responseStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                fs.Write(buffer, 0, size);

            }
            fs.Close();
            response.Close();

            //Console.WriteLine("Загрузка и сохранение файла завершены");
           // Console.Read();
        }

        /// <summary>
        /// Получение файла ссайта 000webhostapp.com
        /// </summary>
        public void GetFailFtp2()
        {
           // string serFtp = @"https://testkkm.000webhostapp.com/1/text.txt";
            string serFtp = @"https://testkkm.000webhostapp.com/1/rufus-3.6p.txt";

            using (var web = new WebClient())
        {
               
           // web.DownloadFile(serFtp, "1te.exe");
            web.DownloadFile(serFtp, "rufus-3.6p.exe");
            }
}

        public  void StartCdm(string pathApp)
        {
            //string pathApp = @"C:\Users\Dmytriy\Downloads\tdsskiller.exe";
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

        
        public  void tesT(string pathApp)
        {
            string command = "ping google.com -t";
            string pathAppSours = @"\elevate\Elevate64.exe";
           // string pathApp = @"C:\Users\Dmytriy\Downloads\tdsskiller.exe";
            string errorLog = $"{DateTime.Now.ToString()}\t\n";

            string temmp = $"\\elevate\\Elevate64.exe {pathApp} u –y";

           // System.Diagnostics.Process.Start("cmd.exe", "/C " + command);
           // System.Diagnostics.Process.Start("cmd.exe", "start" + pathAppSours + pathApp);

            // string[] s = { "@echo off", "start \elevate\Elevate64.exe", "ping google.com -t" };
            string[] s = { "@echo off", "start mspaint.exe", "C:\\Users\\Dmytriy\\Downloads\\tdsskiller.exe" };
             System.Diagnostics.Process.Start("cmd.exe", "/C " + temmp);

        }

    }
}
