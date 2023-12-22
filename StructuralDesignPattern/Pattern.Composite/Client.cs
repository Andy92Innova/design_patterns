using Domain;
using Pattern.Composite.CompoundElement;
using Pattern.Composite.Interface;
using Pattern.Composite.SimpleElement;

namespace Pattern
{
    public class CompositePattern : IPattern
    {
        public void Main()
        {
            var dot = new DotElement(1, 2);
            var circle = new CircleElement(4, 5);

            var composeElement = new CompoundGraphic()
            {
                Graphics = new List<IGraphic>()
                {
                    new DotElement(3,5),
                    new DotElement(4,6),
                    new DotElement(5,7),
                    new CircleElement(10,4),
                    new CircleElement(11,8),
                    new CircleElement(12,9),
                }
            };


            dot.Move();
            dot.Draw();

            circle.Move();
            circle.Draw();

            composeElement.Move();
            composeElement.Draw();
        }
    }
}