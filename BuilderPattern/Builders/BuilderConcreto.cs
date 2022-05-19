using BuilderPattern.Interfaces;
using BuilderPattern.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Builders
{
    internal class BuilderConcreto : IBuilder
    {

        private Producto _producto;

        public BuilderConcreto() {
            Reset();
        }

        public void Reset() {
            _producto = new Producto();
        }

        public void BuildParteA()
        {
            _producto.Add("PARTE A");
        }

        public void BuildParteB()
        {
            _producto.Add("PARTE B");
        }

        public void BuildParteC()
        {
            _producto.Add("PARTE C");
        }

        public Producto GetProducto() {
            var producto = _producto;
            
            Reset();
            
            return producto;
        }
             

    }
}
