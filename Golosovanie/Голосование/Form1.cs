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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string V = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\pr\голосование.accdb";
        public string connection = V; // путь к базе данных

        public OleDbDataReader Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            OleDbConnection connect = new OleDbConnection(connection); // подключаемся к базе данных
            connect.Open(); // открываем базу данных

            OleDbCommand cmd = new OleDbCommand(selectSQL, connect); // создаём запрос
            OleDbDataReader reader = cmd.ExecuteReader(); // получаем данные

            return reader; // возвращаем
        }



        private void entry_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Golosovanie\голосование.accdb");
            OleDbDataAdapter ada = new OleDbDataAdapter("Select ID From Users where Login = '" + login.Text + "'and Password = '" + password.Text + "'", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            if ((login.Text == "admin") && (password.Text == "admin"))
            {
                Form adminForm = new Form3();
                adminForm.Show();
            } else if (dt.Rows.Count > 0)
            {
                Hide();
                Form ifrm = new Form4();
                ifrm.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            

        }

        private void registration_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form2();
            ifrm.Show(); // отображаем Form3

        }
    }
}
        
