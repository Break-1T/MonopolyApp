using System;

namespace ConsoleMonopolyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> myAction = Sum;
            myAction += Multiply;
            myAction.Invoke(12,3);
            myAction-=Sum;
            myAction.Invoke(12,3);
        }

        static void Sum(int x,int y)
        {
            Console.WriteLine($"{x}+{y}={x+y}");
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine($"{x}*{y}={x*y}");
        }
    }
}
