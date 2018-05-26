using Maze.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
