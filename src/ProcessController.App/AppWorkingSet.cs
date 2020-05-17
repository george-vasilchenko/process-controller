using System.Diagnostics;
using ProcessController.Domain;

namespace ProcessController.Service
{
    public class AppWorkingSet
    {
        public IApp App { get; set; }

        public Process SystemProcess { get; set; }
    }
}