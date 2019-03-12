using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory.MazeObjects;
using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory.MazeObjects.Enchanted;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory
{
    public class EnchantedMazeFactory : IMazeFactory
    {
        public Door MakeDoor(Room room1, Room room2)
        {
            return new DoorNeedingSpell
            {
                Room1 = room1,
                Room2 = room2
            };
        }

        public Maze MakeMaze()
        {
            return new Maze();
        }

        public Room MakeRoom(int n)
        {
            return new EnchantedRoom
            {
                Id = n
            };
        }
    }
}
