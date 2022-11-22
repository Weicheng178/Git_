using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Operation
    {
        public static int Addition(int v1, int v2)
        {
            Console.WriteLine("11");
            return v1 + v2;
            
        }

        public static int Multiplication(int v1, int v2)
        {
            Console.WriteLine("22");
            return v1 * v2;
            
        }

        public static int Division(int v1, int v2)
        {
            if (v2 == 0) 
            {
                Console.WriteLine("une erreur algorithmique produit");
            }
            return v1 / v2;
        }
    }
    public class Delegate
    {
        public delegate int Delg1(int v1, int v2);

        /*public static void Main(string[] args)
        {
            Delg1 delg1 = Operation.Addition;
            delg1 += Operation.Multiplication;
            Console.WriteLine(delg1.Invoke(1, 2).ToString());

            Delg1 delg2 = new Delg1(Operation.Multiplication);
            Console.WriteLine(delg2.Invoke(5, 2).ToString());

            Delg1 delg3 = new Delg1(Operation.Division);
            Console.WriteLine(delg3.Invoke(10, 2).ToString());

            Console.Read();
        }*/
    }
}
