using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaclNUnit
{

    public class Addition : add
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public int addition()
        {
            num1 = 20;
            num2 = 5;
            Console.WriteLine(num1 + num2);
            return num1 + num2;
        }
    }

    public class Subtration: sub
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int subtration()
        {
            num1 = 20;
            num2 = 5;
            Console.WriteLine(num1 - num2);
            return num1 - num2;
        }
    }
    public class Multiply: mult
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double multiply()
        {
            num1 = 20;
            num2 = 5;
            double result = num1 * num2;
            Console.WriteLine(result);
            return result;
        }
    }
    public class Divide: div
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double divide()
        {
            num1 = 20;
            num2 = 5;
            double result = num1 / num2;
            if (num1 < 0 || num2 <0)
            {
                result = Math.Abs(result);
                
            }
            Console.WriteLine(result);
            return result;
        }
    }

}
