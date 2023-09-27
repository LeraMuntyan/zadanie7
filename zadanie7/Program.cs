using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {



            Random rand = new Random();
            int n = 20;
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-3, 3);
                Console.Write("{0,3} ", arr[i]);
            }
            Console.WriteLine();
            int j = 0;
            while (j < n / 2)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == 0)
                    {
                        int f = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = f;
                    }
                }
                j++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    break;
                Console.Write("{0,3} ", arr[i]);
            }
            Console.WriteLine();
            {
                Console.WriteLine("Esli hotite povtorit vvod, vvedite 1, inache lubuyu dr cifru");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) Main();
                return;
            }
            Console.ReadLine();

        }
    }
}

