﻿using Microsoft.AspNetCore.Mvc;
using Datos;
using Datos.Models;
using Servicios;
using Servicios.Utils;

namespace Web_API.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase {
        private readonly Context _context;
        private readonly PersonasService _personasService;

        public PersonasController(Context context) {
            _context = context;
            _personasService = new PersonasService(context);
        }
        [HttpGet(Name = "Get Personas")]
        public IActionResult GetPersonas() {
            return Ok(_personasService.GetPersonas());
        }
        [HttpGet("tipo/{tipo}", Name = "Get Personas By Tipo")]
        public IActionResult GetPersonasByTipo(string tipo) {
            return Ok(_personasService.GetPersonasByTipo(tipo));
        }
        [HttpGet("{id}", Name = "Get Persona")]
        public ActionResult<Persona?> GetPersona(int id, [FromQuery] bool? inscripcion, [FromQuery] bool? docente) {
            var persona = _personasService.GetPersona(id, inscripcion, docente);
            return persona == null ? NotFound() : Ok(persona);
        }
        [HttpPost(Name = "Add Persona")]
        public ActionResult AddPersona(Persona persona) {
            _personasService.AddPersona(persona);
            return CreatedAtRoute("Get Persona", new { id = persona.IdPersona }, persona);
        }

        [HttpPut("{id}",Name = "Update Persona")]
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
        [HttpPost("signIn", Name = "SignIn")]
        [Produces("text/plain")]
        public ActionResult<string> SignIn(string nombreUsuario, string clave) {
            var persona = _personasService.SignIn(nombreUsuario, clave);
            if (persona != null) {
                return Ok(JWTService.GenerateToken(persona));
            } else {
                return NotFound();
            }
        }
    }
}
