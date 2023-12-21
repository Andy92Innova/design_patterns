using Pattern.AbstractFactory.Interfaces;

namespace Pattern.AbstractFactory.Productos
{
    internal class ProductoConcretoB2 : IAbstractProductoB
    {
        public string UsoFuncionB()
        {
            return "Resultado del producto B2";
        }

        public string OtroUsoFuncionB(IAbstractProductoA colaborador)
        {
            var resultA = colaborador.UsoFuncionA();
            return $"Este es el resultado del producto B1 con colaboración de ({resultA})";
        }


    }
}