using Domain;
using Pattern.Decorator.Decorators;
using Pattern.Decorator.OriginalProcess;

namespace Pattern
{
    public class DecoratorPattern : IPattern
    {
        public void Main()
        {
            string data = "001001001010101010";
            IDataSource dataSource = new FileDataSource("decoratorPattern.txt");
            dataSource.WriteData(data);
            Console.WriteLine("\n\n");
            dataSource = new EncryptionDecorator(dataSource);
            dataSource.WriteData(data);
            Console.WriteLine("\n\n");
            dataSource = new CompressionDecorator(dataSource);
            dataSource.WriteData(data);
            Console.WriteLine("\n\n");
            dataSource.ReadData();

        }
    }
}