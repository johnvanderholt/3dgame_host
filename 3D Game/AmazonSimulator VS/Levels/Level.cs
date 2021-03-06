﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Levels
{
    public class Level
    {
        private bool[,] layout;
        private List<Coord> starts = new List<Coord>();
        private List<Coord> ends = new List<Coord>();
        private List<Coord> triggers = new List<Coord>();
        private List<Coord> bridges = new List<Coord>();
        private List<Coord> antiTriggers = new List<Coord>();
        private List<Coord> antiBridges = new List<Coord>();
        private List<Coord> fragiles = new List<Coord>();

        public Level(char[,] level_data)
        {
            layout = new bool[level_data.GetLength(0), level_data.GetLength(1)];
            for (int i = 0; i < level_data.GetLength(0); i++)
            {
                for (int j = 0; j < level_data.GetLength(1); j++)
                {
                    char square = level_data[i, j];
                    if (square == 'l') {
                        layout[i, j] = false;
                    }
                    else if (square == 'b') {
                        layout[i, j] = true;
                        starts.Add(new Coord(j,i));
                    }
                    else if (square == 'v') {
                        layout[i, j] = true;
                    }
                    else if (square == 'e') {
                        ends.Add(new Coord(j,i));
                        layout[i, j] = false;
                    }
                    else if (square == 't') {
                        triggers.Add(new Coord(j, i));
                        layout[i, j] = false;
                    }
                    else if (square == 'a') {
                        bridges.Add(new Coord(j, i));
                        layout[i, j] = false;
                    }
                    else if (square == 'f')
                    {
                        fragiles.Add(new Coord(j, i));
                        layout[i, j] = false;
                    }
                    else if (square == 'q')
                    {
                        antiTriggers.Add(new Coord(j, i));
                        layout[i, j] = false;
                    }
                    else if (square == 'u')
                    {
                        antiBridges.Add(new Coord(j, i));
                        layout[i, j] = false;
                    }
                }
            }
        }
      
        public string get_json()
        {
            return JsonConvert.SerializeObject(new {
                layout,
                starts,
                ends,
                triggers,
                bridges,
                fragiles,
                antiTriggers,
                antiBridges
            });
        }
    }

    public class Coord
    {
        public int x { get; }
        public int y { get; }

        public Coord(int x, int y)
        {
            this.y = y;
            this.x = x;
        }


    }
}