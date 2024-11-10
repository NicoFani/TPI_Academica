using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios;
using Datos;
using Datos.Models;

namespace Web_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DocentesCursosController : ControllerBase
    {
        private readonly Context _context;
        private readonly DocentesCursoService _doCuService;

        public DocentesCursosController(Context context)
        {
            _context = context;
            _doCuService = new DocentesCursoService(context);
        }
        [HttpGet(Name = "Get All Docentes Cursos")]
        public IActionResult GetDocentesCursos()
        {
            return Ok(_doCuService.GetDocentesCursos());
        }
        [HttpGet("curso/{idCurso}", Name = "Get Docentes Cursos By Curso")]
        public IActionResult GetDocentesCursosByCurso(int idCurso)
        {
            return Ok(_doCuService.GetDocentesCursosByCurso(idCurso));
        }
        [HttpGet("docente/{idDocente}", Name = "Get Docentes Cursos By Docente")]
        public IActionResult GetDocentesCursosByDocente(int idDocente)
        {
            return Ok(_doCuService.GetDocentesCursosByDocente(idDocente));
        }
        [HttpGet("{id}", Name = "Get Docente Curso")]
        public IActionResult GetDocenteCurso(int id)
        {
            var alIn = _doCuService.GetDocenteCurso(id);
            return alIn == null ? NotFound() : Ok(alIn);
        }
        [HttpPost(Name = "Add Docente Curso")]
        public IActionResult AddDocenteCurso(DocentesCurso doCur)
        {
            bool success = _doCuService.AddDocenteCurso(doCur);
            if (!success) {
                return BadRequest();
            } else {  
                return CreatedAtRoute("Get Docente Curso", new { id = doCur.IdDictado }, doCur);
            }
        }
        [HttpPut("{id}", Name = "Update Docente Curso")]
        public IActionResult UpdateDocenteCurso(int id, DocentesCurso doCur)
        {
            if (id != doCur.IdDictado)
            {
                return BadRequest();
            }
            else
            {
                _doCuService.UpdateDocenteCurso(doCur);
                return Ok();
            }
        }
        [HttpDelete("{id}", Name = "Delete Docente Curso")]
        public IActionResult DeleteDocenteCurso(int id)
        {
            if (_doCuService.DeleteDocenteCurso(id))
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
