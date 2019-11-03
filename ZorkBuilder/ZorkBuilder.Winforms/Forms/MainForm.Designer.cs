namespace ZorkBuilder.Winforms
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
            this.components = new System.ComponentModel.Container();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomsTabPage = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.NeighborsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WestNeighborLabel = new System.Windows.Forms.Label();
            this.EastNeighborTextBox = new System.Windows.Forms.TextBox();
            this.EastNeighborLabel = new System.Windows.Forms.Label();
            this.SouthNeighborTextBox = new System.Windows.Forms.TextBox();
            this.SouthNeighborLabel = new System.Windows.Forms.Label();
            this.NorthNeighborTextBox = new System.Windows.Forms.TextBox();
            this.NorthNeighborLabel = new System.Windows.Forms.Label();
            this.RoomDeleteButton = new System.Windows.Forms.Button();
            this.RoomAddButton = new System.Windows.Forms.Button();
            this.RoomNeighborsLabel = new System.Windows.Forms.Label();
            this.RoomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.RoomDescriptionLabel = new System.Windows.Forms.Label();
            this.RoomNameTextbox = new System.Windows.Forms.TextBox();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.RoomListBox = new System.Windows.Forms.ListBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.WorldSettingsTab = new System.Windows.Forms.TabPage();
            this.WelcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.WelcomeMessageLabel = new System.Windows.Forms.Label();
            this.StartingLocationTextBox = new System.Windows.Forms.TextBox();
            this.StartingLocationLabel = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).BeginInit();
            this.RoomsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeighborsBindingSource)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.WorldSettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(900, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenWorldToolStripMenuItem,
            this.newWorldToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // OpenWorldToolStripMenuItem
            // 
            this.OpenWorldToolStripMenuItem.Name = "OpenWorldToolStripMenuItem";
            this.OpenWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenWorldToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.OpenWorldToolStripMenuItem.Text = "&Open World";
            this.OpenWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldToolStripMenuItem_Click);
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.newWorldToolStripMenuItem.Text = "&New World";
            this.newWorldToolStripMenuItem.Click += new System.EventHandler(this.NewWorldToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "World Files (*.json)|*.json";
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(ZorkBuilder.Winforms.ViewModels.GameViewModel);
            // 
            // RoomsBindingSource
            // 
            this.RoomsBindingSource.DataMember = "Rooms";
            this.RoomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // RoomsTabPage
            // 
            this.RoomsTabPage.Controls.Add(this.textBox3);
            this.RoomsTabPage.Controls.Add(this.WestNeighborLabel);
            this.RoomsTabPage.Controls.Add(this.EastNeighborTextBox);
            this.RoomsTabPage.Controls.Add(this.EastNeighborLabel);
            this.RoomsTabPage.Controls.Add(this.SouthNeighborTextBox);
            this.RoomsTabPage.Controls.Add(this.SouthNeighborLabel);
            this.RoomsTabPage.Controls.Add(this.NorthNeighborTextBox);
            this.RoomsTabPage.Controls.Add(this.NorthNeighborLabel);
            this.RoomsTabPage.Controls.Add(this.RoomDeleteButton);
            this.RoomsTabPage.Controls.Add(this.RoomAddButton);
            this.RoomsTabPage.Controls.Add(this.RoomNeighborsLabel);
            this.RoomsTabPage.Controls.Add(this.RoomDescriptionTextBox);
            this.RoomsTabPage.Controls.Add(this.RoomDescriptionLabel);
            this.RoomsTabPage.Controls.Add(this.RoomNameTextbox);
            this.RoomsTabPage.Controls.Add(this.RoomNameLabel);
            this.RoomsTabPage.Controls.Add(this.RoomListBox);
            this.RoomsTabPage.Location = new System.Drawing.Point(4, 22);
            this.RoomsTabPage.Name = "RoomsTabPage";
            this.RoomsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RoomsTabPage.Size = new System.Drawing.Size(892, 420);
            this.RoomsTabPage.TabIndex = 0;
            this.RoomsTabPage.Text = "Rooms";
            this.RoomsTabPage.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.NeighborsBindingSource, "West", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(230, 304);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 20);
            this.textBox3.TabIndex = 16;
            // 
            // NeighborsBindingSource
            // 
            this.NeighborsBindingSource.DataMember = "Neighbors";
            this.NeighborsBindingSource.DataSource = this.RoomsBindingSource;
            // 
            // WestNeighborLabel
            // 
            this.WestNeighborLabel.AutoSize = true;
            this.WestNeighborLabel.Location = new System.Drawing.Point(191, 307);
            this.WestNeighborLabel.Name = "WestNeighborLabel";
            this.WestNeighborLabel.Size = new System.Drawing.Size(32, 13);
            this.WestNeighborLabel.TabIndex = 15;
            this.WestNeighborLabel.Text = "West";
            // 
            // EastNeighborTextBox
            // 
            this.EastNeighborTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.NeighborsBindingSource, "East", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EastNeighborTextBox.Location = new System.Drawing.Point(230, 278);
            this.EastNeighborTextBox.Name = "EastNeighborTextBox";
            this.EastNeighborTextBox.Size = new System.Drawing.Size(249, 20);
            this.EastNeighborTextBox.TabIndex = 14;
            // 
            // EastNeighborLabel
            // 
            this.EastNeighborLabel.AutoSize = true;
            this.EastNeighborLabel.Location = new System.Drawing.Point(191, 281);
            this.EastNeighborLabel.Name = "EastNeighborLabel";
            this.EastNeighborLabel.Size = new System.Drawing.Size(28, 13);
            this.EastNeighborLabel.TabIndex = 13;
            this.EastNeighborLabel.Text = "East";
            // 
            // SouthNeighborTextBox
            // 
            this.SouthNeighborTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.NeighborsBindingSource, "South", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SouthNeighborTextBox.Location = new System.Drawing.Point(230, 252);
            this.SouthNeighborTextBox.Name = "SouthNeighborTextBox";
            this.SouthNeighborTextBox.Size = new System.Drawing.Size(249, 20);
            this.SouthNeighborTextBox.TabIndex = 12;
            // 
            // SouthNeighborLabel
            // 
            this.SouthNeighborLabel.AutoSize = true;
            this.SouthNeighborLabel.Location = new System.Drawing.Point(191, 255);
            this.SouthNeighborLabel.Name = "SouthNeighborLabel";
            this.SouthNeighborLabel.Size = new System.Drawing.Size(35, 13);
            this.SouthNeighborLabel.TabIndex = 11;
            this.SouthNeighborLabel.Text = "South";
            // 
            // NorthNeighborTextBox
            // 
            this.NorthNeighborTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.NeighborsBindingSource, "North", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NorthNeighborTextBox.Location = new System.Drawing.Point(230, 226);
            this.NorthNeighborTextBox.Name = "NorthNeighborTextBox";
            this.NorthNeighborTextBox.Size = new System.Drawing.Size(249, 20);
            this.NorthNeighborTextBox.TabIndex = 10;
            // 
            // NorthNeighborLabel
            // 
            this.NorthNeighborLabel.AutoSize = true;
            this.NorthNeighborLabel.Location = new System.Drawing.Point(191, 229);
            this.NorthNeighborLabel.Name = "NorthNeighborLabel";
            this.NorthNeighborLabel.Size = new System.Drawing.Size(33, 13);
            this.NorthNeighborLabel.TabIndex = 9;
            this.NorthNeighborLabel.Text = "North";
            // 
            // RoomDeleteButton
            // 
            this.RoomDeleteButton.Location = new System.Drawing.Point(90, 389);
            this.RoomDeleteButton.Name = "RoomDeleteButton";
            this.RoomDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.RoomDeleteButton.TabIndex = 8;
            this.RoomDeleteButton.Text = "Delete";
            this.RoomDeleteButton.UseVisualStyleBackColor = true;
            this.RoomDeleteButton.Click += new System.EventHandler(this.RoomDeleteButton_Click);
            // 
            // RoomAddButton
            // 
            this.RoomAddButton.Location = new System.Drawing.Point(6, 389);
            this.RoomAddButton.Name = "RoomAddButton";
            this.RoomAddButton.Size = new System.Drawing.Size(75, 23);
            this.RoomAddButton.TabIndex = 7;
            this.RoomAddButton.Text = "Add";
            this.RoomAddButton.UseVisualStyleBackColor = true;
            this.RoomAddButton.Click += new System.EventHandler(this.RoomAddButton_Click);
            // 
            // RoomNeighborsLabel
            // 
            this.RoomNeighborsLabel.AutoSize = true;
            this.RoomNeighborsLabel.Location = new System.Drawing.Point(171, 204);
            this.RoomNeighborsLabel.Name = "RoomNeighborsLabel";
            this.RoomNeighborsLabel.Size = new System.Drawing.Size(55, 13);
            this.RoomNeighborsLabel.TabIndex = 6;
            this.RoomNeighborsLabel.Text = "Neighbors";
            // 
            // RoomDescriptionTextBox
            // 
            this.RoomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RoomDescriptionTextBox.Location = new System.Drawing.Point(174, 70);
            this.RoomDescriptionTextBox.Multiline = true;
            this.RoomDescriptionTextBox.Name = "RoomDescriptionTextBox";
            this.RoomDescriptionTextBox.Size = new System.Drawing.Size(415, 115);
            this.RoomDescriptionTextBox.TabIndex = 5;
            // 
            // RoomDescriptionLabel
            // 
            this.RoomDescriptionLabel.AutoSize = true;
            this.RoomDescriptionLabel.Location = new System.Drawing.Point(171, 54);
            this.RoomDescriptionLabel.Name = "RoomDescriptionLabel";
            this.RoomDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.RoomDescriptionLabel.TabIndex = 4;
            this.RoomDescriptionLabel.Text = "Description";
            // 
            // RoomNameTextbox
            // 
            this.RoomNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RoomNameTextbox.Location = new System.Drawing.Point(174, 19);
            this.RoomNameTextbox.Name = "RoomNameTextbox";
            this.RoomNameTextbox.Size = new System.Drawing.Size(249, 20);
            this.RoomNameTextbox.TabIndex = 3;
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(171, 3);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(35, 13);
            this.RoomNameLabel.TabIndex = 2;
            this.RoomNameLabel.Text = "Name";
            // 
            // RoomListBox
            // 
            this.RoomListBox.DataSource = this.RoomsBindingSource;
            this.RoomListBox.FormattingEnabled = true;
            this.RoomListBox.Location = new System.Drawing.Point(3, 3);
            this.RoomListBox.Name = "RoomListBox";
            this.RoomListBox.Size = new System.Drawing.Size(162, 381);
            this.RoomListBox.TabIndex = 0;
            this.RoomListBox.SelectedIndexChanged += new System.EventHandler(this.RoomListBox_SelectedIndexChanged);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.RoomsTabPage);
            this.MainTabControl.Controls.Add(this.WorldSettingsTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 24);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(900, 446);
            this.MainTabControl.TabIndex = 1;
            // 
            // WorldSettingsTab
            // 
            this.WorldSettingsTab.Controls.Add(this.WelcomeMessageTextBox);
            this.WorldSettingsTab.Controls.Add(this.WelcomeMessageLabel);
            this.WorldSettingsTab.Controls.Add(this.StartingLocationTextBox);
            this.WorldSettingsTab.Controls.Add(this.StartingLocationLabel);
            this.WorldSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.WorldSettingsTab.Name = "WorldSettingsTab";
            this.WorldSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.WorldSettingsTab.Size = new System.Drawing.Size(892, 420);
            this.WorldSettingsTab.TabIndex = 1;
            this.WorldSettingsTab.Text = "World Settings";
            this.WorldSettingsTab.UseVisualStyleBackColor = true;
            // 
            // WelcomeMessageTextBox
            // 
            this.WelcomeMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "WelcomeMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.WelcomeMessageTextBox.Location = new System.Drawing.Point(3, 58);
            this.WelcomeMessageTextBox.Multiline = true;
            this.WelcomeMessageTextBox.Name = "WelcomeMessageTextBox";
            this.WelcomeMessageTextBox.Size = new System.Drawing.Size(289, 109);
            this.WelcomeMessageTextBox.TabIndex = 3;
            this.WelcomeMessageTextBox.TextChanged += new System.EventHandler(this.WelcomeMessageTextBox_TextChanged);
            // 
            // WelcomeMessageLabel
            // 
            this.WelcomeMessageLabel.AutoSize = true;
            this.WelcomeMessageLabel.Location = new System.Drawing.Point(3, 42);
            this.WelcomeMessageLabel.Name = "WelcomeMessageLabel";
            this.WelcomeMessageLabel.Size = new System.Drawing.Size(98, 13);
            this.WelcomeMessageLabel.TabIndex = 2;
            this.WelcomeMessageLabel.Text = "Welcome Message";
            // 
            // StartingLocationTextBox
            // 
            this.StartingLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "StartingLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StartingLocationTextBox.Location = new System.Drawing.Point(3, 19);
            this.StartingLocationTextBox.Name = "StartingLocationTextBox";
            this.StartingLocationTextBox.Size = new System.Drawing.Size(186, 20);
            this.StartingLocationTextBox.TabIndex = 1;
            this.StartingLocationTextBox.TextChanged += new System.EventHandler(this.StartingLocationTextBox_TextChanged);
            // 
            // StartingLocationLabel
            // 
            this.StartingLocationLabel.AutoSize = true;
            this.StartingLocationLabel.Location = new System.Drawing.Point(3, 3);
            this.StartingLocationLabel.Name = "StartingLocationLabel";
            this.StartingLocationLabel.Size = new System.Drawing.Size(87, 13);
            this.StartingLocationLabel.TabIndex = 0;
            this.StartingLocationLabel.Text = "Starting Location";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "World Files (*.json)|*.json";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 470);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).EndInit();
            this.RoomsTabPage.ResumeLayout(false);
            this.RoomsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeighborsBindingSource)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.WorldSettingsTab.ResumeLayout(false);
            this.WorldSettingsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenWorldToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.BindingSource RoomsBindingSource;
        private System.Windows.Forms.TabPage RoomsTabPage;
        private System.Windows.Forms.ListBox RoomListBox;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.TextBox RoomDescriptionTextBox;
        private System.Windows.Forms.Label RoomDescriptionLabel;
        private System.Windows.Forms.TextBox RoomNameTextbox;
        private System.Windows.Forms.Label RoomNeighborsLabel;
        private System.Windows.Forms.Button RoomDeleteButton;
        private System.Windows.Forms.Button RoomAddButton;
        private System.Windows.Forms.TextBox NorthNeighborTextBox;
        private System.Windows.Forms.BindingSource NeighborsBindingSource;
        private System.Windows.Forms.Label NorthNeighborLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label WestNeighborLabel;
        private System.Windows.Forms.TextBox EastNeighborTextBox;
        private System.Windows.Forms.Label EastNeighborLabel;
        private System.Windows.Forms.TextBox SouthNeighborTextBox;
        private System.Windows.Forms.Label SouthNeighborLabel;
        private System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.TabPage WorldSettingsTab;
        private System.Windows.Forms.TextBox StartingLocationTextBox;
        private System.Windows.Forms.Label StartingLocationLabel;
        private System.Windows.Forms.TextBox WelcomeMessageTextBox;
        private System.Windows.Forms.Label WelcomeMessageLabel;
    }
}

