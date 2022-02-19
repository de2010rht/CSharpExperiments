using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void Procedure();
public delegate int Maths(int a, int b);

namespace DelegateLambda
{
    internal class DelegateDemo
    {
        public static void FirstMethod()
        {
            Console.WriteLine("Inside the first static method");
        }

        public static void SecondMethod()
        {
            Console.WriteLine("Inside the second static method");
        }

        public void Method()
        {
            Console.WriteLine("Inside the first non-static method");
        }

        public static int ThirdMethod(int x, int y)
        {
            return x + y;
        }

        public static void Exec()
        {
            Procedure proc = null;
            proc += new Procedure(DelegateDemo.FirstMethod);
            proc += new Procedure(SecondMethod);

            DelegateDemo demo = new DelegateDemo();
            proc += new Procedure(demo.Method);
            proc();
        }

        public static void Process()
        {
            Maths proc = null;
            proc += new Maths(ThirdMethod);
            int x = 5, y = 12;
            int result = proc(5, 12);
            Console.WriteLine("Addition of {0} and {1} is {2}", x, y, result);
        }
    }
}
