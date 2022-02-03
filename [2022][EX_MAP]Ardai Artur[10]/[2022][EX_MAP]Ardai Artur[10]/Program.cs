using System;

namespace _2022__EX_MAP_Ardai_Artur_10_
{
    class Program
    {
        static void Main(string[] args)
        {
            //10
            string s = Console.ReadLine();
            int n = int.Parse(s.Split(' ')[0]);
            int m = int.Parse(s.Split(' ')[1]);
            int a = 0;
            if (m * 2 >= n) Console.Write(0 + " ");
            else Console.Write(n - 2 * m + " ");
            while (a * (a - 1) / 2 < m) a++;

            Console.Write(n-a);
           
        }
    }
}
