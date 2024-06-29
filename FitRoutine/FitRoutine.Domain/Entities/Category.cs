using FitRoutine.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Domain.Entities
{
    public partial class Category : BaseEntity
    {
        public int CategoryId { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();
    }
}