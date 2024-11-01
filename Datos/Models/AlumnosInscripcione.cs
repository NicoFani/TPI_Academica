using System;
using System.Collections.Generic;

namespace Datos.Models;

public partial class AlumnosInscripcione
{
    public int IdInscripcion { get; set; }

    public int IdAlumno { get; set; }

    public int IdCurso { get; set; }

    public string Condicion { get; set; } = null!;

    public int? Nota { get; set; }

    public virtual Persona IdAlumnoNavigation { get; set; } = null!;

    public virtual Curso IdCursoNavigation { get; set; } = null!;
}
