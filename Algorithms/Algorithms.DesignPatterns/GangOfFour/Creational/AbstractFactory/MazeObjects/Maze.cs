using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory.MazeObjects
{
    public class Maze
    {
        public List<Room> Rooms = new List<Room> ();

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
    }
}
