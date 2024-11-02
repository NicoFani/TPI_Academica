using System;
using System.Collections.Generic;

namespace Datos.Models;

public partial class Curso
{
    public int IdCurso { get; set; }

    public int IdMateria { get; set; }

    public int IdComision { get; set; }

    public int AnioCalendario { get; set; }

    public int Cupo { get; set; }

    public virtual ICollection<AlumnosInscripcione> AlumnosInscripciones { get; set; } = new List<AlumnosInscripcione>();

    public virtual ICollection<DocentesCurso> DocentesCursos { get; set; } = new List<DocentesCurso>();

    public virtual Comisione? IdComisionNavigation { get; set; }

    public virtual Materia? IdMateriaNavigation { get; set; }
}
