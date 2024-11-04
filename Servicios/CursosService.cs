using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Models;
using Microsoft.EntityFrameworkCore;


namespace Servicios
{
    public class CursosService(Context context)
    {
        public void AddCurso(Curso curso)
        {
            context.Cursos.Add(curso);
            context.SaveChanges();
        }

        public IEnumerable<Curso> GetCursos()
        {
            return context.Cursos.ToList();
        }

        public IEnumerable<Curso> GetCursosByMateria(int materia)
        {
            return context.Cursos.Where(p => p.IdMateria == materia).ToList();
        }

        public IEnumerable<Curso> GetCursosByComision(int comision)
        {
            return context.Cursos.Where(p => p.IdComision == comision).ToList();
        }

        public Curso? GetCurso(int id)
        {
            return context.Cursos.Find(id);
        }

        public bool UpdateCurso(Curso curs)
        {
            Curso? old = context.Cursos.Where(cur => cur.IdCurso == curs.IdCurso).First();
            // no permite cambiar materia y comision
            if (old == null || old.IdCurso != curs.IdCurso || old.IdMateria != curs.IdMateria || old.IdComision != curs.IdComision)
            {
                return false;
            }
            else
            {
                context.Entry(old).State = EntityState.Detached;
                context.Cursos.Update(curs);
                context.SaveChanges();
                return true;
            }
        }

        public bool DeleteCurso(int id)
        {
            var curso = context.Cursos.Find(id);
            if (curso != null)
            {
                context.Cursos.Remove(curso);
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
