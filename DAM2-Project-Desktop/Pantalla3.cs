using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    public partial class Pantalla3 : Form
    {
        private Proyecto proyectoActual;
        private DateTimePicker dtpActivo; // Control del DateTimePicker activo

        public Pantalla3(Proyecto project)
        {
            InitializeComponent();
            proyectoActual = project;

            // Conectar eventos
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.UserDeletingRow += DataGridView1_UserDeletingRow;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.CellBeginEdit += DataGridView1_CellBeginEdit;
            dataGridView1.CurrentCellDirtyStateChanged += DataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.DataError += DataGridView1_DataError;
            pictureBox4.Click += PictureBox4_Click;

            // Validar listas
            if (proyectoActual.tareasProyecto == null)
                proyectoActual.tareasProyecto = new List<Tarea>();
            if (proyectoActual.miembrosProyecto == null)
                proyectoActual.miembrosProyecto = new List<Usuario>();

            // Cargar información
            CargarInfoProyecto();
            CargarUsuariosProyecto();
            CargarTareasProyecto();
        }

        public Pantalla3(Proyecto project, Point p) : this(project) { }

        private void Pantalla3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        #region Eventos DataGridView

        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Rows[e.RowIndex].IsNewRow)
                return;

            var fila = dataGridView1.Rows[e.RowIndex];

            // Crear tarea si no existe
            if (fila.Tag == null)
            {
                Tarea nuevaTarea = new Tarea();
                fila.Tag = nuevaTarea;
                proyectoActual.tareasProyecto.Add(nuevaTarea);

                // Inicializar ComboBox de Responsable SOLO UNA VEZ
                InicializarComboBoxResponsable(fila);

                // Inicializar ComboBox de Estado SOLO UNA VEZ
                InicializarComboBoxEstado(fila);
            }

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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex == dataGridView1.NewRowIndex)
                return;

            string nombreColumna = dataGridView1.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "FechaInicio" || nombreColumna == "FechaFin")
            {
                ShowDatePicker(e.RowIndex, e.ColumnIndex);
            }
        }

        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var nombreColumna = dataGridView1.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "FechaInicio" || nombreColumna == "FechaFin")
            {
                e.Cancel = true; // Evita edición directa
                ShowDatePicker(e.RowIndex, e.ColumnIndex);
            }
        }

        #endregion

        #region DateTimePicker

        private void ShowDatePicker(int rowIndex, int columnIndex)
        {
            // Remover DateTimePicker anterior si existe
            if (dtpActivo != null)
            {
                dataGridView1.Controls.Remove(dtpActivo);
                dtpActivo.Dispose();
                dtpActivo = null;
            }

            var fila = dataGridView1.Rows[rowIndex];

            // Crear tarea si no existe
            if (fila.Tag == null)
            {
                Tarea nuevaTarea = new Tarea();
                fila.Tag = nuevaTarea;
                proyectoActual.tareasProyecto.Add(nuevaTarea);

                InicializarComboBoxResponsable(fila);
                InicializarComboBoxEstado(fila);
            }

            var tareaActual = (Tarea)fila.Tag;
            bool esFechaInicio = dataGridView1.Columns[columnIndex].Name == "FechaInicio";

            // Obtener fecha inicial
            DateTime fechaActual = esFechaInicio
                ? tareaActual.fechaInicioTarea ?? DateTime.Now
                : tareaActual.fechaFinTarea ?? DateTime.Now;

            // Crear DateTimePicker
            dtpActivo = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy",
                Value = fechaActual
            };

            // Posicionar sobre la celda
            Rectangle cellRect = dataGridView1.GetCellDisplayRectangle(columnIndex, rowIndex, true);
            dtpActivo.Location = new Point(cellRect.X, cellRect.Y);
            dtpActivo.Size = new Size(cellRect.Width, cellRect.Height);

            dataGridView1.Controls.Add(dtpActivo);
            dtpActivo.BringToFront();

            // Variable para evitar doble ejecución
            bool fechaGuardada = false;

            // Evento CloseUp - cuando selecciona una fecha
            dtpActivo.CloseUp += (s, e) =>
            {
                if (fechaGuardada) return; // Evitar doble guardado
                fechaGuardada = true;

                try
                {
                    DateTime fechaSeleccionada = ((DateTimePicker)s).Value;

                    // Actualizar tarea
                    if (esFechaInicio)
                    {
                        tareaActual.fechaInicioTarea = fechaSeleccionada;
                    }
                    else
                    {
                        tareaActual.fechaFinTarea = fechaSeleccionada;
                    }

                    // Actualizar celda directamente
                    fila.Cells[columnIndex].Value = fechaSeleccionada.ToShortDateString();

                    // Guardar inmediatamente
                    ListadoDatosClasses.guardarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar fecha: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Remover el DateTimePicker
                    LimpiarDateTimePicker();
                }
            };

            // Evento LostFocus - cuando hace click fuera sin seleccionar
            dtpActivo.LostFocus += (s, e) =>
            {
                if (!fechaGuardada)
                {
                    LimpiarDateTimePicker();
                }
            };

            dtpActivo.Focus();
        }

        // Método auxiliar para limpiar el DateTimePicker
        private void LimpiarDateTimePicker()
        {
            if (dtpActivo != null && !dtpActivo.IsDisposed)
            {
                try
                {
                    dataGridView1.Controls.Remove(dtpActivo);
                    dtpActivo.Dispose();
                }
                catch { }
                finally
                {
                    dtpActivo = null;
                }
            }
        }
        #endregion

        #region Gestión de Usuarios

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            var usuarios = ListadoDatosClasses.ListadoUsuarios.ToList();
            var selector = new SelectorUsuariosForm(usuarios);

            var location = pictureBox4.PointToScreen(new Point(pictureBox4.Width, 0));
            selector.Location = location;

            if (selector.ShowDialog() == DialogResult.OK)
            {
                AgregarUsuarioAlPanel(selector.UsuarioSeleccionado);
            }
        }

        private void AgregarUsuarioAlPanel(Usuario usuario)
        {
            if (usuario == null) return;

            if (proyectoActual.miembrosProyecto.Any(u => u.nombre == usuario.nombre))
            {
                MessageBox.Show("Este usuario ya está en el proyecto", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            proyectoActual.miembrosProyecto.Add(usuario);
            ListadoDatosClasses.guardarDatos();

            CargarUsuariosProyecto();

            // CRÍTICO: Desconectar evento antes de actualizar ComboBox
            dataGridView1.CellValueChanged -= DataGridView1_CellValueChanged;

            try
            {
                ActualizarComboBoxResponsables();
            }
            finally
            {
                // Reconectar evento
                dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            }
        }

        private void ActualizarComboBoxResponsables()
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue;

                var comboCell = fila.Cells["Responsable"] as DataGridViewComboBoxCell;
                if (comboCell != null)
                {
                    // Guardar el valor actual ANTES de limpiar
                    object valorActual = comboCell.Value;
                    string nombreActual = valorActual?.ToString();

                    // Limpiar items
                    comboCell.Items.Clear();

                    // Agregar todos los miembros del proyecto
                    foreach (var usuario in proyectoActual.miembrosProyecto)
                    {
                        comboCell.Items.Add(usuario.nombre);
                    }

                    // Restaurar el valor si es válido
                    if (!string.IsNullOrEmpty(nombreActual))
                    {
                        // Solo asignar si el valor está en la lista
                        if (comboCell.Items.Contains(nombreActual))
                        {
                            comboCell.Value = nombreActual;
                        }
                        else
                        {
                            // Si el usuario ya no existe, buscar si la tarea tiene un responsable
                            if (fila.Tag is Tarea tarea && tarea.responsableAsignado != null)
                            {
                                // Si el responsable de la tarea está en los items, asignarlo
                                if (comboCell.Items.Contains(tarea.responsableAsignado.nombre))
                                {
                                    comboCell.Value = tarea.responsableAsignado.nombre;
                                }
                                else
                                {
                                    // Agregar temporalmente el responsable antiguo
                                    comboCell.Items.Add(tarea.responsableAsignado.nombre);
                                    comboCell.Value = tarea.responsableAsignado.nombre;
                                }
                            }
                            else
                            {
                                // No hay responsable válido, dejarlo null
                                comboCell.Value = null;
                            }
                        }
                    }
                    else
                    {
                        comboCell.Value = null;
                    }
                }
            }
        }

        #endregion

        #region Guardar y Cargar Datos

        private void InicializarComboBoxResponsable(DataGridViewRow fila)
        {
            var comboResp = fila.Cells["Responsable"] as DataGridViewComboBoxCell;
            if (comboResp != null)
            {
                // Solo inicializar si está completamente vacío
                if (comboResp.Items.Count == 0)
                {
                    comboResp.Items.Clear();

                    // Agregar todos los miembros del proyecto
                    foreach (var u in proyectoActual.miembrosProyecto)
                    {
                        comboResp.Items.Add(u.nombre);
                    }

                    // Valor inicial null (sin responsable asignado)
                    comboResp.Value = null;
                }
            }
        }

        private void InicializarComboBoxEstado(DataGridViewRow fila)
        {
            var comboEstado = fila.Cells["Estado"] as DataGridViewComboBoxCell;
            if (comboEstado != null && comboEstado.Items.Count == 0)
            {
                comboEstado.Items.AddRange(new string[] { "Pending", "In Progress", "Done" });
                comboEstado.Value = "Pending";
            }
        }

        private void GuardarFila(DataGridViewRow fila)
        {
            if (fila == null || fila.Index < 0 || fila.IsNewRow) return;

            // Crear tarea si no existe
            if (fila.Tag == null)
            {
                Tarea nuevaTarea = new Tarea();
                fila.Tag = nuevaTarea;
                proyectoActual.tareasProyecto.Add(nuevaTarea);
            }

            Tarea tarea = (Tarea)fila.Tag;

            try
            {
                // Guardar valores
                tarea.nombreTarea = fila.Cells["Nombre"].Value?.ToString() ?? "";
                tarea.descripcionTarea = fila.Cells["Descripcion"].Value?.ToString() ?? "";

                // Responsable
                string nombreResp = fila.Cells["Responsable"].Value?.ToString();
                tarea.responsableAsignado = !string.IsNullOrEmpty(nombreResp)
                    ? proyectoActual.miembrosProyecto.FirstOrDefault(u => u.nombre == nombreResp)
                    : null;

                // Fechas
                var valorFechaInicio = fila.Cells["FechaInicio"].Value;
                if (valorFechaInicio != null && !string.IsNullOrWhiteSpace(valorFechaInicio.ToString()))
                {
                    if (DateTime.TryParse(valorFechaInicio.ToString(), out DateTime inicio))
                    {
                        tarea.fechaInicioTarea = inicio;
                    }
                }
                else if (valorFechaInicio?.ToString() == "")
                {
                    tarea.fechaInicioTarea = null;
                }

                var valorFechaFin = fila.Cells["FechaFin"].Value;
                if (valorFechaFin != null && !string.IsNullOrWhiteSpace(valorFechaFin.ToString()))
                {
                    if (DateTime.TryParse(valorFechaFin.ToString(), out DateTime fin))
                    {
                        tarea.fechaFinTarea = fin;
                    }
                }
                else if (valorFechaFin?.ToString() == "")
                {
                    tarea.fechaFinTarea = null;
                }

                // Estado - CORREGIDO para usar valores válidos
                string estado = fila.Cells["Estado"].Value?.ToString();
                tarea.statusTarea = !string.IsNullOrEmpty(estado) ? estado : "Pending";

                // Horas
                if (int.TryParse(fila.Cells["Horas"].Value?.ToString(), out int h))
                    tarea.horas = h;
                else
                    tarea.horas = null;

                // Guardar
                ListadoDatosClasses.guardarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la fila: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                Panel panelUsuario = new Panel
                {
                    Width = 90,
                    Height = 120,
                    Margin = new Padding(0, 0, 10, 0)
                };

                PictureBox pic = new PictureBox
                {
                    Image = usuario.imgPerfil,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 55,
                    Height = 55,
                    Location = new Point((panelUsuario.Width - 55) / 2, 0)
                };

                Label lbl = new Label
                {
                    Text = usuario.nombre,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Width = 80,
                    Height = 20,
                    Location = new Point((panelUsuario.Width - 80) / 2, 58)
                };

                panelUsuario.Controls.Add(pic);
                panelUsuario.Controls.Add(lbl);
                flowPanelMiembros.Controls.Add(panelUsuario);
            }
        }

        private void CargarTareasProyecto()
        {
            dataGridView1.CellValueChanged -= DataGridView1_CellValueChanged;

            try
            {
                dataGridView1.Rows.Clear();

                foreach (var tarea in proyectoActual.tareasProyecto)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    var fila = dataGridView1.Rows[rowIndex];
                    fila.Tag = tarea;

                    fila.Cells["Nombre"].Value = tarea.nombreTarea ?? "";
                    fila.Cells["Descripcion"].Value = tarea.descripcionTarea ?? "";

                    // ===== RESPONSABLE COMBOBOX - MEJORADO =====
                    var comboResp = fila.Cells["Responsable"] as DataGridViewComboBoxCell;
                    if (comboResp != null)
                    {
                        comboResp.Items.Clear();

                        // Agregar todos los miembros del proyecto
                        foreach (var u in proyectoActual.miembrosProyecto)
                        {
                            comboResp.Items.Add(u.nombre);
                        }

                        // Manejar responsable asignado
                        if (tarea.responsableAsignado != null)
                        {
                            string nombreResponsable = tarea.responsableAsignado.nombre;

                            // ⚠️ CRÍTICO: Verificar si el responsable está en miembros del proyecto
                            bool esMiembro = proyectoActual.miembrosProyecto
                                .Any(m => m.nombre == nombreResponsable);

                            if (esMiembro)
                            {
                                // El responsable está en el proyecto, asignarlo normalmente
                                comboResp.Value = nombreResponsable;
                            }
                            else
                            {
                                // El responsable NO está en el proyecto
                                // Opción 1: Agregarlo temporalmente a la lista (mantener consistencia)
                                comboResp.Items.Add(nombreResponsable + " (No en proyecto)");
                                comboResp.Value = nombreResponsable + " (No en proyecto)";

                                // Opción 2: Desasignarlo (comentar líneas anteriores y descomentar estas)
                                // tarea.responsableAsignado = null;
                                // comboResp.Value = null;

                                // Log de advertencia
                                System.Diagnostics.Debug.WriteLine(
                                    $"⚠️ ADVERTENCIA: Tarea '{tarea.nombreTarea}' tiene responsable '{nombreResponsable}' que NO está en miembros del proyecto");
                            }
                        }
                        else
                        {
                            // No hay responsable asignado
                            comboResp.Value = null;
                        }
                    }

                    // ===== ESTADO COMBOBOX - VALIDADO =====
                    var comboEstado = fila.Cells["Estado"] as DataGridViewComboBoxCell;
                    if (comboEstado != null)
                    {
                        comboEstado.Items.Clear();
                        comboEstado.Items.AddRange(new string[] { "Pending", "In Progress", "Done" });

                        // Validar que el estado sea uno de los valores permitidos
                        string estadoTarea = tarea.statusTarea;

                        if (!string.IsNullOrEmpty(estadoTarea))
                        {
                            // Normalizar estado (por si viene "Pendiente" en lugar de "Pending")
                            if (estadoTarea == "Pendiente") estadoTarea = "Pending";
                            else if (estadoTarea == "En Progreso") estadoTarea = "In Progress";
                            else if (estadoTarea == "Finalizada") estadoTarea = "Done";

                            // Verificar que sea válido
                            if (comboEstado.Items.Contains(estadoTarea))
                            {
                                comboEstado.Value = estadoTarea;
                                tarea.statusTarea = estadoTarea; // Actualizar en el objeto
                            }
                            else
                            {
                                comboEstado.Value = "Pending";
                                tarea.statusTarea = "Pending";
                                System.Diagnostics.Debug.WriteLine(
                                    $"⚠️ Estado inválido '{estadoTarea}' en tarea '{tarea.nombreTarea}', cambiado a 'Pending'");
                            }
                        }
                        else
                        {
                            comboEstado.Value = "Pending";
                            tarea.statusTarea = "Pending";
                        }
                    }

                    // Fechas
                    fila.Cells["FechaInicio"].Value = tarea.fechaInicioTarea.HasValue
                        ? tarea.fechaInicioTarea.Value.ToShortDateString()
                        : "";

                    fila.Cells["FechaFin"].Value = tarea.fechaFinTarea.HasValue
                        ? tarea.fechaFinTarea.Value.ToShortDateString()
                        : "";

                    // Horas
                    fila.Cells["Horas"].Value = tarea.horas?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}\n\n{ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            }
        }

        #endregion

        #region Botones

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
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
                SincronizarProyectoActual();
                CargarUsuariosProyecto();
                CargarTareasProyecto();
            };
            pantalla5.ShowDialog();
        }

        private void SincronizarProyectoActual()
        {
            ListadoDatosClasses.cargarDatos();
            var proyectoActualizado = ListadoDatosClasses.ListadoProyectos
                .FirstOrDefault(p => p.ID == proyectoActual.ID);

            if (proyectoActualizado != null)
                proyectoActual = proyectoActualizado;
        }

        #endregion
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Prevenir que se muestre el diálogo de error
            e.ThrowException = false;
            e.Cancel = true;

            // Obtener información del error
            var fila = dataGridView1.Rows[e.RowIndex];
            var columna = dataGridView1.Columns[e.ColumnIndex];

            string nombreColumna = columna?.Name ?? "desconocida";
            string mensajeError = e.Exception?.Message ?? "Error desconocido";

            // Registrar en consola de depuración
            System.Diagnostics.Debug.WriteLine($"DataError en fila {e.RowIndex}, columna {nombreColumna}: {mensajeError}");

            // Si es un error en ComboBox, intentar solucionarlo
            if (columna?.Name == "Responsable" || columna?.Name == "Estado")
            {
                var comboCell = fila.Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                if (comboCell != null)
                {
                    // Resetear a valor nulo o predeterminado
                    if (columna.Name == "Responsable")
                    {
                        comboCell.Value = null;

                        // Si la tarea tiene un responsable asignado que no está en la lista
                        if (fila.Tag is Tarea tarea && tarea.responsableAsignado != null)
                        {
                            // Agregar el responsable a la lista si no existe
                            if (!comboCell.Items.Contains(tarea.responsableAsignado.nombre))
                            {
                                comboCell.Items.Add(tarea.responsableAsignado.nombre);
                            }
                            comboCell.Value = tarea.responsableAsignado.nombre;
                        }
                    }
                    else if (columna.Name == "Estado")
                    {
                        // Asegurar que tiene los valores correctos
                        if (comboCell.Items.Count == 0)
                        {
                            comboCell.Items.AddRange(new string[] { "Pending", "In Progress", "Done" });
                        }
                        comboCell.Value = "Pending";
                    }
                }
            }

            // Opcional: Mostrar mensaje solo en casos críticos
            // MessageBox.Show($"Error en {nombreColumna}: {mensajeError}", "Advertencia", 
            //     MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void buttonOut_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            this.Close();
        }
    }

}