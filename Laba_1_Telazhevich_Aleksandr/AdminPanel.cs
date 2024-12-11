using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;


namespace PROBizness
{
    public partial class AdminPanel : Form
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=; database=csharp_users_db; ");
        private string selectedTable;
        private notification notification = new notification();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void buttonAddTabl_Click(object sender, EventArgs e)
        {
            try
            {
                string table = Input.Text;
                if (table != null|| table == "" || table == " ")
                {
                    
                    AddTable(table);
                    Listtables listtables = new Listtables();
                    listtables.LoadTablesToListBox();
                    LoadList();
                }
                else
                {

                }
               
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Напишите название таблицы которую надо создать. Ошибка: " + ex.Message);
            }
            
        }
        private void AddTable(string table)
        {
            try
            {
                connection.Open();

                // SQL-команда для создания таблицы
                string query = ($@"CREATE TABLE `csharp_users_db`.`{table}`(
    id INT AUTO_INCREMENT PRIMARY KEY);");
          

                MySqlCommand command = new MySqlCommand(query, connection);

                // Выполняем команду
                command.ExecuteNonQuery();

                notification.AddTabl();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании таблицы: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        private void DeleteTable(string tableName)
        {
            try
            {
              

                // SQL-команда для удаления таблицы
                string query = $"DROP TABLE IF EXISTS `{tableName}`;";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Выполнение команды
                command.ExecuteNonQuery();

                notification.AddTabl(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении таблицы: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTable = listBox1.SelectedItem.ToString(); // Получаем имя выбранной таблицы
         
        }
          


        private void LoadList()
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
    private void AdminPanel_Load(object sender, EventArgs e)
    {
        LoadList();
        
    }

        private void buttonDelTabl_Click(object sender, EventArgs e)
        {
            using (connection)
            {

                try
                {
                    connection.Open();

                    if (listBox1.SelectedItem != null)
                    {
                        string selectedTable = listBox1.SelectedItem.ToString();
                        DeleteTable(selectedTable);

                        // Обновляем список таблиц после удаления
                        Listtables listtables = new Listtables();
                        listtables.LoadTablesToListBox();
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, выберите таблицу для удаления.");
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
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}

