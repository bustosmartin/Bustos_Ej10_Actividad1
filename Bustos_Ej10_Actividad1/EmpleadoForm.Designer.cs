namespace Bustos_Ej10_Actividad1
{
    partial class EmpleadoForm
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
            InfoEmpleadoGroupBox = new GroupBox();
            LegajoTextBox = new TextBox();
            LegajoLabel = new Label();
            ApellidoEmpleadoTextBox = new TextBox();
            ApellidoEmpleadoLabel = new Label();
            NombreEmpleadoTextBox = new TextBox();
            NombreEmpleadoLabel = new Label();
            InfoCursoGroupBox = new GroupBox();
            FechaFinDateTimePicker = new DateTimePicker();
            FechaInicioDateTimePicker = new DateTimePicker();
            FechaFinLabel = new Label();
            FechaInicioLabel = new Label();
            DescripcionCursoTextBox = new TextBox();
            DescripcionCursoLabel = new Label();
            NombreCursoLabel = new Label();
            NombreCursoComboBox = new ComboBox();
            CancelarButton = new Button();
            ConfirmarInscripcionButton = new Button();
            InfoEmpleadoGroupBox.SuspendLayout();
            InfoCursoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // InfoEmpleadoGroupBox
            // 
            InfoEmpleadoGroupBox.Controls.Add(LegajoTextBox);
            InfoEmpleadoGroupBox.Controls.Add(LegajoLabel);
            InfoEmpleadoGroupBox.Controls.Add(ApellidoEmpleadoTextBox);
            InfoEmpleadoGroupBox.Controls.Add(ApellidoEmpleadoLabel);
            InfoEmpleadoGroupBox.Controls.Add(NombreEmpleadoTextBox);
            InfoEmpleadoGroupBox.Controls.Add(NombreEmpleadoLabel);
            InfoEmpleadoGroupBox.Location = new Point(12, 12);
            InfoEmpleadoGroupBox.Name = "InfoEmpleadoGroupBox";
            InfoEmpleadoGroupBox.Size = new Size(445, 185);
            InfoEmpleadoGroupBox.TabIndex = 2;
            InfoEmpleadoGroupBox.TabStop = false;
            InfoEmpleadoGroupBox.Text = "Información del empleado";
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
            // ApellidoEmpleadoTextBox
            // 
            ApellidoEmpleadoTextBox.Location = new Point(234, 120);
            ApellidoEmpleadoTextBox.Name = "ApellidoEmpleadoTextBox";
            ApellidoEmpleadoTextBox.Size = new Size(205, 27);
            ApellidoEmpleadoTextBox.TabIndex = 10;
            // 
            // ApellidoEmpleadoLabel
            // 
            ApellidoEmpleadoLabel.AutoSize = true;
            ApellidoEmpleadoLabel.Location = new Point(234, 97);
            ApellidoEmpleadoLabel.Name = "ApellidoEmpleadoLabel";
            ApellidoEmpleadoLabel.Size = new Size(66, 20);
            ApellidoEmpleadoLabel.TabIndex = 9;
            ApellidoEmpleadoLabel.Text = "Apellido";
            // 
            // NombreEmpleadoTextBox
            // 
            NombreEmpleadoTextBox.Location = new Point(7, 120);
            NombreEmpleadoTextBox.Name = "NombreEmpleadoTextBox";
            NombreEmpleadoTextBox.Size = new Size(199, 27);
            NombreEmpleadoTextBox.TabIndex = 8;
            // 
            // NombreEmpleadoLabel
            // 
            NombreEmpleadoLabel.AutoSize = true;
            NombreEmpleadoLabel.Location = new Point(6, 97);
            NombreEmpleadoLabel.Name = "NombreEmpleadoLabel";
            NombreEmpleadoLabel.Size = new Size(64, 20);
            NombreEmpleadoLabel.TabIndex = 8;
            NombreEmpleadoLabel.Text = "Nombre";
            // 
            // InfoCursoGroupBox
            // 
            InfoCursoGroupBox.Controls.Add(NombreCursoComboBox);
            InfoCursoGroupBox.Controls.Add(FechaFinDateTimePicker);
            InfoCursoGroupBox.Controls.Add(FechaInicioDateTimePicker);
            InfoCursoGroupBox.Controls.Add(FechaFinLabel);
            InfoCursoGroupBox.Controls.Add(FechaInicioLabel);
            InfoCursoGroupBox.Controls.Add(DescripcionCursoTextBox);
            InfoCursoGroupBox.Controls.Add(DescripcionCursoLabel);
            InfoCursoGroupBox.Controls.Add(NombreCursoLabel);
            InfoCursoGroupBox.Location = new Point(12, 214);
            InfoCursoGroupBox.Name = "InfoCursoGroupBox";
            InfoCursoGroupBox.Size = new Size(445, 350);
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
            // NombreCursoLabel
            // 
            NombreCursoLabel.AutoSize = true;
            NombreCursoLabel.Location = new Point(8, 30);
            NombreCursoLabel.Name = "NombreCursoLabel";
            NombreCursoLabel.Size = new Size(64, 20);
            NombreCursoLabel.TabIndex = 0;
            NombreCursoLabel.Text = "Nombre";
            // 
            // NombreCursoComboBox
            // 
            NombreCursoComboBox.FormattingEnabled = true;
            NombreCursoComboBox.Location = new Point(8, 64);
            NombreCursoComboBox.Name = "NombreCursoComboBox";
            NombreCursoComboBox.Size = new Size(349, 28);
            NombreCursoComboBox.TabIndex = 8;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(321, 596);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(136, 27);
            CancelarButton.TabIndex = 4;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // ConfirmarInscripcionButton
            // 
            ConfirmarInscripcionButton.Location = new Point(149, 596);
            ConfirmarInscripcionButton.Name = "ConfirmarInscripcionButton";
            ConfirmarInscripcionButton.Size = new Size(166, 27);
            ConfirmarInscripcionButton.TabIndex = 5;
            ConfirmarInscripcionButton.Text = "Confirmar inscripción";
            ConfirmarInscripcionButton.UseVisualStyleBackColor = true;
            // 
            // EmpleadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 629);
            Controls.Add(ConfirmarInscripcionButton);
            Controls.Add(CancelarButton);
            Controls.Add(InfoCursoGroupBox);
            Controls.Add(InfoEmpleadoGroupBox);
            Name = "EmpleadoForm";
            Text = "Inscripción a cursos";
            InfoEmpleadoGroupBox.ResumeLayout(false);
            InfoEmpleadoGroupBox.PerformLayout();
            InfoCursoGroupBox.ResumeLayout(false);
            InfoCursoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox InfoEmpleadoGroupBox;
        private TextBox LegajoTextBox;
        private Label LegajoLabel;
        private TextBox ApellidoEmpleadoTextBox;
        private Label ApellidoEmpleadoLabel;
        private TextBox NombreEmpleadoTextBox;
        private Label NombreEmpleadoLabel;
        private GroupBox InfoCursoGroupBox;
        private ComboBox NombreCursoComboBox;
        private DateTimePicker FechaFinDateTimePicker;
        private DateTimePicker FechaInicioDateTimePicker;
        private Label FechaFinLabel;
        private Label FechaInicioLabel;
        private TextBox DescripcionCursoTextBox;
        private Label DescripcionCursoLabel;
        private Label NombreCursoLabel;
        private Button CancelarButton;
        private Button ConfirmarInscripcionButton;
    }
}