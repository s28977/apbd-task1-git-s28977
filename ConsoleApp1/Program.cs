namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        PrintHello();
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(username))
        {
            Console.WriteLine("Username cannot be empty.");
        }
        else
        {
            Console.WriteLine("Hello " + username);
        }
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(StatisticsHelper.Sum(array));
    }

    private static void PrintHello()
    {
        Console.WriteLine("Hello, World!");
    }
}