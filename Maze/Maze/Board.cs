using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Board
    {
        public int Width { get; }
        public int Height { get; }

        public List<Block> blocks;

        public Board(int width, int height)
        {
            this.Width = width;
            this.Width = height;
        }
    }
}
