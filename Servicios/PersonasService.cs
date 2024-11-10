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
            return context.Personas.Include(p => p.IdPlanNavigation!.IdEspecialidadNavigation).ToList();
        }

        public IEnumerable<Persona> GetPersonasByTipo(string tipo) {
            return context.Personas.Where(p => p.TipoPersona == tipo).Include(p => p.IdPlanNavigation!.IdEspecialidadNavigation).ToList();
        }

        public Persona? GetPersona(int id) {
            return context.Personas.Find(id);
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
