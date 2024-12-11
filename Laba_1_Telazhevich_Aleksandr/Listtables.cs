using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;
namespace PROBizness
{
    public partial class Listtables : Form
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=; database=csharp_users_db; ");
        
        public Listtables()
        {
            InitializeComponent();
        }

        private void Listtables_Load(object sender, EventArgs e)
        {

            LoadTablesToListBox();
            MainForm mainForm = new MainForm();
        }

        public void LoadTablesToListBox()
        {
            List<string> tables = new List<string>();

            try
            {
                connection.Open();

                // Выполняем запрос для получения списка таблиц
                string query = "SHOW TABLES;";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Добавляем каждое имя таблицы в список
                        tables.Add(reader.GetString(0));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения или запроса: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            // Заполняем ListBox
            listBox1.Items.Clear();
            listBox1.Items.AddRange(tables.ToArray());
         
          
        }

        public void LoadTableToDataGridViewPublic(string tableName)
        {
          
            LoadTableToDataGridView(tableName);
        }

        private void LoadTableToDataGridView(string tableName)
        {
            try
            {
                connection.Open();

                // SQL-запрос для выбора всех данных из таблицы
                string query = $"SELECT * FROM `{tableName}`";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();

                // Заполняем DataTable данными из базы данных
                adapter.Fill(table);

                // Отображаем данные в DataGridView
                Form mainForm = Application.OpenForms["MainForm"]; // Ищем открытую форму MainForm
                if (mainForm != null)
                {
                    DataGridView dataGridViewBD = (DataGridView)mainForm.Controls["dataGridViewBD"]; // Ищем элемент DataGridView на форме
                    dataGridViewBD.DataSource = table;
                }
                else
                {
                    MessageBox.Show("MainForm не найдена.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки таблицы: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedTable = listBox1.SelectedItem.ToString(); // Получаем имя выбранной таблицы
            LoadTableToDataGridView(selectedTable); // Загрузка данных в DataGridView

        }
    }
}
