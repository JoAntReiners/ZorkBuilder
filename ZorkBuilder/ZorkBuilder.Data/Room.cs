using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ZorkBuilder.Data
{
    public class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string Description { get; set; }

        public Neighbors Neighbors { get; set; }

        public Room()
        {
            Neighbors = new Neighbors();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
