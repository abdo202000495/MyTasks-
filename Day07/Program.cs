using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region P1
            Car car1 = new Car();
            Car car2 = new Car(14);
            Car car3 = new Car(15,"marc");
            Car car4= new Car(12,"toyta",15240148);
            #endregion

            #region Q1
            // لما بنعرف Constructor هنا الكوميلر بيعرف انك مش محتاج الجزء الديفلت بتاعه لو مكرتوش هو بيكريته عادي
            #endregion

            #region P2
            Calculator C1 = new Calculator();
            C1.sum(5, 4);
            C1.sum(5, 8, 7);
            C1.sum(5458.158, 784.65);
            #endregion

            #region Q2
            //overlaoding make us use the same name of function to make difference things  and when call it we can use just name 
            // of this function and create alot of operations by change number of parmeter or type of this pratmeter 
            #endregion

            #region P3
            child ch1 = new child(5,8,7);
            #endregion

            #region Q3
            // the main purpose fo constructor cahining is inhertence and readble moer 
            #endregion

            #region P4
            child ch = new child(6,8,7);
            ch.Product2();
            ch.Product();
            #endregion

            #region Q5
            // because this function can be resue to print alot of ways better 
            #endregion

            #region P5
            Rectangle r1= new Rectangle();
            r1.Draw();
            Console.Write(r1.Area);
            #endregion

            #region Q5 

            /*In C#, an interface defines a contract that specifies the methods and properties that a class must implement, 
            but it does not provide any implementation details. 
            Because of this, you cannot create an instance of an interface directly*/

            #endregion

            #region P6
            Circle circle = new Circle();
            circle.PrintDetails();

        }
    }
}
