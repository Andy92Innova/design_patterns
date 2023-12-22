using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Composite.Interface
{
    public interface IGraphic
    {
        void Move();
        void Move(int x, int y);
        void Draw();
    }
}
