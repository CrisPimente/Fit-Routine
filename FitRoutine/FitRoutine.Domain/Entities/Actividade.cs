using FitRoutine.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Domain.Entities
{
    public class Actividade : BaseEntity
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int categoriaId { get; set; }
    }
}
