namespace DiContainer;
public class LoggerNum : ILogger
{
    private int _num;
    public void Log(string mensaje)
    {
        Console.WriteLine($"{++_num} {DateTime.Now:hh:mm:ss:fff} {mensaje}");
    }
}