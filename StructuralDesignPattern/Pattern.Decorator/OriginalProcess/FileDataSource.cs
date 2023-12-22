namespace Pattern.Decorator.OriginalProcess
{
    public class FileDataSource : IDataSource
    {
        private readonly string FileName;
        private string Data;
        public FileDataSource(string fileName)
        {
            FileName = fileName;
            Data = string.Empty;
        }

        public void ReadData()
        {
            Console.WriteLine($"FileDataSource=>Reading data of: {Data}");
        }

        public void WriteData(string data)
        {
            Console.WriteLine($"FileDataSource=>Writing data {data}");
            Data = data;
        }
    }
}
