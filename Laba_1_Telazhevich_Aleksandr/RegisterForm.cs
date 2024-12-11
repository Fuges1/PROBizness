using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROBizness
{
    public partial class RegisterForm : Form
    {
        private notification notification = new notification();
        public string name, surname;
        public RegisterForm()
        {
            InitializeComponent();
        }
      
        private void lableClose_MouseEnter(object sender, EventArgs e)
        {
            lableClose.BackColor = Color.Red;
        }
       

        private void lableClose_MouseLeave(object sender, EventArgs e)
        {
            Color NewColor = Color.FromArgb(255, 128, 128);
            lableClose.BackColor = NewColor;
        }

        private void lableClose_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
        private void textBoxname_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxName.Text == "Имя")
            textBoxName.Text = "";
            
        }

        private void textBoxSurname_MouseClick(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "Фамилия")
            textBoxSurname.Text = "";
        }

        private void textBoxMiddlename_MouseClick(object sender, EventArgs e)
        {
            if (textBoxMiddlename.Text == "Отчество")
            textBoxMiddlename.Text = "";

        }

        private void textBoxEmail_MouseClick(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            textBoxEmail.Text = "";
        }

        private void textBoxPassword_MouseClick(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
            textBoxPassword.Text = "";
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void textBoxrepeatpassword_MouseClick(object sender, EventArgs e)
        {
            if (textBoxrepeatpassword.Text == "Повтор пароля")
            textBoxrepeatpassword.Text = "";
            textBoxrepeatpassword.UseSystemPasswordChar = true;
        }

        private void textBoxName_MouseLeave(object sender, EventArgs e)
        {
            if(textBoxName.Text == "")
            textBoxName.Text = "Имя";
        }

        private void textBoxSurname_MouseLeave(object sender, EventArgs e)
        {
            if(textBoxSurname.Text == "")
            textBoxSurname.Text = "Фамилия";
        }

        private void textBoxMiddlename_MouseLeave(object sender, EventArgs e)
        {
            if(textBoxMiddlename.Text == "")
            textBoxMiddlename.Text = "Отчество";
        }

        private void textBoxEmail_MouseLeave(object sender, EventArgs e)
        {
            if(textBoxEmail.Text == "")
            textBoxEmail.Text = "Email";
        }

        private void textBoxPassword_MouseLeave(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "") { 
            textBoxPassword.Text = "Пароль";
            textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void textBoxrepeatpassword_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxrepeatpassword.Text == "")
            {
                textBoxrepeatpassword.Text = "Повтор пароля";
                textBoxrepeatpassword.UseSystemPasswordChar = false;
            }
        }

        private void Openpass1_MouseMove(object sender, MouseEventArgs e)
        {
           
                textBoxPassword.UseSystemPasswordChar = false;
        }

        private void Openpass2_MouseMove(object sender, MouseEventArgs e)
        {
               textBoxrepeatpassword.UseSystemPasswordChar = false;
        }

        private void Openpass1_MouseLeave(object sender, EventArgs e)
        {

            if (textBoxPassword.Text == "Пароль")
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void Openpass2_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxrepeatpassword.Text == "Повтор пароля")
            {
                textBoxrepeatpassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxrepeatpassword.UseSystemPasswordChar = true;
            }
        }
        public Boolean checkTextBoxValues()
        {
            String Name = textBoxName.Text;
            String Surname = textBoxSurname.Text;
            String Middlename = textBoxMiddlename.Text;
            String Email = textBoxEmail.Text;
            String password = textBoxPassword.Text;
            String repeatpassword = textBoxrepeatpassword.Text;

            if(Name.Equals("Имя") || Surname.Equals("Фамилия") || Middlename.Equals("Отчество") 
                || Email.Equals("Email") || password.Equals("Пароль") || repeatpassword.Equals("Повтор пароля"))
            {
                return true;
            }
            {
                return false;
            }
            
        }
        private void buttonregister_Click(object sender, EventArgs e)
        {
            try
            {
                string Name, Surname;
                Name = textBoxName.Text;
                Surname = textBoxSurname.Text;
                DB db = new DB();
                CreaterUsername use = new CreaterUsername();

                MySqlCommand command = new MySqlCommand("INSERT INTO users (Name, Surname, Middlename, Email, username, password) "
                    + "VALUES (@nm, @sn, @md, @email, @usn, @pass)", db.getConection());

                command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = textBoxName.Text;
                command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = textBoxSurname.Text;
                command.Parameters.Add("@md", MySqlDbType.VarChar).Value = textBoxMiddlename.Text;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
                use.name1 = Name;
                use.surname1 = Surname;
                use.CreaterUser();
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = use.Username;

                db.openConnection();
                if (!checkTextBoxValues())
                {
                    if (textBoxPassword.Text.Equals(textBoxrepeatpassword.Text))
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {

                            MessageBox.Show("Account created. Your login will be sent to your email address - " + textBoxEmail.Text
                                , "Account created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong confirm password", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter your information first", "Empty data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.closeConnection();
            }
            catch(System.InvalidOperationException ex)
            {
                MessageBox.Show("Не удалось зарегистрироваться скорее всего что-то с Интернет подключением. Код ошибки:" + ex);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }


        

      
    }
}
