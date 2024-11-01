using System;
using System.Collections.Generic;

namespace Datos.Models;

public partial class Persona
{
    public int IdPersona { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public DateTime FechaNac { get; set; }

    public int? Legajo { get; set; }

    public int TipoPersona { get; set; }

    public int IdPlan { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public bool? Habilitado { get; set; }

    public bool? CambiaClave { get; set; }

    public virtual ICollection<AlumnosInscripcione> AlumnosInscripciones { get; set; } = new List<AlumnosInscripcione>();

    public virtual ICollection<DocentesCurso> DocentesCursos { get; set; } = new List<DocentesCurso>();

    public virtual Plane IdPlanNavigation { get; set; } = null!;
}
