using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Tarea
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public Tarea(string titulo, string descripcion, string estado)
        {
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Estado = estado;
        }


    }
}
