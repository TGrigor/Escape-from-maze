using Maze.Enums;
using Maze.Interfaces;
using Maze.Models;

namespace Maze.ConsoleModels
{
    class ConsolePlayer :Unit, IPlayer
    {
        public ConsolePlayer(Position position): base(position)
        {
                
        }

        public void Move()
        {
            throw new System.NotImplementedException();
        }

        public void Step(StepState state)
        {
            throw new System.NotImplementedException();
        }

        public void StepBottom()
        {
            throw new System.NotImplementedException();
        }

        public void StepLeft()
        {
            throw new System.NotImplementedException();
        }

        public void StepRight()
        {
            throw new System.NotImplementedException();
        }

        public void StepTop()
        {
            throw new System.NotImplementedException();
        }
    }
}
