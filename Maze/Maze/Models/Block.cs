using Maze.Helper;

namespace Maze.Models
{
    internal class Block
    {
        internal Position _position;

        public Position Position { get => _position; }

        public Block(Position blockPosition)
        {
            this._position = blockPosition;
        }

        public override bool Equals(object obj)
        {
            Block blockObj = (Block)obj;

            return blockObj.Position.Equals(this.Position);
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + _position.GetHashCode();
            return hash;
        }
    }
}
