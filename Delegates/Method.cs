using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Method
    {
        public int FuncMethod(int num1, int num2)
        {
            return num1 + num2;
        }

        public void Add(int num1, int num2)
        {
            Console.WriteLine($"The addition is {num1 + num2}");
        }

        public void Subtract(int num1, int num2)
        {
            Console.WriteLine($"The subtraction is {num1 - num2}");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello world");
        }

        public void sayName()
        {
            Console.WriteLine("My name is dominion");
        }

        public int Add(int nums, int num3, int num4)
        {
            return nums + num3 + num4;
        }

        public void PAstorsName(string Name)
        {
           Console.WriteLine($"The pastors name is {Name}");
        }
    }
}
