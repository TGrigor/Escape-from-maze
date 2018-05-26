using Maze.Models;
using System.Collections.Generic;
using System.Linq;

namespace Maze.Helper
{
    static class Validation
    {
        /// <summary>
        ///     Validate unit object position before inserting to board
        /// </summary>
        /// <param name="board">For getting board position</param>
        /// <param name="unit">For getting unit position</param>
        /// <returns> true/false depends board and unit position </returns>
        public static bool ValidateUnitPosition(Board board, Unit unit)
        {
            //Checking existing unit in the same position
            var isNotExist = !board.Units.Any(b => b.Equals(unit));

            //Check range of Board larger than unit position
            var isLarger = unit.Position.CoordinateX < board.Width &&
                           unit.Position.CoordinateY < board.Height;

            return isNotExist && isLarger;
        }

        /// <summary>
        ///     Validate and filter valid units
        /// </summary>
        /// <param name="board">For getting board position</param>
        /// <param name="units">For getting units positions</param>
        /// <returns>List of valid units</returns>
        public static List<Unit> FilterValidUnits(Board board, List<Unit> units)
        {
            //Filter invalit units
            IEnumerable<Unit> invalidUnits = units.Where(b => board.Units.Contains(b));

            //Except and return valid units
            return units.Except(invalidUnits).ToList();
        }
    }
}
