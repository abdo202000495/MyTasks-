using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Calculator
    {
        public int sum (int x,int y)
        {
            return x+y;
        }

        public int sum(int z,int x,int y)
        {
            return z+this.sum(x,y);
        }
        public double sum(double x, double y)
        {
            return x + y;
        }
    }
}
