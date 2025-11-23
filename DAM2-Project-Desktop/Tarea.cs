namespace DAM2_Project_Desktop
{
    public class Tarea
    {
        //atributos
        public string nombreTarea { get; set; }
        public string? descripcionTarea { get; set; }
        public DateTime? fechaInicioTarea { get; set; }
        public DateTime? fechaFinTarea { get; set; }
        public Usuario? responsableAsignado { get; set; }
        public string? statusTarea { get; set; }

        //test
        //constructores

        public Tarea() { }
        public Tarea(string nombreTarea)
        {
            this.nombreTarea = nombreTarea;
        }

        public Tarea(string nombreTarea, Usuario responsableAsignado)
        {
            this.nombreTarea = nombreTarea;
            this.responsableAsignado = responsableAsignado;
        }
        public Tarea(string nombreTarea, Usuario responsableAsignado, DateTime fechaInicio)
        {
            this.nombreTarea = nombreTarea;
            this.responsableAsignado = responsableAsignado;
            this.fechaInicioTarea = fechaInicio;
        }
        public Tarea(string nombreTarea, Usuario responsableAsignado, DateTime fechaInicio, string status)
        {
            this.nombreTarea = nombreTarea;
            this.responsableAsignado = responsableAsignado;
            this.fechaInicioTarea = fechaInicio;
            this.statusTarea = status;
        }

    }
}