using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProcessController.Domain;
using ProcessController.Service;
using ProcessController.WinForms.Components;

/* todo:
 * 1. Show status (is running) in the list of apps
 * 2. Edit details and save
 */

namespace ProcessController.WinForms
{
    public partial class MainForm : Form
    {
        private readonly IEnvironmentService environmentService;

        private readonly IAppService appService;

        private AppDetailsComponent appDetailsComponent;

        private AppListComponent appListComponent;

        private IEnumerable<IApp> appCollection;

        private BindingSource appBindingSource;

        public MainForm(IEnvironmentService environmentService, IAppService appService)
        {
            this.environmentService = environmentService;
            this.appService = appService;

            this.InitializeComponent();
            this.InitializeMenuStrip();
            this.InitailizeAppDataSource();
            this.InitializeAppDetailsComponent(
                appService,
                this.AppNameText,
                this.AppPathText,
                this.AppCommandText,
                this.AppArgumentsText,
                this.AppVariablesText,
                this.AppOutputText,
                this.AppRunButton,
                this.AppStopButton,
                this.AppRunningCheckbox);
            this.InitializeAppListComponent(this.AppList);

            this.FinalizeInitialized();
        }

        private void InitializeMenuStrip()
        {
            this.QuitToolStripMenuItem.Click += this.QuitToolStripMenuItem_Click;
            this.NewAppToolStripMenuItem.Click += this.NewProcessToolStripMenuItem_Click;
        }

        private void InitailizeAppDataSource()
        {
            this.appCollection = this.appService.GetAll();

            this.appBindingSource = new BindingSource
            {
                DataSource = this.appCollection
            };
        }

        private void InitializeAppListComponent(ListBox appList)
        {
            this.appListComponent = new AppListComponent(appList, this.appBindingSource, this.CreateGraphics());
            this.appListComponent.OnSelectionChanged += this.appDetailsComponent.Update;
        }

        private void InitializeAppDetailsComponent(
            IAppService appService,
            TextBox appNameTextBox,
            TextBox appPathTextBox,
            TextBox appCommandTextBox,
            TextBox appArgumentsTextBox,
            TextBox appVariablesTextBox,
            RichTextBox appOutputText,
            Button appRunButton,
            Button appStopButton,
            CheckBox appRunningCheckbox)
        {
            this.appDetailsComponent = new AppDetailsComponent(
                appService,
                appNameTextBox,
                appPathTextBox,
                appCommandTextBox,
                appArgumentsTextBox,
                appVariablesTextBox,
                appOutputText,
                appRunButton,
                appStopButton,
                appRunningCheckbox);
        }

        private void FinalizeInitialized()
        {
            this.appListComponent.TrySelectFirst();
        }

        private void RefreshProcessDataSource()
        {
            this.appCollection = this.appService.GetAll();
            this.appBindingSource.DataSource = null;
            this.appBindingSource.DataSource = this.appCollection;
            this.appBindingSource.ResetBindings(false);
        }

        #region Event Handlers

        private void NewProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.appService.Add(Domain.App.CreateNew());
            this.RefreshProcessDataSource();
            this.appListComponent.TrySelectFirst();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.environmentService.Close();
        }

        #endregion Event Handlers
    }
}