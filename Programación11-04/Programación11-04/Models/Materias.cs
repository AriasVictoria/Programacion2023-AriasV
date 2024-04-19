using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programación11_04.Models
{
    public class Materias
    {
        public int Id { get; set; }
        public string Nombre_Materias { get; set; }

        public Materias (int id, string materia)
        {
            Id = id;
            Nombre_Materias = materia;
            
        }
    }
}
