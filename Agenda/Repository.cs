using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Agenda;

internal class Repository
{
    public Repository() { }

    // GET Contactos
    public DataTable ListaContactos()
    {
        DataTable dt_ListaContactos = new DataTable();
        SqlConnection? connection = null;
        try
        {
            using (connection = Context.OpenSQLConnetion())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Agenda.dbo.Contactos", connection))
                {
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    data.Fill(dt_ListaContactos);
                }
            }
            Debug.WriteLine("\n¡Contactos cargados con éxito!\n");
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"\n Hubo un problema al cargar los contactos. {ex.Message}\n");
        }
        finally
        {
            if (connection != null)
            {
                Context.CloseSQLConnection(connection);
            }
        }

        return dt_ListaContactos;
    }

    // INSERT Contactos
    public void NewContacto(string nombre, DateTime fechaNacimiento, int telefono, string observaciones)
    {
        SqlConnection? connection = null;
        try
        {
            using (connection = Context.OpenSQLConnetion())
            {
                string query = "INSERT INTO Agenda.dbo.Contactos (Nombre, FechaNacimiento, Telefono, Observaciones) VALUES (@Nombre, @FechaNacimiento, @Telefono, @Observaciones)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Observaciones", observaciones);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("\n¡Datos insertados con éxito!\n");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"\n Hubo un problema al insertar los datos. {ex.Message}\n");
        }
        finally
        {
            if (connection != null)
            {
                Context.CloseSQLConnection(connection);
            }
        }
    }
}
