using Maze.ConsoleModels;
using Maze.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Controllers
{
    class ConsoleController
    {
        private ConsoleColor defaultColor = ConsoleColor.White;

        public void DrowBoard(IBoard<ConsolePlayer,ConsoleExitDoor,ConsoleBlock> board)
        {
            Drow(board.Blocks);
            Drow(board.Player);
            Drow(board.ExitDoor);
        }


        private void Drow(List<ConsoleBlock> blocks)
        {
            foreach (var block in blocks)
            {
                Drow(block);
            }
        }
        //TODO: Remove duplicate code
        private void Drow(ConsoleBlock block)
        {
            Console.ForegroundColor = block.Color;
            Console.SetCursorPosition(block.Position.CoordinateX, block.Position.CoordinateY);
            Console.WriteLine("X");
            Console.ForegroundColor = defaultColor;
        }

        //TODO: Remove duplicate code
        private void Drow(ConsolePlayer player)
        {
            Console.ForegroundColor = player.Color;
            Console.SetCursorPosition(player.Position.CoordinateX, player.Position.CoordinateY);
            Console.WriteLine("X");
            Console.ForegroundColor = defaultColor;
        }

        //TODO: Remove duplicate code
        private void Drow(ConsoleExitDoor exitDoor)
        {
            Console.ForegroundColor = exitDoor.Color;
            Console.SetCursorPosition(exitDoor.Position.CoordinateX, exitDoor.Position.CoordinateY);
            Console.WriteLine("X");
            Console.ForegroundColor = defaultColor;
        }
    }
}
