using Algorithms.DesignPatterns.GangOfFour.Structural.Flyweight.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<ShapeType, IShape> shapes;

        public FlyweightFactory()
        {
            shapes = new Dictionary<ShapeType, IShape>();
        }
        public IShape GetShape(ShapeType shapeType)
        {
            IShape shape;

            if (!shapes.ContainsKey(shapeType))
            {
                shape = CreateShape(shapeType);
                shapes.Add(shapeType, shape);
            }

            shape = shapes[shapeType];
            return shape;
        }

        private IShape CreateShape (ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Square:
                    return new Square();
            }

            throw new ArgumentException();
        }

        public int GetShapesCount ()
        {
            return shapes.Count;
        }

    }
}
