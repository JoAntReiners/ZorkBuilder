using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ZorkBuilder.Data;
using ZorkBuilder.Winforms.ViewModels;

namespace ZorkBuilder.Winforms
{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        private GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    gameViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }

        private bool IsWorldLoaded
        {
            get => mIsWorldLoaded;
            set
            {
                mIsWorldLoaded = value;
                MainTabControl.Enabled = mIsWorldLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            IsWorldLoaded = false;
            ViewModel = new GameViewModel();
        }

        private void RoomAddButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {

                    Room room = new Room { Name = addRoomForm.RoomName };
                    ViewModel.Rooms.Add(room);
                }
            }
        }

        private void RoomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomDeleteButton.Enabled = RoomListBox.SelectedItem != null;
        }

        private void RoomDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)RoomListBox.SelectedItem);
                RoomListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }

        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(OpenFileDialog.FileName));
                ViewModel.FileName = OpenFileDialog.FileName;
                IsWorldLoaded = true;
            }
        }

        private void NewWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.FileName = SaveFileDialog.FileName;
                ViewModel.Game = new Game();
                IsWorldLoaded = true;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.SaveWorld();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.FileName = SaveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartingLocationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WelcomeMessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private GameViewModel mViewModel;
        private bool mIsWorldLoaded;

    }
}
