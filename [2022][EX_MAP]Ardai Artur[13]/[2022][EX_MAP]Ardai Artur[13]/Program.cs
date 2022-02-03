using System;

namespace _2022__EX_MAP_Ardai_Artur_13_
{
    class Program
    {
        //13
        static void Main(string[] args)
        {
            Console.WriteLine("n numere");
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
          
           
            long[] v = new long[n];
            for (int i = 0; i < n; i++)
            {
                long x = long.Parse(s.Split(" ")[i]);
                v[i] = x;
            }
            int k = 0;int d = 0;
          
            
           
                for (int i = 999; i > 99; i --)
                {
                    for (int j = 0; j < v.Length; j++)
                    {
                        if (i != v[j])
                            d++;
                    }
                    if (d >= v.Length&&k<2)
                    {
                        k++;
                        Console.Write(i + " ");
                    }
                    d = 0;
                }
            
        }
    }
}
