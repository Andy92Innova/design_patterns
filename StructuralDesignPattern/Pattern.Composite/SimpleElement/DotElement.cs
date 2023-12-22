using Pattern.Composite.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Composite.SimpleElement
{
    public class DotElement : IGraphic
    {
        public int X { get; set; }
        public int Y { get; set; }

        public DotElement(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing in (X:{X},Y:{Y})");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"Moving over (X:{x},Y:{y})");
        }

        public void Move()
        {
            Console.WriteLine($"Moving over (X:{X},Y:{Y})");
        }
    }
}
