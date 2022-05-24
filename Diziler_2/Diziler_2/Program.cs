using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sayilar = new int[3, 4];
            Random rastgele = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sayilar[i, j] = rastgele.Next(1, 100);
                }
            }

            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 4; l++)
                {
                    Console.Write(sayilar[k, l].ToString()+"\t");
                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }
}
