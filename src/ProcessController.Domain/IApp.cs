using System;
using System.Collections.Generic;

namespace ProcessController.Domain
{
    public interface IApp
    {
        event Action<string> OnStandardOutputUpdated;

        event Action<bool> OnIsRunningUpdated;

        AppId Id { get; }

        string Name { get; }

        string Path { get; }

        string Command { get; }

        string Arguments { get; }

        Dictionary<string, string> Variables { get; }

        string StandardOutput { get; }

        bool IsRunning { get; }

        bool IsDebug { get; set; }

        void ResetStandardOutput();

        void ReceiveStandardOutput(string data);

        void SetRunning(bool isRunning);
    }
}