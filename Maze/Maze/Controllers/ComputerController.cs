using Maze.Abstracts;
using Maze.ConsoleModels;
using Maze.Helpers;
using Maze.Interfaces;
using Maze.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Controllers
{
    class ComputerController
    {
        List<KeyValuePair<int, Position>> whiteSpacePositions = new List<KeyValuePair<int, Position>>();

        public List<KeyValuePair<int, Position>> PlayMazeLogic(IBoard<ConsolePlayer, ConsoleExitDoor, ConsoleBlock> board)
        {
            ConsoleController cons = new ConsoleController();
            int n = 1;
            bool findExitDoor = false;

            whiteSpacePositions.Add(new KeyValuePair<int, Position>(n, board.Player.Position));
            while (!findExitDoor)
            {
                var listOfPositions = whiteSpacePositions.Where(k => k.Key == n).ToList();
                for (int j = 0; j < listOfPositions.Count; j++)
                {
                    board.Player.Move(listOfPositions[j].Value);

                    if (Validation.ValidatePosition(board, board.Player.StepTop()) && !whiteSpacePositions.Any(w => w.Value.Equals(board.Player.StepTop())) && !board.ExitDoor.Position.Equals(board.Player.StepTop()))
                    {
                        whiteSpacePositions.Add(new KeyValuePair<int, Position>(n + 1, board.Player.StepTop()));
                        cons.Drow(new ConsoleBlock(board.Player.StepTop()), n + 1);
                    }

                    if (Validation.ValidatePosition(board, board.Player.StepBottom()) && !whiteSpacePositions.Any(w => w.Value.Equals(board.Player.StepBottom())) && !board.ExitDoor.Position.Equals(board.Player.StepBottom()))
                    {
                        whiteSpacePositions.Add(new KeyValuePair<int, Position>(n + 1, board.Player.StepBottom()));
                        cons.Drow(new ConsoleBlock(board.Player.StepBottom()), n + 1);

                    }

                    if (Validation.ValidatePosition(board, board.Player.StepRight()) && !whiteSpacePositions.Any(w => w.Value.Equals(board.Player.StepRight())) && !board.ExitDoor.Position.Equals(board.Player.StepRight()))
                    {
                        whiteSpacePositions.Add(new KeyValuePair<int, Position>(n + 1, board.Player.StepRight()));
                        cons.Drow(new ConsoleBlock(board.Player.StepRight()), n + 1);
                    }

                    if (Validation.ValidatePosition(board, board.Player.StepLeft()) && !whiteSpacePositions.Any(w => w.Value.Equals(board.Player.StepLeft())) && !board.ExitDoor.Position.Equals(board.Player.StepLeft()))
                    {
                        whiteSpacePositions.Add(new KeyValuePair<int, Position>(n + 1, board.Player.StepLeft()));
                        cons.Drow(new ConsoleBlock(board.Player.StepLeft()), n + 1);
                    }

                    if (board.ExitDoor.Position.Equals(board.Player.StepTop()) || board.ExitDoor.Position.Equals(board.Player.StepBottom()) || board.ExitDoor.Position.Equals(board.Player.StepRight()) || board.ExitDoor.Position.Equals(board.Player.StepLeft()))
                    {
                        findExitDoor = true;
                        whiteSpacePositions.Add(new KeyValuePair<int, Position>(n + 1, board.ExitDoor.Position));
                    }
                }
                n++;
            }
            return whiteSpacePositions;
        }
    }
}
