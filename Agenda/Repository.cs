using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Agenda;

internal class Repository
{
    public Repository() { }

    public DataTable ListaContactos()
    {
        DataTable dt_ListaContactos = new DataTable();
        try
        {
            using (SqlConnection connection = Context.OpenSQLConnetion())
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

        return dt_ListaContactos;
    }
}
