using System;
using System.Collections.Generic;

namespace Datos.Models;

public partial class DocentesCurso
{
    public int IdDictado { get; set; }

    public int IdCurso { get; set; }

    public int IdDocente { get; set; }

    public int Cargo { get; set; }

    public virtual Curso IdCursoNavigation { get; set; } = null!;

    public virtual Persona IdDocenteNavigation { get; set; } = null!;
}
