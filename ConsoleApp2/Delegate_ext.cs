using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class A
    {
        public void ma()
        {
            Console.WriteLine("ma");
        }
    }

    public class B
    {
        public void mb()
        {
            Console.WriteLine("mb");
        }
    }

    public delegate void Delg();

    public class Delegate_ext
    {
        public static void Main(string[] args)
        {
            A a;
            B b;
            Delg d;
            Delg[] ds;

            a = new A();
            b = new B();
            d = new Delg(a.ma);

            ds = new Delg[2];
            ds[0] = a.ma;
            ds[1] = b.mb;
            ds[0] = a.ma;

            a.ma();
            b.mb();
            Console.WriteLine("ma et mb ont été lancées directement");
            d.Invoke();
            Console.WriteLine("la méthode dans d a été invoquée");
            for (int i = 0; i < ds.Length; i++)
            {
                ds[i].Invoke();
                Console.WriteLine($"la méthode dans ds[{i}] a été invoquée");
            }

            Console.Read();
        }
    }
}
   

