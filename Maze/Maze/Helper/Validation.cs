using System.Linq;

namespace Maze.Helper
{
    static class Validation
    {
        public static bool ValidateBlockPosition(Board board, Block block)
        {
            //Checking existing block in the same position
            var isNotExist = !board.Blocks.Any(b => b.Position.Equals(block.Position));

            //Check range of Board larger than block position
            var isLarger = block.Position.CoordinateX < board.Width &&
                           block.Position.CoordinateY < board.Height;
            return isNotExist && isLarger;
        }
    }
}
