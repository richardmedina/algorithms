using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory.MazeObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory
{
    public class MazeGame
    {
        public Maze CreateMaze (IMazeFactory factory)
        {
            var maze = factory.MakeMaze();
            var r1 = factory.MakeRoom(1);
            var r3 = factory.MakeRoom(3);

            var aDoor = factory.MakeDoor(r1, r3);

            maze.AddRoom(r1);
            maze.AddRoom(r3);

            return maze;
        }
    }
}
