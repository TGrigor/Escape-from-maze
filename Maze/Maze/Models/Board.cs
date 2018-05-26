using Maze.Helper;
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        ///     Insert new block to board
        /// </summary>
        /// <param name="newBlock">New block object</param>
        /// <returns>true/false depends inserted block or not</returns>
        public bool Insert(Block newBlock)
        {
            //Validate block
            bool isValidBlock = Validation.ValidateBlockPosition(this, newBlock);

            if (isValidBlock)
            {
                _blocks.Add(newBlock);
            }

            return isValidBlock;
        }

        /// <summary>
        ///     Bulk insert blocks to board
        /// </summary>
        /// <param name="newBlocks">Block list</param>
        /// <returns>true/false depends  inserted blocks or not</returns>
        public bool Insert(List<Block> newBlocks)
        {
            if (newBlocks.Any())
            {
                //Get valid blocks
                List<Block> newValidBlocks = Validation.FilterValidBlocks(this, newBlocks);
                bool validBlocksExist = newValidBlocks.Any();

                if (validBlocksExist)
                {
                    _blocks.AddRange(newValidBlocks);
                    return validBlocksExist;
                }

                return validBlocksExist;
            }

            //New blocks doesn't exist
            return false;
        }
    }
}
