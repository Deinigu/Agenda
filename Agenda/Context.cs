using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Agenda
{
    internal static class Context
    {
        private static readonly string connectionString = @"Data Source=WINAP3MGRRULDGQ\SQLEXPRESS;Initial Catalog=Agenda;Application Name=Agenda;Integrated Security=SSPI";

        public static SqlConnection OpenSQLConnetion()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Debug.WriteLine("\n¡Base de datos conectada!\n");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"\nError al conectar a la base de datos... {ex.Message}\n");
            }
            return connection;
        }

        public static void CloseSQLConnection(SqlConnection connection)
        {
            try
            {
                connection.Close();
                connection.Dispose();
                Debug.WriteLine("\n¡Conexión con base de datos cerrada!\n");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"\n¡Error al cerrar la conexión con base de datos!\n{ex.Message}");
            }
        }
    }
}


