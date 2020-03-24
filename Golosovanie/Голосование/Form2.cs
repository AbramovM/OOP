using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Голосование
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void registration_Click(object sender, EventArgs e)
        {
            if (name.Text.Length > 0) // проверяем имя
            {
                if (surname.Text.Length > 0) // проверяем фамилию
                {
                    if (login.Text.Length > 0) // проверяем логин
                    {
                        if (password1.Text.Length > 0) // проверяем пароль
                        {
                            if (password2.Text.Length > 0) // проверяем второй пароль
                            {
                                if (password1.Text == password2.Text) // проверка на совпадение паролей
                                {
                                    string CONNECT_STRING = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Golosovanie\голосование.mdb";

                                    OleDbConnection cnn = new OleDbConnection(CONNECT_STRING);
                                    cnn.Open();
                                    OleDbCommand cmd = new OleDbCommand("INSERT INTO [users] ([login], [password], [name], [surname]) VALUES (@login, @password, @name, @surname)", cnn);
                                    cmd.Parameters.AddWithValue("login", login.Text);
                                    cmd.Parameters.AddWithValue("password", password1.Text);
                                    cmd.Parameters.AddWithValue("name", name.Text);
                                    cmd.Parameters.AddWithValue("surname", surname.Text);

                                    cmd.ExecuteNonQuery();
                                    cnn.Close();

                                    MessageBox.Show("Пользователь зарегистрирован");
                                }
                                else MessageBox.Show("Пароли не совподают");
                            }
                            else MessageBox.Show("Повторите пароль");
                        }
                        else MessageBox.Show("Укажите пароль");
                    }
                    else MessageBox.Show("Укажите логин");
                }
                else MessageBox.Show("Введите фамилию");
            }
            else MessageBox.Show("Введите имя");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
