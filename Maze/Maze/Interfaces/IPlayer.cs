using Maze.Enums;
using Maze.Helpers;
using Maze.Models;

namespace Maze.Interfaces
{
    interface IPlayer
    {
        void Step(StepState state);
        void Move(Position position);
    }
}
