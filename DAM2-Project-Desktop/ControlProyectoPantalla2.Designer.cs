namespace DAM2_Project_Desktop
{
    partial class ControlProyectoPantalla2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxImagen = new PictureBox();
            labelTitulo = new Label();
            labelMiembros = new Label();
            labelTareas = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Khaki;
            pictureBoxImagen.Location = new Point(15, 25);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Padding = new Padding(5);
            pictureBoxImagen.Size = new Size(119, 118);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 0;
            pictureBoxImagen.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AllowDrop = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.FromArgb(35, 78, 82);
            labelTitulo.Location = new Point(140, 29);
            labelTitulo.MaximumSize = new Size(190, 70);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(173, 70);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Título Proyecto";
            // 
            // labelMiembros
            // 
            labelMiembros.AutoSize = true;
            labelMiembros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMiembros.ForeColor = Color.FromArgb(64, 64, 64);
            labelMiembros.Location = new Point(140, 101);
            labelMiembros.Name = "labelMiembros";
            labelMiembros.Size = new Size(91, 21);
            labelMiembros.TabIndex = 3;
            labelMiembros.Text = "Miembros:";
            // 
            // labelTareas
            // 
            labelTareas.AutoSize = true;
            labelTareas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTareas.ForeColor = Color.FromArgb(64, 64, 64);
            labelTareas.Location = new Point(140, 122);
            labelTareas.Name = "labelTareas";
            labelTareas.Size = new Size(62, 21);
            labelTareas.TabIndex = 4;
            labelTareas.Text = "Tareas:";
            // 
            // ControlProyectoPantalla2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelTareas);
            Controls.Add(labelMiembros);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBoxImagen);
            Cursor = Cursors.Hand;
            Margin = new Padding(12);
            Name = "ControlProyectoPantalla2";
            Size = new Size(366, 170);
            Load += ControlProyectoPantalla2_Load;
            Click += ControlProyectoPantalla2_Click;
            Resize += ControlProyectoPantalla2_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxImagen;
        private Label labelTitulo;
        private Label labelMiembros;
        private Label labelTareas;
    }
}