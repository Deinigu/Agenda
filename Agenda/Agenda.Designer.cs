﻿namespace Agenda
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
            anyadirButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            guardarButton = new Button();
            cancelarButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(30, 53);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(32, 25);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(217, 53);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(150, 31);
            idTextBox.TabIndex = 1;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(30, 97);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(82, 25);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(217, 97);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(150, 31);
            nombreTextBox.TabIndex = 3;
            // 
            // fechaDateTimePicker
            // 
            fechaDateTimePicker.Location = new Point(217, 141);
            fechaDateTimePicker.Name = "fechaDateTimePicker";
            fechaDateTimePicker.Size = new Size(300, 31);
            fechaDateTimePicker.TabIndex = 4;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new Point(30, 141);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new Size(181, 25);
            fechaNacimientoLabel.TabIndex = 5;
            fechaNacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new Point(29, 182);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(83, 25);
            telefonoLabel.TabIndex = 6;
            telefonoLabel.Text = "Teléfono:";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(217, 182);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(261, 31);
            telefonoTextBox.TabIndex = 7;
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new Point(30, 220);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new Size(132, 25);
            observacionesLabel.TabIndex = 8;
            observacionesLabel.Text = "Observaciones:";
            // 
            // observacionesTextBox1
            // 
            observacionesTextBox1.Location = new Point(217, 220);
            observacionesTextBox1.Multiline = true;
            observacionesTextBox1.Name = "observacionesTextBox1";
            observacionesTextBox1.Size = new Size(520, 134);
            observacionesTextBox1.TabIndex = 9;
            // 
            // anyadirButton
            // 
            anyadirButton.Location = new Point(30, 376);
            anyadirButton.Name = "anyadirButton";
            anyadirButton.Size = new Size(112, 34);
            anyadirButton.TabIndex = 10;
            anyadirButton.Text = "Añadir";
            anyadirButton.UseVisualStyleBackColor = true;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(180, 376);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(112, 34);
            eliminarButton.TabIndex = 11;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(326, 376);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(112, 34);
            modificarButton.TabIndex = 12;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new Point(743, 376);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new Size(112, 34);
            this.guardarButton.TabIndex = 13;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(887, 376);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(112, 34);
            cancelarButton.TabIndex = 14;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 476);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1339, 307);
            dataGridView1.TabIndex = 15;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 807);
            Controls.Add(dataGridView1);
            Controls.Add(cancelarButton);
            Controls.Add(this.guardarButton);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(anyadirButton);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button anyadirButton;
        private Button eliminarButton;
        private Button modificarButton;
        private Button button4;
        private Button guardarButton;
        private Button cancelarButton;
        private DataGridView dataGridView1;
    }
}
