using Domain;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pattern
{
    public class SingletonPattern : IPattern
    {
        public void Main()
        {
            Task.Factory.StartNew(() => TestSingleton("C"));
            Thread.Sleep(1000);
            TestSingleton("A");
            TestSingleton("B");
        }

        private void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetSingleton(value);
            Console.WriteLine(singleton.Value);
        }

    }
}
