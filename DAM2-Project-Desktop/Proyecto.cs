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
        private int _nextID = 1;
        public int ID { get; private set; }
        public string titulo { get; set; }
        public DateTime fechaEntrega { get; set; }
        public List<Usuarios> miembrosProyecto { get; set; }
        public List<Tarea> tareasProyecto { get; set; }

            //imagen
        private Bitmap imgProyecto;
        public Bitmap ImgProyecto
        {
            get { return imgProyecto; }
            set { imgProyecto = value ?? GenerarImagenIniciales(titulo, 100); }
        }

        //Metodo
        private Bitmap GenerarImagenIniciales(string titulo, int tamano = 100)
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
            var bitmap = new Bitmap(tamano, tamano);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                // Fondo RECTANGULAR (sin cambios)
                using (var brochaFondo = new SolidBrush(fondoColor))
                    g.FillRectangle(brochaFondo, 0, 0, tamano, tamano);

                // Fuente MÁS GRANDE para una sola letra
                float fontSize = tamano * 0.7f; // 70% del tamaño para una letra más grande

                using (var fuente = new Font("Arial", fontSize, FontStyle.Bold, GraphicsUnit.Pixel))
                using (var brochaTexto = new SolidBrush(Color.White))
                {
                    var formato = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    var areaDibujo = new RectangleF(0, 0, tamano, tamano);

                    // Pequeño ajuste para mejor centrado visual
                    areaDibujo.Y -= tamano * 0.03f;

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
            this.titulo             =   titulo;
            this.miembrosProyecto   =   usuarios;
            this.tareasProyecto     =   tareas;
            this.ImgProyecto        =   imgProyecto;
        }

    }

}
