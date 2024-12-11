using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using Tulpep.NotificationWindow;

namespace PROBizness
{
    internal class DB
    {
        private notification notification = new notification();
        private MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=; database=csharp_users_db; ");
        
        public void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                  
                    notification.conYes();
                }
         
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                
                
               
            }
            
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }
        public MySqlConnection getConection()
        {

          return connection; 

        }
    }

    
}
