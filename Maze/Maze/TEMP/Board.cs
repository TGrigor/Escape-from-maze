using Maze.Abstracts;
using Maze.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Maze.Models
{
    class Board
    {
        public int Width { get; }
        public int Height { get; }

        public Player Player { get; private set; }
        public ExitDoor ExitDoor { get; private set; }
        public List<Unit> Units { get; }

        protected Board(int width, int height)
        {
            this.Width = width;
            this.Height = height;

            Units = new List<Unit>();
        }

        /// <summary>
        ///     Insert new unit to board
        /// </summary>
        /// <param name="newUnit">New unit object</param>
        /// <returns>true/false depends unit was inserted</returns>
        public bool Insert(Unit newUnit)
        {
            //Validate unit
            bool isValidUnit = Validation.ValidateUnitPosition(this, newUnit);

            if (isValidUnit)
            {
                Units.Add(newUnit);
            }

            return isValidUnit;
        }

        /// <summary>
        ///     Bulk insert units to board
        /// </summary>
        /// <param name="newUnits">Unit list</param>
        /// <returns>true/false depends units was inserted</returns>
        public bool Insert(List<Unit> newUnits)
        {
            if (newUnits.Any())
            {
                //Get valid units
                List<Unit> newValidUnits = Validation.FilterValidUnits(this, newUnits);
                bool validUnitsExist = newValidUnits.Any();

                if (validUnitsExist)
                {
                    Units.AddRange(newValidUnits);
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
        public bool Insert(Player newPlayer)
        {
            //Validate player
            bool isValidPlayer = Validation.ValidateUnitPosition(this, newPlayer);

            if (isValidPlayer)
            {
                Player = newPlayer;
            }

            return isValidPlayer;
        }
    }
}
