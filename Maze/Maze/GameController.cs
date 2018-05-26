using Maze.Helper;
using System.Collections.Generic;

namespace Maze
{
    class GameController
    {
        private Board _board;

        public GameController()
        {
        }

        public void StartGame()
        {
            _board = new Board(10, 10);
        }

        private List<Block> GenerateBlocks()
        {
            return new List<Block>();
        }
    }
}
