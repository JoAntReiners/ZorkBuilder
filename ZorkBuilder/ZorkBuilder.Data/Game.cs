using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ZorkBuilder.Data
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string WelcomeMessage { get; set; }

        public World World { get; set; }

        public Game()
        {
            World = new World();
        }
    }
}
