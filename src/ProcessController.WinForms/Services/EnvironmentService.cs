using System.Windows.Forms;
using ProcessController.Service;

namespace ProcessController.WinForms.Services
{
    public class EnvironmentService : IEnvironmentService
    {
        public void Close()
        {
            Application.Exit();
        }
    }
}