using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    internal class Helper :Employee
    {
        public Helper(int id, string name, string department) : base(id, name, department)
        {
        }

        public static int searchArray<T>(T [] a,T value)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (value.Equals( a[i]))
                    return i; 
            }
            return 0;
        }

        public static T MuxVlue<T>(T x, T y) where T : IComparable 
        {
            if (x.CompareTo(y)>0)
                return x;
            else
                return y;
        }

       
    }
}
