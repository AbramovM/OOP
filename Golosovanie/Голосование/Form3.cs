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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void registr_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Length > 0) // проверяем имя
            {
                if (surnameBox.Text.Length > 0) // проверяем фамилию
                {
                    // Открываем подключение.
                    string CONNECT_STRING = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Golosovanie\голосование.mdb";
                    OleDbConnection cnn = new OleDbConnection(CONNECT_STRING);
                    cnn.Open();
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO [candidates] ([name], [surname])  VALUES (@name, @surname)", cnn);
                    cmd.Parameters.AddWithValue("name", nameBox.Text);
                    cmd.Parameters.AddWithValue("surname", surnameBox.Text);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Кандидат добавлен!");
                }
                else MessageBox.Show("Введите фамилию");
            }
            else MessageBox.Show("Введите имя");
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "votingDataSet.candidates". При необходимости она может быть перемещена или удалена.
            this.candidatesTableAdapter.Fill(this.votingDataSet.candidates);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

