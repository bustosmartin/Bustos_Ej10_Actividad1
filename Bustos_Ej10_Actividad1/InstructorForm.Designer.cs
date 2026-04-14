namespace Bustos_Ej10_Actividad1
{
    partial class InstructorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InstructorGroupBox = new GroupBox();
            LegajoTextBox = new TextBox();
            LegajoLabel = new Label();
            ApellidoInstructorTextBox = new TextBox();
            ApellidoInstructorLabel = new Label();
            NombreInstructorTextBox = new TextBox();
            NombreInstructorLabel = new Label();
            InfoCursoGroupBox = new GroupBox();
            FechaFinDateTimePicker = new DateTimePicker();
            FechaInicioDateTimePicker = new DateTimePicker();
            FechaFinLabel = new Label();
            FechaInicioLabel = new Label();
            DescripcionCursoTextBox = new TextBox();
            DescripcionCursoLabel = new Label();
            NombreCursoTextBox = new TextBox();
            NombreCursoLabel = new Label();
            RegistroListView = new ListView();
            LegajoEmpleado = new ColumnHeader();
            NombreEmpleado = new ColumnHeader();
            ApellidoEmpleado = new ColumnHeader();
            CantidadPresentes = new ColumnHeader();
            CantidadAusentes = new ColumnHeader();
            ClasesTotales = new ColumnHeader();
            Calificacion = new ColumnHeader();
            InscriptosGroupBox = new GroupBox();
            CancelarButton = new Button();
            ConfirmarButton = new Button();
            InstructorGroupBox.SuspendLayout();
            InfoCursoGroupBox.SuspendLayout();
            InscriptosGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // InstructorGroupBox
            // 
            InstructorGroupBox.Controls.Add(LegajoTextBox);
            InstructorGroupBox.Controls.Add(LegajoLabel);
            InstructorGroupBox.Controls.Add(ApellidoInstructorTextBox);
            InstructorGroupBox.Controls.Add(ApellidoInstructorLabel);
            InstructorGroupBox.Controls.Add(NombreInstructorTextBox);
            InstructorGroupBox.Controls.Add(NombreInstructorLabel);
            InstructorGroupBox.Location = new Point(111, 12);
            InstructorGroupBox.Name = "InstructorGroupBox";
            InstructorGroupBox.Size = new Size(445, 159);
            InstructorGroupBox.TabIndex = 2;
            InstructorGroupBox.TabStop = false;
            InstructorGroupBox.Text = "Datos del instructor";
            // 
            // LegajoTextBox
            // 
            LegajoTextBox.Location = new Point(129, 48);
            LegajoTextBox.Name = "LegajoTextBox";
            LegajoTextBox.Size = new Size(203, 27);
            LegajoTextBox.TabIndex = 12;
            // 
            // LegajoLabel
            // 
            LegajoLabel.AutoSize = true;
            LegajoLabel.Location = new Point(28, 48);
            LegajoLabel.Name = "LegajoLabel";
            LegajoLabel.Size = new Size(54, 20);
            LegajoLabel.TabIndex = 11;
            LegajoLabel.Text = "Legajo";
            // 
            // ApellidoInstructorTextBox
            // 
            ApellidoInstructorTextBox.Location = new Point(234, 120);
            ApellidoInstructorTextBox.Name = "ApellidoInstructorTextBox";
            ApellidoInstructorTextBox.Size = new Size(205, 27);
            ApellidoInstructorTextBox.TabIndex = 10;
            // 
            // ApellidoInstructorLabel
            // 
            ApellidoInstructorLabel.AutoSize = true;
            ApellidoInstructorLabel.Location = new Point(234, 97);
            ApellidoInstructorLabel.Name = "ApellidoInstructorLabel";
            ApellidoInstructorLabel.Size = new Size(66, 20);
            ApellidoInstructorLabel.TabIndex = 9;
            ApellidoInstructorLabel.Text = "Apellido";
            // 
            // NombreInstructorTextBox
            // 
            NombreInstructorTextBox.Location = new Point(7, 120);
            NombreInstructorTextBox.Name = "NombreInstructorTextBox";
            NombreInstructorTextBox.Size = new Size(199, 27);
            NombreInstructorTextBox.TabIndex = 8;
            // 
            // NombreInstructorLabel
            // 
            NombreInstructorLabel.AutoSize = true;
            NombreInstructorLabel.Location = new Point(6, 97);
            NombreInstructorLabel.Name = "NombreInstructorLabel";
            NombreInstructorLabel.Size = new Size(64, 20);
            NombreInstructorLabel.TabIndex = 8;
            NombreInstructorLabel.Text = "Nombre";
            // 
            // InfoCursoGroupBox
            // 
            InfoCursoGroupBox.Controls.Add(FechaFinDateTimePicker);
            InfoCursoGroupBox.Controls.Add(FechaInicioDateTimePicker);
            InfoCursoGroupBox.Controls.Add(FechaFinLabel);
            InfoCursoGroupBox.Controls.Add(FechaInicioLabel);
            InfoCursoGroupBox.Controls.Add(DescripcionCursoTextBox);
            InfoCursoGroupBox.Controls.Add(DescripcionCursoLabel);
            InfoCursoGroupBox.Controls.Add(NombreCursoTextBox);
            InfoCursoGroupBox.Controls.Add(NombreCursoLabel);
            InfoCursoGroupBox.Location = new Point(111, 177);
            InfoCursoGroupBox.Name = "InfoCursoGroupBox";
            InfoCursoGroupBox.Size = new Size(382, 350);
            InfoCursoGroupBox.TabIndex = 3;
            InfoCursoGroupBox.TabStop = false;
            InfoCursoGroupBox.Text = "Información del curso";
            // 
            // FechaFinDateTimePicker
            // 
            FechaFinDateTimePicker.Location = new Point(8, 295);
            FechaFinDateTimePicker.Name = "FechaFinDateTimePicker";
            FechaFinDateTimePicker.Size = new Size(349, 27);
            FechaFinDateTimePicker.TabIndex = 7;
            // 
            // FechaInicioDateTimePicker
            // 
            FechaInicioDateTimePicker.Location = new Point(7, 211);
            FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker";
            FechaInicioDateTimePicker.Size = new Size(350, 27);
            FechaInicioDateTimePicker.TabIndex = 6;
            // 
            // FechaFinLabel
            // 
            FechaFinLabel.AutoSize = true;
            FechaFinLabel.Location = new Point(6, 260);
            FechaFinLabel.Name = "FechaFinLabel";
            FechaFinLabel.Size = new Size(68, 20);
            FechaFinLabel.TabIndex = 5;
            FechaFinLabel.Text = "Fecha fin";
            // 
            // FechaInicioLabel
            // 
            FechaInicioLabel.AutoSize = true;
            FechaInicioLabel.Location = new Point(8, 179);
            FechaInicioLabel.Name = "FechaInicioLabel";
            FechaInicioLabel.Size = new Size(108, 20);
            FechaInicioLabel.TabIndex = 4;
            FechaInicioLabel.Text = "Fecha de inicio";
            // 
            // DescripcionCursoTextBox
            // 
            DescripcionCursoTextBox.Location = new Point(7, 134);
            DescripcionCursoTextBox.Name = "DescripcionCursoTextBox";
            DescripcionCursoTextBox.ReadOnly = true;
            DescripcionCursoTextBox.Size = new Size(350, 27);
            DescripcionCursoTextBox.TabIndex = 3;
            // 
            // DescripcionCursoLabel
            // 
            DescripcionCursoLabel.AutoSize = true;
            DescripcionCursoLabel.Location = new Point(8, 102);
            DescripcionCursoLabel.Name = "DescripcionCursoLabel";
            DescripcionCursoLabel.Size = new Size(87, 20);
            DescripcionCursoLabel.TabIndex = 2;
            DescripcionCursoLabel.Text = "Descripción";
            // 
            // NombreCursoTextBox
            // 
            NombreCursoTextBox.Location = new Point(7, 58);
            NombreCursoTextBox.Name = "NombreCursoTextBox";
            NombreCursoTextBox.ReadOnly = true;
            NombreCursoTextBox.Size = new Size(350, 27);
            NombreCursoTextBox.TabIndex = 1;
            // 
            // NombreCursoLabel
            // 
            NombreCursoLabel.AutoSize = true;
            NombreCursoLabel.Location = new Point(8, 30);
            NombreCursoLabel.Name = "NombreCursoLabel";
            NombreCursoLabel.Size = new Size(64, 20);
            NombreCursoLabel.TabIndex = 0;
            NombreCursoLabel.Text = "Nombre";
            // 
            // RegistroListView
            // 
            RegistroListView.Columns.AddRange(new ColumnHeader[] { LegajoEmpleado, NombreEmpleado, ApellidoEmpleado, CantidadPresentes, CantidadAusentes, ClasesTotales, Calificacion });
            RegistroListView.Location = new Point(6, 35);
            RegistroListView.Name = "RegistroListView";
            RegistroListView.Size = new Size(624, 212);
            RegistroListView.TabIndex = 4;
            RegistroListView.UseCompatibleStateImageBehavior = false;
            RegistroListView.View = View.Details;
            // 
            // LegajoEmpleado
            // 
            LegajoEmpleado.Text = "Legajo";
            LegajoEmpleado.Width = 80;
            // 
            // NombreEmpleado
            // 
            NombreEmpleado.Text = "Nombre";
            NombreEmpleado.Width = 80;
            // 
            // ApellidoEmpleado
            // 
            ApellidoEmpleado.Text = "Apellido";
            ApellidoEmpleado.Width = 80;
            // 
            // CantidadPresentes
            // 
            CantidadPresentes.Text = "Presente";
            CantidadPresentes.Width = 80;
            // 
            // CantidadAusentes
            // 
            CantidadAusentes.Text = "Ausente";
            CantidadAusentes.Width = 80;
            // 
            // ClasesTotales
            // 
            ClasesTotales.Text = "Clases Totales";
            ClasesTotales.Width = 120;
            // 
            // Calificacion
            // 
            Calificacion.Text = "Calificación";
            Calificacion.Width = 90;
            // 
            // InscriptosGroupBox
            // 
            InscriptosGroupBox.Controls.Add(RegistroListView);
            InscriptosGroupBox.Location = new Point(10, 544);
            InscriptosGroupBox.Name = "InscriptosGroupBox";
            InscriptosGroupBox.Size = new Size(634, 257);
            InscriptosGroupBox.TabIndex = 5;
            InscriptosGroupBox.TabStop = false;
            InscriptosGroupBox.Text = "Datos de los inscriptos";
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(505, 810);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(125, 31);
            CancelarButton.TabIndex = 6;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(374, 810);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(125, 31);
            ConfirmarButton.TabIndex = 7;
            ConfirmarButton.Text = "Confirmar";
            ConfirmarButton.UseVisualStyleBackColor = true;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 853);
            Controls.Add(ConfirmarButton);
            Controls.Add(CancelarButton);
            Controls.Add(InscriptosGroupBox);
            Controls.Add(InfoCursoGroupBox);
            Controls.Add(InstructorGroupBox);
            Name = "InstructorForm";
            Text = "Información cursos";
            InstructorGroupBox.ResumeLayout(false);
            InstructorGroupBox.PerformLayout();
            InfoCursoGroupBox.ResumeLayout(false);
            InfoCursoGroupBox.PerformLayout();
            InscriptosGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox InstructorGroupBox;
        private TextBox LegajoTextBox;
        private Label LegajoLabel;
        private TextBox ApellidoInstructorTextBox;
        private Label ApellidoInstructorLabel;
        private TextBox NombreInstructorTextBox;
        private Label NombreInstructorLabel;
        private GroupBox InfoCursoGroupBox;
        private DateTimePicker FechaFinDateTimePicker;
        private DateTimePicker FechaInicioDateTimePicker;
        private Label FechaFinLabel;
        private Label FechaInicioLabel;
        private TextBox DescripcionCursoTextBox;
        private Label DescripcionCursoLabel;
        private TextBox NombreCursoTextBox;
        private Label NombreCursoLabel;
        private ListView RegistroListView;
        private ColumnHeader LegajoEmpleado;
        private ColumnHeader NombreEmpleado;
        private ColumnHeader ApellidoEmpleado;
        private ColumnHeader CantidadPresentes;
        private ColumnHeader CantidadAusentes;
        private ColumnHeader ClasesTotales;
        private ColumnHeader Calificacion;
        private GroupBox InscriptosGroupBox;
        private Button CancelarButton;
        private Button ConfirmarButton;
    }
}