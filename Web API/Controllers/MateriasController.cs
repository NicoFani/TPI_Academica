using Microsoft.AspNetCore.Mvc;
using Datos;
using Datos.Models;
using Servicios;
using Servicios.Utils;

namespace Web_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private readonly Context _context;
        private readonly MateriasService _materiasService;

        public MateriasController(Context context)
        {
            _context = context;
            _materiasService = new MateriasService(context);
        }
        [HttpGet(Name = "Get Materias")]
        public IActionResult Materias()
        {
            return Ok(_materiasService.GetMaterias());
        }
        [HttpGet("{id}", Name = "Get Materia")]
        public IActionResult GetMateria(int id)
        {
            var materia = _materiasService.GetMateria(id);
            return materia == null ? NotFound() : Ok(materia);
        }
        [HttpPost(Name = "Add Materia")]
        public ActionResult AddMateria(Materia materia)
        {
            Console.WriteLine(materia);
            _materiasService.AddMateria(materia);
            return CreatedAtRoute("Get Materia", new { id = materia.IdMateria }, materia);
        }

        [HttpPut("{id}", Name = "Update Materia")]
        public IActionResult UpdateMateria(int id, Materia materia)
        {
            if (id != materia.IdMateria)
            {
                return BadRequest();
            }
            else
            {
                _materiasService.UpdateMateria(materia);
                return Ok();
            }
        }
        [HttpDelete("{id}", Name = "Delete Materia")]
        public IActionResult DeleteMateria(int id)
        {
            if (_materiasService.DeleteMateria(id))
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
