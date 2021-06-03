using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DARVRIYKASR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Davriy kasr kirting Qoida: AA,BB(CC) yoki AA,(CC)");
            AralashDK aralashDK = new AralashDK();
            aralashDK.Kasr(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
