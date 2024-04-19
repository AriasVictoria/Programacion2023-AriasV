using Microsoft.AspNetCore.Mvc;
using Programación11_04.Models;
using System.Globalization;

namespace Programación11_04.Controllers
{
    [ApiController]
    [Route("api/alumnos")]
    public class AlumnosController : ControllerBase
    {
        static List<Alumnos> Alumnoslist = new List<Alumnos>()
        {
            new Alumnos(1,"Victoria", "Arias"),
            new Alumnos(2,"Valentina", "Arias")
        };

        [HttpGet]
        public List<Alumnos> ConsultarAlumnos()
        {
            return Alumnoslist;
        }

        [HttpPost]
        public int CrearAlumnos(Alumnos alumno)
        {
            Alumnoslist.Add(alumno);
            return alumno.Id;
        }

        [HttpPut("{Id}")]
        public ActionResult ActualizarAlumno(int Id, Alumnos alumno)
        {
            var alumnoActualizar = Alumnoslist.Find(x => x.Id == Id);

            if (alumnoActualizar == null)
            {
                return NotFound();
            }

            alumnoActualizar.Nombre = alumno.Nombre;
            alumnoActualizar.Apellido = alumno.Apellido;

            return Ok();
        }
        [HttpGet("{Id}")]
        public ActionResult ConsultarAlumno(int Id)
        {
            var alumno = Alumnoslist.Find(x => x.Id == Id);
            if (alumno == null)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpDelete("{Id}")]
        public ActionResult BorrarAlumno(int Id)
        {
            var alumnoBorrar = Alumnoslist.Find(x => x.Id == Id);
            if (alumnoBorrar == null)
            {
                return NotFound();
            }
            Alumnoslist.Remove(alumnoBorrar);

            return Ok();
        }
    }
}
