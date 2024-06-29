using FitRoutine.Domain.Core;
using FitRoutine.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Domain.Entities
{
    public partial class Session : BaseEntity
    {
        public int SessionId { get; set; }

        public DateTime Date { get; set; }

        public int ActivityId { get; set; }

        public int InstructorId { get; set; }

        public int UserId { get; set; }

        public virtual Activity Activity { get; set; } = null!;

        public virtual Instructor Instructor { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}