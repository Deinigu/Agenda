namespace Agenda
{
    partial class Agenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idLabel = new Label();
            idTextBox = new TextBox();
            nombreLabel = new Label();
            nombreTextBox = new TextBox();
            fechaDateTimePicker = new DateTimePicker();
            fechaNacimientoLabel = new Label();
            telefonoLabel = new Label();
            telefonoTextBox = new TextBox();
            observacionesLabel = new Label();
            observacionesTextBox1 = new TextBox();
            nuevoButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            guardarButton = new Button();
            cancelarButton = new Button();
            contactosDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)contactosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(35, 59);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(32, 25);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(222, 59);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(150, 31);
            idTextBox.TabIndex = 1;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(35, 103);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(82, 25);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(222, 103);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.ReadOnly = true;
            nombreTextBox.Size = new Size(150, 31);
            nombreTextBox.TabIndex = 3;
            // 
            // fechaDateTimePicker
            // 
            fechaDateTimePicker.Enabled = false;
            fechaDateTimePicker.Format = DateTimePickerFormat.Short;
            fechaDateTimePicker.Location = new Point(222, 147);
            fechaDateTimePicker.Name = "fechaDateTimePicker";
            fechaDateTimePicker.Size = new Size(300, 31);
            fechaDateTimePicker.TabIndex = 4;
            fechaDateTimePicker.Value = new DateTime(2024, 4, 11, 10, 0, 9, 0);
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new Point(35, 147);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new Size(181, 25);
            fechaNacimientoLabel.TabIndex = 5;
            fechaNacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new Point(34, 188);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(83, 25);
            telefonoLabel.TabIndex = 6;
            telefonoLabel.Text = "Teléfono:";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(222, 188);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.ReadOnly = true;
            telefonoTextBox.Size = new Size(261, 31);
            telefonoTextBox.TabIndex = 7;
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new Point(35, 226);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new Size(132, 25);
            observacionesLabel.TabIndex = 8;
            observacionesLabel.Text = "Observaciones:";
            // 
            // observacionesTextBox1
            // 
            observacionesTextBox1.Location = new Point(222, 226);
            observacionesTextBox1.Multiline = true;
            observacionesTextBox1.Name = "observacionesTextBox1";
            observacionesTextBox1.ReadOnly = true;
            observacionesTextBox1.Size = new Size(520, 134);
            observacionesTextBox1.TabIndex = 9;
            // 
            // nuevoButton
            // 
            nuevoButton.Location = new Point(35, 382);
            nuevoButton.Name = "nuevoButton";
            nuevoButton.Size = new Size(112, 34);
            nuevoButton.TabIndex = 10;
            nuevoButton.Text = "Nuevo";
            nuevoButton.UseVisualStyleBackColor = true;
            nuevoButton.Click += nuevoButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(185, 382);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(112, 34);
            eliminarButton.TabIndex = 11;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(331, 382);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(112, 34);
            modificarButton.TabIndex = 12;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click_1;
            // 
            // guardarButton
            // 
            guardarButton.Location = new Point(748, 382);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(112, 34);
            guardarButton.TabIndex = 13;
            guardarButton.Text = "Guardar";
            guardarButton.UseVisualStyleBackColor = true;
            guardarButton.Click += guardarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(892, 382);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(112, 34);
            cancelarButton.TabIndex = 14;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // contactosDataGridView
            // 
            contactosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contactosDataGridView.Location = new Point(35, 476);
            contactosDataGridView.Name = "contactosDataGridView";
            contactosDataGridView.RowHeadersWidth = 62;
            contactosDataGridView.RowTemplate.Height = 33;
            contactosDataGridView.Size = new Size(1339, 307);
            contactosDataGridView.TabIndex = 15;
            contactosDataGridView.CellClick += contactosDataGridView_CellClick;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 807);
            Controls.Add(contactosDataGridView);
            Controls.Add(cancelarButton);
            Controls.Add(guardarButton);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(nuevoButton);
            Controls.Add(observacionesTextBox1);
            Controls.Add(observacionesLabel);
            Controls.Add(telefonoTextBox);
            Controls.Add(telefonoLabel);
            Controls.Add(fechaNacimientoLabel);
            Controls.Add(fechaDateTimePicker);
            Controls.Add(nombreTextBox);
            Controls.Add(nombreLabel);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Name = "Agenda";
            Text = "Form1";
            Load += Agenda_Load;
            ((System.ComponentModel.ISupportInitialize)contactosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private TextBox idTextBox;
        private Label nombreLabel;
        private TextBox nombreTextBox;
        private DateTimePicker fechaDateTimePicker;
        private Label fechaNacimientoLabel;
        private Label telefonoLabel;
        private TextBox telefonoTextBox;
        private Label observacionesLabel;
        private TextBox observacionesTextBox1;
        private Button nuevoButton;
        private Button eliminarButton;
        private Button modificarButton;
        private Button button4;
        private Button guardarButton;
        private Button cancelarButton;
        private DataGridView contactosDataGridView;
    }
}
