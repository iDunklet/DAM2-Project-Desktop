namespace DAM2_Project_Desktop
{
    partial class Pantalla8
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla8));
            splitContainer1 = new SplitContainer();
            buttonOut = new Button();
            pictureBoxTasky = new PictureBox();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonInicio = new Button();
            buttonUsuarios = new Button();
            buttonImportarJSON = new Button();
            buttonExportarJSON = new Button();
            buttonCrearUser = new Button();
            button7 = new Button();
            dataGridViewListadoUsuarios = new DataGridView();
            ImgPerfil = new DataGridViewImageColumn();
            Username = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Curso = new DataGridViewTextBoxColumn();
            iconoEdit = new DataGridViewImageColumn();
            IconoDelete = new DataGridViewImageColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewListadoUsuarios).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(buttonOut);
            splitContainer1.Panel1.Controls.Add(pictureBoxTasky);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1424, 985);
            splitContainer1.SplitterDistance = 93;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // buttonOut
            // 
            buttonOut.BackgroundImage = Properties.Resources._out;
            buttonOut.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOut.Dock = DockStyle.Right;
            buttonOut.FlatStyle = FlatStyle.Flat;
            buttonOut.ForeColor = Color.Transparent;
            buttonOut.Location = new Point(1328, 0);
            buttonOut.Name = "buttonOut";
            buttonOut.Size = new Size(94, 91);
            buttonOut.TabIndex = 3;
            buttonOut.UseVisualStyleBackColor = true;
            buttonOut.Click += buttonOut_Click;
            // 
            // pictureBoxTasky
            // 
            pictureBoxTasky.Image = Properties.Resources.Group_50;
            pictureBoxTasky.Location = new Point(-1, -1);
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
            splitContainer2.Margin = new Padding(3, 4, 3, 4);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer2.Panel1.Controls.Add(buttonCrearUser);
            splitContainer2.Panel1.Controls.Add(button7);
            splitContainer2.Panel1.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel2.Controls.Add(dataGridViewListadoUsuarios);
            splitContainer2.Size = new Size(1424, 889);
            splitContainer2.SplitterDistance = 242;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonInicio, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonUsuarios, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonImportarJSON, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonExportarJSON, 0, 3);
            tableLayoutPanel1.Location = new Point(21, 14);
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
            buttonInicio.Font = new Font("Montserrat Medium", 13.7999992F, FontStyle.Bold);
            buttonInicio.ForeColor = Color.FromArgb(35, 78, 82);
            buttonInicio.Location = new Point(3, 3);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(194, 59);
            buttonInicio.TabIndex = 3;
            buttonInicio.Text = "Proyectos";
            buttonInicio.UseVisualStyleBackColor = false;
            buttonInicio.Click += buttonInicio_Click_1;
            // 
            // buttonUsuarios
            // 
            buttonUsuarios.BackColor = Color.FromArgb(79, 209, 197);
            buttonUsuarios.FlatStyle = FlatStyle.Flat;
            buttonUsuarios.Font = new Font("Montserrat Medium", 13.7999992F, FontStyle.Bold);
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
            buttonImportarJSON.Font = new Font("Montserrat Medium", 13.7999992F, FontStyle.Bold);
            buttonImportarJSON.ForeColor = Color.FromArgb(35, 78, 82);
            buttonImportarJSON.Location = new Point(3, 133);
            buttonImportarJSON.Name = "buttonImportarJSON";
            buttonImportarJSON.Size = new Size(194, 59);
            buttonImportarJSON.TabIndex = 10;
            buttonImportarJSON.Text = "Importar JSON";
            buttonImportarJSON.UseVisualStyleBackColor = false;
            // 
            // buttonExportarJSON
            // 
            buttonExportarJSON.BackColor = Color.FromArgb(79, 209, 197);
            buttonExportarJSON.FlatStyle = FlatStyle.Flat;
            buttonExportarJSON.Font = new Font("Montserrat Medium", 13.7999992F, FontStyle.Bold);
            buttonExportarJSON.ForeColor = Color.FromArgb(35, 78, 82);
            buttonExportarJSON.Location = new Point(3, 198);
            buttonExportarJSON.Name = "buttonExportarJSON";
            buttonExportarJSON.Size = new Size(194, 59);
            buttonExportarJSON.TabIndex = 7;
            buttonExportarJSON.Text = "ExportarJSON";
            buttonExportarJSON.UseVisualStyleBackColor = false;
            // 
            // buttonCrearUser
            // 
            buttonCrearUser.BackColor = Color.FromArgb(35, 78, 82);
            buttonCrearUser.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonCrearUser.ForeColor = Color.White;
            buttonCrearUser.Location = new Point(21, 796);
            buttonCrearUser.Name = "buttonCrearUser";
            buttonCrearUser.Size = new Size(200, 68);
            buttonCrearUser.TabIndex = 11;
            buttonCrearUser.Text = "Nuevo Usuario";
            buttonCrearUser.UseVisualStyleBackColor = false;
            buttonCrearUser.Click += buttonCrearUser_Click;
            // 
            // button7
            // 
            button7.Location = new Point(24, 1072);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(229, 80);
            button7.TabIndex = 9;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListadoUsuarios
            // 
            dataGridViewListadoUsuarios.AllowUserToAddRows = false;
            dataGridViewListadoUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewListadoUsuarios.BackgroundColor = Color.FromArgb(247, 250, 252);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 78, 82);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(247, 250, 252);
            dataGridViewListadoUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewListadoUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListadoUsuarios.Columns.AddRange(new DataGridViewColumn[] { ImgPerfil, Username, Nombre, Apellidos, Email, Curso, iconoEdit, IconoDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(242, 222, 166);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewListadoUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewListadoUsuarios.Location = new Point(32, 27);
            dataGridViewListadoUsuarios.Name = "dataGridViewListadoUsuarios";
            dataGridViewListadoUsuarios.RowHeadersVisible = false;
            dataGridViewListadoUsuarios.RowHeadersWidth = 51;
            dataGridViewListadoUsuarios.ScrollBars = ScrollBars.None;
            dataGridViewListadoUsuarios.Size = new Size(1098, 810);
            dataGridViewListadoUsuarios.TabIndex = 0;
            dataGridViewListadoUsuarios.CellContentClick += dataGridView1_CellContentClick;
            dataGridViewListadoUsuarios.CellFormatting += dataGridViewListadoUsuarios_CellFormatting;
            // 
            // ImgPerfil
            // 
            ImgPerfil.DataPropertyName = "miniImgPerfil";
            ImgPerfil.HeaderText = "";
            ImgPerfil.MinimumWidth = 6;
            ImgPerfil.Name = "ImgPerfil";
            ImgPerfil.Resizable = DataGridViewTriState.True;
            ImgPerfil.SortMode = DataGridViewColumnSortMode.Automatic;
            ImgPerfil.Width = 30;
            // 
            // Username
            // 
            Username.DataPropertyName = "userName";
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.Width = 150;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 175;
            // 
            // Apellidos
            // 
            Apellidos.DataPropertyName = "apellidoCompleto";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            Apellidos.Width = 285;
            // 
            // Email
            // 
            Email.DataPropertyName = "email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 250;
            // 
            // Curso
            // 
            Curso.DataPropertyName = "classe";
            Curso.HeaderText = "Curso";
            Curso.MinimumWidth = 6;
            Curso.Name = "Curso";
            Curso.Width = 125;
            // 
            // iconoEdit
            // 
            iconoEdit.HeaderText = "";
            iconoEdit.MinimumWidth = 6;
            iconoEdit.Name = "iconoEdit";
            iconoEdit.Resizable = DataGridViewTriState.True;
            iconoEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            iconoEdit.Width = 40;
            // 
            // IconoDelete
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 111, 97);
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            IconoDelete.DefaultCellStyle = dataGridViewCellStyle2;
            IconoDelete.HeaderText = "";
            IconoDelete.MinimumWidth = 6;
            IconoDelete.Name = "IconoDelete";
            IconoDelete.Resizable = DataGridViewTriState.True;
            IconoDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            IconoDelete.Width = 40;
            // 
            // Pantalla8
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1424, 985);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1440, 1018);
            Name = "Pantalla8";
            Text = "Tasky";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTasky).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListadoUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button button7;
        private DataGridView dataGridViewListadoUsuarios;
        private DataGridViewImageColumn ImgPerfil;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewImageColumn iconoEdit;
        private DataGridViewImageColumn IconoDelete;
        private PictureBox pictureBoxTasky;
        private Button buttonCrearUser;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonInicio;
        private Button buttonUsuarios;
        private Button buttonImportarJSON;
        private Button buttonExportarJSON;
        private Button buttonOut;
    }
}