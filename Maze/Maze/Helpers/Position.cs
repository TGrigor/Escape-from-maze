namespace Maze.Helpers
{
    public struct Position
    {
        private int _coordinateX;
        private int _coordinateY;

        public int CoordinateX { get => _coordinateX; set => _coordinateX = value; }
        public int CoordinateY { get => _coordinateY; set => _coordinateY = value; }

        public override bool Equals(object obj)
        {
            Position PositionObj = (Position)obj;

            return _coordinateX.Equals(PositionObj.CoordinateX) && 
                   _coordinateY.Equals(PositionObj._coordinateY);
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + _coordinateX.GetHashCode();
            hash = (hash * 7) + _coordinateY.GetHashCode();
            return hash;
        }
    }
}
