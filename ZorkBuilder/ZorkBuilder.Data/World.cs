using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ZorkBuilder.Data
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string StartingLocation { get; set; }

        public List<Room> Rooms { get; set; }

        public World()
        {
            Rooms = new List<Room>();
        }
    }
}
