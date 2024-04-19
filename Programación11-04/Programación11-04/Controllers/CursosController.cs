using Microsoft.AspNetCore.Mvc;
using Programación11_04.Models;

namespace Programación11_04.Controllers
{
    [ApiController]
    [Route("api/cursos")]
    public class CursosController : ControllerBase
    {
        static List<Cursos> CursosList = new List<Cursos>()
        {
            new Cursos(1, "Primero A", 25),
            new Cursos(2, "Segundo B", 36)
        };

        [HttpGet]
        public List<Cursos> ConsultarCurso()
        {
            return CursosList;
        }

        [HttpPost]
        public int AgregarCurso(Cursos cursos)
        {
            CursosList.Add(cursos);
            return cursos.Id;
        }

        [HttpPut("{Id}")]
        public ActionResult ActualizarCurso(int Id, Cursos curso)
        {
            var alumnoActualizar = CursosList.Find(x => x.Id == Id);

            if (alumnoActualizar == null)
            {
                return NotFound();
            }

            alumnoActualizar.CantidadAlumno = curso.CantidadAlumno;

            return Ok();
        }
        [HttpGet("{Id}")]
        public ActionResult ConsultarCurso(int Id)
        {
            var alumno = CursosList.Find(x => x.Id == Id);
            if (alumno == null)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpDelete("{Id}")]
        public ActionResult BorrarCurso(int Id)
        {
            var BorrarCurso = CursosList.Find(x => x.Id == Id);
            if (BorrarCurso == null)
            {
                return NotFound();
            }
            CursosList.Remove(BorrarCurso);

            return Ok();
        }
    }
}
