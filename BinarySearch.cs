
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Example usage
        int[] array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int target = GetUserInput("Enter the target number: ");

        int result = BinarySearch(array, target);

        if (result != -1)
            Console.WriteLine("Target element found at index: " + result);
        else
            Console.WriteLine("Target element not found.");

        Console.ReadLine();
    }

    public static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid; // Found the target element at index mid

            if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; // Target element not found
    }

    public static int GetUserInput(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
}