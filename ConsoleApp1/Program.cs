namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        PrintHello();
        Console.WriteLine("Enter username:");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Username cannot be empty.");
        }
        else
        {
            Console.WriteLine("Hello " + name);
        }
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(StatisticsHelper.Sum(array));
    }

    private static void PrintHello()
    {
        Console.WriteLine("Hello, World!");
    }
}