using FitRoutine.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Domain.Entities
{
    public class Sesione : BaseEntity
    {
        public int usuarioId { get; set; }
        public int actividaaId { get; set; }
        public int entrenadorId { get; set; }
        public DateTime fecha {  get; set; }
        public int duracion { get; set; }
    }
}
