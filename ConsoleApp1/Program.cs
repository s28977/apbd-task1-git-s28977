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
    }

    private static void PrintHello()
    {
        Console.WriteLine("Hello, World!");
    }
}