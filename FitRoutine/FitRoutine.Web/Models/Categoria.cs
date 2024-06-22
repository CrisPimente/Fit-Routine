using System;
using System.Collections.Generic;

namespace FitRoutine.Web.Models;

public partial class Categoria
{
    public int CategoriaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripción { get; set; }

    public virtual ICollection<Actividade> Actividades { get; set; } = new List<Actividade>();
}
