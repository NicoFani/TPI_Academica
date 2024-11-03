using System;
using System.Collections.Generic;

namespace Datos.Models;

public partial class Comisione
{
    public int IdComision { get; set; }

    public string DescComision { get; set; } = null!;

    public int AnioEspecialidad { get; set; }

    public int IdPlan { get; set; }

    public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();

    public virtual Plane? IdPlanNavigation { get; set; } = null!;
}
