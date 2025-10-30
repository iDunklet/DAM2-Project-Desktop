namespace DAM2_Project_Desktop
{
    partial class Pantalla2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla2));
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            button7 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            controlProyectoPantalla21 = new ControlProyectoPantalla2();
            label2 = new Label();
            label1 = new Label();
            buttonExportarJson = new Button();
            buttonImportarJson = new Button();
            buttonUsuarios = new Button();
            buttonProyectosPrivados = new Button();
            buttonFavoritos = new Button();
            buttonInicio = new Button();
            pictureBox1 = new PictureBox();
            pictureBoxLogo = new PictureBox();
            pictureBoxMenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer1.Panel1.Controls.Add(pictureBoxMenu);
            splitContainer1.Panel1.Controls.Add(pictureBoxLogo);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1424, 985);
            splitContainer1.SplitterDistance = 95;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(3, 2, 3, 2);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel1.Controls.Add(buttonExportarJson);
            splitContainer2.Panel1.Controls.Add(buttonImportarJson);
            splitContainer2.Panel1.Controls.Add(buttonUsuarios);
            splitContainer2.Panel1.Controls.Add(buttonProyectosPrivados);
            splitContainer2.Panel1.Controls.Add(buttonFavoritos);
            splitContainer2.Panel1.Controls.Add(buttonInicio);
            splitContainer2.Panel1.Controls.Add(button7);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Panel2.Controls.Add(label2);
            splitContainer2.Panel2.Controls.Add(label1);
            splitContainer2.Size = new Size(1424, 888);
            splitContainer2.SplitterDistance = 243;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new Point(18, 818);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(175, 45);
            button7.TabIndex = 9;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(controlProyectoPantalla21);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 150);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1177, 736);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // controlProyectoPantalla21
            // 
            controlProyectoPantalla21.BackColor = Color.White;
            controlProyectoPantalla21.BorderStyle = BorderStyle.FixedSingle;
            controlProyectoPantalla21.Imagen = null;
            controlProyectoPantalla21.Location = new Point(10, 10);
            controlProyectoPantalla21.Margin = new Padding(10);
            controlProyectoPantalla21.Name = "controlProyectoPantalla21";
            controlProyectoPantalla21.Proyecto = null;
            controlProyectoPantalla21.Size = new Size(259, 108);
            controlProyectoPantalla21.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(35, 78, 82);
            label2.Location = new Point(54, 96);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 1;
            label2.Text = "Recientes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 78, 82);
            label1.Location = new Point(54, 31);
            label1.Name = "label1";
            label1.Size = new Size(125, 54);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            // 
            // buttonExportarJson
            // 
            buttonExportarJson.BackColor = Color.FromArgb(79, 209, 197);
            buttonExportarJson.FlatStyle = FlatStyle.Flat;
            buttonExportarJson.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            buttonExportarJson.ForeColor = Color.FromArgb(35, 78, 82);
            buttonExportarJson.Location = new Point(18, 436);
            buttonExportarJson.Name = "buttonExportarJson";
            buttonExportarJson.Size = new Size(200, 70);
            buttonExportarJson.TabIndex = 15;
            buttonExportarJson.Text = "Exportar JSON";
            buttonExportarJson.UseVisualStyleBackColor = false;
            // 
            // buttonImportarJson
            // 
            buttonImportarJson.BackColor = Color.FromArgb(79, 209, 197);
            buttonImportarJson.FlatStyle = FlatStyle.Flat;
            buttonImportarJson.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            buttonImportarJson.ForeColor = Color.FromArgb(35, 78, 82);
            buttonImportarJson.Location = new Point(18, 346);
            buttonImportarJson.Name = "buttonImportarJson";
            buttonImportarJson.Size = new Size(200, 67);
            buttonImportarJson.TabIndex = 14;
            buttonImportarJson.Text = "Importar JSON";
            buttonImportarJson.UseVisualStyleBackColor = false;
            buttonImportarJson.Click += buttonImportarJson_Click;
            // 
            // buttonUsuarios
            // 
            buttonUsuarios.BackColor = Color.FromArgb(79, 209, 197);
            buttonUsuarios.FlatStyle = FlatStyle.Flat;
            buttonUsuarios.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            buttonUsuarios.ForeColor = Color.FromArgb(35, 78, 82);
            buttonUsuarios.Location = new Point(18, 262);
            buttonUsuarios.Name = "buttonUsuarios";
            buttonUsuarios.Size = new Size(200, 68);
            buttonUsuarios.TabIndex = 16;
            buttonUsuarios.Text = "Usuarios";
            buttonUsuarios.UseVisualStyleBackColor = false;
            // 
            // buttonProyectosPrivados
            // 
            buttonProyectosPrivados.BackColor = Color.FromArgb(79, 209, 197);
            buttonProyectosPrivados.FlatStyle = FlatStyle.Flat;
            buttonProyectosPrivados.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            buttonProyectosPrivados.ForeColor = Color.FromArgb(35, 78, 82);
            buttonProyectosPrivados.Location = new Point(18, 177);
            buttonProyectosPrivados.Name = "buttonProyectosPrivados";
            buttonProyectosPrivados.Size = new Size(200, 70);
            buttonProyectosPrivados.TabIndex = 13;
            buttonProyectosPrivados.Text = "Proyectos \r\nprivados";
            buttonProyectosPrivados.UseVisualStyleBackColor = false;
            // 
            // buttonFavoritos
            // 
            buttonFavoritos.BackColor = Color.FromArgb(79, 209, 197);
            buttonFavoritos.FlatStyle = FlatStyle.Flat;
            buttonFavoritos.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            buttonFavoritos.ForeColor = Color.FromArgb(35, 78, 82);
            buttonFavoritos.Location = new Point(18, 97);
            buttonFavoritos.Name = "buttonFavoritos";
            buttonFavoritos.Size = new Size(200, 64);
            buttonFavoritos.TabIndex = 12;
            buttonFavoritos.Text = "Favoritos";
            buttonFavoritos.UseVisualStyleBackColor = false;
            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = Color.FromArgb(79, 209, 197);
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInicio.ForeColor = Color.FromArgb(35, 78, 82);
            buttonInicio.Location = new Point(18, 19);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(200, 66);
            buttonInicio.TabIndex = 11;
            buttonInicio.Text = "Inicio";
            buttonInicio.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1315, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(183, 6);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(241, 84);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 5;
            pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxMenu
            // 
            pictureBoxMenu.Image = (Image)resources.GetObject("pictureBoxMenu.Image");
            pictureBoxMenu.Location = new Point(11, 6);
            pictureBoxMenu.Name = "pictureBoxMenu";
            pictureBoxMenu.Size = new Size(137, 84);
            pictureBoxMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMenu.TabIndex = 6;
            pictureBoxMenu.TabStop = false;
            // 
            // Pantalla2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 985);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1440, 1024);
            Name = "Pantalla2";
            Text = "Form1";
            Load += Pantalla2_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button button7;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ControlProyectoPantalla2 controlProyectoPantalla21;
        private Button buttonExportarJson;
        private Button buttonImportarJson;
        private Button buttonUsuarios;
        private Button buttonProyectosPrivados;
        private Button buttonFavoritos;
        private Button buttonInicio;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxMenu;
    }
}
