namespace Bustos_Ej10_Actividad1
{
    partial class AnalistaHistorialForm
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
            CursosAnotadosGroupBox = new GroupBox();
            listView1 = new ListView();
            NombreCurso = new ColumnHeader();
            DescripcionCurso = new ColumnHeader();
            CertificadoEmitido = new ColumnHeader();
            AceptarButton = new Button();
            InfoEmpleadoGroupBox.SuspendLayout();
            CursosAnotadosGroupBox.SuspendLayout();
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
            InfoEmpleadoGroupBox.Location = new Point(112, 21);
            InfoEmpleadoGroupBox.Name = "InfoEmpleadoGroupBox";
            InfoEmpleadoGroupBox.Size = new Size(445, 185);
            InfoEmpleadoGroupBox.TabIndex = 3;
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
            // CursosAnotadosGroupBox
            // 
            CursosAnotadosGroupBox.Controls.Add(listView1);
            CursosAnotadosGroupBox.Location = new Point(14, 227);
            CursosAnotadosGroupBox.Name = "CursosAnotadosGroupBox";
            CursosAnotadosGroupBox.Size = new Size(636, 278);
            CursosAnotadosGroupBox.TabIndex = 4;
            CursosAnotadosGroupBox.TabStop = false;
            CursosAnotadosGroupBox.Text = "Cursos anotados";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NombreCurso, DescripcionCurso, CertificadoEmitido });
            listView1.Location = new Point(7, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(619, 231);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NombreCurso
            // 
            NombreCurso.Text = "Nombre del curso";
            NombreCurso.Width = 150;
            // 
            // DescripcionCurso
            // 
            DescripcionCurso.Text = "Descripción";
            DescripcionCurso.Width = 100;
            // 
            // CertificadoEmitido
            // 
            CertificadoEmitido.Text = "Certificado emitido (S/N)";
            CertificadoEmitido.Width = 190;
            // 
            // AceptarButton
            // 
            AceptarButton.Location = new Point(258, 516);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(148, 28);
            AceptarButton.TabIndex = 5;
            AceptarButton.Text = "Aceptar";
            AceptarButton.UseVisualStyleBackColor = true;
            // 
            // AnalistaHistorialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 551);
            Controls.Add(AceptarButton);
            Controls.Add(CursosAnotadosGroupBox);
            Controls.Add(InfoEmpleadoGroupBox);
            Name = "AnalistaHistorialForm";
            Text = "Historial de formación";
            InfoEmpleadoGroupBox.ResumeLayout(false);
            InfoEmpleadoGroupBox.PerformLayout();
            CursosAnotadosGroupBox.ResumeLayout(false);
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
        private GroupBox CursosAnotadosGroupBox;
        private ListView listView1;
        private ColumnHeader NombreCurso;
        private ColumnHeader DescripcionCurso;
        private ColumnHeader CertificadoEmitido;
        private Button AceptarButton;
    }
}