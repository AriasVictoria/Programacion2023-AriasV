using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class GestorTareas
    {
        //LISTA, OBJETO TAREA
        private List<Tarea> tareas;
        public void AgregarTarea(string titulo, string descripcion, string estado)
        {
            Tarea nuevaTarea = new Tarea(titulo, descripcion, estado);
            tareas.Add(nuevaTarea);
        }

    }
}
