using System;
using System.IO;
using System.Threading.Tasks;
namespace _2022__EX_MAP_Ardai_Artur_19_
{
    class Program
    {
        //19
        public static async Task unu(int[] a, int k, int lim)
        {
            int db = 0;
            using TextWriter afara = new StreamWriter(@"..\..\combinari.out");
            if(db<=lim)
            for (int i = 1; i <= k; ++i)
            { await afara.WriteAsync(Convert.ToString(a[i]+" "));
                db++;
            }
        }
       public static  void comb(int k,int[]v,int n,int lim)
        {
            


            for (int i = v[k - 1] + 1; i <= n; ++i)
            {
                v[k] = i;
                unu(v, k,lim);
                comb(k + 1,v,n,lim);
            }
        }
     
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\combinari.in");
            string buffer = load.ReadLine();
            int n = int.Parse(buffer.Split(' ')[0]);
            int k = int.Parse(buffer.Split(' ')[1]);
            int[] v = new int[100];

            comb(1, v, n,k);

            


        }
    }
}
