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
            splitContainer1 = new SplitContainer();
            pictureBoxTasky = new PictureBox();
            splitContainer2 = new SplitContainer();
            button7 = new Button();
            buttonExportarJSON = new Button();
            buttonImportarJSON = new Button();
            buttonUsuarios = new Button();
            buttonProyectosPrivados = new Button();
            buttonInicio = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            controlProyectoPantalla21 = new ControlProyectoPantalla2();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTasky).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer1.Panel1.Controls.Add(pictureBoxTasky);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1424, 985);
            splitContainer1.SplitterDistance = 94;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBoxTasky
            // 
            pictureBoxTasky.Image = Properties.Resources.Group_50;
            pictureBoxTasky.Location = new Point(0, 0);
            pictureBoxTasky.Margin = new Padding(4, 3, 4, 3);
            pictureBoxTasky.Name = "pictureBoxTasky";
            pictureBoxTasky.Size = new Size(300, 94);
            pictureBoxTasky.TabIndex = 2;
            pictureBoxTasky.TabStop = false;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel1.Controls.Add(button7);
            splitContainer2.Panel1.Controls.Add(buttonExportarJSON);
            splitContainer2.Panel1.Controls.Add(buttonImportarJSON);
            splitContainer2.Panel1.Controls.Add(buttonUsuarios);
            splitContainer2.Panel1.Controls.Add(buttonProyectosPrivados);
            splitContainer2.Panel1.Controls.Add(buttonInicio);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Panel2.Controls.Add(label2);
            splitContainer2.Panel2.Controls.Add(label1);
            splitContainer2.Size = new Size(1424, 888);
            splitContainer2.SplitterDistance = 242;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new Point(21, 1091);
            button7.Name = "button7";
            button7.Size = new Size(200, 60);
            button7.TabIndex = 9;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // buttonExportarJSON
            // 
            buttonExportarJSON.BackColor = Color.FromArgb(79, 209, 197);
            buttonExportarJSON.FlatStyle = FlatStyle.Flat;
            buttonExportarJSON.ForeColor = Color.FromArgb(35, 78, 82);
            buttonExportarJSON.Location = new Point(21, 276);
            buttonExportarJSON.Name = "buttonExportarJSON";
            buttonExportarJSON.Size = new Size(200, 60);
            buttonExportarJSON.TabIndex = 7;
            buttonExportarJSON.Text = "ExportarJSON";
            buttonExportarJSON.UseVisualStyleBackColor = false;
            buttonExportarJSON.Click += buttonExportarJson_Click;
            // 
            // buttonImportarJSON
            // 
            buttonImportarJSON.BackColor = Color.FromArgb(79, 209, 197);
            buttonImportarJSON.FlatStyle = FlatStyle.Flat;
            buttonImportarJSON.ForeColor = Color.FromArgb(35, 78, 82);
            buttonImportarJSON.Location = new Point(21, 210);
            buttonImportarJSON.Name = "buttonImportarJSON";
            buttonImportarJSON.Size = new Size(200, 60);
            buttonImportarJSON.TabIndex = 10;
            buttonImportarJSON.Text = "Importar JSON";
            buttonImportarJSON.UseVisualStyleBackColor = false;
            // 
            // buttonUsuarios
            // 
            buttonUsuarios.BackColor = Color.FromArgb(79, 209, 197);
            buttonUsuarios.FlatStyle = FlatStyle.Flat;
            buttonUsuarios.ForeColor = Color.FromArgb(35, 78, 82);
            buttonUsuarios.Location = new Point(21, 144);
            buttonUsuarios.Name = "buttonUsuarios";
            buttonUsuarios.Size = new Size(200, 60);
            buttonUsuarios.TabIndex = 5;
            buttonUsuarios.Text = "Usuarios";
            buttonUsuarios.UseVisualStyleBackColor = false;
            buttonUsuarios.Click += buttonUsuarios_Click;
            // 
            // buttonProyectosPrivados
            // 
            buttonProyectosPrivados.BackColor = Color.FromArgb(79, 209, 197);
            buttonProyectosPrivados.FlatStyle = FlatStyle.Flat;
            buttonProyectosPrivados.ForeColor = Color.FromArgb(35, 78, 82);
            buttonProyectosPrivados.Location = new Point(21, 78);
            buttonProyectosPrivados.Name = "buttonProyectosPrivados";
            buttonProyectosPrivados.Size = new Size(200, 60);
            buttonProyectosPrivados.TabIndex = 4;
            buttonProyectosPrivados.Text = "Proyectos Privados";
            buttonProyectosPrivados.UseVisualStyleBackColor = false;
            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = Color.FromArgb(79, 209, 197);
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.ForeColor = Color.FromArgb(35, 78, 82);
            buttonInicio.Location = new Point(21, 12);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(200, 60);
            buttonInicio.TabIndex = 3;
            buttonInicio.Text = "Inicio";
            buttonInicio.UseVisualStyleBackColor = false;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(controlProyectoPantalla21);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, -1);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1178, 887);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // controlProyectoPantalla21
            // 
            controlProyectoPantalla21.BackColor = Color.White;
            controlProyectoPantalla21.BorderStyle = BorderStyle.FixedSingle;
            controlProyectoPantalla21.Imagen = null;
            controlProyectoPantalla21.Location = new Point(11, 13);
            controlProyectoPantalla21.Margin = new Padding();
            controlProyectoPantalla21.Name = "controlProyectoPantalla21";
            controlProyectoPantalla21.Proyecto = null;
            controlProyectoPantalla21.Size = new Size(369, 222);
            controlProyectoPantalla21.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(35, 78, 82);
            label2.Location = new Point(62, 128);
            label2.Name = "label2";
            label2.Size = new Size(121, 35);
            label2.TabIndex = 1;
            label2.Text = "Recientes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 78, 82);
            label1.Location = new Point(62, 41);
            label1.Name = "label1";
            label1.Size = new Size(158, 67);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            // 
            // Pantalla2
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1424, 985);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(1440, 1024);
            Name = "Pantalla2";
            Text = "Form1";
            Load += Pantalla2_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTasky).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button button7;
        private Button button6;
        private Button buttonImportarJSON;
        private Button buttonUsuarios;
        private Button buttonProyectosPrivados;
        private Button buttonInicio;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ControlProyectoPantalla2 controlProyectoPantalla21;
        private Button buttonExportarJSON;
        private PictureBox pictureBoxTasky;
    }
}
