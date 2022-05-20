namespace AbstractFactoryPattern.Interfaces
{
    interface IAbstractFactory
    {
        IAbstractProductoA CrearProductoA();
        IAbstractProductoB CrearProductoB();
    }
}
