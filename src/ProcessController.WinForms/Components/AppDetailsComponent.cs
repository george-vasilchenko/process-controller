using System;
using System.Windows.Forms;
using ProcessController.Domain;
using ProcessController.Service;
using ProcessController.WinForms.Extensions;

namespace ProcessController.WinForms.Components
{
    public class AppDetailsComponent
    {
        private readonly IAppService appService;

        private readonly TextBox nameText;

        private readonly TextBox pathText;

        private readonly TextBox commandText;

        private readonly TextBox argumentsText;

        private readonly RichTextBox outputText;

        private readonly Button runButton;

        private readonly Button stopButton;

        private readonly CheckBox runningCheckbox;

        private IApp currentApp;

        public AppDetailsComponent(
            IAppService appService,
            TextBox nameText,
            TextBox pathText,
            TextBox commandText,
            TextBox argumentsText,
            RichTextBox outputText,
            Button runButton,
            Button stopButton,
            CheckBox runningCheckbox)
        {
            this.appService = appService;
            this.nameText = nameText;
            this.pathText = pathText;
            this.commandText = commandText;
            this.argumentsText = argumentsText;
            this.outputText = outputText;
            this.runButton = runButton;
            this.stopButton = stopButton;
            this.runningCheckbox = runningCheckbox;

            this.runButton.Click += (s, e) => this.OnRunAppClickHandler();
            this.stopButton.Click += (s, e) => this.OnStopAppClickHandler();
        }

        public void Update(IApp selectedApp)
        {
            if (selectedApp is null)
            {
                throw new ArgumentNullException(nameof(selectedApp));
            }

            if (this.currentApp != null)
            {
                this.currentApp.OnStandardOutputUpdated -= UpdateOutputText;
                this.currentApp.OnIsRunningUpdated -= UpdateRunningCheckbox;
            }

            this.currentApp = selectedApp;

            this.currentApp.OnStandardOutputUpdated += UpdateOutputText;
            this.currentApp.OnIsRunningUpdated += UpdateRunningCheckbox;

            this.Redraw();
        }

        private void UpdateRunningCheckbox(bool isRunning)
        {
            this.runningCheckbox.Invoke(() =>
            {
                this.runningCheckbox.Checked = isRunning;
            });
        }

        private void OnRunAppClickHandler()
        {
            if (this.currentApp.IsRunning)
            {
                return;
            }

            this.appService.CreateAndRunAppProcess(this.currentApp.Id);
        }

        private void OnStopAppClickHandler()
        {
            if (!this.currentApp.IsRunning)
            {
                return;
            }

            this.appService.TerminateAppProcess(this.currentApp.Id);
        }

        private void UpdateOutputText(string text)
        {
            this.outputText.Invoke(() =>
            {
                this.outputText.Text = text;
            });
        }

        private void Redraw()
        {
            this.nameText.Text = this.currentApp.Name;
            this.pathText.Text = this.currentApp.Path;
            this.commandText.Text = this.currentApp.Command;
            this.argumentsText.Text = this.currentApp.Arguments;
            this.outputText.Text = this.currentApp.StandardOutput;
            this.runningCheckbox.Checked = this.currentApp.IsRunning;
        }
    }
}