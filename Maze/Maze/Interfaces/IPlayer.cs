using Maze.Enums;
using Maze.Helpers;

namespace Maze.Interfaces
{
    interface IPlayer
    {
        void Step(StepState state);
        void Move();
    }
}
