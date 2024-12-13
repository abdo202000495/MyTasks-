using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Car
    {
        public int Id { get; set; }
        public string Barnd { get; set; }
        public double Price { get; set; }

        public Car()
        {
            Console.WriteLine("your object has been created");
        }
        public Car(int _Id)
        {
            this.Id=_Id;
        }
        public Car(int _Id,string _Brand) : this(_Id)
        {
            
            this.Barnd = _Brand;
        }
        public Car(int _Id,string _Brand ,double _price):this(_Id,_Brand)
        {
            
            this.Price = _price;
        }
    }
}
