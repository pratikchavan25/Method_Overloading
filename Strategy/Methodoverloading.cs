using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // METHOD OVERLOADING PROGRAM
    public class Methodoverloading
    {

        public int Guide(int x,int y)
        {
            return x - y;
        }
        public double Guide(double x,double y)
        {
            return x * y;
        }
        
        

    }
}
