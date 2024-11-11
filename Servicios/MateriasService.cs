using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Models;
using Microsoft.EntityFrameworkCore;


namespace Servicios {
    public class MateriasService(Context context) {
        public void AddMateria(Materia materia) {
            context.Materias.Add(materia);
            context.SaveChanges();
        }

        public IEnumerable<Materia> GetMaterias() {
            return context.Materias.Include(m => m.IdPlanNavigation).ToList();
        }

        public IEnumerable<Materia> GetMateriasByYear(int year) {
            var query = from cur in context.Cursos
                        join insc in context.AlumnosInscripciones on cur.IdCurso equals insc.IdCurso into inscripcionesGroup
                        from insc in inscripcionesGroup.DefaultIfEmpty()
                        join mat in context.Materias on cur.IdMateria equals mat.IdMateria
                        where cur.AnioCalendario == year
                        group insc by new { mat.IdMateria, mat.DescMateria, mat.HsSemanales, mat.HsTotales, mat.IdPlan } into g
                        select new Materia {
                            IdMateria = g.Key.IdMateria,
                            DescMateria = g.Key.DescMateria,
                            HsSemanales = g.Key.HsSemanales,
                            HsTotales = g.Key.HsTotales,
                            IdPlan = g.Key.IdPlan,
                            CantidadAlumnos = g.Count(insc => insc != null)
                        };
            return query.ToList();
        }

        public Materia? GetMateria(int id) {
            return context.Materias.Find(id);
        }

        public void UpdateMateria(Materia materia) {
            context.Materias.Update(materia);
            context.SaveChanges();
        }

        public bool DeleteMateria(int id) {
            var materia = context.Materias.Find(id);
            if (materia != null) {
                context.Materias.Remove(materia);
                context.SaveChanges();
                return true;
            } else {
                return false;
            }
        }
    }
}
