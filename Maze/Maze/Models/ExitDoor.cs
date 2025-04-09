using Maze.Abstracts;
using Maze.Interfaces;

namespace Maze.Models
{
    class ExitDoor: Unit, IExitDoor
    {
        public ExitDoor(Position position): base(position)
        {
        }
    }
}
