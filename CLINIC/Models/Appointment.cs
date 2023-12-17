using System;
using System.Collections.Generic;

namespace CLINIC.Models
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public int? PatientId { get; set; }
        public int? SpecializationId { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; } = null!;
        public string Status { get; set; } = null!;

        public virtual Patient? Patient { get; set; }
        public virtual Specialization? Specialization { get; set; }
    }
}
