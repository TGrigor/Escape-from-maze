using Maze.Abstracts;
using Maze.Interfaces;
using Maze.Models;
using System;

namespace Maze.Models
{
    class ExitDoor: Unit, IExitDoor
    {
        public ExitDoor(Position position): base(position)
        {
        }
    }
}
