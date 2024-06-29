using FitRoutine.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Domain.Entities
{
    public partial class User : BaseEntity
    {
        public int UserId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public DateTime RegistrationDate { get; set; }

        public string? Gender { get; set; }

        public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}