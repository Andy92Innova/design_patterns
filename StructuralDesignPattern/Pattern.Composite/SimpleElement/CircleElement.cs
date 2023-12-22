using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Composite.SimpleElement
{
    public class CircleElement : DotElement
    {
        public CircleElement(int x, int y) : base(x, y)
        {
        }

        public new void Draw()
        {
            Console.WriteLine($"Drawing circle over (X:{X},Y:{Y})");
        }

    }
}
