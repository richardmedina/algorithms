using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory.MazeObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory
{
    /// <summary>
    /// Abstract Factory. Allows to create family of objects by implemented
    /// the following interface
    /// </summary>
    public interface IMazeFactory
    {
        Maze MakeMaze();
        Room MakeRoom(int n);
        Door MakeDoor(Room r1, Room r2);
    }
}
