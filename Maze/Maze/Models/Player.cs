using Maze.Abstracts;
using Maze.Enums;
using Maze.Interfaces;
using Maze.Models;
using System;

namespace Maze.Models
{
    class Player :Unit, IPlayer
    {
        public Player(Position position): base(position)
        {
        }

        public void Move(Position position)
        {
            _position = position;
        }

        /// <summary>
        ///     Change position do step
        /// </summary>
        /// <param name="state">Change step using state</param>
        public void Step(StepState state)
        {
            //switch (state)
            //{
            //    case StepState.Top:
            //        StepTop();
            //        break;
            //    case StepState.Bottom:
            //        StepBottom();
            //        break;
            //    case StepState.Right:
            //        StepRight();
            //        break;
            //    case StepState.Left:
            //        StepLeft();
            //        break;
            //}
        }

        /// <summary>
        ///     Change player position to right +1
        /// </summary>
        public Position StepRight()
        {
            return new Position(_position.CoordinateX+1,_position.CoordinateY);
        }

        /// <summary>
        ///     Change player position to left +1
        /// </summary>
        public Position StepLeft()
        {
            return new Position(_position.CoordinateX-1, _position.CoordinateY);
        }

        /// <summary>
        ///     Change player position to top +1
        /// </summary>
        public Position StepTop()
        {
            return new Position(_position.CoordinateX, _position.CoordinateY+1);
        }

        /// <summary>
        ///     Change player position to bottom +1
        /// </summary>
        public Position StepBottom()
        {
            return new Position(_position.CoordinateX, _position.CoordinateY-1);
        }
    }
}
