using Maze.Abstracts;
using Maze.Helpers;
using Maze.Interfaces;
using Maze.Models;
using System.Collections.Generic;
using System.Linq;

namespace Maze.Models
{
    class Board<P,E,B> : IBoard<P, E, B> where B :Block 
                                         where E: ExitDoor
                                         where P: Player
    {
        public Square Square { get; private set; }

        public P Player { get; private set; }
        public E ExitDoor { get; private set; }
        public List<B> Blocks { get; }

        /// <summary>
        ///     Constructor use square for create empty board.
        /// </summary>
        /// <param name="square">Square of board</param>
        public Board(Square square)
        {
            this.Square = square;
            Blocks = new List<B>();
        }

        /// <summary>
        ///     Insert new block to board
        /// </summary>
        /// <param name="newBlock">New block object</param>
        /// <returns>true/false depends block was inserted</returns>
        public bool Insert(B newBlock)
        {
            //Validate unit
            //bool isValidUnit = Validation.ValidatePosition((IBoard<Player, ExitDoor,Block>)this, newBlock);

            Blocks.Add(newBlock);
            //if (isValidUnit)
            //{
            //}

            return true;//isValidUnit;
        }

        /// <summary>
        ///     Bulk insert blocks to board
        /// </summary>
        /// <param name="newBlocks">Block list</param>
        /// <returns>true/false depends blocks was inserted</returns>
        public bool Insert(List<B> blocks)
        {
            if (blocks.Any())
            {
                Blocks.AddRange(blocks);

                return true;
            }

            //New blocks doesn't exist
            return false;
        }

        /// <summary>
        ///     Insert Player to board
        /// </summary>
        /// <param name="newPlayer">New player object</param>
        /// <returns>true/false depends player was inserted</returns>
        public bool Insert(P newPlayer)
        {
            //Validate player
            //bool isValidPlayer = Validation.ValidatePosition((IBoard<Player, ExitDoor, Block>)this, newPlayer);

            //if (isValidPlayer)
            //{
                Player = newPlayer;
            //}

            return true;//isValidPlayer;
        }

        /// <summary>
        ///     Insert Exit Door to board
        /// </summary>
        /// <param name="exitDoor">New Exit Door object</param>
        /// <returns>true/false depends door was inserted</returns>
        public bool Insert(E exitDoor)
        {
            //Validate player
            //bool isValidDoor = Validation.ValidatePosition((IBoard<Player, ExitDoor, Block>)this, exitDoor);

            //if (isValidDoor)
            //{
                ExitDoor = exitDoor;
            //}

            return true;//isValidDoor;
        }
    }
}
