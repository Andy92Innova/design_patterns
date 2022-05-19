using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Interfaces
{
    interface IBuilder
    {
        void BuildParteA();
        void BuildParteB();
        void BuildParteC();
    }
}
