using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public virtual int Product()
        {
            return X * Y;
        }

        public void Product2()
        {
            Console.WriteLine("Weclom to my function");
        }


        public override string ToString()
        {
            return $"x numvber :  {X}and y number :   {Y}";
        }
    }
    internal class child : Parent
    {
        public int Z { get; set; }

        public child(int z,int x ,int y):base(x,y)
        {
            this.Z = z;
        }
        public override int Product()
        {
            return base.Product();
        }

        public new void Product2() 
        {
            Console.WriteLine("my override by new key word ");
        }


        public override string ToString()
        {
            return $"x numvber :  {X} and y number :   {Y} and z number : {Z}";
        }

    }
}
