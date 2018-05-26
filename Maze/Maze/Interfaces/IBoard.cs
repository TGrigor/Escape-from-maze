using Maze.Abstracts;
using Maze.Models;
using System.Collections.Generic;

namespace Maze.Interfaces
{
    interface IBoard<TPlayer,TExitDoor,TBlock> where TPlayer : Unit, IPlayer 
                                               where TExitDoor: Unit, IExitDoor 
                                               where TBlock: Unit
    {
        Square Square { get; set; }
        TPlayer Player { get; }
        TExitDoor ExitDoor { get; }
        IEnumerable<TBlock> Blocks { get; }

        bool Insert(TBlock block);
        bool Insert(IEnumerable<TBlock> blocks);
        bool Insert(TPlayer player);
        bool Insert(TExitDoor exitDoor);
    }
}
