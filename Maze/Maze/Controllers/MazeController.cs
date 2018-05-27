using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Controllers
{
    class MazeController
    {
        /// <summary>
        ///     Generate maze using 2d array
        ///     1(Unit)
        ///    -1(ExitDoor)
        ///     2(Player)
        /// </summary>
        /// <returns>Maze array</returns>
        public int[,] GenerateMazeArray()
        {
            return new int[,]{
                               {1,2,1,1,1,1,1,1,1,1,1,1,1},
                               {1,0,1,0,1,0,1,0,0,0,0,0,1},
                               {1,0,1,0,0,0,1,0,1,1,1,0,1},
                               {1,0,0,0,1,1,1,0,0,0,0,0,1},
                               {1,0,1,0,0,0,0,0,1,1,1,0,1},
                               {1,0,1,0,1,1,1,0,1,0,0,0,1},
                               {1,0,1,0,1,0,0,0,1,1,1,0,1},
                               {1,0,1,0,1,1,1,0,1,0,1,0,1},
                               {1,0,0,0,0,0,0,0,0,0,1,0,1},
                               {1,1,1,1,1,1,1,1,1,1,1,-1,1}
                             };
        }
    }
}
