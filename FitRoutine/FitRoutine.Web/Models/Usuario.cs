using System;
using System.Collections.Generic;

namespace FitRoutine.Web.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public DateOnly? FechaNacimiento { get; set; }

    public string? Genero { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Sesione> Sesiones { get; set; } = new List<Sesione>();
}
