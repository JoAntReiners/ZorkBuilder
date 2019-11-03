using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ZorkBuilder.Data
{
    public class Neighbors : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string North { get; set; }

        public string South { get; set; }

        public string East { get; set; }

        public string West { get; set; }

        public Neighbors()
        {

        }

    }
}
