using Maze.Abstracts;
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

        /// <summary>
        ///     Change position do step
        /// </summary>
        /// <param name="state">Change step using state</param>
        public void Step(StepState state)
        {
            switch (state)
            {
                case StepState.Top:
                    StepTop();
                    break;
                case StepState.Bottom:
                    StepBottom();
                    break;
                case StepState.Right:
                    StepRight();
                    break;
                case StepState.Left:
                    StepLeft();
                    break;
            }
        }

        /// <summary>
        ///     Change player position to right +1
        /// </summary>
        private void StepRight()
        {
            this._position.CoordinateX++;
        }

        /// <summary>
        ///     Change player position to left +1
        /// </summary>
        private void StepLeft()
        {
            this._position.CoordinateX--;
        }

        /// <summary>
        ///     Change player position to top +1
        /// </summary>
        private void StepTop()
        {
            this._position.CoordinateY++;
        }

        /// <summary>
        ///     Change player position to bottom +1
        /// </summary>
        private void StepBottom()
        {
            this._position.CoordinateY--;
        }
    }
}
