using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios;
using Datos;
using Datos.Models;

namespace Web_API.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class AlumnosInscripcionesController : ControllerBase {
        private readonly Context _context;
        private readonly AlumnosInscripcionesService _alInService;

        public AlumnosInscripcionesController(Context context) {
            _context = context;
            _alInService = new AlumnosInscripcionesService(context);
        }
        [HttpGet(Name ="Get All Alumnos Inscripciones")]
        public IActionResult GetAlumnosInscripciones() {
            return Ok(_alInService.GetAlumnosInscripciones());
        }
        [HttpGet("curso/{idCurso}", Name = "Get Alumnos Inscripciones By Curso")]
        public IActionResult GetAlumnosInscripcionesByCurso(int idCurso) {
            return Ok(_alInService.GetAlumnosInscripcionesByCurso(idCurso));
        }
        [HttpGet("alumno/{idAlumno}", Name = "Get Alumnos Inscripciones By Alumno")]
        public IActionResult GetAlumnosInscripcionesByAlumno(int idAlumno) {
            return Ok(_alInService.GetAlumnosInscripcionesByAlumno(idAlumno));
        }
        [HttpGet("{id}", Name = "Get Alumno Inscripcion")]
        public IActionResult GetAlumnoInscripcion(int id) {
            var alIn = _alInService.GetAlumnoInscripcion(id);
            return alIn == null ? NotFound() : Ok(alIn);
        }
        [HttpPost(Name = "Add Alumno Inscripcion")]
        public IActionResult AddAlumnoInscripcion(AlumnosInscripcione alIn) {
            _alInService.AddAlumnoInscripcion(alIn);
            return CreatedAtRoute("Get Alumno Inscripcion", new { id = alIn.IdInscripcion }, alIn);
        }
        [HttpPut(Name = "Update Alumno Inscripcion")]
        public IActionResult UpdateAlumnoInscripcion(int id, AlumnosInscripcione alIn) {
            if (id != alIn.IdInscripcion) {
                return BadRequest();
            } else {
                _alInService.UpdateAlumnoInscripcion(alIn);
                return Ok();
            }
        }
        [HttpDelete("{id}", Name = "Delete Alumno Inscripcion")]
        public IActionResult DeleteAlumnoInscripcion(int id) {
            if (_alInService.DeleteAlumnoInscripcion(id)) {
                return NoContent();
            } else {
                return NotFound();
            }
        }
    }
}
