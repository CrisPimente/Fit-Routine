using FitRoutine.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Domain.Entities
{
    public class Session : BaseEntity
    {
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public int InstructorId { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
    }
}