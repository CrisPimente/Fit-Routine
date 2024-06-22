using System;
using System.Collections.Generic;

namespace FitRoutine.Web.Models;

public partial class Actividade
{
    public int ActividadId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripción { get; set; }

    public int? CategoriaId { get; set; }

    public virtual Categoria? Categoria { get; set; }

    public virtual ICollection<Sesione> Sesiones { get; set; } = new List<Sesione>();
}
