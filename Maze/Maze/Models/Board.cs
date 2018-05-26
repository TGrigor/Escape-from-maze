using Maze.Helper;
using System.Collections.Generic;
using System.Linq;

namespace Maze.Models
{
    class Board
    {
        public int Width { get; }
        public int Height { get; }

        public Player Player { get; private set; }
        public List<Block> Blocks { get; }

        public Board(int width, int height)
        {
            this.Width = width;
            this.Height = height;

            Blocks = new List<Block>();
        }

        /// <summary>
        ///     Insert new block to board
        /// </summary>
        /// <param name="newBlock">New block object</param>
        /// <returns>true/false depends block was inserted</returns>
        public bool Insert(Block newBlock)
        {
            //Validate block
            bool isValidBlock = Validation.ValidateBlockPosition(this, newBlock);

            if (isValidBlock)
            {
                Blocks.Add(newBlock);
            }

            return isValidBlock;
        }

        /// <summary>
        ///     Bulk insert blocks to board
        /// </summary>
        /// <param name="newBlocks">Block list</param>
        /// <returns>true/false depends blocks was inserted</returns>
        public bool Insert(List<Block> newBlocks)
        {
            if (newBlocks.Any())
            {
                //Get valid blocks
                List<Block> newValidBlocks = Validation.FilterValidBlocks(this, newBlocks);
                bool validBlocksExist = newValidBlocks.Any();

                if (validBlocksExist)
                {
                    Blocks.AddRange(newValidBlocks);
                    return validBlocksExist;
                }

                return validBlocksExist;
            }

            //New blocks doesn't exist
            return false;
        }

        /// <summary>
        ///     Insert Player to board
        /// </summary>
        /// <param name="newPlayer">New player object</param>
        /// <returns>true/false depends player was inserted</returns>
        public bool Insert(Player newPlayer)
        {
            //Validate player
            bool isValidPlayer = Validation.ValidateBlockPosition(this, newPlayer);

            if (isValidPlayer)
            {
                Player = newPlayer;
            }

            return isValidPlayer;
        }
    }
}
