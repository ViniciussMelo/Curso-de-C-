using Workout02.Entities.Enums;

namespace Workout02.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        abstract public double Area();
    }
}
