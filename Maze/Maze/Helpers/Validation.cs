using Maze.Abstracts;
using Maze.ConsoleModels;
using Maze.Interfaces;
using Maze.Models;
using System.Collections.Generic;
using System.Linq;

namespace Maze.Helpers
{
    static class Validation
    {
        /// <summary>
        ///     Validate unit object position before inserting to board
        /// </summary>
        /// <param name="board">For getting board position</param>
        /// <param name="unit">For getting unit position</param>
        /// <returns> true/false depends board and unit position </returns>
        public static bool ValidatePosition(IBoard<ConsolePlayer, ConsoleExitDoor, ConsoleBlock> board, Unit unit)
        {
            //Checking existing unit in the same position
            var isNotExist = !board.Blocks.Any(b => b.Equals(unit));

            //Check range of Board larger than unit position
            var isLarger = unit.Position.CoordinateX < board.Square.Width &&
                           unit.Position.CoordinateY < board.Square.Height;

            return isNotExist && isLarger;
        }

        //// <summary>
        ///     Validate and filter valid blocks
        /// </summary>
        /// <param name="board">For getting board position</param>
        /// <param name="blocks">For getting blocks positions</param>
        /// <returns>List of valid blocks</returns>
        public static List<ConsoleBlock> FilterInvalids(IBoard<ConsolePlayer, ConsoleExitDoor, ConsoleBlock> board, List<ConsoleBlock> blocks)
        {
            //Filter invalit blocks
            IEnumerable<ConsoleBlock> invalidBlocks = blocks.Where(b => board.Blocks.Contains(b));

            //Except and return valid blocks
            return blocks.Except(invalidBlocks).ToList();
        }
    }
}
