using System.Collections.Generic;
using ProcessController.Domain;

namespace ProcessController.Service
{
    public interface IAppService
    {
        IReadOnlyCollection<IApp> GetAll();

        void Add(IApp app);

        void CreateAndRunAppProcess(AppId appId);

        void TerminateAppProcess(AppId appId);
        void StopAllProcesses();
    }
}