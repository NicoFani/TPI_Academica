using System;
using System.Collections.Generic;

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
}
