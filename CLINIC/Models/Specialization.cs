using System;
using System.Collections.Generic;

namespace CLINIC.Models
{
    public partial class Specialization
    {
        public Specialization()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int SpecializationId { get; set; }
        public string SpecializationName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
