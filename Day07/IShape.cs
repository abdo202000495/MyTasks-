using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal interface IShape
    {
        int Area { get; }
        void Draw();

        void PrintDetails();
    }

    class Rectangle : IShape
    {
        public int Area { get; }

        int IShape.Area => throw new NotImplementedException();

        public void Draw()
        {
            Console.WriteLine("i will show you my photo");
        }

        void IShape.Draw()
        {
            throw new NotImplementedException();
        }

        void IShape.PrintDetails()
        {
            throw new NotImplementedException();
        }
    }


    class Circle : IShape
    {
        public int Area { get; }

        public void Draw()
        {
            Console.WriteLine("all my drwo here");
        }

        public void PrintDetails()
        {
            Console.WriteLine("every data you will sent to you");
        }
    }

}
