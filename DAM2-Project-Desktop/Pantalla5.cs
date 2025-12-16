namespace DAM2_Project_Desktop
{
    public partial class Pantalla5 : Form
    {
        private Size originalSize;

        // Rectángulos para textboxes
        private Rectangle rNombre;
        private Rectangle rApellido1;
        private Rectangle rApellido2;
        private Rectangle rCurso;
        private Rectangle rEmail;
        private Rectangle rFecha;
        private Rectangle rUsuario;
        private Rectangle rPassword;
        private Rectangle rRepPassword;
        private Rectangle rButtonCrear;

        // Rectángulos para labels
        private Rectangle rLabelNombre;
        private Rectangle rLabelApellido1;
        private Rectangle rLabelApellido2;
        private Rectangle rLabelCurso;
        private Rectangle rLabelEmail;
        private Rectangle rLabelFecha;
        private Rectangle rLabelUsuario;
        private Rectangle rLabelPassword;
        private Rectangle rLabelRepPassword;

        // Botones laterales
        private Rectangle rButtonInicio;
        private Rectangle rButtonProyectos;
        private Rectangle rButtonUsuarios;
        private Rectangle rButtonImportar;
        private Rectangle rButtonExportar;

        public Pantalla5()
        {
            InitializeComponent();

            this.Load += Pantalla5_Load;
            this.Resize += Pantalla5_Resize;

            // 🔹 Username automático
            textBoxNombre.TextChanged += CamposUsuario_TextChanged;
            textBoxApellido1.TextChanged += CamposUsuario_TextChanged;
            textBoxCurso.TextChanged += CamposUsuario_TextChanged;

            // 🔹 Botón “Crear usuario”
        }

        private void Pantalla5_Load(object sender, EventArgs e)
        {
            originalSize = this.Size;
            SaveOriginalRectangles();
            this.WindowState = FormWindowState.Maximized;
        }

        private void SaveOriginalRectangles()
        {
            // Textboxes
            rNombre = new Rectangle(textBoxNombre.Location, textBoxNombre.Size);
            rApellido1 = new Rectangle(textBoxApellido1.Location, textBoxApellido1.Size);
            rApellido2 = new Rectangle(textBoxApellido2.Location, textBoxApellido2.Size);
            rCurso = new Rectangle(textBoxCurso.Location, textBoxCurso.Size);
            rEmail = new Rectangle(textBoxEmail.Location, textBoxEmail.Size);
            rFecha = new Rectangle(dateTimePickerFechaNacimiento.Location, dateTimePickerFechaNacimiento.Size);
            rUsuario = new Rectangle(textBoxUsuario.Location, textBoxUsuario.Size);
            rPassword = new Rectangle(textBoxContrasenya.Location, textBoxContrasenya.Size);
            rRepPassword = new Rectangle(textBoxRepetirContrasenya.Location, textBoxRepetirContrasenya.Size);
            rButtonCrear = new Rectangle(buttonCrearUsuario.Location, buttonCrearUsuario.Size);

            // Labels
            rLabelNombre = new Rectangle(labelNombre.Location, labelNombre.Size);
            rLabelApellido1 = new Rectangle(labelApellido1.Location, labelApellido1.Size);
            rLabelApellido2 = new Rectangle(labelApellido2.Location, labelApellido2.Size);
            rLabelCurso = new Rectangle(labelCurso.Location, labelCurso.Size);
            rLabelEmail = new Rectangle(labelEmail.Location, labelEmail.Size);
            rLabelFecha = new Rectangle(labelFechaNacimiento.Location, labelFechaNacimiento.Size);
            rLabelUsuario = new Rectangle(labelUsuario.Location, labelUsuario.Size);
            rLabelPassword = new Rectangle(labelContrasenya.Location, labelContrasenya.Size);
            rLabelRepPassword = new Rectangle(labelRepContrasenya.Location, labelRepContrasenya.Size);
        }

        private void Pantalla5_Resize(object sender, EventArgs e)
        {
            float scaleX = (float)this.Width / originalSize.Width;
            float scaleY = (float)this.Height / originalSize.Height;

            // Textboxes
            ResizeControl(textBoxNombre, rNombre, scaleX, scaleY);
            ResizeControl(textBoxApellido1, rApellido1, scaleX, scaleY);
            ResizeControl(textBoxApellido2, rApellido2, scaleX, scaleY);
            ResizeControl(textBoxCurso, rCurso, scaleX, scaleY);
            ResizeControl(textBoxEmail, rEmail, scaleX, scaleY);
            ResizeControl(dateTimePickerFechaNacimiento, rFecha, scaleX, scaleY);
            ResizeControl(textBoxUsuario, rUsuario, scaleX, scaleY);
            ResizeControl(textBoxContrasenya, rPassword, scaleX, scaleY);
            ResizeControl(textBoxRepetirContrasenya, rRepPassword, scaleX, scaleY);
            ResizeControl(buttonCrearUsuario, rButtonCrear, scaleX, scaleY);

            // Labels
            ResizeControl(labelNombre, rLabelNombre, scaleX, scaleY);
            ResizeControl(labelApellido1, rLabelApellido1, scaleX, scaleY);
            ResizeControl(labelApellido2, rLabelApellido2, scaleX, scaleY);
            ResizeControl(labelCurso, rLabelCurso, scaleX, scaleY);
            ResizeControl(labelEmail, rLabelEmail, scaleX, scaleY);
            ResizeControl(labelFechaNacimiento, rLabelFecha, scaleX, scaleY);
            ResizeControl(labelUsuario, rLabelUsuario, scaleX, scaleY);
            ResizeControl(labelContrasenya, rLabelPassword, scaleX, scaleY);
            ResizeControl(labelRepContrasenya, rLabelRepPassword, scaleX, scaleY);

        }

        private void ResizeControl(Control c, Rectangle r, float scaleX, float scaleY)
        {
            c.Left = (int)(r.Left * scaleX);
            c.Top = (int)(r.Top * scaleY);
            c.Width = (int)(r.Width * scaleX);
            c.Height = (int)(r.Height * scaleY);
        }

        private void ResizeSidebarButton(Control c, Rectangle r, float scaleX, float scaleY)
        {
            c.Left = (int)(r.Left * scaleX);
            c.Top = (int)(r.Top * scaleY);
            c.Width = (int)(r.Width * scaleX);
            c.Height = (int)(r.Height * scaleY);
        }

        // ===========================================================
        //                GENERADOR AUTOMÁTICO DE USERNAME
        // ===========================================================

        private void CamposUsuario_TextChanged(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido1 = textBoxApellido1.Text;
            string clase = textBoxCurso.Text;

            textBoxUsuario.Text = GenerateUserName(nombre, apellido1, clase);
        }

        private string GenerateUserName(string nombre, string apellido1, string classe)
        {
            nombre = nombre?.Trim() ?? "";
            apellido1 = apellido1?.Trim() ?? "";
            classe = classe?.Trim() ?? "";

            string inicialNombre = nombre.Length > 0 ? nombre[0].ToString() : "?";
            string apellido = apellido1.Length > 0 ? apellido1 : "?";
            string claseParte = classe.Length > 0 ? classe : "";

            string userName = inicialNombre + apellido + claseParte;
            return userName.ToUpper();
        }

        // ===========================================================
        //                     CREACIÓN DE USUARIO
        // ===========================================================

        private void ButtonCrearUsuario_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();
            string apellido1 = textBoxApellido1.Text.Trim();
            string apellido2 = textBoxApellido2.Text.Trim();
            string clase = textBoxCurso.Text.Trim();
            DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
            string email = textBoxEmail.Text.Trim();
            string password = textBoxContrasenya.Text.Trim();
            string repPassword = textBoxRepetirContrasenya.Text.Trim();
            string userName = textBoxUsuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido1) ||
                string.IsNullOrWhiteSpace(clase) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(repPassword))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != repPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario nuevoUsuario = new Usuario(
                nombre, apellido1, fechaNacimiento, clase, email, password, userName
            );

            ListadoDatosClasses.ListadoUsuarios.Add(nuevoUsuario);

            MessageBox.Show($"Usuario creado correctamente.\nUserName: {nuevoUsuario.userName}");

            // Mostrar listado
            string lista = string.Join("\n",
                ListadoDatosClasses.ListadoUsuarios.Select(u =>
                    $"• {u.userName} ({u.nombre} {u.apellido1}) {u.classe}"
                )
            );

            MessageBox.Show(lista, "Lista de Usuarios");

            // Limpiar
            LimpiarCamposUsuario();

            ListadoDatosClasses.guardarDatos();
            this.Close();
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.exportProjects();
            Pantalla8 pantalla8 = new Pantalla8();
            pantalla8.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.exportProjects();
            Pantalla2 pantalla2 = new Pantalla2();
            pantalla2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.importJSONFromNewDirectory();
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.guardarDatos();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListadoDatosClasses.exportProjects();
        }
    }
}
