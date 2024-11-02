using Datos;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Servicios {
    public class AlumnosInscripcionesService(Context context) {
        public IEnumerable<AlumnosInscripcione> GetAlumnosInscripciones() {
            return context.AlumnosInscripciones.Include(ai => ai.IdAlumnoNavigation).Include(ai => ai.IdCursoNavigation).ToList();
        }

        public IEnumerable<AlumnosInscripcione> GetAlumnosInscripcionesByCurso(int idCurso) {
            return context.AlumnosInscripciones.Include(ai => ai.IdAlumnoNavigation).Where(ai => ai.IdCurso == idCurso).ToList();
        }

        public IEnumerable<AlumnosInscripcione> GetAlumnosInscripcionesByAlumno(int idAlumno) {
            return context.AlumnosInscripciones.Include(ai => ai.IdCursoNavigation).Where(ai => ai.IdAlumno == idAlumno).ToList();
        }

        public AlumnosInscripcione? GetAlumnoInscripcion(int id) {
            return context.AlumnosInscripciones.Include(ai => ai.IdAlumnoNavigation).Include(ai => ai.IdCursoNavigation).FirstOrDefault(ai => ai.IdInscripcion == id);
        }

        public void AddAlumnoInscripcion(AlumnosInscripcione alumnoInscripcion) {
            context.AlumnosInscripciones.Add(alumnoInscripcion);
            context.SaveChanges();
        }

        public void UpdateAlumnoInscripcion(AlumnosInscripcione alumnoInscripcion) {
            context.AlumnosInscripciones.Update(alumnoInscripcion);
            context.SaveChanges();
        }

        public bool DeleteAlumnoInscripcion(int id) {
            var alumnoInscripcion = context.AlumnosInscripciones.Find(id);
            if (alumnoInscripcion != null) {
                context.AlumnosInscripciones.Remove(alumnoInscripcion);
                context.SaveChanges();
                return true;
            } else {
                return false;
            }
        }
    }
}
