using Maze.Helpers;
using Maze.Interfaces;
using Maze.Models;

namespace Maze.ConsoleModels
{
    class ConsoleExitDoor: Unit, IExitDoor
    {
        public ConsoleExitDoor(Position position): base(position)
        {

        }
    }
}
