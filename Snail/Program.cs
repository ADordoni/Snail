using System;

namespace Snail
{
    class Program
    {
        // Given an M x N array, return the array elements arranged from
        // outermost elements to the middle element, traveling clockwise.

        static void Main(string[] args)
        {
            Console.WriteLine("FIRST EXAMPLE");
            int[,] arr1 = new int[3, 3] { { 1, 2, 3 },
                                          { 4, 5, 6 },
                                          { 7, 8, 9 } };
            int[] array1 = Order.Snail(arr1);

            foreach (int i in array1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("SECOND EXAMPLE");
            int[,] arr2 = new int[4, 3] { { 1, 2, 3 }, 
                                          { 4, 5, 6 }, 
                                          { 7, 8, 9 }, 
                                         { 10, 11, 12} };
            int[] array2 = Order.Snail(arr2);

            foreach(int i in array2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("THIRD EXAMPLE");
            int[,] arr3 = new int[3, 4] { { 1, 2, 3, 4 },
                                          { 5, 6, 7, 8 },
                                         { 9, 10, 11, 12 } };
            int[] array3 = Order.Snail(arr3);

            foreach (int i in array3)
            {
                Console.WriteLine(i);
            }
        }
    }
    
    class Order
    {
        public static int[] Snail(int[,] array)
        {
            int cant = array.Length;
            
            int[] res = new int[cant];
            int index = 0;

            while (cant > 0)
            {
                int x = array.GetLength(1);
                int y = array.GetLength(0);
                for (int i = 0; i < x; i++)
                {
                    res[index] = array[0, i];
                    index++;
                    cant--;
                }
                int[,] arr = new int[x, y - 1];
                for (int i = 0; i < x; i++)
                {                    
                    for (int j = 0; j < y - 1; j++)
                    {                        
                        arr[i, j] = array[j + 1, x - 1 - i];                        
                    }
                }
                array = arr;
            }
            return res;
        }
    }
}