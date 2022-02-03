using System;

namespace _2022__EX_MAP_Ardai_Artur_05_
{
    class Program
    {
        static void Main(string[] args)
        {
            //05 
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string buffer;
            int[,] a = new int[n, n];
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(s.Split(" ")[i]);
                v[i] = x;
            }

            int e = 0;
            for (int i = 0; i < n; i++)
            { if (i % 2 == 0)
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        a[j, i] = v[e];
                        e++;
                    }
                }
                if (i % 2 != 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        a[j, i] = v[j];
                    }
                }
                e = 0;
            }


            Console.WriteLine();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
           
        }
    }
}
