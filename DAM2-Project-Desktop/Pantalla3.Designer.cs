namespace DAM2_Project_Desktop
{
    partial class Pantalla3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla3));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            buttonOut = new Button();
            pictureBoxTasky = new PictureBox();
            splitContainer3 = new SplitContainer();
            splitContainer7 = new SplitContainer();
            labelId = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonCrearNuevoUsuario = new Button();
            splitContainer4 = new SplitContainer();
            splitContainer5 = new SplitContainer();
            labelNombreProyecto = new Label();
            labelFechaProyecto = new Label();
            flowPanelMiembros = new FlowLayoutPanel();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            splitContainer6 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Responsable = new DataGridViewComboBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            FechaFin = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewComboBoxColumn();
            Horas = new DataGridViewTextBoxColumn();
            colCheck = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTasky).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer6);
            splitContainer1.Size = new Size(1424, 985);
            splitContainer1.SplitterDistance = 243;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4, 3, 4, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel1.Controls.Add(buttonOut);
            splitContainer2.Panel1.Controls.Add(pictureBoxTasky);
            splitContainer2.Panel1.ForeColor = SystemColors.MenuText;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(1424, 243);
            splitContainer2.SplitterDistance = 93;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 0;
            // 
            // buttonOut
            // 
            buttonOut.BackgroundImage = (Image)resources.GetObject("buttonOut.BackgroundImage");
            buttonOut.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOut.Dock = DockStyle.Right;
            buttonOut.FlatStyle = FlatStyle.Flat;
            buttonOut.ForeColor = Color.Transparent;
            buttonOut.Location = new Point(1330, 0);
            buttonOut.Name = "buttonOut";
            buttonOut.Size = new Size(94, 93);
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
            // splitContainer3
            // 
            splitContainer3.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(4, 3, 4, 3);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer3.Panel1.Controls.Add(splitContainer7);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new Size(1424, 148);
            splitContainer3.SplitterDistance = 242;
            splitContainer3.SplitterWidth = 2;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer7
            // 
            splitContainer7.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer7.Dock = DockStyle.Fill;
            splitContainer7.Location = new Point(0, 0);
            splitContainer7.Margin = new Padding(4, 3, 4, 3);
            splitContainer7.Name = "splitContainer7";
            splitContainer7.Orientation = Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer7.Panel1.Controls.Add(labelId);
            splitContainer7.Panel1.Controls.Add(label1);
            // 
            // splitContainer7.Panel2
            // 
            splitContainer7.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer7.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer7.Size = new Size(242, 148);
            splitContainer7.SplitterDistance = 51;
            splitContainer7.SplitterWidth = 1;
            splitContainer7.TabIndex = 0;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 20F);
            labelId.Location = new Point(69, 7);
            labelId.Name = "labelId";
            labelId.Size = new Size(92, 37);
            labelId.TabIndex = 1;
            labelId.Text = "00000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.Location = new Point(8, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 31);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(buttonCrearNuevoUsuario, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(242, 96);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonCrearNuevoUsuario
            // 
            buttonCrearNuevoUsuario.BackColor = Color.FromArgb(79, 209, 197);
            buttonCrearNuevoUsuario.Dock = DockStyle.Fill;
            buttonCrearNuevoUsuario.FlatStyle = FlatStyle.Flat;
            buttonCrearNuevoUsuario.Font = new Font("Microsoft Sans Serif", 15F);
            buttonCrearNuevoUsuario.ForeColor = Color.FromArgb(35, 78, 82);
            buttonCrearNuevoUsuario.Location = new Point(15, 15);
            buttonCrearNuevoUsuario.Margin = new Padding(15);
            buttonCrearNuevoUsuario.Name = "buttonCrearNuevoUsuario";
            buttonCrearNuevoUsuario.Size = new Size(212, 66);
            buttonCrearNuevoUsuario.TabIndex = 4;
            buttonCrearNuevoUsuario.Text = "Crear nuevo usuario";
            buttonCrearNuevoUsuario.UseVisualStyleBackColor = false;
            buttonCrearNuevoUsuario.Click += buttonCrearNuevoUsuario_Click;
            // 
            // splitContainer4
            // 
            splitContainer4.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Margin = new Padding(4, 3, 4, 3);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer4.Panel1.Controls.Add(splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer4.Panel2.Controls.Add(flowPanelMiembros);
            splitContainer4.Panel2.Controls.Add(label6);
            splitContainer4.Panel2.Controls.Add(pictureBox4);
            splitContainer4.Size = new Size(1180, 148);
            splitContainer4.SplitterDistance = 51;
            splitContainer4.SplitterWidth = 2;
            splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            splitContainer5.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Margin = new Padding(4, 3, 4, 3);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer5.Panel1.Controls.Add(labelNombreProyecto);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer5.Panel2.Controls.Add(labelFechaProyecto);
            splitContainer5.Size = new Size(1180, 51);
            splitContainer5.SplitterDistance = 868;
            splitContainer5.SplitterWidth = 2;
            splitContainer5.TabIndex = 0;
            // 
            // labelNombreProyecto
            // 
            labelNombreProyecto.AutoSize = true;
            labelNombreProyecto.Font = new Font("Segoe UI", 20F);
            labelNombreProyecto.Location = new Point(23, 7);
            labelNombreProyecto.Name = "labelNombreProyecto";
            labelNombreProyecto.Size = new Size(226, 37);
            labelNombreProyecto.TabIndex = 0;
            labelNombreProyecto.Text = "Nombre Proyecto";
            // 
            // labelFechaProyecto
            // 
            labelFechaProyecto.AutoSize = true;
            labelFechaProyecto.Font = new Font("Segoe UI", 20F);
            labelFechaProyecto.Location = new Point(11, 7);
            labelFechaProyecto.Name = "labelFechaProyecto";
            labelFechaProyecto.Size = new Size(85, 37);
            labelFechaProyecto.TabIndex = 0;
            labelFechaProyecto.Text = "Fecha";
            // 
            // flowPanelMiembros
            // 
            flowPanelMiembros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelMiembros.Location = new Point(135, 8);
            flowPanelMiembros.Name = "flowPanelMiembros";
            flowPanelMiembros.Padding = new Padding(0, 0, 10, 0);
            flowPanelMiembros.Size = new Size(1033, 80);
            flowPanelMiembros.TabIndex = 8;
            flowPanelMiembros.WrapContents = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.Location = new Point(34, 67);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 7;
            label6.Text = "Agregar";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.mas2;
            pictureBox4.Location = new Point(34, 8);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // splitContainer6
            // 
            splitContainer6.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.Location = new Point(0, 0);
            splitContainer6.Margin = new Padding(4, 3, 4, 3);
            splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer6.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(dataGridView1);
            splitContainer6.Panel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            splitContainer6.Size = new Size(1424, 738);
            splitContainer6.SplitterDistance = 242;
            splitContainer6.SplitterWidth = 2;
            splitContainer6.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button4, 0, 4);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 0, 2);
            tableLayoutPanel1.Controls.Add(button3, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.98102975F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1626015F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.620596F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.807588F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0271006F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.94309F));
            tableLayoutPanel1.Size = new Size(242, 738);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(79, 209, 197);
            button4.Dock = DockStyle.Fill;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 15F);
            button4.ForeColor = Color.FromArgb(35, 78, 82);
            button4.Location = new Point(15, 233);
            button4.Margin = new Padding(15, 4, 15, 4);
            button4.Name = "button4";
            button4.Size = new Size(212, 65);
            button4.TabIndex = 3;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(79, 209, 197);
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15F);
            button1.ForeColor = Color.FromArgb(35, 78, 82);
            button1.Location = new Point(15, 25);
            button1.Margin = new Padding(15, 4, 15, 4);
            button1.Name = "button1";
            button1.Size = new Size(212, 66);
            button1.TabIndex = 0;
            button1.Text = "Crear nueva tarea";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(79, 209, 197);
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 15F);
            button2.ForeColor = Color.FromArgb(35, 78, 82);
            button2.Location = new Point(15, 99);
            button2.Margin = new Padding(15, 4, 15, 4);
            button2.Name = "button2";
            button2.Size = new Size(212, 62);
            button2.TabIndex = 1;
            button2.Text = "Cuadricula";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(79, 209, 197);
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 15F);
            button3.ForeColor = Color.FromArgb(35, 78, 82);
            button3.Location = new Point(15, 169);
            button3.Margin = new Padding(15, 4, 15, 4);
            button3.Name = "button3";
            button3.Size = new Size(212, 56);
            button3.TabIndex = 2;
            button3.Text = "Diagrama";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Descripcion, Responsable, FechaInicio, FechaFin, Estado, Horas, colCheck });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1180, 738);
            dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Resizable = DataGridViewTriState.True;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            // 
            // Responsable
            // 
            Responsable.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Responsable.HeaderText = "Asignar";
            Responsable.MinimumWidth = 6;
            Responsable.Name = "Responsable";
            Responsable.Resizable = DataGridViewTriState.True;
            Responsable.SortMode = DataGridViewColumnSortMode.Automatic;
            Responsable.Width = 88;
            // 
            // FechaInicio
            // 
            FechaInicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            FechaInicio.HeaderText = "Fecha inicio";
            FechaInicio.MinimumWidth = 6;
            FechaInicio.Name = "FechaInicio";
            FechaInicio.Width = 118;
            // 
            // FechaFin
            // 
            FechaFin.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            FechaFin.HeaderText = "Fecha final";
            FechaFin.MinimumWidth = 6;
            FechaFin.Name = "FechaFin";
            FechaFin.Width = 112;
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Estado.HeaderText = "Estado de la tarea";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Resizable = DataGridViewTriState.True;
            Estado.SortMode = DataGridViewColumnSortMode.Automatic;
            Estado.Width = 164;
            // 
            // Horas
            // 
            Horas.HeaderText = "Horas";
            Horas.MinimumWidth = 6;
            Horas.Name = "Horas";
            Horas.Width = 125;
            // 
            // colCheck
            // 
            colCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCheck.HeaderText = "Check";
            colCheck.MinimumWidth = 6;
            colCheck.Name = "colCheck";
            colCheck.Resizable = DataGridViewTriState.True;
            colCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            colCheck.Width = 79;
            // 
            // Pantalla3
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1424, 985);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1440, 1018);
            Name = "Pantalla3";
            Text = "Pantalla3";
            Load += Pantalla3_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTasky).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel1.PerformLayout();
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            splitContainer5.Panel2.ResumeLayout(false);
            splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCrearNuevoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxTasky;
        private FlowLayoutPanel flowPanelMiembros;
        private Label labelNombreProyecto;
        private Label labelFechaProyecto;
        private Label labelId;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewComboBoxColumn Responsable;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewComboBoxColumn Estado;
        private DataGridViewTextBoxColumn Horas;
        private DataGridViewCheckBoxColumn colCheck;
        private Button buttonOut;
    }
}