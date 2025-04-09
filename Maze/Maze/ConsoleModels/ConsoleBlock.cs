using Maze.Models;
using System;

namespace Maze.ConsoleModels
{
    class ConsoleBlock : Block
    {
        public ConsoleColor Color { get; }

        public ConsoleBlock(Position position, ConsoleColor color = ConsoleColor.Red): base(position)
        {
            Color = color;
        }
    }
}
