using FitRoutine.Domain.Core;
using FitRoutine.Domain.Entities;
using System;
using System.Collections.Generic;

namespace FitRoutine.Domain.Entities
{
    public partial class Activity : BaseEntity
    {
        public int ActivityId { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}

