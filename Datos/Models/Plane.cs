using System;
using System.Collections.Generic;

namespace Datos.Models;

public partial class Plane
{
    public int IdPlan { get; set; }

    public string DescPlan { get; set; } = null!;

    public int IdEspecialidad { get; set; }

    public virtual ICollection<Comisione> Comisiones { get; set; } = new List<Comisione>();

    public virtual Especialidade IdEspecialidadNavigation { get; set; } = null!;

    public virtual ICollection<Materia> Materia { get; set; } = new List<Materia>();

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
