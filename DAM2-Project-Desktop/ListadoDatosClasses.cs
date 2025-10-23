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
        static ListadoDatosClasses()
        {
            GenerarListaDePrueba();
        }


        public static void GenerarListaDePrueba()
        {
            // --- 1. Usuario Normal (DAM2) ---
            ListadoUsuarios.Add(new Usuarios(
                nombre: "Juan",
                apellido1: "García",
                fechaNacimiento: new DateTime(2000, 5, 15),
                classe: "DAM2",
                email: "juan.garcia@ies.es",
                password: "hashed_password_jg",
                userName: "juangarc"
            ));

            // --- 2. Usuario de Clase Diferente (DAW1) ---
            ListadoUsuarios.Add(new Usuarios(
                nombre: "Ana",
                apellido1: "López",
                fechaNacimiento: new DateTime(1998, 11, 22),
                classe: "DAW1",
                email: "ana.lopez@ies.es",
                password: "hashed_password_al",
                userName: "analopez"
            ));

            // --- 3. Usuario con Apellido Compuesto (Full Constructor) ---
            ListadoUsuarios.Add(new Usuarios(
                nombre: "Carlos",
                apellido1: "Ruiz",
                apellido2: "De la Fuente",
                fechaNacimiento: new DateTime(2003, 3, 1),
                classe: "DAM2",
                email: "carlos.ruiz@ies.es",
                password: "hashed_password_cr",
                userName: "carlosruiz"
            ));

            // --- 4. Usuario para Prueba de Búsqueda (Username Corto) ---
            ListadoUsuarios.Add(new Usuarios(
                nombre: "Eva",
                apellido1: "Sanz",
                fechaNacimiento: new DateTime(2001, 7, 7),
                classe: "ASIX1",
                email: "eva.sanz@ies.es",
                password: "hashed_password_es",
                userName: "evasanz"
            ));

        }


    }
}
