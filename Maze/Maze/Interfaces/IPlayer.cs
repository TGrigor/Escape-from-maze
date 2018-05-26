using Maze.Enums;
using Maze.Helpers;

namespace Maze.Interfaces
{
    interface IPlayer
    {
        void Step(StepState state);
        void StepRight();
        void StepLeft();
        void StepTop();
        void StepBottom();
        void Move();
    }
}
