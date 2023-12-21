namespace Pattern.AbstractFactory.Interfaces
{
    interface IAbstractFactory
    {
        IAbstractProductoA CrearProductoA();
        IAbstractProductoB CrearProductoB();
    }
}
