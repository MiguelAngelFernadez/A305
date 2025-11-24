// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Miguel Angel del ciclo superior");
public class Matematicas
{
    public static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
