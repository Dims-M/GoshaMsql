using MaterialSkin.Controls;
using System;
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
    public partial class Form1 : MaterialForm
    {
        private string loginUser;
        private string passwordUser;



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
            loginUser = textBoxUser.Text;
            passwordUser = textBoxUser.Text;
            
            //BL.Test(); //Тестовой метод
        }

        //кнопка выход
        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
