using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla3 : Form
    {
        private ComboBox comboUsuariosDAM2;
        private Proyecto proyectoActual;
        //private ComboBox comboProyectos;

        public Pantalla3(Proyecto project)
        {


            InitializeComponent();
            //dataGridView1_CellContentClick();
            dataGridView1.CellClick += dataGridView1_CellClick;
            proyectoActual = project;
            CargarInfoProyecto();
            CargarUsuariosProyecto();
            CargarTareasProyecto();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita errores si se hace clic en el encabezado
            try
            {
                if (e.RowIndex < 0) return;

                // Comprueba en qué columna se ha hecho clic (usa los nombres que pusiste en el diseñador)
                string nombreColumna = dataGridView1.Columns[e.ColumnIndex].Name;

                if (nombreColumna == "FechaInicioColumn" || nombreColumna == "FechaFinalColumn")
                {
                    ShowDatePicker(e.RowIndex, e.ColumnIndex);
                }
            }
            catch { }
        }

        private void ShowDatePicker(int rowIndex, int columnIndex)
        {
            var fila = dataGridView1.Rows[rowIndex];
            var tareaActual = (Tarea)fila.Tag;

            DateTime? fechaActual = (columnIndex == 3)
                ? tareaActual.fechaInicioTarea
                : tareaActual.fechaFinTarea;

            DateTimePicker dtp = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy",
                Value = fechaActual ?? DateTime.Now,
                Visible = true
            };

            Rectangle cellRectangle = dataGridView1.GetCellDisplayRectangle(columnIndex, rowIndex, true);
            dtp.Location = new Point(cellRectangle.X, cellRectangle.Y);
            dtp.Size = new Size(cellRectangle.Width, cellRectangle.Height);

            dataGridView1.Controls.Add(dtp);

            dtp.CloseUp += (s, e) =>
            {
                // Actualizar la celda y la tarea
                fila.Cells[columnIndex].Value = dtp.Value.ToShortDateString();
                if (columnIndex == 3)
                    tareaActual.fechaInicioTarea = dtp.Value;
                else
                    tareaActual.fechaFinTarea = dtp.Value;

                dataGridView1.Controls.Remove(dtp);
            };
        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pantalla3_Load(object sender, EventArgs e)
        {
            Proyecto proyecto = ListadoDatosClasses.ListadoProyectos[0]; // <-- viene de la clase estática
            //MostrarProyecto();
            dataGridView1.CellBeginEdit += DataGridView1_CellBeginEdit;
        }
        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Solo para columnas de fecha
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                e.Cancel = true; // Evita edición directa
                ShowDatePicker(e.RowIndex, e.ColumnIndex);
            }
        }

        private void splitContainer6_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer7_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer5_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxColumn colOpciones = new DataGridViewComboBoxColumn();
            colOpciones.HeaderText = "Opciones";
            colOpciones.Items.AddRange("Opción 1", "Opción 2", "Opción 3");
            dataGridView1.Columns.Add(colOpciones);

            DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();
            colCheck.HeaderText = "Activo";
            dataGridView1.Columns.Add(colCheck);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer4_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer7_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Si ya existe un combo, lo eliminamos
            if (comboUsuariosDAM2 != null)
            {
                splitContainer4.Panel2.Controls.Remove(comboUsuariosDAM2);
                comboUsuariosDAM2.Dispose();
                comboUsuariosDAM2 = null;
            }

            comboUsuariosDAM2 = new ComboBox();
            comboUsuariosDAM2.DropDownStyle = ComboBoxStyle.DropDownList;

            var usuariosDAM2 = ListadoDatosClasses.ListadoUsuarios
                .Where(u => u.classe == "DAM2")
                .ToList();

            comboUsuariosDAM2.DataSource = usuariosDAM2;
            comboUsuariosDAM2.DisplayMember = "nombre";

            // 💥 Importante: añadir el combo en el mismo contenedor que el PictureBox
            splitContainer4.Panel2.Controls.Add(comboUsuariosDAM2);

            // 🟩 Colocarlo al lado del pictureBox4, en coordenadas del mismo Panel
            comboUsuariosDAM2.Location = new Point(
                splitContainer4.Panel2.Left,
                pictureBox4.Top - 12
            );

            comboUsuariosDAM2.Width = 160;
            comboUsuariosDAM2.BringToFront();

            comboUsuariosDAM2.SelectedIndexChanged += (s, ev) =>
            {
                var u = (Usuario)comboUsuariosDAM2.SelectedItem;
                AgregarUsuarioAlPanel(u);

                splitContainer4.Panel2.Controls.Remove(comboUsuariosDAM2);
                comboUsuariosDAM2.Dispose();
                comboUsuariosDAM2 = null;
            };
        }

        private void AgregarUsuarioAlPanel(Usuario usuario)
        {
            // Crear contenedor visual para cada usuario
            Panel panelUsuario = new Panel();
            panelUsuario.Width = 90;
            panelUsuario.Height = 120;
            panelUsuario.Margin = new Padding(0, 0, 10, 0);

            // Imagen (usamos la mini o la grande)
            PictureBox pic = new PictureBox();
            pic.Image = usuario.imgPerfil; // O miniImgPerfil si prefieres pequeño
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Width = 55;
            pic.Height = 55;
            pic.Location = new Point((panelUsuario.Width - pic.Width) / 2, 0);

            // Nombre debajo de la imagen
            Label lbl = new Label();
            lbl.Text = usuario.nombre;
            lbl.Font = new Font("Microsoft Sans Serif", 10F);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.AutoSize = false;
            lbl.Width = 80;
            lbl.Height = 20;
            lbl.Location = new Point((panelUsuario.Width - lbl.Width) / 2, pic.Height + 3);

            // Agregar al panel
            panelUsuario.Controls.Add(pic);
            panelUsuario.Controls.Add(lbl);

            // Agregar al FlowLayoutPanel del formulario
            flowPanelMiembros.Controls.Add(panelUsuario);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer5_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarInfoProyecto()
        {
            if (proyectoActual == null) return;

            // Suponiendo que tienes Labels dentro de cada SplitContainer:
            labelId.Text = proyectoActual.ID.ToString(); // Id del proyecto
            labelNombreProyecto.Text = proyectoActual.titulo; // Nombre
            labelFechaProyecto.Text = proyectoActual.fechaEntrega.ToString("dd/MM/yyyy"); // Fecha

            // Centrar texto (opcional)
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            labelNombreProyecto.TextAlign = ContentAlignment.MiddleCenter;
            labelFechaProyecto.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void CargarUsuariosProyecto()
        {
            flowPanelMiembros.Controls.Clear(); // Limpiamos antes de cargar

            foreach (var usuario in proyectoActual.miembrosProyecto)
            {
                // Creamos un panel individual para cada usuario
                Panel panelUsuario = new Panel();
                panelUsuario.Width = 90;
                panelUsuario.Height = 120;
                panelUsuario.Margin = new Padding(0, 0, 10, 0);

                // PictureBox con la imagen del usuario
                PictureBox pic = new PictureBox();
                pic.Image = usuario.imgPerfil; // Usamos la imagen generada
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Width = 55;
                pic.Height = 55;
                pic.Location = new Point((panelUsuario.Width - pic.Width) / 2, 0);

                // Label con el nombre del usuario
                Label lbl = new Label();
                lbl.Text = usuario.nombre;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.AutoSize = false;
                lbl.Width = 80;
                lbl.Height = 20;
                lbl.Location = new Point((panelUsuario.Width - lbl.Width) / 2, pic.Height + 3);

                // Añadimos PictureBox y Label al panel del usuario
                panelUsuario.Controls.Add(pic);
                panelUsuario.Controls.Add(lbl);

                // Añadimos el panel al FlowLayoutPanel de miembros
                flowPanelMiembros.Controls.Add(panelUsuario);
            }
        }

        private void CargarTareasProyecto()
        {
            dataGridView1.Rows.Clear();

            foreach (var tarea in proyectoActual.tareasProyecto)
            {
                int rowIndex = dataGridView1.Rows.Add();
                var fila = dataGridView1.Rows[rowIndex];

                // Guardamos la tarea en Tag
                fila.Tag = tarea;

                // Nombre
                fila.Cells[0].Value = tarea.nombreTarea;
                // Descripción
                fila.Cells[1].Value = tarea.descripcionTarea;

                // ComboBox responsables
                var comboCell = (DataGridViewComboBoxCell)fila.Cells[2];
                comboCell.Items.Clear();
                foreach (var usuario in proyectoActual.miembrosProyecto)
                {
                    comboCell.Items.Add(usuario.nombre);
                }
                if (tarea.responsableAsignado != null && !comboCell.Items.Contains(tarea.responsableAsignado.nombre))
                    comboCell.Items.Add(tarea.responsableAsignado.nombre);
                comboCell.Value = tarea.responsableAsignado?.nombre;

                // Fechas (solo mostrar)
                fila.Cells[3].Value = tarea.fechaInicioTarea.HasValue
    ? tarea.fechaInicioTarea.Value.ToShortDateString()
    : "";
                fila.Cells[4].Value = tarea.fechaFinTarea.HasValue
                    ? tarea.fechaFinTarea.Value.ToShortDateString()
                    : "";

                // Estado
                fila.Cells[5].Value = tarea.statusTarea;
            }

            // Capturar errores de ComboBox
            dataGridView1.DataError += (s, e) => { e.ThrowException = false; };
        }

        private void labelNombreProyecto_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaProyecto_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreProyecto_Click_1(object sender, EventArgs e)
        {

        }

        private void flowPanelMiembros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCrearNuevoUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
