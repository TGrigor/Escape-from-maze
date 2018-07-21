using Maze.Abstracts;
using Maze.Enums;
using Maze.Interfaces;
using Maze.Models;
using System;

namespace Maze.ConsoleModels
{
    class ConsolePlayer :Player, IPlayer
    {
        public ConsoleColor Color { get; }

        public ConsolePlayer(Position position): base(position)
        {
            Color = ConsoleColor.Blue;
        }
    }
}
