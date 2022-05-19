using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Productos
{
    internal class ProductoConcretoA2 : IAbstractProductoA
    {
        public string UsoFuncionA() {
            return "Resultado del producto A2";
        }
    }
}