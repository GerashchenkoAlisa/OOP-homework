using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayDoing
{
    public class ArrayProcessing
    {
        public int[] data;

        /// <summary>  
        /// Input array from the keyboard.  
        /// </summary>  
        public void MaidArray()
        {
            int size = 0;
            Console.Write("Enter the number of array elements: ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("The number of array elements must be a positive number.\nEnter the number of array elements:");
            }

            data = new int[size];

            for (int i = 0; i < size; i++)
            {
                bool validInput = false;
                while (!validInput)
                {
                    Console.Write($"Enter element № {i + 1}: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int value))
                    {
                        data[i] = value;
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Error! \nEnter an integer:");
                    }
                }
            }
        }

        /// <summary>  
        /// Display the array on the screen.  
        /// </summary>  
        public void PrintArray()
        {
            Console.WriteLine("Array: " + string.Join(" ", data));
        }

        /// <summary>
        /// Calculate the sum of negative numbers after the second zero in the array.
        /// </summary>
        public static int SumNegativeAfter2Zero(int[] array)
        {
            int sum = 0;
            int count = 0;
            int i = 0;

            while (i < array.Length && count < 2)
            {
                if (array[i] == 0)
                {
                    count++;
                }
                i++;
            }

            for (; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine($"Calculation result: {sum}");
            return sum;
        }
    }
}