using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace GestionDeProjets
{
    class MysqlController
    {
        //Class attributes

        public MySqlConnection connection { get; set; }
        public MySqlCommand command { get; set; }
        public MySqlDataReader reader { get; set; }
        string connectionString = "server=localhost;database=umlDB;uid=root;pwd=;";
        string req;

        public MysqlController(string request)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                req = request;
                command = new MySqlCommand(req, connection);
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (MySqlException)
            {

                System.Windows.Forms.MessageBox.Show("Erreur");
            }

        } // End Constructor

    } // End Class
}
