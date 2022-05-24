using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            sayilar.Add(1);
            sayilar.Add(17);
            sayilar.Add(12.5);
            sayilar.Add("Merhaba");
            sayilar.Add('a');
            sayilar.Add(45);
            foreach (var i in sayilar)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();

        }
    }
}
