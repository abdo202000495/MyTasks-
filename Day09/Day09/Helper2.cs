using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public struct rectngle 
    {
        public float hight { get; set; }
        public float width { get; set; }
    }

   
    internal class Helper2<T>
    {
        public static void ReplaceArray(T [] original ,T [] result)
        {
            if (original == null||result==null)
            {
                Console.WriteLine("the array value can be not null 1");
                return;
            }
            
            else if (original.Length>result.Length)
            {
                Console.WriteLine("the array value can be not null");
                return;
            }

            else
                for (int i = 0; i < original.Length; i++)
                {
                    result[i] = original[i];
                }
            
        }
    }
}
