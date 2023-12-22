using Pattern.Decorator.OriginalProcess;

namespace Pattern.Decorator.Decorators
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public string DATA { get; set; }
        public CompressionDecorator(IDataSource dataSource) : base(dataSource)
        {
            DATA = string.Empty;
        }

        public override void WriteData(string data)
        {
            base.WriteData(data);
            //TODO something
            DATA = data;
            Console.WriteLine($"CompressionDecorator=>Compressing data:{DATA}");
        }

        public override void ReadData()
        {
            base.ReadData();
            //TODO something
            Console.WriteLine($"CompressionDecorator=>Compressed data:{DATA}");
        }

    }
}
