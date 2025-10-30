using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_Project_Desktop
{
    public static class ListadoDatosClasses
    {
        public static BindingList<Proyecto> ListadoProyectos = new BindingList<Proyecto>();
        public static BindingList<Usuarios> ListadoUsuarios = new BindingList<Usuarios>();
        public static BindingList<Tarea> ListaTareas = new BindingList<Tarea>();

        static ListadoDatosClasses()
        {
            GenerarListaUsuarios();
            GenerarListaTareas();
            GenerarListaProyectos();
        }

        public static void GenerarListaUsuarios()
        {
            // Usuarios DAM2
            ListadoUsuarios.Add(new Usuarios("Juan", "García", new DateTime(2000, 5, 15), "DAM2", "juan.garcia@ies.es", "pass123", "juangarc"));
            ListadoUsuarios.Add(new Usuarios("Carlos", "Ruiz", "De la Fuente", new DateTime(2003, 3, 1), "DAM2", "carlos.ruiz@ies.es", "pass456", "carlosruiz"));
            ListadoUsuarios.Add(new Usuarios("María", "Fernández", new DateTime(2001, 8, 12), "DAM2", "maria.fernandez@ies.es", "pass789", "mariafer"));
            ListadoUsuarios.Add(new Usuarios("David", "Martín", new DateTime(2002, 11, 5), "DAM2", "david.martin@ies.es", "pass101", "davidmar"));
            ListadoUsuarios.Add(new Usuarios("Laura", "Gómez", new DateTime(2000, 12, 25), "DAM2", "laura.gomez@ies.es", "pass202", "lauragom"));

            // Usuarios DAW
            ListadoUsuarios.Add(new Usuarios("Ana", "López", new DateTime(1998, 11, 22), "DAW1", "ana.lopez@ies.es", "pass303", "analopez"));
            ListadoUsuarios.Add(new Usuarios("Pedro", "Sánchez", new DateTime(1999, 4, 18), "DAW2", "pedro.sanchez@ies.es", "pass404", "pedrosan"));
            ListadoUsuarios.Add(new Usuarios("Sofia", "Ramírez", new DateTime(2001, 7, 30), "DAW1", "sofia.ramirez@ies.es", "pass505", "sofiram"));
            ListadoUsuarios.Add(new Usuarios("Javier", "Ortega", new DateTime(2000, 2, 14), "DAW2", "javier.ortega@ies.es", "pass606", "javiort"));

            // Usuarios ASIX
            ListadoUsuarios.Add(new Usuarios("Eva", "Sanz", new DateTime(2001, 7, 7), "ASIX1", "eva.sanz@ies.es", "pass707", "evasanz"));
            ListadoUsuarios.Add(new Usuarios("Miguel", "Díaz", new DateTime(2002, 9, 9), "ASIX2", "miguel.diaz@ies.es", "pass808", "migudiaz"));
            ListadoUsuarios.Add(new Usuarios("Carmen", "Vega", new DateTime(2001, 1, 19), "ASIX1", "carmen.vega@ies.es", "pass909", "carvega"));
            ListadoUsuarios.Add(new Usuarios("Raúl", "Castro", new DateTime(2003, 6, 11), "ASIX2", "raul.castro@ies.es", "pass010", "raulcas"));

            // Profesores
            ListadoUsuarios.Add(new Usuarios("Profesor", "Informática", new DateTime(1980, 3, 10), "PROF", "prof.informatica@ies.es", "prof123", "profinfo"));
            ListadoUsuarios.Add(new Usuarios("Tutor", "DAM2", new DateTime(1975, 8, 22), "PROF", "tutor.dam2@ies.es", "tutor456", "tutordam"));
        }

        public static void GenerarListaTareas()
        {
            // Tareas de Desarrollo
            ListaTareas.Add(new Tarea("Diseño UI/UX", ListadoUsuarios[0], new DateTime(2024, 1, 15), "En progreso"));
            ListaTareas.Add(new Tarea("Desarrollo Backend", ListadoUsuarios[2], new DateTime(2024, 1, 20), "Pendiente"));
            ListaTareas.Add(new Tarea("Maquetación HTML/CSS", ListadoUsuarios[5], new DateTime(2024, 2, 1), "Completada"));
            ListaTareas.Add(new Tarea("Base de Datos SQL", ListadoUsuarios[9], new DateTime(2024, 2, 10), "En progreso"));
            ListaTareas.Add(new Tarea("Testing Unitario", ListadoUsuarios[3], new DateTime(2024, 3, 1), "Pendiente"));
            ListaTareas.Add(new Tarea("Documentación API", ListadoUsuarios[1], new DateTime(2024, 3, 5), "Completada"));
            ListaTareas.Add(new Tarea("Configuración Servidor", ListadoUsuarios[10], new DateTime(2024, 3, 10), "En progreso"));
            ListaTareas.Add(new Tarea("Optimización Código", ListadoUsuarios[4], new DateTime(2024, 3, 15), "Pendiente"));
            ListaTareas.Add(new Tarea("Diseño Logo", ListadoUsuarios[6], new DateTime(2024, 3, 20), "Completada"));
            ListaTareas.Add(new Tarea("Implementación Seguridad", ListadoUsuarios[7], new DateTime(2024, 4, 1), "En progreso"));

            // Tareas de Análisis
            ListaTareas.Add(new Tarea("Análisis Requisitos", ListadoUsuarios[8], new DateTime(2024, 1, 10), "Completada"));
            ListaTareas.Add(new Tarea("Diagramas UML", ListadoUsuarios[11], new DateTime(2024, 1, 25), "Completada"));
            ListaTareas.Add(new Tarea("Planificación Proyecto", ListadoUsuarios[12], new DateTime(2024, 2, 5), "En progreso"));
            ListaTareas.Add(new Tarea("Estudio Viabilidad", ListadoUsuarios[13], new DateTime(2024, 2, 15), "Pendiente"));

            // Tareas de Mantenimiento
            ListaTareas.Add(new Tarea("Revisión Código", ListadoUsuarios[0], new DateTime(2024, 4, 10), "Pendiente"));
            ListaTareas.Add(new Tarea("Actualización Dependencias", ListadoUsuarios[2], new DateTime(2024, 4, 15), "Pendiente"));
            ListaTareas.Add(new Tarea("Backup Base de Datos", ListadoUsuarios[9], new DateTime(2024, 4, 20), "Pendiente"));
        }

        public static void GenerarListaProyectos()
        {
            // Proyecto 1 - Aplicación Móvil
            var proyecto1 = new Proyecto("App Móvil DAM2", new DateTime(2024, 6, 15));
            proyecto1.miembrosProyecto = new List<Usuarios> { ListadoUsuarios[0], ListadoUsuarios[2], ListadoUsuarios[3] };
            proyecto1.tareasProyecto = new List<Tarea> { ListaTareas[0], ListaTareas[1], ListaTareas[5], ListaTareas[8] };
            ListadoProyectos.Add(proyecto1);

            // Proyecto 2 - Portal Web Institucional
            var proyecto2 = new Proyecto("Portal Web Institucional", new DateTime(2024, 7, 1));
            proyecto2.miembrosProyecto = new List<Usuarios> { ListadoUsuarios[1], ListadoUsuarios[5], ListadoUsuarios[6], ListadoUsuarios[7] };
            proyecto2.tareasProyecto = new List<Tarea> { ListaTareas[2], ListaTareas[3], ListaTareas[6], ListaTareas[9] };
            ListadoProyectos.Add(proyecto2);

            // Proyecto 3 - Sistema de Gestión Escolar
            var proyecto3 = new Proyecto("Sistema Gestión Escolar", new DateTime(2024, 8, 20));
            proyecto3.miembrosProyecto = new List<Usuarios> { ListadoUsuarios[8], ListadoUsuarios[9], ListadoUsuarios[10], ListadoUsuarios[12] };
            proyecto3.tareasProyecto = new List<Tarea> { ListaTareas[10], ListaTareas[11], ListaTareas[12], ListaTareas[13] };
            ListadoProyectos.Add(proyecto3);

            // Proyecto 4 - E-commerce
            var proyecto4 = new Proyecto("Tienda Online ASIX", new DateTime(2024, 9, 10));
            proyecto4.miembrosProyecto = new List<Usuarios> { ListadoUsuarios[4], ListadoUsuarios[11], ListadoUsuarios[13] };
            proyecto4.tareasProyecto = new List<Tarea> { ListaTareas[4], ListaTareas[7], ListaTareas[14] };
            ListadoProyectos.Add(proyecto4);

            // Proyecto 5 - Red Social Educativa
            var proyecto5 = new Proyecto("Red Social Educativa", new DateTime(2024, 10, 5));
            proyecto5.miembrosProyecto = new List<Usuarios> { ListadoUsuarios[0], ListadoUsuarios[1], ListadoUsuarios[5], ListadoUsuarios[8] };
            proyecto5.tareasProyecto = new List<Tarea> { ListaTareas[15], ListaTareas[16] };
            ListadoProyectos.Add(proyecto5);

            // Proyecto 6 - App Clima
            var proyecto6 = new Proyecto("Aplicación del Clima", new DateTime(2024, 5, 30));
            proyecto6.miembrosProyecto = new List<Usuarios> { ListadoUsuarios[2], ListadoUsuarios[6] };
            proyecto6.tareasProyecto = new List<Tarea> { ListaTareas[0], ListaTareas[1] };
            ListadoProyectos.Add(proyecto6);

            // Proyecto 7 - Juego Educativo
            var proyecto7 = new Proyecto("Juego Educativo Infantil", new DateTime(2024, 11, 15));
            proyecto7.miembrosProyecto = new List<Usuarios> { ListadoUsuarios[3], ListadoUsuarios[7], ListadoUsuarios[10] };
            proyecto7.tareasProyecto = new List<Tarea> { ListaTareas[8], ListaTareas[9] };
            ListadoProyectos.Add(proyecto7);

            // Proyecto 8 - Sin tareas (para pruebas)
            var proyecto8 = new Proyecto("Proyecto de Prueba", new DateTime(2024, 12, 1));
            proyecto8.miembrosProyecto = new List<Usuarios> { ListadoUsuarios[0] };
            proyecto8.tareasProyecto = new List<Tarea>();
            ListadoProyectos.Add(proyecto8);
        }
    }
}