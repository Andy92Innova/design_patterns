using Pattern.Builder.Builders;
using Domain;
using System;

namespace Pattern
{
    public class BuilderPattern : IPattern
    {
        public void Main()
        {

            var director = new BuilderDirector();
            var builder = new BuilderConcreto();
            director.Constructor = builder;

            Console.WriteLine("Producto con  características estándar");
            director.BuildPMV();
            Console.WriteLine(builder.GetProducto().ListaDePartes());
            Console.WriteLine("\n");

            Console.WriteLine("Producto con fulll características");
            director.BuildFullPartes();
            Console.WriteLine(builder.GetProducto().ListaDePartes());
            Console.WriteLine("\n");

            Console.WriteLine("Producto personalizado");
            builder.BuildParteA();
            builder.BuildParteC();
            Console.WriteLine(builder.GetProducto().ListaDePartes());
        }
    }
}
