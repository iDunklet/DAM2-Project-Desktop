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

        public Pantalla3(Proyecto project)
        {
            InitializeComponent();

            proyectoActual = project;

            // Inicializar listas si son null
            if (proyectoActual.tareasProyecto == null)
                proyectoActual.tareasProyecto = new List<Tarea>();
            if (proyectoActual.miembrosProyecto == null)
                proyectoActual.miembrosProyecto = new List<Usuario>();

            // Conectar eventos ANTES de cargar datos
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.UserDeletingRow += DataGridView1_UserDeletingRow;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellBeginEdit += DataGridView1_CellBeginEdit;
            dataGridView1.DataError += DataGridView1_DataError;

            // ✅ CRÍTICO: Añadir evento para ComboBox
            dataGridView1.CurrentCellDirtyStateChanged += DataGridView1_CurrentCellDirtyStateChanged;

            pictureBox4.Click += pictureBox4_Click;

            // Cargar información
            CargarInfoProyecto();
            CargarUsuariosProyecto();
            CargarTareasProyecto();
        }

        public Pantalla3(Proyecto project, Point p) : this(project)
        {
            // ✅ NO duplicar código aquí - el constructor base ya hace todo
            // El constructor delegado (: this(project)) ejecuta el constructor principal
        }

        private void Pantalla3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        #region Eventos DataGridView

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Evitar que errores de datos detengan la aplicación
            e.ThrowException = false;
        }

        // ✅ NUEVO: Para que ComboBox guarde inmediatamente
        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                // Confirmar cambios inmediatamente en ComboBox
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dataGridView1.Rows[e.RowIndex];
            if (fila.IsNewRow) return;

            // ✅ Guardar inmediatamente después de cualquier cambio
            GuardarFila(fila);
        }

        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Tag is Tarea tarea)
            {
                proyectoActual.tareasProyecto.Remove(tarea);
                ListadoDatosClasses.guardarDatos();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dataGridView1.NewRowIndex)
                return;

            if (e.ColumnIndex < 0) return;

            string nombreColumna = dataGridView1.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "FechaInicio" || nombreColumna == "FechaFin")
            {
                ShowDatePicker(e.RowIndex, e.ColumnIndex);
            }
        }

        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Solo para columnas de fecha
            var nombreColumna = dataGridView1.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "FechaInicio" || nombreColumna == "FechaFin")
            {
                e.Cancel = true; // Evita edición directa
                ShowDatePicker(e.RowIndex, e.ColumnIndex);
            }
        }

        #endregion

        #region DatePicker para Fechas

        private void ShowDatePicker(int rowIndex, int columnIndex)
        {
            var fila = dataGridView1.Rows[rowIndex];

            // Crear tarea nueva solo si fila válida y lista inicializada
            if (fila.Tag == null)
            {
                Tarea nuevaTarea = new Tarea();
                fila.Tag = nuevaTarea;
                proyectoActual.tareasProyecto.Add(nuevaTarea);
            }

            var tareaActual = (Tarea)fila.Tag;

            DateTime fechaActual = (columnIndex == dataGridView1.Columns["FechaInicio"].Index)
                ? tareaActual.fechaInicioTarea ?? DateTime.Now
                : tareaActual.fechaFinTarea ?? DateTime.Now;

            DateTimePicker dtp = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy",
                Value = fechaActual
            };

            // Posicionar el DateTimePicker encima de la celda
            Rectangle cellRect = dataGridView1.GetCellDisplayRectangle(columnIndex, rowIndex, true);
            dtp.Location = new Point(cellRect.X, cellRect.Y);
            dtp.Size = new Size(cellRect.Width, cellRect.Height);
            dtp.Visible = true;

            dataGridView1.Controls.Add(dtp);
            dtp.BringToFront();

            dtp.CloseUp += (s, e) =>
            {
                // Actualizar la celda y la tarea
                fila.Cells[columnIndex].Value = dtp.Value.ToShortDateString();

                if (columnIndex == dataGridView1.Columns["FechaInicio"].Index)
                    tareaActual.fechaInicioTarea = dtp.Value;
                else
                    tareaActual.fechaFinTarea = dtp.Value;

                dataGridView1.Controls.Remove(dtp);
                dtp.Dispose();

                // ✅ Guardar toda la fila después de seleccionar fecha
                GuardarFila(fila);
            };

            dtp.Focus();
        }

        #endregion

        #region Gestión de Miembros

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
            if (usuario == null) return;

            // Verificar que el usuario no esté ya en el proyecto
            if (proyectoActual.miembrosProyecto.Any(u => u.nombre == usuario.nombre))
            {
                MessageBox.Show("Este usuario ya está en el proyecto", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ✅ AGREGAR AL PROYECTO EN MEMORIA
            proyectoActual.miembrosProyecto.Add(usuario);

            // ✅ GUARDAR PRIMERO
            ListadoDatosClasses.guardarDatos();

            // ✅ RECARGAR VISTA - esto mostrará el nuevo usuario
            CargarUsuariosProyecto();

            // ✅ ACTUALIZAR ComboBox de responsables en todas las filas
            ActualizarComboBoxResponsables();
        }

        private void ActualizarComboBoxResponsables()
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue;

                var comboCell = fila.Cells["Responsable"] as DataGridViewComboBoxCell;
                if (comboCell != null)
                {
                    string valorActual = comboCell.Value?.ToString();

                    comboCell.Items.Clear();

                    // Agregar todos los miembros del proyecto
                    foreach (var usuario in proyectoActual.miembrosProyecto)
                    {
                        comboCell.Items.Add(usuario.nombre);
                    }

                    // Restaurar el valor si existía
                    if (!string.IsNullOrEmpty(valorActual) && comboCell.Items.Contains(valorActual))
                    {
                        comboCell.Value = valorActual;
                    }
                }
            }
        }

        #endregion

        #region Guardar Fila

        private void GuardarFila(DataGridViewRow fila)
        {
            if (fila == null || fila.Index < 0 || fila.IsNewRow)
                return;

            // ✅ NO validar contenido - guardar siempre, incluso con campos vacíos

            // Inicializar listas si son null
            if (proyectoActual.tareasProyecto == null)
                proyectoActual.tareasProyecto = new List<Tarea>();

            if (proyectoActual.miembrosProyecto == null)
                proyectoActual.miembrosProyecto = new List<Usuario>();

            // Crear tarea si no existe
            if (fila.Tag == null)
            {
                Tarea nuevaTarea = new Tarea();
                fila.Tag = nuevaTarea;
                proyectoActual.tareasProyecto.Add(nuevaTarea);
            }

            Tarea tarea = (Tarea)fila.Tag;

            // ✅ Guardar todos los valores (permitir vacíos)
            tarea.nombreTarea = fila.Cells["Nombre"].Value?.ToString() ?? "";
            tarea.descripcionTarea = fila.Cells["Descripcion"].Value?.ToString() ?? "";

            // Responsable
            string nombreResp = fila.Cells["Responsable"].Value?.ToString();
            if (!string.IsNullOrEmpty(nombreResp))
            {
                tarea.responsableAsignado = proyectoActual.miembrosProyecto
                    .FirstOrDefault(u => u.nombre == nombreResp);
            }
            else
            {
                tarea.responsableAsignado = null;
            }

            // Fechas
            if (DateTime.TryParse(fila.Cells["FechaInicio"].Value?.ToString(), out DateTime ini))
                tarea.fechaInicioTarea = ini;
            else
                tarea.fechaInicioTarea = null;

            if (DateTime.TryParse(fila.Cells["FechaFin"].Value?.ToString(), out DateTime fin))
                tarea.fechaFinTarea = fin;
            else
                tarea.fechaFinTarea = null;

            // Estado
            tarea.statusTarea = fila.Cells["Estado"].Value?.ToString() ?? "";

            // Horas
            if (int.TryParse(fila.Cells["Horas"].Value?.ToString(), out int h))
                tarea.horas = h;
            else
                tarea.horas = null;

            // ✅ GUARDAR siempre
            ListadoDatosClasses.guardarDatos();
        }

        #endregion

        #region Cargar Información

        private void CargarInfoProyecto()
        {
            if (proyectoActual == null) return;

            labelId.Text = proyectoActual.ID.ToString();
            labelNombreProyecto.Text = proyectoActual.titulo;
            labelFechaProyecto.Text = proyectoActual.fechaEntrega.ToString("dd/MM/yyyy");

            labelId.TextAlign = ContentAlignment.MiddleCenter;
            labelNombreProyecto.TextAlign = ContentAlignment.MiddleCenter;
            labelFechaProyecto.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void CargarUsuariosProyecto()
        {
            flowPanelMiembros.Controls.Clear();

            if (proyectoActual.miembrosProyecto == null)
                proyectoActual.miembrosProyecto = new List<Usuario>();

            foreach (var usuario in proyectoActual.miembrosProyecto)
            {
                Panel panelUsuario = new Panel();
                panelUsuario.Width = 90;
                panelUsuario.Height = 120;
                panelUsuario.Margin = new Padding(0, 0, 10, 0);

                PictureBox pic = new PictureBox();
                pic.Image = usuario.imgPerfil;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Width = 55;
                pic.Height = 55;
                pic.Location = new Point((panelUsuario.Width - pic.Width) / 2, 0);

                Label lbl = new Label();
                lbl.Text = usuario.nombre;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.AutoSize = false;
                lbl.Width = 80;
                lbl.Height = 20;
                lbl.Location = new Point((panelUsuario.Width - lbl.Width) / 2, pic.Height + 3);

                panelUsuario.Controls.Add(pic);
                panelUsuario.Controls.Add(lbl);
                flowPanelMiembros.Controls.Add(panelUsuario);
            }
        }

        private void CargarTareasProyecto()
        {
            // ✅ Desconectar eventos temporalmente para evitar guardados durante la carga
            dataGridView1.CellValueChanged -= DataGridView1_CellValueChanged;

            dataGridView1.Rows.Clear();

            if (proyectoActual == null)
                return;

            if (proyectoActual.tareasProyecto == null)
                proyectoActual.tareasProyecto = new List<Tarea>();

            if (proyectoActual.miembrosProyecto == null)
                proyectoActual.miembrosProyecto = new List<Usuario>();

            foreach (var tarea in proyectoActual.tareasProyecto)
            {
                int rowIndex = dataGridView1.Rows.Add();
                var fila = dataGridView1.Rows[rowIndex];

                fila.Tag = tarea;

                fila.Cells["Nombre"].Value = tarea?.nombreTarea ?? "";
                fila.Cells["Descripcion"].Value = tarea?.descripcionTarea ?? "";

                // ComboBox responsable - ✅ CRUCIAL: poblar con miembros
                var comboCell = (DataGridViewComboBoxCell)fila.Cells["Responsable"];
                comboCell.Items.Clear();

                foreach (var usuario in proyectoActual.miembrosProyecto)
                    comboCell.Items.Add(usuario.nombre);

                // Asignar valor del responsable
                if (tarea?.responsableAsignado != null)
                {
                    if (!comboCell.Items.Contains(tarea.responsableAsignado.nombre))
                        comboCell.Items.Add(tarea.responsableAsignado.nombre);

                    comboCell.Value = tarea.responsableAsignado.nombre;
                }

                // Fechas
                fila.Cells["FechaInicio"].Value = tarea?.fechaInicioTarea?.ToShortDateString() ?? "";
                fila.Cells["FechaFin"].Value = tarea?.fechaFinTarea?.ToShortDateString() ?? "";

                // Estado y horas
                fila.Cells["Estado"].Value = tarea?.statusTarea ?? "";
                fila.Cells["Horas"].Value = tarea?.horas?.ToString() ?? "";
            }

            // ✅ Reconectar eventos después de cargar
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

        #endregion

        #region Botones

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: Implementar crear nueva tarea
            ListadoDatosClasses.guardarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            // Vista actual - ya estamos en cuadrícula
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            Pantalla4 pantalla4 = new Pantalla4(proyectoActual);
            pantalla4.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            this.Close();
        }

        private void buttonCrearNuevoUsuario_Click(object sender, EventArgs e)
        {
            Pantalla5 pantalla5 = new Pantalla5();
            pantalla5.FormClosed += (s, args) =>
            {
                // Sincronizar proyecto después de crear usuario
                SincronizarProyectoActual();

                // Recargar vistas
                CargarUsuariosProyecto();
                CargarTareasProyecto();
            };
            pantalla5.ShowDialog();
        }

        /// <summary>
        /// Sincroniza proyectoActual con la versión guardada en ListadoDatosClasses
        /// después de recargar datos
        /// </summary>
        private void SincronizarProyectoActual()
        {
            // Recargar datos desde archivo
            ListadoDatosClasses.cargarDatos();

            // Buscar el proyecto actual en la lista recargada por ID
            var proyectoActualizado = ListadoDatosClasses.ListadoProyectos
                .FirstOrDefault(p => p.ID == proyectoActual.ID);

            if (proyectoActualizado != null)
            {
                // Actualizar la referencia local
                proyectoActual = proyectoActualizado;
            }
        }

        #endregion
    }
}