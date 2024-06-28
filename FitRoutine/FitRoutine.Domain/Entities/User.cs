using FitRoutine.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitRoutine.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Address { get; set; }
    }
}