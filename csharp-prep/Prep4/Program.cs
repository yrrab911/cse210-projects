using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> nums = new List<int>();

        int fin = -1;
        while (fin != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            fin = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (fin != 0)
            {
                nums.Add(fin);
            }
        }

        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");
        
        int ave = sum / nums.Count;

        Console.WriteLine($"The average is: {ave}");
        
        int large = nums[0];
        foreach (int num in nums)
        {
            if (num > large)
            {
                large = num;
            }
        }

        Console.WriteLine($"The largest number is: {large}");
    }
}