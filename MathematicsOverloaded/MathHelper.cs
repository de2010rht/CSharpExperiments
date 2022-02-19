using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsOverloaded
{
    public class MathHelper
    {
        public int sum(int a, int b)
        {
            return a + b;
        }

        public double sum(double a, double b)
        {
            return a + b;
        }

        public decimal sum(decimal a, decimal b)
        {
            return a + b;
        }

        public int sumOptional(int num1, int num2 = 10)     // One optional parameter
        {
            return num1 + num2;
        }

        public int sumOptionalBoth(int num1 = 50, int num2 = 10)     // Both optional parameters
        {
            return num1 + num2;
        }

        public void numOut(out int n)
        {
            n = 105;
        }

        public void numRef(ref int n)
        {
            n = 420;
        }
    }
}
