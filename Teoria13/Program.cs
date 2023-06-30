class Program
{
    static void Main(string[] args)
    {
        Task t = new Task(ImprimirA);
        t.Start();
        for (int i = 1; i <= 100; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        t.Wait();
    }
    static void ImprimirA()
    {
        for (int i = 1; i <= 1000; i++)
        {
            Console.Write("A");
        }
        Console.WriteLine(" FIN ");
    }
}