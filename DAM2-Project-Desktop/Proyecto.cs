using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
    


}
