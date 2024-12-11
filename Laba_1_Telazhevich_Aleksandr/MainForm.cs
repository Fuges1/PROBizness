using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROBizness
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
            if(Properties.Settings.Default.role == "admin")
            {
                messeg.Text = "Вы администратор";
                buttonEditing.Visible = true;
            }
            if(Properties.Settings.Default.role == "guest")
            {
                messeg.Text = "Вы зашли как гость, чтобы начать редактировать обратитесь к администратору";
                buttonEditing.Visible = false;    
            }
            Refresh();
        }
        


        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonSelecTabl_Click(object sender, EventArgs e)
        {
         
           Listtables listtables = new Listtables();
           listtables.Show();
           
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegBD_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }
    }
}
