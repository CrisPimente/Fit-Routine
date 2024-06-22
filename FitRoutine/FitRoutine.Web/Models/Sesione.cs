using System;
using System.Collections.Generic;

namespace FitRoutine.Web.Models;

public partial class Sesione
{
    public int SesionId { get; set; }

    public int? UsuarioId { get; set; }

    public int? ActividadId { get; set; }

    public int? EntrenadorId { get; set; }

    public DateTime Fecha { get; set; }

    public int? Duración { get; set; }

    public virtual Actividade? Actividad { get; set; }

    public virtual Entrenadore? Entrenador { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
