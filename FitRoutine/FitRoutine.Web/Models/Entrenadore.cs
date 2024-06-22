using System;
using System.Collections.Generic;

namespace FitRoutine.Web.Models;

public partial class Entrenadore
{
    public int EntrenadorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Especialidad { get; set; }

    public virtual ICollection<Sesione> Sesiones { get; set; } = new List<Sesione>();
}
