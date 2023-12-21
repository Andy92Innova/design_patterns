using Pattern.AbstractFactory.Interfaces;

namespace Pattern.AbstractFactory.Productos
{
    internal class ProductoConcretoA1 : IAbstractProductoA
    {
        public string UsoFuncionA()
        {
            return "Resultado del producto A1";
        }
    }
}