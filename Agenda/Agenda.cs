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

        private void guardarButton_Click(object sender, EventArgs e)
        {

        }

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

        private void modificarButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nombreTextBox.Text = "";
            fechaDateTimePicker.Text = "";
            telefonoTextBox.Text = "";
            observacionesTextBox1.Text = "";
        }
    }
}
