using System;
using Newtonsoft.Json;

namespace ProcessController.Domain
{
    public class App : IApp
    {
        private App(string name, string path, string command = "", string arguments = "")
        {
            this.Id = new AppId(Guid.NewGuid());

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("message", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("message", nameof(path));
            }

            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            if (arguments is null)
            {
                throw new ArgumentNullException(nameof(arguments));
            }

            this.Name = name;
            this.Path = path;
            this.Command = command;
            this.Arguments = arguments;
        }

        [JsonConstructor]
        private App(AppId id, string name, string path, string command, string arguments)
        {
            this.Id = id;
            this.Name = name;
            this.Path = path;
            this.Command = command;
            this.Arguments = arguments;
        }

        public event Action<string> OnStandardOutputUpdated;

        public event Action<bool> OnIsRunningUpdated;

        public AppId Id { get; }

        public string Name { get; }

        public string Path { get; }

        public string Command { get; }

        public string Arguments { get; }

        [JsonIgnore]
        public string StandardOutput { get; private set; }

        [JsonIgnore]
        public bool IsRunning { get; private set; }

        public static IApp CreateNew()
        {
            return new App("Unnamed", ".");
        }

        public static App CreateFromSpecification(IApp processSpecificaiton)
        {
            if (processSpecificaiton is null)
            {
                throw new ArgumentNullException(nameof(processSpecificaiton));
            }

            return new App(
                processSpecificaiton.Name,
                processSpecificaiton.Path,
                processSpecificaiton.Command,
                processSpecificaiton.Arguments);
        }

        public void SetRunning(bool isRunning)
        {
            this.IsRunning = isRunning;

            this.OnIsRunningUpdated?.Invoke(this.IsRunning);
        }

        public void ReceiveStandardOutput(string data)
        {
            if (data is null)
            {
                return;
            }

            var current = string.Join(Environment.NewLine, this.StandardOutput, data);
            this.StandardOutput = current;

            this.OnStandardOutputUpdated?.Invoke(this.StandardOutput);
        }

        public void ResetStandardOutput()
        {
            this.StandardOutput = string.Empty;
            this.OnStandardOutputUpdated?.Invoke(this.StandardOutput);
        }
    }
}