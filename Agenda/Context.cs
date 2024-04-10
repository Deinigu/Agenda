using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Context
    {
        private static string connectionString = @"Data Source=WINAP3MGRRULDGQ\SQLEXPRESS;Initial Catalog=Agenda;Application Name=Agenda;Integrated Security=SSPI";

        private static SqlConnection connection = new SqlConnection(connectionString);

        public static void OpenSQLConnetion()
        {
            try
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                Debug.WriteLine("\n¡Base de datos conectada!\n");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError al conectar a la base de datos... " + ex.Message + "\n");
            }
        }

        public static void CloseSQLConnection()
        {
            try
            {
                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\n¡Error al cerrar la conexión con base de datos!\n" + ex.Message);
            }
        }

    }
}

