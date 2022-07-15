using System;
using MyMaths;

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press 1 to add or 2 to multiply");
            int option = Convert.ToInt32(Console.ReadLine());

            int result;
            MyMaths.MyMaths math = new MyMaths.MyMaths();
            if(option == 1)
            {
                result = math.Add(a, b);
                Console.WriteLine(a + " + " + b + " = " + result);
            }
            else if(option == 2)
            {
                result = math.Mul(a, b);
                Console.WriteLine(a + " * " + b + " = " + result);
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
