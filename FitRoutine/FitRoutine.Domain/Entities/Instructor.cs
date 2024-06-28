using FitRoutine.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Domain.Entities
{
    public class Instructor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }
    }
}
