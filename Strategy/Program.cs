using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// OVERLOADING main PROGRAM
namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methodoverloading m1 = new Methodoverloading();
            int resul1 = m1.Guide(30, 40);
            Console.WriteLine(resul1);

            // Methodoverloading m2 = new Methodoverloading();
            double result2 = m1.Guide(50.05, 60.06);
            Console.WriteLine(result2);

        }
    }
}
