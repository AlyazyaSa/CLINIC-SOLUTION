using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINIC.model
{
   public class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }

       //----------
        public List<Appointment> Appointments { get; set; }
    }
}
