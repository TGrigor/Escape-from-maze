using Maze.Abstracts;
using Maze.Helpers;
using Maze.Interfaces;
using Maze.Models;
using System;

namespace Maze.ConsoleModels
{
    class ConsoleBlock : Block
    {
        public ConsoleColor Color { get; }

        public ConsoleBlock(Position position): base(position)
        {
            Color = ConsoleColor.Red;
        }
    }
}
