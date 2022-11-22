using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Lambda
    {
        public delegate void Delg2();

        public delegate int Delg3(int a, int b);

        /* public static void Main(string[] args)
         {
             Delg2 delg2 = () => Console.WriteLine("Je t'aime");
             delg2.Invoke();

             Delg3 delg3 = (a, b) => a + b;
             Console.WriteLine(delg3.Invoke(5, 10));

             Console.Read();
         }*/
    }
}
