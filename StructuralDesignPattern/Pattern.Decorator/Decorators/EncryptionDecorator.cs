using Pattern.Decorator.OriginalProcess;
using System.Data.Common;
using System.Text;

namespace Pattern.Decorator.Decorators
{
    public class EncryptionDecorator : DataSourceDecorator, IDataSource
    {
        public string DATA { get; set; }
        public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
        {
            DATA = string.Empty;
        }

        public override void WriteData(string data)
        {
            base.WriteData(data);
            //TODO something
            DATA = Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
            Console.WriteLine($"EncryptionDecorator=>Encoding data:{DATA}");

        }

        public override void ReadData()
        {
            base.ReadData();
            //TODO something
            Console.WriteLine($"EncryptionDecorator=>Encoded data:{DATA}");
        }


    }
}
