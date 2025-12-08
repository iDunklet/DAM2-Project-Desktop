
namespace DAM2_Project_Desktop
{
    partial class Pantalla6
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
            splitContainer1 = new SplitContainer();
            pictureBoxLogo = new PictureBox();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonInicio = new Button();
            buttonUsuarios = new Button();
            buttonImportarJSON = new Button();
            buttonExportarJSON = new Button();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            listBoxUsuariosProyecto = new ListBox();
            label2 = new Label();
            label1 = new Label();
            listBoxUsuarios = new ListBox();
            buttonBorrar = new Button();
            buttonAgregar = new Button();
            buttonCrear = new Button();
            textBoxNombreUsuario = new TextBox();
            textBoxNombreProyecto = new TextBox();
            labelNombreUsuario = new Label();
            labelAgregarMiembros = new Label();
            linea = new Panel();
            labelFechaEntrega = new Label();
            labelNombreProyecto = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer1.Panel1.Controls.Add(pictureBoxLogo);
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
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Group_50;
            pictureBoxLogo.Location = new Point(3, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(321, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(3, 4, 3, 4);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel2.Controls.Add(dateTimePickerFechaNacimiento);
            splitContainer2.Panel2.Controls.Add(listBoxUsuariosProyecto);
            splitContainer2.Panel2.Controls.Add(label2);
            splitContainer2.Panel2.Controls.Add(label1);
            splitContainer2.Panel2.Controls.Add(listBoxUsuarios);
            splitContainer2.Panel2.Controls.Add(buttonBorrar);
            splitContainer2.Panel2.Controls.Add(buttonAgregar);
            splitContainer2.Panel2.Controls.Add(buttonCrear);
            splitContainer2.Panel2.Controls.Add(textBoxNombreUsuario);
            splitContainer2.Panel2.Controls.Add(textBoxNombreProyecto);
            splitContainer2.Panel2.Controls.Add(labelNombreUsuario);
            splitContainer2.Panel2.Controls.Add(labelAgregarMiembros);
            splitContainer2.Panel2.Controls.Add(linea);
            splitContainer2.Panel2.Controls.Add(labelFechaEntrega);
            splitContainer2.Panel2.Controls.Add(labelNombreProyecto);
            splitContainer2.Panel2.Paint += splitContainer2_Panel2_Paint;
            splitContainer2.Size = new Size(1424, 888);
            splitContainer2.SplitterDistance = 243;
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
            tableLayoutPanel1.Location = new Point(21, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(200, 260);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = Color.FromArgb(79, 209, 197);
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.ForeColor = Color.FromArgb(35, 78, 82);
            buttonInicio.Location = new Point(3, 3);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(194, 59);
            buttonInicio.TabIndex = 3;
            buttonInicio.Text = "Inicio";
            buttonInicio.UseVisualStyleBackColor = false;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // buttonUsuarios
            // 
            buttonUsuarios.BackColor = Color.FromArgb(79, 209, 197);
            buttonUsuarios.FlatStyle = FlatStyle.Flat;
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
            buttonExportarJSON.ForeColor = Color.FromArgb(35, 78, 82);
            buttonExportarJSON.Location = new Point(3, 198);
            buttonExportarJSON.Name = "buttonExportarJSON";
            buttonExportarJSON.Size = new Size(194, 59);
            buttonExportarJSON.TabIndex = 7;
            buttonExportarJSON.Text = "ExportarJSON";
            buttonExportarJSON.UseVisualStyleBackColor = false;
            buttonExportarJSON.Click += buttonExportarJSON_Click;
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.CalendarFont = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerFechaNacimiento.Location = new Point(743, 111);
            dateTimePickerFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(275, 27);
            dateTimePickerFechaNacimiento.TabIndex = 22;
            dateTimePickerFechaNacimiento.ValueChanged += dateTimePickerFechaNacimiento_ValueChanged;
            // 
            // listBoxUsuariosProyecto
            // 
            listBoxUsuariosProyecto.FormattingEnabled = true;
            listBoxUsuariosProyecto.Items.AddRange(new object[] { "", "", "" });
            listBoxUsuariosProyecto.Location = new Point(743, 394);
            listBoxUsuariosProyecto.Name = "listBoxUsuariosProyecto";
            listBoxUsuariosProyecto.Size = new Size(309, 144);
            listBoxUsuariosProyecto.TabIndex = 18;
            listBoxUsuariosProyecto.SelectedIndexChanged += listBoxUsuariosProyecto_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.FromArgb(35, 78, 82);
            label2.Location = new Point(743, 330);
            label2.Name = "label2";
            label2.Size = new Size(370, 46);
            label2.TabIndex = 17;
            label2.Text = "Miembros del proyecto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.FromArgb(35, 78, 82);
            label1.Location = new Point(118, 330);
            label1.Name = "label1";
            label1.Size = new Size(350, 46);
            label1.TabIndex = 16;
            label1.Text = "Miembros disponibles";
            // 
            // listBoxUsuarios
            // 
            listBoxUsuarios.FormattingEnabled = true;
            listBoxUsuarios.Items.AddRange(new object[] { "", "", "" });
            listBoxUsuarios.Location = new Point(118, 394);
            listBoxUsuarios.Name = "listBoxUsuarios";
            listBoxUsuarios.Size = new Size(309, 144);
            listBoxUsuarios.TabIndex = 15;
            listBoxUsuarios.SelectedIndexChanged += listBoxUsuarios_SelectedIndexChanged;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Font = new Font("Segoe UI", 18F);
            buttonBorrar.ForeColor = Color.FromArgb(35, 78, 82);
            buttonBorrar.Location = new Point(541, 687);
            buttonBorrar.Margin = new Padding(3, 4, 3, 4);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(119, 41);
            buttonBorrar.TabIndex = 14;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Font = new Font("Segoe UI", 18F);
            buttonAgregar.ForeColor = Color.FromArgb(35, 78, 82);
            buttonAgregar.Location = new Point(385, 687);
            buttonAgregar.Margin = new Padding(3, 4, 3, 4);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(119, 41);
            buttonAgregar.TabIndex = 12;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonCrear
            // 
            buttonCrear.Font = new Font("Segoe UI", 18F);
            buttonCrear.ForeColor = Color.FromArgb(35, 78, 82);
            buttonCrear.Location = new Point(463, 783);
            buttonCrear.Margin = new Padding(3, 4, 3, 4);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(229, 80);
            buttonCrear.TabIndex = 11;
            buttonCrear.Text = "CREAR";
            buttonCrear.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreUsuario
            // 
            textBoxNombreUsuario.BackColor = SystemColors.Control;
            textBoxNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombreUsuario.ForeColor = Color.FromArgb(35, 78, 82);
            textBoxNombreUsuario.Location = new Point(385, 615);
            textBoxNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            textBoxNombreUsuario.Size = new Size(275, 27);
            textBoxNombreUsuario.TabIndex = 10;
            textBoxNombreUsuario.TextChanged += textBoxNombreUsuario_TextChanged_1;
            // 
            // textBoxNombreProyecto
            // 
            textBoxNombreProyecto.BackColor = SystemColors.Control;
            textBoxNombreProyecto.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombreProyecto.ForeColor = Color.FromArgb(35, 78, 82);
            textBoxNombreProyecto.Location = new Point(118, 111);
            textBoxNombreProyecto.Margin = new Padding(3, 4, 3, 4);
            textBoxNombreProyecto.Name = "textBoxNombreProyecto";
            textBoxNombreProyecto.Size = new Size(275, 27);
            textBoxNombreProyecto.TabIndex = 8;
            textBoxNombreProyecto.TextChanged += textBoxNombreProyecto_TextChanged;
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.Font = new Font("Segoe UI", 20F);
            labelNombreUsuario.ForeColor = Color.FromArgb(35, 78, 82);
            labelNombreUsuario.Location = new Point(118, 601);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(309, 46);
            labelNombreUsuario.TabIndex = 5;
            labelNombreUsuario.Text = "Nombre de usuario";
            // 
            // labelAgregarMiembros
            // 
            labelAgregarMiembros.AutoSize = true;
            labelAgregarMiembros.Font = new Font("Segoe UI", 20F);
            labelAgregarMiembros.ForeColor = Color.FromArgb(35, 78, 82);
            labelAgregarMiembros.Location = new Point(118, 255);
            labelAgregarMiembros.Name = "labelAgregarMiembros";
            labelAgregarMiembros.Size = new Size(300, 46);
            labelAgregarMiembros.TabIndex = 4;
            labelAgregarMiembros.Text = "Agregar miembros";
            // 
            // linea
            // 
            linea.BackColor = Color.Black;
            linea.Location = new Point(0, 212);
            linea.Name = "linea";
            linea.Size = new Size(1178, 5);
            linea.TabIndex = 0;
            linea.Paint += linea_Paint;
            // 
            // labelFechaEntrega
            // 
            labelFechaEntrega.AutoSize = true;
            labelFechaEntrega.Font = new Font("Segoe UI", 20F);
            labelFechaEntrega.ForeColor = Color.FromArgb(35, 78, 82);
            labelFechaEntrega.Location = new Point(743, 68);
            labelFechaEntrega.Name = "labelFechaEntrega";
            labelFechaEntrega.Size = new Size(279, 46);
            labelFechaEntrega.TabIndex = 1;
            labelFechaEntrega.Text = "Fecha de entrega";
            // 
            // labelNombreProyecto
            // 
            labelNombreProyecto.AutoSize = true;
            labelNombreProyecto.Font = new Font("Segoe UI", 20F);
            labelNombreProyecto.ForeColor = Color.FromArgb(35, 78, 82);
            labelNombreProyecto.Location = new Point(118, 64);
            labelNombreProyecto.Name = "labelNombreProyecto";
            labelNombreProyecto.Size = new Size(342, 46);
            labelNombreProyecto.TabIndex = 0;
            labelNombreProyecto.Text = "Nombre del proyecto";
            // 
            // Pantalla6
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1424, 985);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1440, 1024);
            Name = "Pantalla6";
            Text = "Pantalla6";
            Load += Pantalla6_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
        }

        private void listBoxUsuariosProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBoxNombreUsuario_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBoxNombreProyecto_TextChanged(object sender, EventArgs e)
        {
        }

        private void linea_Paint(object sender, PaintEventArgs e)
        {
        }

        private void listBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label9;
        private PictureBox pictureBoxLogo;
        private Label labelFechaEntrega;
        private Label labelNombreProyecto;
        private Panel linea;
        private Label labelNombreUsuario;
        private Label labelAgregarMiembros;
        private TextBox textBoxNombreUsuario;
        private TextBox textBoxNombreProyecto;
        private Button buttonBorrar;
        private Button buttonAgregar;
        private Button buttonCrear;
        private Label label1;
        private ListBox listBoxUsuariosProyecto;
        private Label label2;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private ListBox listBoxUsuarios;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonInicio;
        private Button buttonUsuarios;
        private Button buttonImportarJSON;
        private Button buttonExportarJSON;
    }
}