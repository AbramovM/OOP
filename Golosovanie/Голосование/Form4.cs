using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Голосование
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Table_Load();
        }
        SqlConnection SqlConnection;

        private const string V = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Golosovanie\голосование.mdb";
        public string connection = V; // путь к базе данных

        public OleDbDataReader Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            OleDbConnection connect = new OleDbConnection(connection); // подключаемся к базе данных
            connect.Open(); // открываем базу данных

            OleDbCommand cmd = new OleDbCommand(selectSQL, connect); // создаём запрос
            OleDbDataReader reader = cmd.ExecuteReader(); // получаем данные

            return reader; // возвращаем
        }

        private void Golos_Click(object sender, EventArgs e)
        {
            try
            {
                //Логіка голосування 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Spisok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vibor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Table_Load()
        {
           // Список.DataSource = null;
            List<string> candidats = new List<string>();
            OleDbDataReader read = Select("Select * From candidates");
            while (read.Read())
            {
                candidats.Add("Кандидат № " + read.GetInt32(0) + " " + read.GetString(1) + " " + read.GetString(2) + "\n");
            }
           // Список.DataSource = candidats;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "votingDataSet.candidates". При необходимости она может быть перемещена или удалена.
            this.candidatesTableAdapter.Fill(this.votingDataSet.candidates);

        }
    }
}
