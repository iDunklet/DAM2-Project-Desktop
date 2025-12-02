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
            pictureBoxImagen.Location = new Point(14, 24);
            pictureBoxImagen.Margin = new Padding(3, 4, 3, 4);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Padding = new Padding(6, 7, 6, 7);
            pictureBoxImagen.Size = new Size(140, 140);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxImagen.TabIndex = 0;
            pictureBoxImagen.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AllowDrop = true;
            labelTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.FromArgb(35, 78, 82);
            labelTitulo.Location = new Point(160, 24);
            labelTitulo.MaximumSize = new Size(217, 100);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(207, 89);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Título Proyecto";
            // 
            // labelMiembros
            // 
            labelMiembros.AutoSize = true;
            labelMiembros.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelMiembros.ForeColor = Color.FromArgb(64, 64, 64);
            labelMiembros.Location = new Point(160, 113);
            labelMiembros.Name = "labelMiembros";
            labelMiembros.Size = new Size(107, 25);
            labelMiembros.TabIndex = 3;
            labelMiembros.Text = "Miembros:";
            // 
            // labelTareas
            // 
            labelTareas.AutoSize = true;
            labelTareas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelTareas.ForeColor = Color.FromArgb(64, 64, 64);
            labelTareas.Location = new Point(160, 141);
            labelTareas.Name = "labelTareas";
            labelTareas.Size = new Size(72, 25);
            labelTareas.TabIndex = 4;
            labelTareas.Text = "Tareas:";
            // 
            // ControlProyectoPantalla2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Khaki;
            Controls.Add(labelTareas);
            Controls.Add(labelMiembros);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBoxImagen);
            Cursor = Cursors.Hand;
            Margin = new Padding(14, 16, 14, 16);
            Name = "ControlProyectoPantalla2";
            Size = new Size(380, 192);
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