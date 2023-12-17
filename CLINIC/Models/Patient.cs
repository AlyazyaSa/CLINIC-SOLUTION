using System;
using System.Collections.Generic;

namespace CLINIC.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int PatientId { get; set; }
        public string Name { get; set; } = null!;
        public string ContactDetails { get; set; } = null!;

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
