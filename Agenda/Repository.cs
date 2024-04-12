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
                using (SqlCommand command = new SqlCommand("MostrarContactos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
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
                string query = "NuevoContacto";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

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

    // UPDATE Contacto
    public void EditarContacto(int id, string nombre, DateTime fechaNacimiento, int telefono, string observaciones)
    {
        SqlConnection? connection = null;
        try
        {
            using (connection = Context.OpenSQLConnetion())
            {
                string query = "UPDATE Agenda.dbo.Contactos SET Nombre = @Nombre, FechaNacimiento = @FechaNacimiento, Telefono = @Telefono, Observaciones = @Observaciones WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Observaciones", observaciones);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("\n¡Datos actualizados con éxito!\n");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"\n Hubo un problema al actualizar los datos. {ex.Message}\n");
        }
        finally
        {
            if (connection != null)
            {
                Context.CloseSQLConnection(connection);
            }
        }
    }

    public void BorrarContacto(int id)
    {
        // Si el usuario hace clic en 'Sí', elimina el contacto
        SqlConnection? connection = null;
        try
        {
            using (connection = Context.OpenSQLConnetion())
            {
                string query = "BorrarUsuario";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("\n¡Contacto eliminado con éxito!\n");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"\n Hubo un problema al eliminar el contacto. {ex.Message}\n");
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
