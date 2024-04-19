using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programación11_04.Models
{
    public class Cursos
    {
        public int Id { get; set; }
        public string Curso { get; set; }
        public int CantidadAlumno { get; set; }

        public Cursos(int id,string curso, int cantidadAlumno)
        {
            Id = Id;
            Curso = curso;
            CantidadAlumno = cantidadAlumno;
        }

    }
}
