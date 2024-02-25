internal class Program
{
    private static void Main(string[] args)
    {
        int result = Add(1, 2);
        Console.WriteLine($"The result is {result}");
    }

    private static int Add(int a, int b)
    {
        return a + b;
    }
}
