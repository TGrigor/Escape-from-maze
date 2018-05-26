using Maze.Models;
using System.Collections.Generic;
using System.Linq;

namespace Maze.Helper
{
    static class Validation
    {
        /// <summary>
        ///     Validate block object position before inserting to board
        /// </summary>
        /// <param name="board">For getting board position</param>
        /// <param name="block">For getting block position</param>
        /// <returns> true/false depends board and block position </returns>
        public static bool ValidateBlockPosition(Board board, Block block)
        {
            //Checking existing block in the same position
            var isNotExist = !board.Blocks.Any(b => b.Equals(block));

            //Check range of Board larger than block position
            var isLarger = block.Position.CoordinateX < board.Width &&
                           block.Position.CoordinateY < board.Height;

            return isNotExist && isLarger;
        }

        /// <summary>
        ///     Validate and filter valid blocks
        /// </summary>
        /// <param name="board">For getting board position</param>
        /// <param name="blocks">For getting blocks positions</param>
        /// <returns>List of valid blocks</returns>
        public static List<Block> FilterValidBlocks(Board board, List<Block> blocks)
        {
            //Filter invalit blocks
            IEnumerable<Block> invalidBlocks = blocks.Where(b => board.Blocks.Contains(b));
            
            //Except and return valid blocks
            return blocks.Except(invalidBlocks).ToList();
        }
    }
}
