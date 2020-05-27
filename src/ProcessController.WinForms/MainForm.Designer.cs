namespace ProcessController.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AppList = new System.Windows.Forms.ListBox();
            this.AppMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.AppOutputGroupbox = new System.Windows.Forms.GroupBox();
            this.AppOutputText = new System.Windows.Forms.RichTextBox();
            this.AppVariablesText = new System.Windows.Forms.TextBox();
            this.AppVariablesLabel = new System.Windows.Forms.Label();
            this.AppRunningCheckbox = new System.Windows.Forms.CheckBox();
            this.AppStopButton = new System.Windows.Forms.Button();
            this.AppArgumentsText = new System.Windows.Forms.TextBox();
            this.AppArgumentsLabel = new System.Windows.Forms.Label();
            this.AppCommandText = new System.Windows.Forms.TextBox();
            this.AppCommandLabel = new System.Windows.Forms.Label();
            this.AppRunButton = new System.Windows.Forms.Button();
            this.AppPathText = new System.Windows.Forms.TextBox();
            this.AppPathLabel = new System.Windows.Forms.Label();
            this.AppNameText = new System.Windows.Forms.TextBox();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.AppListGroupBox = new System.Windows.Forms.GroupBox();
            this.stopAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppMenuStrip.SuspendLayout();
            this.AppDetailsGroupBox.SuspendLayout();
            this.AppOutputGroupbox.SuspendLayout();
            this.AppListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppList
            // 
            this.AppList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppList.FormattingEnabled = true;
            this.AppList.ItemHeight = 16;
            this.AppList.Location = new System.Drawing.Point(6, 21);
            this.AppList.Name = "AppList";
            this.AppList.Size = new System.Drawing.Size(187, 640);
            this.AppList.TabIndex = 1;
            // 
            // AppMenuStrip
            // 
            this.AppMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.AppMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AppMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AppToolStripMenuItem});
            this.AppMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AppMenuStrip.Name = "AppMenuStrip";
            this.AppMenuStrip.Size = new System.Drawing.Size(1119, 28);
            this.AppMenuStrip.TabIndex = 3;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.QuitToolStripMenuItem.Text = "Quit";
            // 
            // AppToolStripMenuItem
            // 
            this.AppToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewAppToolStripMenuItem,
            this.stopAllToolStripMenuItem});
            this.AppToolStripMenuItem.Name = "AppToolStripMenuItem";
            this.AppToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.AppToolStripMenuItem.Text = "App";
            // 
            // NewAppToolStripMenuItem
            // 
            this.NewAppToolStripMenuItem.Name = "NewAppToolStripMenuItem";
            this.NewAppToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.NewAppToolStripMenuItem.Text = "New";
            // 
            // AppDetailsGroupBox
            // 
            this.AppDetailsGroupBox.Controls.Add(this.AppOutputGroupbox);
            this.AppDetailsGroupBox.Controls.Add(this.AppVariablesText);
            this.AppDetailsGroupBox.Controls.Add(this.AppVariablesLabel);
            this.AppDetailsGroupBox.Controls.Add(this.AppRunningCheckbox);
            this.AppDetailsGroupBox.Controls.Add(this.AppStopButton);
            this.AppDetailsGroupBox.Controls.Add(this.AppArgumentsText);
            this.AppDetailsGroupBox.Controls.Add(this.AppArgumentsLabel);
            this.AppDetailsGroupBox.Controls.Add(this.AppCommandText);
            this.AppDetailsGroupBox.Controls.Add(this.AppCommandLabel);
            this.AppDetailsGroupBox.Controls.Add(this.AppRunButton);
            this.AppDetailsGroupBox.Controls.Add(this.AppPathText);
            this.AppDetailsGroupBox.Controls.Add(this.AppPathLabel);
            this.AppDetailsGroupBox.Controls.Add(this.AppNameText);
            this.AppDetailsGroupBox.Controls.Add(this.AppNameLabel);
            this.AppDetailsGroupBox.Location = new System.Drawing.Point(217, 31);
            this.AppDetailsGroupBox.Name = "AppDetailsGroupBox";
            this.AppDetailsGroupBox.Size = new System.Drawing.Size(893, 672);
            this.AppDetailsGroupBox.TabIndex = 4;
            this.AppDetailsGroupBox.TabStop = false;
            this.AppDetailsGroupBox.Text = "Details";
            // 
            // AppOutputGroupbox
            // 
            this.AppOutputGroupbox.Controls.Add(this.AppOutputText);
            this.AppOutputGroupbox.Location = new System.Drawing.Point(9, 205);
            this.AppOutputGroupbox.Name = "AppOutputGroupbox";
            this.AppOutputGroupbox.Size = new System.Drawing.Size(878, 460);
            this.AppOutputGroupbox.TabIndex = 15;
            this.AppOutputGroupbox.TabStop = false;
            this.AppOutputGroupbox.Text = "Output";
            // 
            // AppOutputText
            // 
            this.AppOutputText.BackColor = System.Drawing.Color.White;
            this.AppOutputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppOutputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AppOutputText.Location = new System.Drawing.Point(6, 21);
            this.AppOutputText.Name = "AppOutputText";
            this.AppOutputText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.AppOutputText.Size = new System.Drawing.Size(866, 433);
            this.AppOutputText.TabIndex = 9;
            this.AppOutputText.Text = "";
            // 
            // AppVariablesText
            // 
            this.AppVariablesText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppVariablesText.Location = new System.Drawing.Point(83, 131);
            this.AppVariablesText.Multiline = true;
            this.AppVariablesText.Name = "AppVariablesText";
            this.AppVariablesText.Size = new System.Drawing.Size(482, 68);
            this.AppVariablesText.TabIndex = 14;
            // 
            // AppVariablesLabel
            // 
            this.AppVariablesLabel.AutoSize = true;
            this.AppVariablesLabel.Location = new System.Drawing.Point(6, 134);
            this.AppVariablesLabel.Name = "AppVariablesLabel";
            this.AppVariablesLabel.Size = new System.Drawing.Size(67, 17);
            this.AppVariablesLabel.TabIndex = 13;
            this.AppVariablesLabel.Text = "Variables";
            // 
            // AppRunningCheckbox
            // 
            this.AppRunningCheckbox.AutoSize = true;
            this.AppRunningCheckbox.Enabled = false;
            this.AppRunningCheckbox.Location = new System.Drawing.Point(805, 61);
            this.AppRunningCheckbox.Name = "AppRunningCheckbox";
            this.AppRunningCheckbox.Size = new System.Drawing.Size(83, 21);
            this.AppRunningCheckbox.TabIndex = 12;
            this.AppRunningCheckbox.Text = "Running";
            this.AppRunningCheckbox.UseVisualStyleBackColor = true;
            // 
            // AppStopButton
            // 
            this.AppStopButton.Location = new System.Drawing.Point(794, 19);
            this.AppStopButton.Name = "AppStopButton";
            this.AppStopButton.Size = new System.Drawing.Size(93, 35);
            this.AppStopButton.TabIndex = 10;
            this.AppStopButton.Text = "Stop";
            this.AppStopButton.UseVisualStyleBackColor = true;
            // 
            // AppArgumentsText
            // 
            this.AppArgumentsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppArgumentsText.Location = new System.Drawing.Point(83, 103);
            this.AppArgumentsText.Name = "AppArgumentsText";
            this.AppArgumentsText.Size = new System.Drawing.Size(482, 22);
            this.AppArgumentsText.TabIndex = 8;
            // 
            // AppArgumentsLabel
            // 
            this.AppArgumentsLabel.AutoSize = true;
            this.AppArgumentsLabel.Location = new System.Drawing.Point(6, 106);
            this.AppArgumentsLabel.Name = "AppArgumentsLabel";
            this.AppArgumentsLabel.Size = new System.Drawing.Size(37, 17);
            this.AppArgumentsLabel.TabIndex = 7;
            this.AppArgumentsLabel.Text = "Args";
            // 
            // AppCommandText
            // 
            this.AppCommandText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppCommandText.Location = new System.Drawing.Point(83, 75);
            this.AppCommandText.Name = "AppCommandText";
            this.AppCommandText.Size = new System.Drawing.Size(482, 22);
            this.AppCommandText.TabIndex = 6;
            // 
            // AppCommandLabel
            // 
            this.AppCommandLabel.AutoSize = true;
            this.AppCommandLabel.Location = new System.Drawing.Point(6, 78);
            this.AppCommandLabel.Name = "AppCommandLabel";
            this.AppCommandLabel.Size = new System.Drawing.Size(71, 17);
            this.AppCommandLabel.TabIndex = 5;
            this.AppCommandLabel.Text = "Command";
            // 
            // AppRunButton
            // 
            this.AppRunButton.Location = new System.Drawing.Point(695, 19);
            this.AppRunButton.Name = "AppRunButton";
            this.AppRunButton.Size = new System.Drawing.Size(93, 35);
            this.AppRunButton.TabIndex = 4;
            this.AppRunButton.Text = "Run";
            this.AppRunButton.UseVisualStyleBackColor = true;
            // 
            // AppPathText
            // 
            this.AppPathText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppPathText.Location = new System.Drawing.Point(83, 47);
            this.AppPathText.Name = "AppPathText";
            this.AppPathText.Size = new System.Drawing.Size(482, 22);
            this.AppPathText.TabIndex = 3;
            // 
            // AppPathLabel
            // 
            this.AppPathLabel.AutoSize = true;
            this.AppPathLabel.Location = new System.Drawing.Point(6, 50);
            this.AppPathLabel.Name = "AppPathLabel";
            this.AppPathLabel.Size = new System.Drawing.Size(37, 17);
            this.AppPathLabel.TabIndex = 2;
            this.AppPathLabel.Text = "Path";
            // 
            // AppNameText
            // 
            this.AppNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppNameText.Location = new System.Drawing.Point(83, 19);
            this.AppNameText.Name = "AppNameText";
            this.AppNameText.Size = new System.Drawing.Size(482, 22);
            this.AppNameText.TabIndex = 1;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Location = new System.Drawing.Point(6, 22);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(45, 17);
            this.AppNameLabel.TabIndex = 0;
            this.AppNameLabel.Text = "Name";
            // 
            // AppListGroupBox
            // 
            this.AppListGroupBox.Controls.Add(this.AppList);
            this.AppListGroupBox.Location = new System.Drawing.Point(12, 31);
            this.AppListGroupBox.Name = "AppListGroupBox";
            this.AppListGroupBox.Size = new System.Drawing.Size(199, 672);
            this.AppListGroupBox.TabIndex = 5;
            this.AppListGroupBox.TabStop = false;
            this.AppListGroupBox.Text = "Apps";
            // 
            // stopAllToolStripMenuItem
            // 
            this.stopAllToolStripMenuItem.Name = "stopAllToolStripMenuItem";
            this.stopAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stopAllToolStripMenuItem.Text = "Stop All";
            this.stopAllToolStripMenuItem.Click += new System.EventHandler(this.stopAllToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 710);
            this.Controls.Add(this.AppListGroupBox);
            this.Controls.Add(this.AppDetailsGroupBox);
            this.Controls.Add(this.AppMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.AppMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Controller";
            this.AppMenuStrip.ResumeLayout(false);
            this.AppMenuStrip.PerformLayout();
            this.AppDetailsGroupBox.ResumeLayout(false);
            this.AppDetailsGroupBox.PerformLayout();
            this.AppOutputGroupbox.ResumeLayout(false);
            this.AppListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AppList;
        private System.Windows.Forms.MenuStrip AppMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewAppToolStripMenuItem;
        private System.Windows.Forms.GroupBox AppDetailsGroupBox;
        private System.Windows.Forms.TextBox AppPathText;
        private System.Windows.Forms.Label AppPathLabel;
        private System.Windows.Forms.TextBox AppNameText;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.GroupBox AppListGroupBox;
        private System.Windows.Forms.Button AppRunButton;
        private System.Windows.Forms.TextBox AppCommandText;
        private System.Windows.Forms.Label AppCommandLabel;
        private System.Windows.Forms.TextBox AppArgumentsText;
        private System.Windows.Forms.Label AppArgumentsLabel;
        private System.Windows.Forms.RichTextBox AppOutputText;
        private System.Windows.Forms.Button AppStopButton;
        private System.Windows.Forms.CheckBox AppRunningCheckbox;
        private System.Windows.Forms.Label AppVariablesLabel;
        private System.Windows.Forms.TextBox AppVariablesText;
        private System.Windows.Forms.GroupBox AppOutputGroupbox;
        private System.Windows.Forms.ToolStripMenuItem stopAllToolStripMenuItem;
    }
}

