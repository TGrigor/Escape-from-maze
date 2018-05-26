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

        public override bool Equals(object obj)
        {
            Block blockObj = (Block)obj;

            return blockObj.Position.Equals(this.Position);
        }
    }
}
