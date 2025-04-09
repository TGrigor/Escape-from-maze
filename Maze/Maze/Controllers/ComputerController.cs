using Maze.ConsoleModels;
using Maze.Helpers;
using Maze.Interfaces;
using Maze.Models;
using System;
using System.Collections.Generic;

namespace Maze.Controllers
{
    class ComputerController
    {
        List<KeyValuePair<int, Position>> whiteSpacePositions = new List<KeyValuePair<int, Position>>();
        Dictionary<Position, Position?> cameFrom = new Dictionary<Position, Position?>();

        public List<Position> PlayMazeLogic(IBoard<ConsolePlayer, ConsoleExitDoor, ConsoleBlock> board)
        {
            ConsoleController cons = new ConsoleController();
            Queue<Position> frontier = new Queue<Position>();
            cameFrom.Clear();
            whiteSpacePositions.Clear();

            Position start = board.Player.Position;
            Position exit = board.ExitDoor.Position;

            frontier.Enqueue(start);
            cameFrom[start] = null;

            bool found = false;

            while (frontier.Count > 0)
            {
                Position current = frontier.Dequeue();
                board.Player.Move(current);

                List<Position> neighbors = new List<Position>
                {
                    board.Player.StepTop(),
                    board.Player.StepBottom(),
                    board.Player.StepLeft(),
                    board.Player.StepRight()
                };

                foreach (var next in neighbors)
                {
                    if (!Validation.ValidatePosition(board, next)) continue;
                    if (cameFrom.ContainsKey(next)) continue;

                    frontier.Enqueue(next);
                    cameFrom[next] = current;

                    // Optional: Show exploration steps
                    cons.Drow(new ConsoleBlock(next), 1);
                    System.Threading.Thread.Sleep(50);

                    if (next.Equals(exit))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                    break;
            }

            // Now reconstruct the path
            List<Position> path = new List<Position>();
            if (!cameFrom.ContainsKey(exit)) return path; // no path found

            Position? p = exit;
            while (p != null)
            {
                path.Add(p.Value);
                p = cameFrom[p.Value];
            }
            path.Reverse();

            // Draw only the correct path clearly
            int step = 1;
            foreach (var pos in path)
            {
                cons.Drow(new ConsoleBlock(pos, ConsoleColor.Green), step++, 'o');
                System.Threading.Thread.Sleep(100);
            }

            return path;
        }


    }
}
