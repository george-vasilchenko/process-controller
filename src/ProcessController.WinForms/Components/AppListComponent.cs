using System;
using System.Windows.Forms;
using ProcessController.Domain;

namespace ProcessController.WinForms.Components
{
    public class AppListComponent
    {
        private readonly ListBox appListBox;

        public AppListComponent(ListBox appListBox, BindingSource appBindingSource)
        {
            if (appListBox is null)
            {
                throw new ArgumentNullException(nameof(appListBox));
            }

            if (appBindingSource is null)
            {
                throw new ArgumentNullException(nameof(appBindingSource));
            }

            this.appListBox = appListBox;
            this.appListBox.DataSource = appBindingSource;
            this.appListBox.DisplayMember = "Name";
            this.appListBox.SelectedIndexChanged += this.OnSelectedIndexChanged;
        }

        public event Action<IApp> OnSelectionChanged;

        public void TrySelectFirst()
        {
            if (this.appListBox.Items.Count == 0)
            {
                return;
            }

            this.appListBox.SetSelected(0, true);
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.appListBox.SelectedItem is App selectedProcess)
            {
                this.OnSelectionChanged?.Invoke(selectedProcess);
            }
        }
    }
}