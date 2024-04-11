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
    }
}
