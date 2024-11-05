using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models;

public partial class Materia
{
    public int IdMateria { get; set; }

    public string DescMateria { get; set; } = null!;

    public int HsSemanales { get; set; }

    public int HsTotales { get; set; }

    public int IdPlan { get; set; }

    public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();

    public virtual Plane? IdPlanNavigation { get; set; }

    // para getAll by year, se usa en reportes
    [NotMapped]
    public int? CantidadAlumnos { get; set; }
}
