using System.Data;
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
            DataTable table = rep.ListaContactos();

            // Bind the DataTable to the DataGridView
            contactosDataGridView.DataSource = table;

            contactosDataGridView.Columns["Observaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        // GRID VIEW

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

        // BOTONES

        // Guardar
        private void guardarButton_Click(object sender, EventArgs e)
        {
            // TODO: INSERT o UPDATE
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

        // Modificar
        private void modificarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarBotones();

            ReiniciarForm();
            QuitarReadOnly();
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

        // METODOS AUXILIARES

        // Formulario en ReadOnly
        private void PonerReadOnly()
        {
            idTextBox.ReadOnly = true;
            nombreTextBox.ReadOnly = true;
            fechaDateTimePicker.Enabled = false; // Distinto para las fechas
            telefonoTextBox.ReadOnly = true;
            observacionesTextBox1.ReadOnly = true;
        }

        // Formulario sin ReadOnly
        private void QuitarReadOnly()
        {
            idTextBox.ReadOnly = false;
            nombreTextBox.ReadOnly = false;
            fechaDateTimePicker.Enabled = true; // Distinto para las fechas
            telefonoTextBox.ReadOnly = false;
            observacionesTextBox1.ReadOnly = false;
        }

        // Vacía todos los campos del formulario
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
