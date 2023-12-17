using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINIC.model
{
    public class Specialization
    {
        public int SpecializationID { get; set; }
        public string SpecializationName { get; set; }
        public string Description { get; set; }

        //------------------------
        public List<Appointment> Appointments { get; set; }
    }
}
