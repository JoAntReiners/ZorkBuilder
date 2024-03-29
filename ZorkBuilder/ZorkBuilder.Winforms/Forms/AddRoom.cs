﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZorkBuilder.Winforms
{
    public partial class AddRoomForm : Form
    {
        public string RoomName
        {
            get => RoomNameTextbox.Text;
            set => RoomNameTextbox.Text = value;
        }

        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void RoomNameTextbox_TextChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
