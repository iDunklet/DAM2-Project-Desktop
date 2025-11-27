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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var usuariosDAM2 = ListadoDatosClasses.ListadoUsuarios
                                .Where(u => u.classe == "DAM2")
                                .ToList();

            var selector = new SelectorUsuariosForm(usuariosDAM2);

            // Posición al lado del PictureBox
            var location = pictureBox4.PointToScreen(new Point(pictureBox4.Width, 0));
            selector.Location = location;

            if (selector.ShowDialog() == DialogResult.OK)
            {
                var usuarioSeleccionado = selector.UsuarioSeleccionado;
                AgregarUsuarioAlPanel(usuarioSeleccionado);
            }
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

                //horas
                if (tarea.horas == null) {
                    fila.Cells[6].Value = 0;
                } else {
                    fila.Cells[6].Value = tarea.horas;
                        }
            }

            // Capturar errores de ComboBox
            dataGridView1.DataError += (s, e) => { e.ThrowException = false; };
        }
    }
}
