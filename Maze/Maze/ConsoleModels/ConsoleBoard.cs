﻿using Maze.Interfaces;
using Maze.Models;
using System;
using System.Collections.Generic;

namespace Maze.ConsoleModels
{
    class ConsoleBoard : IBoard<ConsolePlayer, ConsoleExitDoor, ConsoleBlock>
    {
        public Square Square { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ConsolePlayer Player => throw new NotImplementedException();

        public ConsoleExitDoor ExitDoor => throw new NotImplementedException();

        public IEnumerable<ConsoleBlock> Blocks => throw new NotImplementedException();

        public bool Insert(ConsoleBlock block)
        {
            throw new NotImplementedException();
        }

        public bool Insert(IEnumerable<ConsoleBlock> blocks)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ConsolePlayer player)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ConsoleExitDoor exitDoor)
        {
            throw new NotImplementedException();
        }
    }
}
