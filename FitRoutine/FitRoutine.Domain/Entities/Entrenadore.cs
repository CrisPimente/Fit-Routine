using FitRoutine.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Domain.Entities
{
    public class Entrenadore : BaseEntity
    {
        public string nombre {  get; set; }
        public string apellido { get; set; }
        public string especialidad { get; set; }
    }
}
