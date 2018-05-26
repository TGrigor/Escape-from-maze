using Maze.Helpers;

namespace Maze.Models
{
    class Unit
    {
        protected Position _position;

        public Position Position { get => _position; }

        protected Unit(Position unitPosition)
        {
            this._position = unitPosition;
        }

        /// <summary>
        ///     Checking equals of unit objects
        /// </summary>
        /// <param name="obj">unit object</param>
        /// <returns>true if objects equals</returns>
        public override bool Equals(object obj)
        {
            Unit unitObj = (Unit)obj;

            return unitObj.Position.Equals(this.Position);
        }
        
        /// <summary>
        ///     Generate uniq hash for object of unit
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + _position.GetHashCode();
            return hash;
        }
    }
}
