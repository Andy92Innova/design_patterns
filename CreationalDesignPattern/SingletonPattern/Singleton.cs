namespace Pattern
{
    public sealed class Singleton
    {
        private static Singleton Instance;

        private static readonly object _lock = new object();

        private Singleton()
        {

        }

        public static Singleton GetSingleton(string value)
        {
            if (Instance == null)
            {
                lock (_lock)
                { //protección multihilos
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                        Instance.Value = value;
                    }
                }
            }

            return Instance;

        }

        public string Value { get; set; }

    }
}
