using System.Collections.Generic;

namespace Maze
{
    class Board
    {
        private List<Block> _blocks;

        public int Width { get; }
        public int Height { get; }

        public List<Block> Blocks { get => _blocks; }

        public Board(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
