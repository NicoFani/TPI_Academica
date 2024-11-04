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
        [HttpGet("materia/{materia}", Name = "Get Cursos By Materia")]
        public IActionResult GetCursosByMateria(int materia)
        {
            return Ok(_cursosService.GetCursosByMateria(materia));
        }
        [HttpGet("comision/{comision}", Name = "Get Cursos By Comision")]
        public IActionResult GetCursosByComision(int comision)
        {
            return Ok(_cursosService.GetCursosByComision(comision));
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

        [HttpPut("{id}", Name = "Update Curso")]
        public IActionResult UpdateCurso(int id, Curso curso)
        {
            if (id != curso.IdCurso)
            {
                return BadRequest();
            }
            else
            {
                bool success = _cursosService.UpdateCurso(curso);
                return success ? NoContent() : NotFound();
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

