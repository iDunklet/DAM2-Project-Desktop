using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAM2_Project_Desktop
{
    public class Proyecto
    {
        //atributos
        private static int _nextID = 1;
        public int ID { get; private set; }
        public string titulo { get; set; }
        public DateTime fechaEntrega { get; set; }
        public List<Usuarios> miembrosProyecto { get; set; }
        public List<Tarea> tareasProyecto { get; set; }

        private Bitmap imgProyecto;
        public Bitmap ImgProyecto
        {
            get { return imgProyecto; }
            set { imgProyecto = value ?? GenerarImagenIniciales(titulo); }
        }



        private Bitmap GenerarImagenIniciales(string titulo, int tamano = 135)
        {
            // Obtener solo la PRIMERA letra del título
            string inicial = "";
            if (!string.IsNullOrWhiteSpace(titulo))
            {
                // Tomar solo el primer carácter no-espacio
                inicial = titulo.Trim()[0].ToString();
            }

            if (string.IsNullOrEmpty(inicial))
                inicial = "?";

            inicial = inicial.ToUpper();

            // Colores posibles
            Color[] coloresAvatar = {
        Color.SteelBlue, Color.DarkCyan, Color.IndianRed,
        Color.DarkOliveGreen, Color.MediumVioletRed,
        Color.SlateBlue, Color.DarkOrange
    };
            Random random = new Random();
            Color fondoColor = coloresAvatar[random.Next(coloresAvatar.Length)];

            // Crear imagen
            // El tamaño del mapa de bits ahora usa el valor predeterminado de 135
            var bitmap = new Bitmap(tamano, tamano);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                // Fondo RECTANGULAR
                using (var brochaFondo = new SolidBrush(fondoColor))
                    g.FillRectangle(brochaFondo, 0, 0, tamano, tamano);

                // Fuente. Usamos un 65% del tamaño total para una letra más grande y legible
                float fontSize = tamano * 0.50f;

                using (var fuente = new Font("Arial", fontSize, FontStyle.Bold, GraphicsUnit.Pixel))
                using (var brochaTexto = new SolidBrush(Color.White))
                {
                    var formato = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    var areaDibujo = new RectangleF(0, 0, tamano, tamano);

                    // Ajuste fino para la corrección del centrado vertical (las fuentes cuelgan)
                    // Se reduce el ajuste a 2% (0.02f) del tamaño para un mejor centrado en 135px
                    areaDibujo.Y -= tamano * 0.0001f;

                    g.DrawString(inicial, fuente, brochaTexto, areaDibujo, formato);
                }
            }

            return bitmap;
        }


        //constructores
        public Proyecto(string titulo, DateTime fechaEntrega)
        {
            this.ID = _nextID;
            _nextID++;
            this.titulo = titulo;
            this.fechaEntrega = fechaEntrega;

        }
        public Proyecto(string titulo, DateTime fechaEntrega, List<Usuarios> miembros)
        {
            this.ID = _nextID;
            _nextID++;
            this.titulo = titulo;
            this.fechaEntrega = fechaEntrega;
            this.miembrosProyecto = miembros;

        }
        public Proyecto(string titulo, List<Usuarios> usuarios, List<Tarea> tareas, Bitmap imgProyecto)
        {
            this.ID = _nextID;
            _nextID++;
            this.titulo = titulo;
            this.miembrosProyecto = usuarios;
            this.tareasProyecto = tareas;
            this.ImgProyecto = imgProyecto;
        }


        public void exportarTodosLosProyectos()
        {
            string rutaArchivo = @"D:\Tasky_Desktop\DAM2-Project-Desktop\DAM2-Project-Desktop\Data\Exports";
            Directory.CreateDirectory(rutaArchivo);
            string rutaCompletaArchivo = Path.Combine(rutaArchivo, "JSON_PRUEBA.json");

            var proyectosList = ListadoDatosClasses.ListadoProyectos;
            JArray Proyectos = (JArray)JToken.FromObject(proyectosList);

            File.WriteAllText(rutaCompletaArchivo, Proyectos.ToString());
            Console.WriteLine("Exportación a JSON completada con éxito.");
            Console.WriteLine($"Datos exportados con éxito a {rutaArchivo}");
        }

    }

}
