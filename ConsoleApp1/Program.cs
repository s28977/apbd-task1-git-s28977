namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        PrintHello();
        Console.WriteLine("Enter username:");
        string userName = Console.ReadLine();
        Console.WriteLine("Username is: " + userName);
    }

    private static void PrintHello()
    {
        Console.WriteLine("Hello, World!");
    }
}