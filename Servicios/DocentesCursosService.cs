using Datos;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Servicios
{
    public class DocentesCursoService(Context context)
    {
        public IEnumerable<DocentesCurso> GetDocentesCursos()
        {
            return context.DocentesCursos.Include(ai => ai.IdDocenteNavigation).Include(ai => ai.IdCursoNavigation!.IdMateriaNavigation!.IdPlanNavigation!.IdEspecialidadNavigation).Include(doCu => doCu.IdCursoNavigation!.IdComisionNavigation).ToList();
        }

        public IEnumerable<DocentesCurso> GetDocentesCursosByCurso(int idCurso)
        {
            return context.DocentesCursos.Include(ai => ai.IdDocenteNavigation).Where(ai => ai.IdCurso == idCurso).ToList();
        }

        public IEnumerable<DocentesCurso> GetDocentesCursosByDocente(int idDocente)
        {
            return context.DocentesCursos.Include(ai => ai.IdCursoNavigation).Where(ai => ai.IdDocente == idDocente).ToList();
        }

        public DocentesCurso? GetDocenteCurso(int id)
        {
            return context.DocentesCursos.Include(ai => ai.IdDocenteNavigation).Include(ai => ai.IdCursoNavigation).FirstOrDefault(ai => ai.IdDictado == id);
        }

        public bool AddDocenteCurso(DocentesCurso docenteCurso)
        {
            Curso? curso = context.Cursos.Find(docenteCurso.IdCurso);
            Persona? docente = context.Personas.Find(docenteCurso.IdDocente);
            if (curso == null || docente == null || docente.TipoPersona != "Profesor")
            {
                return false;
            }
            else
            {
                context.DocentesCursos.Add(docenteCurso);
                context.SaveChanges();
                return true;
            }
        }

        public void UpdateDocenteCurso(DocentesCurso docenteCurso)
        {
            context.DocentesCursos.Update(docenteCurso);
            context.SaveChanges();
        }

        public bool DeleteDocenteCurso(int id)
        {
            var docenteCurso = context.DocentesCursos.Find(id);
            if (docenteCurso != null)
            {
                context.DocentesCursos.Remove(docenteCurso);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

