namespace Maze.Models
{
    struct Square
    {
        private int _width;
        private int _height;

        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }
    }
}
