using Maze.Helper;

namespace Maze
{
    class Block
    {
        public Position Position { get; }

        public Block(Position blockPosition)
        {
            this.Position = blockPosition;
        }
    }
}
