using System;

public class Program
{
    static int[] myArray = new int[] { 1, 3, 4, 2, 7, 0 };

    public static void Main()
    {
        FindElementsWithSum10(myArray);
    }

    static void FindElementsWithSum10(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == 10)
                {
                    Console.WriteLine(array[i] + " " + array[j]);
                    return;
                }
            }
        }
    }

}
