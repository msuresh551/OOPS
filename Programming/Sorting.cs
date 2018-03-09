using System;

namespace Programming
{
    public  class Sorting
    {
        public Sorting()
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 900 };
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length-write - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            Console.WriteLine("After Sorting application \n");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            
            Console.ReadLine();
        }
    }
}
