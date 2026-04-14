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
            NombreCursoLabel = new Label();
            NombreCursoTextBox = new TextBox();
            InfoCursoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // InfoCursoGroupBox
            // 
            InfoCursoGroupBox.Controls.Add(NombreCursoTextBox);
            InfoCursoGroupBox.Controls.Add(NombreCursoLabel);
            InfoCursoGroupBox.Location = new Point(12, 12);
            InfoCursoGroupBox.Name = "InfoCursoGroupBox";
            InfoCursoGroupBox.Size = new Size(463, 266);
            InfoCursoGroupBox.TabIndex = 0;
            InfoCursoGroupBox.TabStop = false;
            InfoCursoGroupBox.Text = "Información del curso";
            InfoCursoGroupBox.Enter += groupBox1_Enter;
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
            // NombreCursoTextBox
            // 
            NombreCursoTextBox.Location = new Point(7, 58);
            NombreCursoTextBox.Name = "NombreCursoTextBox";
            NombreCursoTextBox.Size = new Size(268, 27);
            NombreCursoTextBox.TabIndex = 1;
            // 
            // RRHHForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 450);
            Controls.Add(InfoCursoGroupBox);
            Name = "RRHHForm";
            Text = "Form1";
            InfoCursoGroupBox.ResumeLayout(false);
            InfoCursoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox InfoCursoGroupBox;
        private TextBox NombreCursoTextBox;
        private Label NombreCursoLabel;
    }
}
