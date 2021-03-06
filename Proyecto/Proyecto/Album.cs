﻿using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class Album
    {
        private string Name;
        private List<Song> SongList;
        

        public Album(string name, List<Song> songList)
        {
            Name = name;
            SongList = songList;
        }

        public string GetName()
        {
            return Name;
        }

        public List<Song> GetSongs()
        {
            return SongList;
        }
    }
}
