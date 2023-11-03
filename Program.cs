using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" nhap ten cua ban :");
            string ten = Console.ReadLine();
            Console.Write(" nhap tuoi cua ban: ");
            int tuoi = Int16.Parse(Console.ReadLine());
            Console.Write(" quen cua ban: ");
            string que = Console.ReadLine();
            Console.WriteLine(" ban ten la: {0},{1} tuoi, que o {2}" ,ten, tuoi, que);
            Console.ReadKey();
            


        }
    }
}
