using Maze.Abstracts;
using Maze.ConsoleModels;
using Maze.Interfaces;
using Maze.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Helpers
{
    static class Helper
    {
        /// <summary>
        ///     Convert array to object
        /// </summary>
        /// <param name="maze">maze array</param>
        /// <returns>object list</returns>
        public static List<ConsoleBlock> ConvertMazeArrayToObject(int[,] maze, ref ConsolePlayer player, ref ConsoleExitDoor exitDoor)
        {
            List<ConsoleBlock> units = new List<ConsoleBlock>();

            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    Position position = new Position(i, j);
                    switch (maze[i, j])
                    {
                        case -1:
                            exitDoor = new ConsoleExitDoor(position);
                            break;

                        case 1:
                            units.Add(new ConsoleBlock(position));
                            break;
                        case 2:
                            player = new ConsolePlayer(position);
                            break;
                    }
                }
            }

            return units;
        }
    }
}
