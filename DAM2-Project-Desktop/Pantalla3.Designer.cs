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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            splitContainer3 = new SplitContainer();
            splitContainer7 = new SplitContainer();
            label1 = new Label();
            button5 = new Button();
            splitContainer4 = new SplitContainer();
            splitContainer5 = new SplitContainer();
            labelNombreProyecto = new Label();
            labelFechaProyecto = new Label();
            flowPanelMiembros = new FlowLayoutPanel();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            splitContainer6 = new SplitContainer();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewComboBoxColumn();
            FechaInicioColumn = new DataGridViewTextBoxColumn();
            FechaFinalColumn = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewComboBoxColumn();
            colCheck = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
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
            splitContainer1.SplitterDistance = 379;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4, 3, 4, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel1.Controls.Add(pictureBox6);
            splitContainer2.Panel1.Controls.Add(pictureBox7);
            splitContainer2.Panel1.Controls.Add(pictureBox5);
            splitContainer2.Panel1.ForeColor = SystemColors.MenuText;
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(1424, 379);
            splitContainer2.SplitterDistance = 125;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.person;
            pictureBox6.Location = new Point(1338, 30);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(63, 59);
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.menu;
            pictureBox7.Location = new Point(12, 25);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(64, 64);
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(99, 11);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(291, 88);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // splitContainer3
            // 
            splitContainer3.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer3.BorderStyle = BorderStyle.FixedSingle;
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
            splitContainer3.Size = new Size(1424, 252);
            splitContainer3.SplitterDistance = 266;
            splitContainer3.SplitterWidth = 2;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer7
            // 
            splitContainer7.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer7.BorderStyle = BorderStyle.FixedSingle;
            splitContainer7.Dock = DockStyle.Fill;
            splitContainer7.Location = new Point(0, 0);
            splitContainer7.Margin = new Padding(4, 3, 4, 3);
            splitContainer7.Name = "splitContainer7";
            splitContainer7.Orientation = Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer7.Panel1.Controls.Add(label1);
            splitContainer7.Panel1.Paint += splitContainer7_Panel1_Paint;
            // 
            // splitContainer7.Panel2
            // 
            splitContainer7.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer7.Panel2.Controls.Add(button5);
            splitContainer7.Size = new Size(266, 252);
            splitContainer7.SplitterDistance = 82;
            splitContainer7.SplitterWidth = 2;
            splitContainer7.TabIndex = 0;
            splitContainer7.SplitterMoved += splitContainer7_SplitterMoved;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.Location = new Point(35, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 31);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(79, 209, 197);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 14F);
            button5.ForeColor = Color.FromArgb(35, 78, 82);
            button5.Location = new Point(35, 35);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(175, 63);
            button5.TabIndex = 4;
            button5.Text = "Crear nuevo usuario";
            button5.UseVisualStyleBackColor = false;
            // 
            // splitContainer4
            // 
            splitContainer4.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer4.BorderStyle = BorderStyle.FixedSingle;
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
            splitContainer4.Panel2.Paint += splitContainer4_Panel2_Paint;
            splitContainer4.Size = new Size(1156, 252);
            splitContainer4.SplitterDistance = 82;
            splitContainer4.SplitterWidth = 2;
            splitContainer4.TabIndex = 0;
            splitContainer4.SplitterMoved += splitContainer4_SplitterMoved;
            // 
            // splitContainer5
            // 
            splitContainer5.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer5.BorderStyle = BorderStyle.FixedSingle;
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Margin = new Padding(4, 3, 4, 3);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer5.Panel1.Controls.Add(labelNombreProyecto);
            splitContainer5.Panel1.Paint += splitContainer5_Panel1_Paint;
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer5.Panel2.Controls.Add(labelFechaProyecto);
            splitContainer5.Panel2.Paint += splitContainer5_Panel2_Paint;
            splitContainer5.Size = new Size(1156, 82);
            splitContainer5.SplitterDistance = 847;
            splitContainer5.SplitterWidth = 2;
            splitContainer5.TabIndex = 0;
            // 
            // labelNombreProyecto
            // 
            labelNombreProyecto.AutoSize = true;
            labelNombreProyecto.Location = new Point(45, 32);
            labelNombreProyecto.Name = "labelNombreProyecto";
            labelNombreProyecto.Size = new Size(38, 15);
            labelNombreProyecto.TabIndex = 0;
            labelNombreProyecto.Text = "label2";
            // 
            // labelFechaProyecto
            // 
            labelFechaProyecto.AutoSize = true;
            labelFechaProyecto.Location = new Point(31, 41);
            labelFechaProyecto.Name = "labelFechaProyecto";
            labelFechaProyecto.Size = new Size(38, 15);
            labelFechaProyecto.TabIndex = 0;
            labelFechaProyecto.Text = "label2";
            // 
            // flowPanelMiembros
            // 
            flowPanelMiembros.AutoScroll = true;
            flowPanelMiembros.Location = new Point(135, 10);
            flowPanelMiembros.Name = "flowPanelMiembros";
            flowPanelMiembros.Padding = new Padding(10);
            flowPanelMiembros.Size = new Size(1008, 145);
            flowPanelMiembros.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(40, 121);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 7;
            label6.Text = "Agregar";
            label6.Click += label6_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(40, 54);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // splitContainer6
            // 
            splitContainer6.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer6.BorderStyle = BorderStyle.FixedSingle;
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.Location = new Point(0, 0);
            splitContainer6.Margin = new Padding(4, 3, 4, 3);
            splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer6.Panel1.Controls.Add(button4);
            splitContainer6.Panel1.Controls.Add(button3);
            splitContainer6.Panel1.Controls.Add(button2);
            splitContainer6.Panel1.Controls.Add(button1);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(dataGridView1);
            splitContainer6.Panel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            splitContainer6.Panel2.Paint += splitContainer6_Panel2_Paint;
            splitContainer6.Size = new Size(1424, 604);
            splitContainer6.SplitterDistance = 266;
            splitContainer6.SplitterWidth = 2;
            splitContainer6.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(79, 209, 197);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 14F);
            button4.ForeColor = Color.FromArgb(35, 78, 82);
            button4.Location = new Point(35, 201);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(175, 45);
            button4.TabIndex = 3;
            button4.Text = "Exportar";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(79, 209, 197);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 14F);
            button3.ForeColor = Color.FromArgb(35, 78, 82);
            button3.Location = new Point(35, 139);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(175, 45);
            button3.TabIndex = 2;
            button3.Text = "Diagrama";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(79, 209, 197);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14F);
            button2.ForeColor = Color.FromArgb(35, 78, 82);
            button2.Location = new Point(35, 79);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(175, 45);
            button2.TabIndex = 1;
            button2.Text = "Cuadricula";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(79, 209, 197);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14F);
            button1.ForeColor = Color.FromArgb(35, 78, 82);
            button1.Location = new Point(35, 18);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(175, 45);
            button1.TabIndex = 0;
            button1.Text = "Crear nueva tarea";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column7, Column2, FechaInicioColumn, FechaFinalColumn, Column5, colCheck });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1154, 602);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 164;
            // 
            // Column7
            // 
            Column7.HeaderText = "Descripcion";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 164;
            // 
            // Column2
            // 
            Column2.HeaderText = "Asignar";
            Column2.Items.AddRange(new object[] { "Juan", "Marta", "Carlos" });
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.Automatic;
            Column2.Width = 164;
            // 
            // FechaInicioColumn
            // 
            FechaInicioColumn.HeaderText = "Fecha inicio";
            FechaInicioColumn.MinimumWidth = 6;
            FechaInicioColumn.Name = "FechaInicioColumn";
            FechaInicioColumn.Width = 164;
            // 
            // FechaFinalColumn
            // 
            FechaFinalColumn.HeaderText = "Fecha final";
            FechaFinalColumn.MinimumWidth = 6;
            FechaFinalColumn.Name = "FechaFinalColumn";
            FechaFinalColumn.Width = 164;
            // 
            // Column5
            // 
            Column5.HeaderText = "Estado de la tarea";
            Column5.Items.AddRange(new object[] { "In progress", "Done", "In review", "Blocked", "To do" });
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.Width = 164;
            // 
            // colCheck
            // 
            colCheck.HeaderText = "Check";
            colCheck.MinimumWidth = 6;
            colCheck.Name = "colCheck";
            colCheck.Resizable = DataGridViewTriState.True;
            colCheck.SortMode = DataGridViewColumnSortMode.Automatic;
            colCheck.Width = 164;
            // 
            // Pantalla3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 985);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1440, 1024);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel1.PerformLayout();
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewComboBoxColumn Column2;
        private DataGridViewTextBoxColumn FechaInicioColumn;
        private DataGridViewTextBoxColumn FechaFinalColumn;
        private DataGridViewComboBoxColumn Column5;
        private DataGridViewCheckBoxColumn colCheck;
        private FlowLayoutPanel flowPanelMiembros;
        private Label labelNombreProyecto;
        private Label labelFechaProyecto;
    }
}

