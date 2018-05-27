using Maze.Abstracts;
using Maze.ConsoleModels;
using Maze.Controllers;
using Maze.Helpers;
using Maze.Interfaces;
using Maze.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Maze
{
    class GameController
    {
        MazeController _mazeController;
        ConsoleController _consoleController;
        IBoard<ConsolePlayer, ConsoleExitDoor, ConsoleBlock> _consoleBoard;

        public GameController()
        {
            _mazeController = new MazeController();
            _consoleController = new ConsoleController();
            _consoleBoard = new ConsoleBoard(new Square()
                                             {
                                                 Width = 20,
                                                 Height = 20
                                             });
        }

        public void StartGame()
        {
            CreateBoard();
        }

        public void CreateBoard()
        {
            var mazeArray = _mazeController.GenerateMazeArray();

            ConsolePlayer player = new ConsolePlayer(new Position { });
            ConsoleExitDoor exitDoor = new ConsoleExitDoor(new Position { });
            List<ConsoleBlock> blocks = Helper.ConvertMazeArrayToObject(mazeArray, ref player, ref exitDoor);

            //Insert blocks into board
            _consoleBoard.Insert(blocks);
            _consoleBoard.Insert(player);
            _consoleBoard.Insert(exitDoor);

            _consoleController.DrowBoard(_consoleBoard);
        }
    }
}
