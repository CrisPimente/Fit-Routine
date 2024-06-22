using FitRoutine.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Domain.Entities
{
    public class Usuario : Persona
    {
        public string nombre {  get; set; }
        public string apellido { get; set; }
        public string email {  get; set; }
        public string contraseña { get; set; }
        public DateOnly fechanacimiento { get; set; }
        public string genero { get; set; }
        public DateTime fecharegistro { get; set; }
        public string direccion { get; set; }
    }
}
