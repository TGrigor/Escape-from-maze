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

        /// <summary>
        ///     Validate and filter valid units
        /// </summary>
        /// <param name="board">For getting board position</param>
        /// <param name="units">For getting units positions</param>
        /// <returns>List of valid units</returns>
        public static List<Unit> FilterValidUnits(IBoard<ConsolePlayer, ConsoleExitDoor, ConsoleBlock> board, List<Unit> units)
        {
            //Filter invalit units
            IEnumerable<Unit> invalidUnits = units.Where(b => board.Blocks.Contains(b));

            //Except and return valid units
            return units.Except(invalidUnits).ToList();
        }
    }
}
