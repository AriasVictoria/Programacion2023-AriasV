using Microsoft.AspNetCore.Mvc;
using Programación11_04.Models;

namespace Programación11_04.Controllers
{
    [ApiController]
    [Route("api/materia")]
    public class MateriaController : ControllerBase
    {
        static List<Materias> MateriasList = new List<Materias>()
        {
            new Materias(1, "Matematica"),
            new Materias(2, "Lengua"),
        };
        [HttpGet]
        public List<Materias> ConsultarMateria()
        {
            return MateriasList;
        }
        [HttpPost]
        public int CrearMateria(Materias materia)
        {
            MateriasList.Add(materia);
            return materia.Id;
        }
        [HttpGet("{Id}")]
        public ActionResult ConsultarMateria(int Id)
        {
            var materia = MateriasList.Find(x => x.Id == Id);
            if (materia == null)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpDelete("{Id}")]
        public ActionResult BorrarMateria(int Id)
        {
            var BorrarMateria = MateriasList.Find(x => x.Id == Id);
            if (BorrarMateria == null)
            {
                return NotFound();
            }
            MateriasList.Remove(BorrarMateria);

            return Ok();
        }
    }
}
