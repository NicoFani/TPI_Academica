using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Datos;
using Datos.Models;
using Servicios;

namespace Web_API.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase {
        private readonly Datos.Context _context;
        private readonly PersonasService _personasService;

        public PersonasController(Datos.Context context) {
            _context = context;
            _personasService = new PersonasService(context);
        }

        [HttpGet(Name = "Get Personas")]
        public IActionResult GetPersonas() {
            return Ok(_personasService.GetPersonas());
        }
        [HttpGet("{id}", Name = "Get Persona")]
        public IActionResult GetPersona(int id) {
            var persona = _personasService.GetPersona(id);
            return persona == null ? NotFound() : Ok(persona);
        }

        [HttpPost(Name = "Add Persona")]
        public ActionResult AddPersona(Persona persona) {
            _personasService.AddPersona(persona);
            return CreatedAtRoute("Get Persona", new { id = persona.IdPersona }, persona);
        }

        [HttpPut(Name = "Update Persona")]
        public IActionResult UpdatePersona(int id, Persona persona) {
            if (id != persona.IdPersona) {
                return BadRequest();
            } else {
                _personasService.UpdatePersona(persona);
                return Ok();
            }
        }

        [HttpDelete("{id}", Name = "Delete Persona")]
        public IActionResult DeletePersona(int id) {
            if (_personasService.DeletePersona(id)) {
                return NoContent();
            } else {
                return NotFound();
            }
        }
    }
}
