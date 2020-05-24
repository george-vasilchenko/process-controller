using System;
using System.Drawing;
using System.Windows.Forms;
using ProcessController.Domain;

namespace ProcessController.WinForms.Components
{
    public class AppListComponent : IDisposable
    {
        private readonly ListBox listBox;

        private readonly Graphics graphics;

        public AppListComponent(ListBox appListBox, BindingSource appBindingSource, Graphics graphics)
        {
            if (appListBox is null)
            {
                throw new ArgumentNullException(nameof(appListBox));
            }

            if (appBindingSource is null)
            {
                throw new ArgumentNullException(nameof(appBindingSource));
            }

            this.listBox = appListBox;
            this.graphics = graphics;
            this.listBox.DataSource = appBindingSource;
            this.listBox.DisplayMember = "Name";
            this.listBox.SelectedIndexChanged += this.OnSelectedIndexChanged;
        }

        public event Action<IApp> OnSelectionChanged;

        public void TrySelectFirst()
        {
            if (this.listBox.Items.Count == 0)
            {
                return;
            }

            this.listBox.SetSelected(0, true);
        }

        public void Dispose()
        {
            this.graphics.Dispose();
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;

            if (listBox.SelectedItem is App selectedApp)
            {
                this.OnSelectionChanged?.Invoke(selectedApp);

                // RedrawSelectedListItem(listBox, selectedApp);
            }
        }

        private void RedrawSelectedListItem(ListBox listBox, App selectedApp)
        {
            var itemIndex = listBox.Items.IndexOf(selectedApp);

            if (selectedApp.IsRunning)
            {
                var xPos = 0;
                var yPos = itemIndex * listBox.ItemHeight;

                this.graphics.DrawString(selectedApp.Name, listBox.Font, new SolidBrush(Color.Green), xPos, yPos);
            }
        }
    }
}