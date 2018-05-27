﻿using Maze.Abstracts;
using Maze.Helpers;
using Maze.Interfaces;
using Maze.Models;
using System.Collections.Generic;
using System.Linq;

namespace Maze.ConsoleModels
{
    class ConsoleBoard : IBoard<ConsolePlayer, ConsoleExitDoor, ConsoleBlock>
    {
        public Square Square { get; private set; }

        public ConsolePlayer Player { get; private set; }
        public ConsoleExitDoor ExitDoor { get; private set; }
        public List<ConsoleBlock> Blocks { get; }

        /// <summary>
        ///     Constructor use square for create empty board.
        /// </summary>
        /// <param name="square">Square of board</param>
        protected ConsoleBoard(Square square)
        {
            this.Square = square;
        }

        /// <summary>
        ///     Insert new block to board
        /// </summary>
        /// <param name="newBlock">New block object</param>
        /// <returns>true/false depends block was inserted</returns>
        public bool Insert(ConsoleBlock newBlock)
        {
            //Validate unit
            bool isValidUnit = true; //Validation.ValidateUnitPosition(this, newBlock);

            if (isValidUnit)
            {
                Blocks.Add(newBlock);
            }

            return isValidUnit;
        }

        /// <summary>
        ///     Bulk insert blocks to board
        /// </summary>
        /// <param name="newUnits">Block list</param>
        /// <returns>true/false depends blocks was inserted</returns>
        public bool Insert(List<ConsoleBlock> newUnits)
        {
            if (newUnits.Any())
            {
                //Get valid units
                List<ConsoleBlock> newValidUnits = Validation.FilterValidUnits(this, newUnits);
                bool validUnitsExist = newValidUnits.Any();

                if (validUnitsExist)
                {
                    Blocks.AddRange(newValidUnits);
                    return validUnitsExist;
                }

                return validUnitsExist;
            }

            //New units doesn't exist
            return false;
        }

        /// <summary>
        ///     Insert Player to board
        /// </summary>
        /// <param name="newPlayer">New player object</param>
        /// <returns>true/false depends player was inserted</returns>
        public bool Insert(ConsolePlayer newPlayer)
        {
            //Validate player
            bool isValidPlayer = Validation.ValidatePosition(this, newPlayer);

            if (isValidPlayer)
            {
                Player = newPlayer;
            }

            return isValidPlayer;
        }

        /// <summary>
        ///     Insert Exit Door to board
        /// </summary>
        /// <param name="exitDoor">New Exit Door object</param>
        /// <returns>true/false depends door was inserted</returns>
        public bool Insert(ConsoleExitDoor exitDoor)
        {
            //Validate player
            bool isValidDoor = true;//Validation.ValidateUnitPosition(this, newPlayer);

            if (isValidDoor)
            {
                ExitDoor = exitDoor;
            }

            return isValidDoor;
        }
    }
}
