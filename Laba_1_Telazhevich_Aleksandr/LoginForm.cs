using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Agreement.Kdf;
using Tulpep.NotificationWindow;


namespace PROBizness
{
    public partial class LoginForm : Form
    {
        private notification notification = new notification();
        private DB DB = new DB();
        private SqlConnection connection; 
    
        public LoginForm()
        {
            InitializeComponent();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                String username = textBoxUsername.Text;
                String password = textBoxPassword.Text;

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `password` = @pass", db.getConection());
                
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Properties.Settings.Default.role = table.Rows[0][7].ToString();
                    notification.conYes();
                    MainForm mainform = new MainForm();
                    mainform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("no");

                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Не удалось зарегистрироваться скорее всего что-то с Интернет подключением. Код ошибки:" + ex);
            }


        }

        private void lableClose_MouseEnter(object sender, EventArgs e)
        {
            lableClose.BackColor = Color.Red;
        }

        private void lableClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lableClose_MouseLeave(object sender, EventArgs e)
        {
            Color NewColor = Color.FromArgb(255, 128, 128);
            lableClose.BackColor = NewColor;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void mySqlConnection1_StateChange(object sender, StateChangeEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    notification.conYes();
                }
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                notification.conNO();
            }
           

        }
    }
}
