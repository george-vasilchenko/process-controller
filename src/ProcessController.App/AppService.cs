using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using ProcessController.Data.Repositories;
using ProcessController.Domain;

namespace ProcessController.Service
{
    public class AppService : IAppService
    {
        private readonly IAppRepository repository;

        private readonly Collection<AppWorkingSet> appWorkingSets;

        public AppService(IAppRepository repository)
        {
            this.repository = repository;
            this.appWorkingSets = new Collection<AppWorkingSet>();
        }

        public void CreateAndRunAppProcess(AppId appId)
        {
            var app = this.repository.GetById(appId);
            app.ResetStandardOutput();

            var process = ConfigureProcess(app);

            this.appWorkingSets.Add(new AppWorkingSet
            {
                App = app,
                SystemProcess = process
            });

            process.Start();
            process.BeginOutputReadLine();

            app.SetRunning(true);
        }

        public void TerminateAppProcess(AppId appId)
        {
            var workingSet = this.appWorkingSets.Single(o => o.App.Id.Equals(appId));

            if (!workingSet.SystemProcess.HasExited)
            {
                workingSet.SystemProcess.CancelOutputRead();
                workingSet.SystemProcess.Kill();
            }

            workingSet.App.SetRunning(false);

            this.appWorkingSets.Remove(workingSet);
        }

        public void Add(IApp app)
        {
            if (app is null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            this.repository.Add(app);
        }

        public IReadOnlyCollection<IApp> GetAll()
        {
            var apps = this.repository.GetAll();

            return apps.ToList();
        }

        private Process ConfigureProcess(IApp app)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = app.Path,
                    FileName = app.Command,
                    Arguments = app.Arguments,
                    UseShellExecute = false,
                    ErrorDialog = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                },
                EnableRaisingEvents = true
            };

            foreach (var variable in app.Variables)
            {
                process.StartInfo.EnvironmentVariables.Add(variable.Key, variable.Value);
            }

            process.OutputDataReceived += (s, e) => app.ReceiveStandardOutput(e.Data);
            process.ErrorDataReceived += (s, e) => app.ReceiveStandardOutput(e.Data);
            process.Exited += this.TryCleanupAppProcess;

            return process;
        }

        private void TryCleanupAppProcess(object sender, EventArgs e)
        {
            var process = (Process)sender;
            var workingSet = this.appWorkingSets.SingleOrDefault(o => o.SystemProcess.Id.Equals(process.Id));

            if (workingSet != null)
            {
                this.TerminateAppProcess(workingSet.App.Id);
            }
        }
    }
}