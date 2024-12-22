using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;


namespace PROBizness
{
    public partial class AdminPanel : Form
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=; database=csharp_users_db; ");
        private string selectedTable;
        private notification notification = new notification();
        private string column;
        private System.Windows.Forms.Panel panel3;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void buttonAddTabl_Click(object sender, EventArgs e)
        {
            try
            {
                string table = Input.Text;
                if (table != null || table == "" || table == " ")
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
            catch (NullReferenceException ex)
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
                string query = ($@"CREATE TABLE `csharp_users_db`.`{table}`{column};");


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
        private void Column()
        {
            string namecolumn = "";
            column = $"(`{namecolumn}` INT(1) BINARY AS (1) VIRTUAL COMMENT '1' , PRIMARY KEY (`1`)) ENGINE = InnoDB;";
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

                notification.DelTable();
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

        private void AddControl(int Controlnumber)
        {
            int top = 15;
            string NameColumn;
            for (int i = 0; i < Controlnumber; i++)
            {
                

                TextBox textBoxPanel1 = new TextBox();
                textBoxPanel1.Top = top;
                textBoxPanel1.Left = 5;
                textBoxPanel1.Width = 100;
                textBoxPanel1.Name = "textBoxPanel1" + i.ToString();
                NameColumn = textBoxPanel1.Text;
                TextBox textBoxPanel2 = new TextBox();
                textBoxPanel2.Top = top;
                textBoxPanel2.Left = 209;
                textBoxPanel2.Width = 100;
                textBoxPanel2.Name = "textBoxPanel2" + i.ToString();
                TextBox textBoxPanel3 = new TextBox();
                textBoxPanel3.Top = top;
                textBoxPanel3.Left = 734;
                textBoxPanel3.Width = 100;
                textBoxPanel3.Name = "textBoxPanel3" + i.ToString();
                TextBox textBoxPanel4 = new TextBox();
                textBoxPanel4.Top = top;
                textBoxPanel4.Left = 1261;
                textBoxPanel4.Width = 100;
                textBoxPanel4.Name = "textBoxPanel4" + i.ToString();
                TextBox textBoxPanel5 = new TextBox();
                textBoxPanel5.Top = top;
                textBoxPanel5.Left = 1465;
                textBoxPanel5.Width = 100;
                textBoxPanel5.Name = "textBoxPanel5" + i.ToString();
                ComboBox comboBoxPanel1 = new ComboBox();
                comboBoxPanel1.Top = top;
                comboBoxPanel1.Left = 107;
                comboBoxPanel1.Width = 100;
                comboBoxPanel1.Name = "textBoxPanel1" + i.ToString();
                ComboBox comboBoxPanel2 = new ComboBox();
                comboBoxPanel2.Top = top;
                comboBoxPanel2.Left = 311;
                comboBoxPanel2.Width = 100;
                comboBoxPanel2.Name = "comboBoxPanel2" + i.ToString();
                ComboBox comboBoxPanel3 = new ComboBox();
                comboBoxPanel3.Top = top;
                comboBoxPanel3.Left = 413;
                comboBoxPanel3.Width = 100;
                comboBoxPanel3.Name = "comboBoxPanel3" + i.ToString();
                ComboBox comboBoxPanel4 = new ComboBox();
                comboBoxPanel4.Top = top;
                comboBoxPanel4.Left = 515;
                comboBoxPanel4.Width = 100;
                comboBoxPanel4.Name = "comboBoxPanel4" + i.ToString();
                ComboBox comboBoxPanel5 = new ComboBox();
                comboBoxPanel5.Top = top;
                comboBoxPanel5.Left = 632;
                comboBoxPanel5.Width = 100;
                comboBoxPanel5.Name = "comboBoxPanel5" + i.ToString();
                ComboBox comboboxPanel6 = new ComboBox();
                comboboxPanel6.Top = top;
                comboboxPanel6.Left = 851;
                comboboxPanel6.Width = 100;
                comboboxPanel6.Name = "comboboxPanel6" + i.ToString();
                ComboBox comboBoxPanel7 = new ComboBox();
                comboBoxPanel7.Top = top;
                comboBoxPanel7.Left = 953;
                comboBoxPanel7.Width = 100;
                comboBoxPanel7.Name = "comboBoxPanel7" + i.ToString();
                ComboBox comboBoxPanel8 = new ComboBox();
                comboBoxPanel8.Top = top;
                comboBoxPanel8.Left = 1055;
                comboBoxPanel8.Width = 100;
                comboBoxPanel8.Name = "comboBoxPanel8" + i.ToString();
                ComboBox comboBoxPanel9 = new ComboBox();
                comboBoxPanel9.Top = top;
                comboBoxPanel9.Left = 1159;
                comboBoxPanel9.Width = 100;
                comboBoxPanel9.Name = "comboBoxPanel9" + i.ToString();
                ComboBox comboBoxPanel10 = new ComboBox();
                comboBoxPanel10.Top = top;
                comboBoxPanel10.Left = 1363;
                comboBoxPanel10.Width = 100;
                comboBoxPanel10.Name = "comboBoxPanel10" + i.ToString();
                CheckBox checkBoxPanel1 = new CheckBox();
                checkBoxPanel1.Top = top;
                checkBoxPanel1.Left = 617;
                checkBoxPanel1.Name = "checkBoxPanel1" + i.ToString();
                CheckBox checkBoxPanel2 = new CheckBox();
                checkBoxPanel2.Top = top;
                checkBoxPanel2.Left = 836;
                checkBoxPanel2.Name = "checkBoxPanel2" + i.ToString();

                panel2.Controls.Add(textBoxPanel1);
                panel2.Controls.Add(textBoxPanel2);
                panel2.Controls.Add(textBoxPanel3);
                panel2.Controls.Add(textBoxPanel4);
                panel2.Controls.Add(textBoxPanel5);
                panel2.Controls.Add(comboBoxPanel1);
                panel2.Controls.Add(comboBoxPanel2);
                panel2.Controls.Add(comboBoxPanel3);
                panel2.Controls.Add(comboBoxPanel4);
                panel2.Controls.Add(comboBoxPanel5);
                panel2.Controls.Add(comboboxPanel6);
                panel2.Controls.Add(comboBoxPanel7);
                panel2.Controls.Add(comboBoxPanel8);
                panel2.Controls.Add(comboBoxPanel9);
                panel2.Controls.Add(comboBoxPanel10);
                panel2.Controls.Add(checkBoxPanel1);
                panel2.Controls.Add(checkBoxPanel2);

                top = top + 20;
            }
       
        }

       

        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                panel2.Controls.Clear();
                int number = Convert.ToInt32(numericUpDown1.Value);
                AddControl(number);
            }
        }
    }
}

