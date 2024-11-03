using Microsoft.AspNetCore.Mvc;
using Datos;
using Datos.Models;
using Servicios;
using Servicios.Utils;

namespace Web_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly Context _context;
        private readonly CursosService _cursosService;

        public CursosController(Context context)
        {
            _context = context;
            _cursosService = new CursosService(context);
        }
        [HttpGet(Name = "Get Cursos")]
        public IActionResult Cursos()
        {
            return Ok(_cursosService.GetCursos());
        }
        [HttpGet("{id}", Name = "Get Curso")]
        public IActionResult GetCurso(int id)
        {
            var curso = _cursosService.GetCurso(id);
            return curso == null ? NotFound() : Ok(curso);
        }
        [HttpPost(Name = "Add Curso")]
        public ActionResult AddCurso(Curso curso)
        {
            _cursosService.AddCurso(curso);
            return CreatedAtRoute("Get Curso", new { id = curso.IdCurso }, curso);
        }

        [HttpPut(Name = "Update Curso")]
        public IActionResult UpdateCurso(int id, Curso curso)
        {
            if (id != curso.IdCurso)
            {
                return BadRequest();
            }
            else
            {
                _cursosService.UpdateCurso(curso);
                return Ok();
            }
        }
        [HttpDelete("{id}", Name = "Delete Curso")]
        public IActionResult DeleteCurso(int id)
        {
            if (_cursosService.DeleteCurso(id))
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

