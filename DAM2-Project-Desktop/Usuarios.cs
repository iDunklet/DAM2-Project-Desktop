using System.Drawing.Drawing2D;
using System.Drawing.Text;
using DAM2_Project_Desktop.Properties;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;

namespace DAM2_Project_Desktop
{
    public class Usuarios
    {
        //atributos
        public string nombre {  get; set; }
        public string apellido1 { get; set; }
        public string? apellido2 { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string classe { get; set;}
        public string email { get; set;}
        public string password { get; set; }

        public string userName { get; }
 
        public Bitmap imgPerfil { get; set; }

        //artivutos ocultos
        public Bitmap miniImgPerfil { get; set; }

        public string apellidoCompleto { get; }




        //constructores
        public Usuarios(string nombre, string apellido1, string apellido2, DateTime fechaNacimiento,
            string classe, string email, string password, string userName)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.fechaNacimiento = fechaNacimiento;
            this.classe = classe;
            this.email = email;
            this.password = password;


            this.userName = UserNameGenerator();

            this.imgPerfil = GenerarImagenIniciales(100);
            this.miniImgPerfil = GenerarImagenIniciales(20);

            this.apellidoCompleto = setApellidoCompleto();

           
        }

        public Usuarios(string nombre, string apellido1, DateTime fechaNacimiento,
    string classe, string email, string password, string userName)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = null;
            this.fechaNacimiento = fechaNacimiento;
            this.classe = classe;
            this.email = email;
            this.password = password;


            this.userName = UserNameGenerator();

            this.imgPerfil = GenerarImagenIniciales(100);
            this.miniImgPerfil = GenerarImagenIniciales(20);
            this.apellidoCompleto = setApellidoCompleto();
        }

        //constructor de test para proyecto Hugo
        public Usuarios(string nombre)
        {
            this.nombre = nombre;
        }

        /*constructor de test para proyecto Hugo
        public Usuarios(string nombre)
        {
            this.nombre = nombre;
        }

        */




        //metodos 

        public string setApellidoCompleto() 
        { return this.apellido1 + " " + this.apellido2; } 
        

        private string UserNameGenerator()
        {
            string username = "";
            if (!string.IsNullOrEmpty(nombre))
            {
                username += nombre[0];
            }
            if (!string.IsNullOrEmpty(apellido1))
            {
                username += apellido1;
            }
            if (string.IsNullOrEmpty(username))
            {
                username = "?";
            }
            return username.ToUpper();
        }


        private static readonly Color[] ColoresAvatar = new[]
        {
            Color.FromArgb(255, 63, 81),    // Rojo
            Color.FromArgb(33, 150, 243),   // Azul
            Color.FromArgb(76, 175, 80),    // Verde
            Color.FromArgb(255, 152, 0),    // Naranja
            Color.FromArgb(156, 39, 176),   // Morado
            Color.FromArgb(0, 188, 212),    // Cian
            Color.FromArgb(233, 30, 99),    // Rosa
            Color.FromArgb(103, 58, 183)    // Índigo
        };

        private static readonly Random random = new Random();

        public Bitmap GenerarImagenIniciales(int tamano)
        {
            // --- 1. SELECCIÓN DE INICIALES Y COLOR ALEATORIO ---

            // Seleccionar un color de fondo aleatorio de la lista
            Color fondoColor = ColoresAvatar[random.Next(ColoresAvatar.Length)];

            // Obtener las iniciales
            string iniciales = "";
            if (!string.IsNullOrEmpty(nombre))
            {
                iniciales += nombre[0];
            }
            if (!string.IsNullOrEmpty(apellido1))
            {
                iniciales += apellido1[0];
            }
            if (string.IsNullOrEmpty(iniciales))
            {
                iniciales = "?";
            }
            iniciales = iniciales.ToUpper();


            // --- 2. GENERACIÓN DE LA IMAGEN ---

            var bitmap = new Bitmap(tamano, tamano);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Configuración de renderizado
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                // 3. Pintar el fondo
                using (var brochaFondo = new SolidBrush(fondoColor))
                {
                    g.FillRectangle(brochaFondo, 0, 0, tamano, tamano);
                }

                // 4. Definir la fuente (texto blanco)
                float fontSize = tamano / (iniciales.Length > 1 ? 1.5f : 1.8f);
                using (var fuente = new Font("Arial", fontSize, FontStyle.Bold))
                using (var brochaTexto = new SolidBrush(Color.White))
                {
                    // 5. Formato para centrar el texto
                    var formato = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    // Definir el área de dibujo
                    var areaDibujo = new RectangleF(0, 0, tamano, tamano);

                    // 6. Dibujar el texto
                    g.DrawString(iniciales, fuente, brochaTexto, areaDibujo, formato);
                }
            }

            return bitmap;
        }
    }
}
