using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Models;
using Microsoft.EntityFrameworkCore;


namespace Servicios {
    public class PersonasService(Context context) {
        public void AddPersona(Persona persona) {
            context.Personas.Add(persona);
            context.SaveChanges();
        }

        public IEnumerable<Persona> GetPersonas() {
            return context.Personas.ToList();
        }

        public IEnumerable<Persona> GetPersonasByTipo(string tipo) {
            return context.Personas.Where(p => p.TipoPersona == tipo).ToList();
        }

        public Persona? GetPersona(int id, bool? inscripcion, bool? docente) {
            IQueryable<Persona> persona = context.Personas;
            if (inscripcion == true) {
                persona = persona.Include(p => p.AlumnosInscripciones).ThenInclude(insc => insc.IdCursoNavigation!.IdMateriaNavigation);
                persona = persona.Include(p => p.AlumnosInscripciones).ThenInclude(insc => insc.IdCursoNavigation!.IdComisionNavigation);
            }
            if (docente == true) {
                persona = persona.Include(p => p.DocentesCursos).ThenInclude(doc => doc.IdCursoNavigation!.AlumnosInscripciones).ThenInclude(insc => insc.IdAlumnoNavigation);
                persona = persona.Include(p => p.DocentesCursos).ThenInclude(doc => doc.IdCursoNavigation!.IdMateriaNavigation);
                persona = persona.Include(p => p.DocentesCursos).ThenInclude(doc => doc.IdCursoNavigation!.IdComisionNavigation);
            }
            return persona.FirstOrDefault(p => p.IdPersona == id);
        }

        public void UpdatePersona(Persona persona) {
            context.Personas.Update(persona);
            context.SaveChanges();
        }

        public bool DeletePersona(int id) {
            var persona = context.Personas.Find(id);
            if (persona != null) {
                context.Personas.Remove(persona);
                context.SaveChanges();
                return true;
            } else {
                return false;
            }
        }

        public Persona? SignIn(string nombreUsuario, string clave) {
            return context.Personas.FirstOrDefault(p => p.NombreUsuario == nombreUsuario && p.Clave == clave);
        }
    }
}
