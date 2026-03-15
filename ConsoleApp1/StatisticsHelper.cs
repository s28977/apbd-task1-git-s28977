namespace ConsoleApp1;

public class StatisticsHelper
{
    public static int Sum(int[] array)
    {
        var sum = 0;
        foreach (var el in array)
        {
            sum += el;  
        }
        return sum;
    }
}