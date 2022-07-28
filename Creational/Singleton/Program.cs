namespace Singleton
{
    class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton(), isThreadSafe: true);

        private Singleton()
        {
            Console.WriteLine("Creating new instance of Singleton class");
        }

        public static Singleton Instance { get => instance.Value; }

        public void DoSomething()
        {
            Console.WriteLine("Singleton class is doing something useful...");
            Thread.Sleep(1000);
            Console.WriteLine($"Current thread Id is {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Singleton class finished it's work");
        }
    }

    class App
    {
        private readonly Thread[] threads;

        public App()
        {
            threads = new Thread[]
            {
                new Thread(UseSingleton),
                new Thread(UseSingleton),
                new Thread(UseSingleton)
            };
        }

        public void Run()
        {
            foreach (var thread in threads)
            {
                thread.Start();
            }
        }

        private void UseSingleton()
        {
            Singleton.Instance.DoSomething();
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            new App().Run();
        }
    }
}
