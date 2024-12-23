using Day09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public class ComplexNumber
    {
        public int Real { get; set; }
        public int Image { get; set; }

        //public ComplexNumber(int real,int image)
        //{
        //    Real = real;
        //    Image = image;
        //}
        public override string ToString()
        {
            return $"{Real} {Image}i";
        }

        public static ComplexNumber operator  * ( ComplexNumber a ,ComplexNumber b)
        {
            return new ComplexNumber
            {
                Image = a?.Image??0 * b?.Image??0,
                Real  = a?.Real??0 * b?.Real??0
            };

        }
    }
}
