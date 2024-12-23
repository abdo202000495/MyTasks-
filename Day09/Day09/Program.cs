using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    #region P1
    enum Weekdays
    {
        Monday = 1,
        Tuesday, 
        Wednesday,
        Thursday, 
        Friday
    }
    #endregion
    #region P2
    enum Grades
    {
           A,B,C,D,E,F=1
    }
    #endregion

    enum Gender:byte
    {
        Male,Fmale
    }

    
    internal class Program
    {
        public static void Swap<T>(ref T  x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            #region Q1 
            //By explicitly assigning values, you can ensure that each enum member has a specific, predictable value.
            //This is particularly important when the enum values are used in scenarios where the numerical representation matters
            #endregion

            //Grades a = (Grades)3;
            //Console.WriteLine(a);
            #region P2
            for (int i = 0; i < 6;i++)
            {
                Grades a=(Grades)i;
                Console.WriteLine(a);
            }
            #endregion

            #region Q2 
            // When we assign number to item in enum , enum have anther item in this index 
            // clr will override this items and assign new items to this index 
            #endregion

            #region P3
            Person p1 = new Person(5,"ahmed","IS");
            Person p2 = new Person(7, "Abdo", "IT");
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            #endregion

            #region Q3 
            //What is the purpose of the virtual keyword when used with properties?
            //this meaning we can use it and ovveride when we inherit this class and modify 
            //what we want to 
            #endregion

            #region  Q4
            /* Preventing Further Modifications: When a property or method is marked as sealed,
             it is a way to ensure that the implementation provided by the base class is the final one,
             preventing any subclasses from changing its behavior.This is useful
             when the behavior of the property or method is critical 
             and shouldn't be altered to avoid unexpected results.*/
            #endregion

            #region P5
            double x = Utility.perimeter(5, 10);
            Console.WriteLine(x);
            #endregion

            #region Q5 
            //What is the key difference between static and object members? 
            // 1-static can't inherit   2-Call by class name 
            // 3-No inheritance         4-Container for Static members
            #endregion


            #region Complex number and swap 
            //ComplexNumber num1 = new ComplexNumber();
            //ComplexNumber num2 = new ComplexNumber();
            //num1.Real = 4;
            //num2.Image = 2;
            //num2.Real= 3;
            //num1.Image = 1;
            //ComplexNumber num3 = num1 * num2;

            //Console.WriteLine(num3);
            //Console.WriteLine(num2);
            // int n =2,m=45;
            //Swap (ref n,ref m);
            //Console.WriteLine($"n={n} \nm={m}"); 
            #endregion

            #region  Celsius To Fahrenheit.
            // Console.WriteLine(Utility.FahrenheitToCelsius(50));
            //Console.WriteLine(Utility.CelsiusToFahrenheit(10));

            #endregion

            /*Problem: 
               Write a program that tries to parse a string to a Grades enum value. Use Enum.TryParse 
               to handle invalid inputs gracefully.
            */

            #region TryPars_Enum 
            //string input = Console.ReadLine();
            //if (Enum.TryParse(input, true, out Grades grade))
            //{
            //    Console.WriteLine($"your input invalid type of Grads {grade} ");
            //}
            //else
            //{
            //    Console.WriteLine("invalid input please enter {A,B,C,D,E,F}");
            //}
            #endregion

            #region Search Array
            string[] str2 = { "ahmed", "mohmaed", "abdo", "adel", "wiled", "Ahmed" };
            string v = "mohmaed";
            Console.WriteLine(Helper.searchArray(str2, v)); 
            

            Employee E01 = new Employee(4, "hamed", "is");
            Employee E02 = new Employee(80, "weiled", "CS");
            Employee E03 = new Employee(2, "Abdo", "CS");
            Employee E04 = new Employee(20, "zakria", "IS");
            Employee E05 = new Employee(12, "Hmada", "CS");
            Employee[] emp =
            {
                E01,
                E02,
                E03,
                E04,
                E05
            };



            Console.WriteLine(Helper.searchArray(emp,new Employee(20,"zakria","IS")));
            #endregion

            #region Eqauls in struct and class 

            // What is the difference between overriding Equals and == for object comparison in C# struct and class ? 
            //the key differnce is Equals in struct compare vlue in other hand compare refernce in class not state. 
            // new Employee(20,"zakria","IS")) in this chapter we create new object in memory has new address in heap

            #endregion

            #region Mux vlue 
            int x5 = Helper.MuxVlue(5, 12);
            Console.WriteLine(x5);
            string x4 = Helper.MuxVlue("ahmed", "wesame");
            #endregion

            #region ٌReplace Array 
            int[] jgj = { 1, 8, 7, 5, 9, 4 };
            int[] b = { 4, 5, 8, 7, 8, 7 };
            Helper2<int>.ReplaceArray(jgj, b);
            foreach (int i in b)
                Console.WriteLine(i);
            #endregion
           
            #region  ReverseArray 
            int[] array2 = { 5, 4, 3, 2, 1 };
            ReverseArray(array2);
            string[] array7 = { "a", "ghhg", "gihdg", "ahmed" };
            ReverseArray(array2);
            #endregion

            Console.Clear();

            #region Stack 
            Stack<int>.push(1);
            Stack<int>.push(10);
            Stack<int>.push(4);
            Stack<int>.push(3);
            Stack<int>.push(7);
            Stack<int>.pop();
            Console.WriteLine(Stack<int>.peek()); 
            #endregion
            Console.ReadKey();
        }

        public static void ReverseArray<T>(T[] a)
        {
            T[] result = new T[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[a.Length - i - 1];
                Console.WriteLine(result[i]);
            }
        } 
        
    }
}
