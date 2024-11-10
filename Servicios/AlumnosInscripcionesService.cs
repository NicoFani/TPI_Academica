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
            return context.AlumnosInscripciones.Include(ai => ai.IdAlumnoNavigation).Include(ai => ai.IdCursoNavigation).ThenInclude(curs => curs!.IdMateriaNavigation).ThenInclude(mat => mat!.IdPlanNavigation).ThenInclude(plan => plan!.IdEspecialidadNavigation).Include(ai => ai.IdCursoNavigation!.IdComisionNavigation).ToList();
        }

        public IEnumerable<AlumnosInscripcione> GetAlumnosInscripcionesByCurso(int idCurso) {
            return context.AlumnosInscripciones.Include(ai => ai.IdAlumnoNavigation).Where(ai => ai.IdCurso == idCurso).ToList();
        }

        public IEnumerable<AlumnosInscripcione> GetAlumnosInscripcionesByAlumno(int idAlumno)
        {
            return context.AlumnosInscripciones
                .Include(ai => ai.IdCursoNavigation)
                    .ThenInclude(curso => curso.IdMateriaNavigation)
                .Where(ai => ai.IdAlumno == idAlumno)
                .ToList();
        }


        public AlumnosInscripcione? GetAlumnoInscripcion(int id) {
            return context.AlumnosInscripciones.Include(ai => ai.IdAlumnoNavigation).Include(ai => ai.IdCursoNavigation).FirstOrDefault(ai => ai.IdInscripcion == id);
        }

        public bool AddAlumnoInscripcion(AlumnosInscripcione alumnoInscripcion) {
            Curso? curso = context.Cursos.Find(alumnoInscripcion.IdCurso);
            Persona? alumno = context.Personas.Find(alumnoInscripcion.IdAlumno);
            if (curso == null || alumno == null || alumno.TipoPersona != "Alumno") {
                return false;
            } else {
                int cantidad = context.AlumnosInscripciones.Count(ai => ai.IdCurso == curso.IdCurso);
                if (curso.Cupo > cantidad) {
                    context.AlumnosInscripciones.Add(alumnoInscripcion);
                    context.SaveChanges();
                    return true;
                } else {
                    return false;
                }
            }
        }

        public bool UpdateAlumnoInscripcion(AlumnosInscripcione alIn) {
            AlumnosInscripcione? old = context.AlumnosInscripciones.Where(alumnInsc => alumnInsc.IdInscripcion == alIn.IdInscripcion).First();
            // only can change the condition and the note
            if (old == null || old.IdCurso != alIn.IdCurso || old.IdAlumno != alIn.IdAlumno) {
                return false;
            } else {
                context.Entry(old).State = EntityState.Detached;
                context.AlumnosInscripciones.Update(alIn);
                context.SaveChanges();
                return true;
            }
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
