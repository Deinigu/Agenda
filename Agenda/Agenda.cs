using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;


namespace Agenda
{
    public partial class Agenda : Form
    {
        private Repository rep;
        public Agenda()
        {
            InitializeComponent();
            this.rep = new Repository();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            RecargarContactos();
        }

        /// <summary>
        /// GRID VIEW
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        // Click en el Grid View
        private void contactosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = this.contactosDataGridView.Rows[e.RowIndex];

                idTextBox.Text = row.Cells["Id"].Value.ToString();
                nombreTextBox.Text = row.Cells["Nombre"].Value.ToString();
                fechaDateTimePicker.Text = row.Cells["FechaNacimiento"].Value.ToString();
                telefonoTextBox.Text = row.Cells["Telefono"].Value.ToString();
                observacionesTextBox1.Text = row.Cells["Observaciones"].Value.ToString();
            }
        }

        /// <summary>
        /// BOTONES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        // Guardar
        private void guardarButton_Click(object sender, EventArgs e)
        {
            // TODO:UPDATE

            // Nuevo Contacto
            if (string.IsNullOrEmpty(idTextBox.Text) && !nuevoButton.Enabled)
            {
                NuevoContacto();
            }
            else if (!modificarButton.Enabled)
            {
                EditarContacto();
            }
            ReiniciarForm();
            PonerReadOnly();
            HabilitarBotones();
        }

        // Cancelar
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            ReiniciarForm();
            PonerReadOnly();

            HabilitarBotones();

        }

        // Nuevo
        private void nuevoButton_Click(object sender, EventArgs e)
        {
            DeshabilitarBotones();

            ReiniciarForm();
            QuitarReadOnly();
        }

        // Modificar
        private void modificarButton_Click_1(object sender, EventArgs e)
        {
            DeshabilitarBotones();

            QuitarReadOnly();
        }

        // Eliminar
        private void eliminarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarBotones();

            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("No hay ning�n contacto seleccionado.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"�Est�s seguro de que quieres eliminar a {nombreTextBox.Text}?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = int.Parse(idTextBox.Text);
                    this.rep.BorrarContacto(id);
                }
                else
                {
                    // No hago nada
                }
            }

            ReiniciarForm();
            HabilitarBotones();
            RecargarContactos();

        }

        /// <summary>
        /// METODOS AUXILIARES
        /// </summary>

        // Nuevo contacto: Control de errores y llamar a repo
        private void NuevoContacto()
        {
            string nombre;
            DateTime fechaNacimiento;
            int telefono;
            string observaciones;

            // Nombre
            nombre = nombreTextBox.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                nombre = "sin_nombre";
            }

            // Fecha Nacimiento
            if (string.IsNullOrEmpty(fechaDateTimePicker.Text))
            {
                fechaNacimiento = DateTime.Now;

            }
            else
            {
                fechaNacimiento = DateTime.Parse(fechaDateTimePicker.Text);
            }

            // Telefono
            if (string.IsNullOrEmpty(telefonoTextBox.Text))
            {
                telefono = 0;

            }
            else
            {
                telefono = int.Parse(telefonoTextBox.Text);
            }

            // Observaciones
            observaciones = observacionesTextBox1.Text;

            this.rep.NewContacto(nombre, fechaNacimiento, telefono, observaciones);

            RecargarContactos();
        }


        private void EditarContacto()
        {
            int id;
            string nombre;
            DateTime fechaNacimiento;
            int telefono;
            string observaciones;

            // id
            id = int.Parse(idTextBox.Text);

            // Nombre
            nombre = nombreTextBox.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                nombre = "sin_nombre";
            }

            // Fecha Nacimiento
            if (string.IsNullOrEmpty(fechaDateTimePicker.Text))
            {
                fechaNacimiento = DateTime.Now;

            }
            else
            {
                fechaNacimiento = DateTime.Parse(fechaDateTimePicker.Text);
            }

            // Telefono
            if (string.IsNullOrEmpty(telefonoTextBox.Text))
            {
                telefono = 0;

            }
            else
            {
                telefono = int.Parse(telefonoTextBox.Text);
            }

            // Observaciones
            observaciones = observacionesTextBox1.Text;

            this.rep.EditarContacto(id, nombre, fechaNacimiento, telefono, observaciones);

            RecargarContactos();
        }

        private void RecargarContactos()
        {
            DataTable table = rep.ListaContactos();

            // Bind the DataTable to the DataGridView
            contactosDataGridView.DataSource = table;

            contactosDataGridView.Columns["Observaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // Formulario en ReadOnly
        private void PonerReadOnly()
        {
            nombreTextBox.ReadOnly = true;
            fechaDateTimePicker.Enabled = false; // Distinto para las fechas
            telefonoTextBox.ReadOnly = true;
            observacionesTextBox1.ReadOnly = true;
        }

        // Formulario sin ReadOnly
        private void QuitarReadOnly()
        {
            nombreTextBox.ReadOnly = false;
            fechaDateTimePicker.Enabled = true; // Distinto para las fechas
            telefonoTextBox.ReadOnly = false;
            observacionesTextBox1.ReadOnly = false;
        }

        // Vac�a todos los campos del formulario
        private void ReiniciarForm()
        {
            idTextBox.Text = "";
            nombreTextBox.Text = "";
            fechaDateTimePicker.Text = "";
            telefonoTextBox.Text = "";
            observacionesTextBox1.Text = "";
        }

        // Vuelve a habilitar los botones
        private void HabilitarBotones()
        {
            nuevoButton.Enabled = true;
            modificarButton.Enabled = true;
            eliminarButton.Enabled = true;

            contactosDataGridView.Enabled = true;
        }

        private void DeshabilitarBotones()
        {
            nuevoButton.Enabled = false;
            modificarButton.Enabled = false;
            eliminarButton.Enabled = false;

            contactosDataGridView.Enabled = false;

        }

    }
}
