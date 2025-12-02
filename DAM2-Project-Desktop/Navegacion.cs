using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_Project_Desktop
{
    internal class Navegacion
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
    
    public static Point FormInicialLocation(Form frm)
        {
            return frm.Location;
        }

        public static Size FormInicialSize(Form frm)
        {
            return frm.Size;
        }

    }
}
