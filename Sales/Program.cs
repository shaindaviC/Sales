using System;

class SalesProgram
{
    static void Main()
    {
       
        Console.WriteLine("Enter number of days:");
        int n = int.Parse(Console.ReadLine());

      
        int[] sales = new int[n];

        
        Console.WriteLine("\nEnter sales for each day:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Day " + (i + 1) + ": ");
            sales[i] = int.Parse(Console.ReadLine());
        }

        
        Console.WriteLine("\nOriginal Sales:");
        PrintArray(sales);

       
        int[] sorted = new int[n];
        Array.Copy(sales, sorted, n);
        Array.Sort(sorted);

        Console.WriteLine("\nSorted Sales:");
        PrintArray(sorted);

     
        int total = 0;
        int highest = sales[0];
        int lowest = sales[0];

        for (int i = 0; i < n; i++)
        {
            total += sales[i];

            if (sales[i] > highest)
                highest = sales[i];

            if (sales[i] < lowest)
                lowest = sales[i];
        }

        Console.WriteLine("\n--- Summary ---");
        Console.WriteLine("Total Sales = " + total);
        Console.WriteLine("Highest Sale = " + highest);
        Console.WriteLine("Lowest Sale = " + lowest);

        // 7. Search for a value
        Console.WriteLine("\nEnter a sales value to search:");
        int searchValue = int.Parse(Console.ReadLine());

        bool found = false;
        for (int i = 0; i < n; i++)
        {
            if (sales[i] == searchValue)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine("Value FOUND in the sales data.");
        else
            Console.WriteLine("Value NOT FOUND.");

      
        int[] backup = new int[n];
        Array.Copy(sales, backup, n);
        Console.WriteLine("\nBackup array created.");

        
        Console.WriteLine("\nEnter another set of sales to compare:");
        int[] other = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Day " + (i + 1) + ": ");
            other[i] = int.Parse(Console.ReadLine());
        }

        bool equal = true;
        for (int i = 0; i < n; i++)
        {
            if (sales[i] != other[i])
            {
                equal = false;
                break;
            }
        }

        if (equal)
            Console.WriteLine("\nBoth sales datasets are IDENTICAL.");
        else
            Console.WriteLine("\nSales datasets are DIFFERENT.");
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
