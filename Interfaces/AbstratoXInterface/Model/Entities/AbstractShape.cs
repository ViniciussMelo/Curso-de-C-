using AbstratoXInterface.Model.Enums;

namespace AbstratoXInterface.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
