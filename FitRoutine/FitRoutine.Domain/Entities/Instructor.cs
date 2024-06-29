using FitRoutine.Domain.Core;
using FitRoutine.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Domain.Entities
{
    public partial class Instructor : BaseEntity
    {
        public int InstructorId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Specialty { get; set; }

        public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}