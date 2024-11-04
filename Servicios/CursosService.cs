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

        public Curso? GetCurso(int id)
        {
            return context.Cursos.Find(id);
        }

        public void UpdateCurso(Curso curso)
        {
            context.Cursos.Update(curso);
            context.SaveChanges();
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
