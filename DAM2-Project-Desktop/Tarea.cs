namespace DAM2_Project_Desktop
{
    public class Tarea
    {
        //atributos
        public string nombreTarea { get; set; }
        public string descripcionTarea { get; set; }
        public DateTime fechaInicioTarea { get; set; }
        public DateTime fechaFinTarea { get; set; }
        public Usuarios responsableAsignado { get; set; }
        public string statusTarea { get; set; }


        //constructores
         
        public Tarea(string nombreTarea)
        {
            this.nombreTarea = nombreTarea;
        }

        public Tarea(string nombreTarea, Usuarios responsableAsignado)
        {
            this.nombreTarea = nombreTarea;
            this.responsableAsignado = responsableAsignado;
        }
        public Tarea(string nombreTarea, Usuarios responsableAsignado, DateTime fechaInicio)
        {
            this.nombreTarea = nombreTarea;
            this.responsableAsignado = responsableAsignado;
            this.fechaInicioTarea = fechaInicio;
        }
        public Tarea(string nombreTarea, Usuarios responsableAsignado, DateTime fechaInicio, string status)
        {
            this.nombreTarea = nombreTarea;
            this.responsableAsignado = responsableAsignado;
            this.fechaInicioTarea = fechaInicio;
            this.statusTarea = status;
        }

    }
}