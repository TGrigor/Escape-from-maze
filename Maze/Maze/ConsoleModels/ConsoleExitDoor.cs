using Maze.Abstracts;
using Maze.Interfaces;
using Maze.Models;
using System;

namespace Maze.ConsoleModels
{
    class ConsoleExitDoor: ExitDoor, IExitDoor
    {
        public ConsoleColor Color { get; }

        public ConsoleExitDoor(Position position): base(position)
        {
            Color = ConsoleColor.Green;
        }
    }
}
