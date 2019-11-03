using System;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using ZorkBuilder.Data;

namespace ZorkBuilder.Winforms.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string FileName { get; set; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public Game Game
        {
            set
            {
                if(mGame!= value)
                {
                    mGame = value;
                    if(mGame != null)
                    {
                        WelcomeMessage = mGame.WelcomeMessage;
                        World = mGame.World;
                    }
                    else
                    {
                        WelcomeMessage = "";
                        World = new World();
                    }
                }
            }
        }

        public World World
        {
            set
            {
                if (mWorld != value)
                {
                    mWorld = value;

                    if (mWorld != null)
                    {
                        StartingLocation = mWorld.StartingLocation;
                        Rooms = new BindingList<Room>(mWorld.Rooms);
                    }
                    else
                    {
                        StartingLocation = "";
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public GameViewModel(Game game = null)
        {
            Game = game;
        }

        public void SaveWorld()
        {
            if (string.IsNullOrEmpty(FileName))
            {
                throw new InvalidProgramException("Filename expected");
            }
            updateStartingLoc();
            updateWelcomeMessage();
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(FileName))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, mGame);
            }
        }

        public void updateStartingLoc()
        {
            mWorld.StartingLocation = StartingLocation;
        }

        public void updateWelcomeMessage()
        {
            mGame.WelcomeMessage = WelcomeMessage;
        }

        private World mWorld;
        private Game mGame;

    }
}
