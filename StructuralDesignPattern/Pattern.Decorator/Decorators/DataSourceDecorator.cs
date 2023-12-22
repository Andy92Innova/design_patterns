using Pattern.Decorator.OriginalProcess;

namespace Pattern.Decorator.Decorators
{
    public abstract class DataSourceDecorator : IDataSource
    {
        public IDataSource _dataSource { get; set; }

        public DataSourceDecorator(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public virtual void ReadData()
        {
            _dataSource.ReadData();
        }

        public virtual void WriteData(string data)
        {
            _dataSource.WriteData(data);
        }
    }
}
