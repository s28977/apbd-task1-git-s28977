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

    public static double CalculateAverage(int[] array)
    {
        double sum = 0;
        foreach (var el in array)
        {
            sum += el;  
        }
        return sum/array.Length;
    }

    public static int CalculateMin(int[] array)
    {
        int min = array[0];
        foreach (int el in array)
        {
            if (el < min)
            {
                min = el;
            }
        }
        return min;
    }

    public static int CalculateMax(int[] array)
    {
        return 0;
    }
}