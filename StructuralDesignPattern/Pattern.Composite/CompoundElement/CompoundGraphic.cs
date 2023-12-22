using Pattern.Composite.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Composite.CompoundElement
{
    public class CompoundGraphic : IGraphic
    {
        public required IList<IGraphic> Graphics;

        public void Add(IGraphic element)
        {
            Graphics.Add(element);
        }

        public void Remove(IGraphic element)
        {
            Graphics.Remove(element);
        }

        public void Move(int x, int y)
        {
            foreach (IGraphic element in Graphics)
            {
                element.Move(x, y);
            }
        }

        public void Move()
        {
            foreach (IGraphic element in Graphics)
            {
                element.Move();
            }
        }

        public void Draw()
        {
            foreach (IGraphic element in Graphics)
            {
                element.Draw();
            }
        }

    }
}
