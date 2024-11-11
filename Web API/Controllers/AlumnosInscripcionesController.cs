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
        [HttpGet(Name = "Get All Alumnos Inscripciones")]
        public ActionResult<IEnumerable<AlumnosInscripcione>> GetAlumnosInscripciones() {
            return Ok(_alInService.GetAlumnosInscripciones());
        }
        [HttpGet("curso/{idCurso}", Name = "Get Alumnos Inscripciones By Curso")]
        public ActionResult<IEnumerable<AlumnosInscripcione>> GetAlumnosInscripcionesByCurso(int idCurso) {
            return Ok(_alInService.GetAlumnosInscripcionesByCurso(idCurso));
        }
        [HttpGet("alumno/{idAlumno}", Name = "Get Alumnos Inscripciones By Alumno")]
        public ActionResult<IEnumerable<AlumnosInscripcione>> GetAlumnosInscripcionesByAlumno(int idAlumno) {
            return Ok(_alInService.GetAlumnosInscripcionesByAlumno(idAlumno));
        }
        [HttpGet("{id}", Name = "Get Alumno Inscripcion")]
        public ActionResult<AlumnosInscripcione> GetAlumnoInscripcion(int id) {
            var alIn = _alInService.GetAlumnoInscripcion(id);
            return alIn == null ? NotFound() : Ok(alIn);
        }
        [HttpPost(Name = "Add Alumno Inscripcion")]
        public IActionResult AddAlumnoInscripcion(AlumnosInscripcione alIn) {
            bool success = _alInService.AddAlumnoInscripcion(alIn);
            if (!success) {
                return BadRequest();
            } else {
                return CreatedAtRoute("Get Alumno Inscripcion", new { id = alIn.IdInscripcion }, alIn);
            }
        }
        [HttpPut("{id}", Name = "Update Alumno Inscripcion")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdateAlumnoInscripcion(int id, AlumnosInscripcione alIn) {
            if (id != alIn.IdInscripcion) {
                return BadRequest();
            } else {
                bool success = _alInService.UpdateAlumnoInscripcion(alIn);
                return success ? NoContent() : BadRequest();
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
