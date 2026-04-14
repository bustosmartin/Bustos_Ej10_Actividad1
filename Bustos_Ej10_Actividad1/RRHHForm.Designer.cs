namespace Bustos_Ej10_Actividad1
{
    partial class RRHHForm
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
            InfoCursoGroupBox = new GroupBox();
            NombreCursoTextBox = new TextBox();
            NombreCursoLabel = new Label();
            DescripcionCursoLabel = new Label();
            DescripcionCursoTextBox = new TextBox();
            FechaInicioLabel = new Label();
            FechaFinLabel = new Label();
            FechaInicioDateTimePicker = new DateTimePicker();
            FechaFinDateTimePicker = new DateTimePicker();
            InstructorGroupBox = new GroupBox();
            NombreInstructorLabel = new Label();
            NombreInstructorTextBox = new TextBox();
            ApellidoInstructorLabel = new Label();
            ApellidoInstructorTextBox = new TextBox();
            CrearCursoButton = new Button();
            CancelarButton = new Button();
            LegajoLabel = new Label();
            LegajoTextBox = new TextBox();
            InfoCursoGroupBox.SuspendLayout();
            InstructorGroupBox.SuspendLayout();
            SuspendLayout();
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
            InfoCursoGroupBox.Location = new Point(12, 12);
            InfoCursoGroupBox.Name = "InfoCursoGroupBox";
            InfoCursoGroupBox.Size = new Size(451, 350);
            InfoCursoGroupBox.TabIndex = 0;
            InfoCursoGroupBox.TabStop = false;
            InfoCursoGroupBox.Text = "Información del curso";
            InfoCursoGroupBox.Enter += groupBox1_Enter;
            // 
            // NombreCursoTextBox
            // 
            NombreCursoTextBox.Location = new Point(7, 58);
            NombreCursoTextBox.Name = "NombreCursoTextBox";
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
            // DescripcionCursoLabel
            // 
            DescripcionCursoLabel.AutoSize = true;
            DescripcionCursoLabel.Location = new Point(8, 102);
            DescripcionCursoLabel.Name = "DescripcionCursoLabel";
            DescripcionCursoLabel.Size = new Size(87, 20);
            DescripcionCursoLabel.TabIndex = 2;
            DescripcionCursoLabel.Text = "Descripción";
            // 
            // DescripcionCursoTextBox
            // 
            DescripcionCursoTextBox.Location = new Point(7, 134);
            DescripcionCursoTextBox.Name = "DescripcionCursoTextBox";
            DescripcionCursoTextBox.Size = new Size(350, 27);
            DescripcionCursoTextBox.TabIndex = 3;
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
            // FechaFinLabel
            // 
            FechaFinLabel.AutoSize = true;
            FechaFinLabel.Location = new Point(6, 260);
            FechaFinLabel.Name = "FechaFinLabel";
            FechaFinLabel.Size = new Size(68, 20);
            FechaFinLabel.TabIndex = 5;
            FechaFinLabel.Text = "Fecha fin";
            // 
            // FechaInicioDateTimePicker
            // 
            FechaInicioDateTimePicker.Location = new Point(7, 211);
            FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker";
            FechaInicioDateTimePicker.Size = new Size(350, 27);
            FechaInicioDateTimePicker.TabIndex = 6;
            // 
            // FechaFinDateTimePicker
            // 
            FechaFinDateTimePicker.Location = new Point(8, 295);
            FechaFinDateTimePicker.Name = "FechaFinDateTimePicker";
            FechaFinDateTimePicker.Size = new Size(349, 27);
            FechaFinDateTimePicker.TabIndex = 7;
            // 
            // InstructorGroupBox
            // 
            InstructorGroupBox.Controls.Add(LegajoTextBox);
            InstructorGroupBox.Controls.Add(LegajoLabel);
            InstructorGroupBox.Controls.Add(ApellidoInstructorTextBox);
            InstructorGroupBox.Controls.Add(ApellidoInstructorLabel);
            InstructorGroupBox.Controls.Add(NombreInstructorTextBox);
            InstructorGroupBox.Controls.Add(NombreInstructorLabel);
            InstructorGroupBox.Location = new Point(15, 379);
            InstructorGroupBox.Name = "InstructorGroupBox";
            InstructorGroupBox.Size = new Size(445, 165);
            InstructorGroupBox.TabIndex = 1;
            InstructorGroupBox.TabStop = false;
            InstructorGroupBox.Text = "Datos del instructor";
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
            // NombreInstructorTextBox
            // 
            NombreInstructorTextBox.Location = new Point(7, 120);
            NombreInstructorTextBox.Name = "NombreInstructorTextBox";
            NombreInstructorTextBox.Size = new Size(199, 27);
            NombreInstructorTextBox.TabIndex = 8;
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
            // ApellidoInstructorTextBox
            // 
            ApellidoInstructorTextBox.Location = new Point(234, 120);
            ApellidoInstructorTextBox.Name = "ApellidoInstructorTextBox";
            ApellidoInstructorTextBox.Size = new Size(205, 27);
            ApellidoInstructorTextBox.TabIndex = 10;
            // 
            // CrearCursoButton
            // 
            CrearCursoButton.Location = new Point(174, 568);
            CrearCursoButton.Name = "CrearCursoButton";
            CrearCursoButton.Size = new Size(140, 29);
            CrearCursoButton.TabIndex = 2;
            CrearCursoButton.Text = "Crear Curso";
            CrearCursoButton.UseVisualStyleBackColor = true;
            CrearCursoButton.Click += CrearCursoButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(320, 568);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(140, 29);
            CancelarButton.TabIndex = 3;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
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
            // LegajoTextBox
            // 
            LegajoTextBox.Location = new Point(129, 48);
            LegajoTextBox.Name = "LegajoTextBox";
            LegajoTextBox.Size = new Size(203, 27);
            LegajoTextBox.TabIndex = 12;
            // 
            // RRHHForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 599);
            Controls.Add(CancelarButton);
            Controls.Add(CrearCursoButton);
            Controls.Add(InstructorGroupBox);
            Controls.Add(InfoCursoGroupBox);
            Name = "RRHHForm";
            Text = "Creación de cursos";
            InfoCursoGroupBox.ResumeLayout(false);
            InfoCursoGroupBox.PerformLayout();
            InstructorGroupBox.ResumeLayout(false);
            InstructorGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox InfoCursoGroupBox;
        private TextBox NombreCursoTextBox;
        private Label NombreCursoLabel;
        private Label FechaFinLabel;
        private Label FechaInicioLabel;
        private TextBox DescripcionCursoTextBox;
        private Label DescripcionCursoLabel;
        private DateTimePicker FechaInicioDateTimePicker;
        private DateTimePicker FechaFinDateTimePicker;
        private GroupBox InstructorGroupBox;
        private TextBox ApellidoInstructorTextBox;
        private Label ApellidoInstructorLabel;
        private TextBox NombreInstructorTextBox;
        private Label NombreInstructorLabel;
        private Button CrearCursoButton;
        private Button CancelarButton;
        private TextBox LegajoTextBox;
        private Label LegajoLabel;
    }
}
