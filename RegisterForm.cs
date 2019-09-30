using System;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoshaMsql
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            textBoxUser.Text = "Введите имя";
            passUserFild.Text = "Пароль";
            userRegEmail.Text = "Введите почту";
            textBoxUser.ForeColor = Color.Gray;
            passUserFild.ForeColor = Color.Gray;
            userRegEmail.ForeColor = Color.Gray;
        }

        //форма
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        //сохранить введенные даннын
        private void SaveRegButton_Click(object sender, EventArgs e)
        {

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

        //Обработчик события. Сработывает при выходе из формы вв ода
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

        private void UserRegEmail_Leave(object sender, EventArgs e)
        {
            if (userRegEmail.Text == "")
            {
                userRegEmail.Text = "Введите почту";
                userRegEmail.ForeColor = Color.Red;
            }
        }
    }
}
