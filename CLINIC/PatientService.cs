using CLINIC.Mdbcontext;

namespace CLINIC
{
    internal class PatientService
    {
        private Applicationdbcontext applicationdbcontext;

        public PatientService(Applicationdbcontext applicationdbcontext)
        {
            this.applicationdbcontext = applicationdbcontext;
        }
    }
}