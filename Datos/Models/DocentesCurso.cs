using System;
using System.Collections.Generic;

namespace Datos.Models;

public partial class DocentesCurso
{
    public int IdDictado { get; set; }

    public int IdCurso { get; set; }

    public int IdDocente { get; set; }

    public string Cargo { get; set; } = null!;

    public virtual Curso? IdCursoNavigation { get; set; }

    public virtual Persona? IdDocenteNavigation { get; set; }
}
