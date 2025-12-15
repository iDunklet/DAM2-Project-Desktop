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
            button1 = new Button();
            pictureBoxTasky = new PictureBox();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonInicio = new Button();
            buttonUsuarios = new Button();
            buttonImportarJSON = new Button();
            buttonExportarJSON = new Button();
            buttonCrearProyecto = new Button();
            button7 = new Button();
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
            tableLayoutPanel1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(button1);
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
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            button1.Location = new Point(1335, 0);
            button1.Name = "button1";
            button1.Size = new Size(87, 92);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonOut_Click;
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
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer2.Panel1.Controls.Add(buttonCrearProyecto);
            splitContainer2.Panel1.Controls.Add(button7);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonInicio, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonUsuarios, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonImportarJSON, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonExportarJSON, 0, 3);
            tableLayoutPanel1.Location = new Point(21, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(200, 260);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = Color.FromArgb(79, 209, 197);
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            buttonInicio.ForeColor = Color.FromArgb(35, 78, 82);
            buttonInicio.Location = new Point(3, 3);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(194, 59);
            buttonInicio.TabIndex = 3;
            buttonInicio.Text = "Proyectos";
            buttonInicio.UseVisualStyleBackColor = false;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // buttonUsuarios
            // 
            buttonUsuarios.BackColor = Color.FromArgb(79, 209, 197);
            buttonUsuarios.FlatStyle = FlatStyle.Flat;
            buttonUsuarios.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            buttonUsuarios.ForeColor = Color.FromArgb(35, 78, 82);
            buttonUsuarios.Location = new Point(3, 68);
            buttonUsuarios.Name = "buttonUsuarios";
            buttonUsuarios.Size = new Size(194, 59);
            buttonUsuarios.TabIndex = 5;
            buttonUsuarios.Text = "Usuarios";
            buttonUsuarios.UseVisualStyleBackColor = false;
            buttonUsuarios.Click += buttonUsuarios_Click;
            // 
            // buttonImportarJSON
            // 
            buttonImportarJSON.BackColor = Color.FromArgb(79, 209, 197);
            buttonImportarJSON.FlatStyle = FlatStyle.Flat;
            buttonImportarJSON.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            buttonImportarJSON.ForeColor = Color.FromArgb(35, 78, 82);
            buttonImportarJSON.Location = new Point(3, 133);
            buttonImportarJSON.Name = "buttonImportarJSON";
            buttonImportarJSON.Size = new Size(194, 59);
            buttonImportarJSON.TabIndex = 10;
            buttonImportarJSON.Text = "Importar JSON";
            buttonImportarJSON.UseVisualStyleBackColor = false;
            buttonImportarJSON.Click += buttonImportarJSON_Click;
            // 
            // buttonExportarJSON
            // 
            buttonExportarJSON.BackColor = Color.FromArgb(79, 209, 197);
            buttonExportarJSON.FlatStyle = FlatStyle.Flat;
            buttonExportarJSON.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            buttonExportarJSON.ForeColor = Color.FromArgb(35, 78, 82);
            buttonExportarJSON.Location = new Point(3, 198);
            buttonExportarJSON.Name = "buttonExportarJSON";
            buttonExportarJSON.Size = new Size(194, 59);
            buttonExportarJSON.TabIndex = 7;
            buttonExportarJSON.Text = "ExportarJSON";
            buttonExportarJSON.UseVisualStyleBackColor = false;
            buttonExportarJSON.Click += buttonExportarJson_Click;
            // 
            // buttonCrearProyecto
            // 
            buttonCrearProyecto.BackColor = Color.FromArgb(35, 78, 82);
            buttonCrearProyecto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCrearProyecto.ForeColor = Color.White;
            buttonCrearProyecto.Location = new Point(0, 818);
            buttonCrearProyecto.Name = "buttonCrearProyecto";
            buttonCrearProyecto.Size = new Size(240, 68);
            buttonCrearProyecto.TabIndex = 11;
            buttonCrearProyecto.Text = "Nuevo Proyecto";
            buttonCrearProyecto.UseVisualStyleBackColor = false;
            buttonCrearProyecto.Click += buttonCrearProyecto_Click;
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
            controlProyectoPantalla21.Anchor = AnchorStyles.Left;
            controlProyectoPantalla21.BackColor = Color.White;
            controlProyectoPantalla21.BorderStyle = BorderStyle.FixedSingle;
            controlProyectoPantalla21.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlProyectoPantalla21.Imagen = null;
            controlProyectoPantalla21.Location = new Point(0, 0);
            controlProyectoPantalla21.Margin = new Padding(0);
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
            label2.Size = new Size(96, 28);
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
            label1.Size = new Size(125, 54);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            // 
            // Pantalla2
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1424, 985);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1440, 1018);
            Name = "Pantalla2";
            Text = "Tasky";
            Load += Pantalla2_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTasky).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
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
        private Button buttonInicio;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ControlProyectoPantalla2 controlProyectoPantalla21;
        private Button buttonExportarJSON;
        private PictureBox pictureBoxTasky;
        private Button buttonCrearProyecto;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
    }
}