using Pattern.AbstractFactory.Interfaces;

namespace Pattern.AbstractFactory.Productos
{
    internal class ProductoConcretoA2 : IAbstractProductoA
    {
        public string UsoFuncionA()
        {
            return "Resultado del producto A2";
        }
    }
}