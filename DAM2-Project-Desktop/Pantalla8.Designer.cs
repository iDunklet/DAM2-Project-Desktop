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
            splitContainer2 = new SplitContainer();
            button7 = new Button();
            buttonExportarJSON = new Button();
            buttonImportarJSON = new Button();
            buttonUsuarios = new Button();
            buttonProyectosPrivados = new Button();
            buttonInicio = new Button();
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
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
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
            splitContainer2.Panel2.Controls.Add(dataGridViewListadoUsuarios);
            splitContainer2.Size = new Size(1424, 889);
            splitContainer2.SplitterDistance = 242;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 0;
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
            // buttonExportarJSON
            // 
            buttonExportarJSON.BackColor = Color.FromArgb(79, 209, 197);
            buttonExportarJSON.FlatStyle = FlatStyle.Flat;
            buttonExportarJSON.ForeColor = Color.FromArgb(35, 78, 82);
            buttonExportarJSON.Location = new Point(21, 276);
            buttonExportarJSON.Name = "buttonExportarJSON";
            buttonExportarJSON.Size = new Size(200, 60);
            buttonExportarJSON.TabIndex = 7;
            buttonExportarJSON.Text = "Exportar JSON";
            buttonExportarJSON.UseVisualStyleBackColor = false;
            buttonExportarJSON.Click += buttonExportarJSON_Click;
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
            dataGridViewListadoUsuarios.Location = new Point(52, 119);
            dataGridViewListadoUsuarios.Name = "dataGridViewListadoUsuarios";
            dataGridViewListadoUsuarios.RowHeadersVisible = false;
            dataGridViewListadoUsuarios.RowHeadersWidth = 51;
            dataGridViewListadoUsuarios.ScrollBars = ScrollBars.None;
            dataGridViewListadoUsuarios.Size = new Size(1227, 810);
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
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1440, 1024);
            Name = "Pantalla8";
            Text = "Tasky";
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListadoUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button button7;
        private Button buttonExportarJSON;
        private Button buttonImportarJSON;
        private Button buttonUsuarios;
        private Button buttonProyectosPrivados;
        private Button buttonInicio;
        private DataGridView dataGridViewListadoUsuarios;
        private DataGridViewImageColumn ImgPerfil;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewImageColumn iconoEdit;
        private DataGridViewImageColumn IconoDelete;
    }
}