namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Logger log = new Logger();

            LogManager manager = new LogManager(log);

            log.LogInAction("test log ");
        }
    }
}
