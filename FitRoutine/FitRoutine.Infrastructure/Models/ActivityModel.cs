using FitRoutine.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Infrastructure.Models
{
    public class ActivityModel
    {
        public int ActivityId { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}
