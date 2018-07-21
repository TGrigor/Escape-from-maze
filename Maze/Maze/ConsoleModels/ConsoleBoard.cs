using Maze.Abstracts;
using Maze.Helpers;
using Maze.Interfaces;
using Maze.Models;
using System.Collections.Generic;
using System.Linq;

namespace Maze.ConsoleModels
{
    class ConsoleBoard : Board<ConsolePlayer,ConsoleExitDoor,ConsoleBlock>
    {
        public ConsoleBoard(Square square): base(square)
        {
            
        }
       
    }
}
