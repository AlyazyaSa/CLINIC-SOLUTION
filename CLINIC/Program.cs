using CLINIC.Mdbcontext;
using CLINIC.model;

namespace CLINIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Patient = new PatientService (new Applicationdbcontext());


        }
    }
}