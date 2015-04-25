using System;

        // This calc is using lambda expressions;

namespace ConsoleApplication1
{
    public delegate double CalcDelegate(int a, int b);

    internal class Program
    {
        private static void Main(string[] args)
        {


            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());          // .Parse or Convert.ToInt32? 
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator:");
            string operate = Console.ReadLine();

            CalcDelegate myOperator = null;

            switch (operate)
            {
                case "+":
                    myOperator = (x, y) => { return x + y; };
                    break;

                case "-":
                    myOperator = (x, y) => { return x - y; };
                    break;

                case "*":
                    myOperator = (x, y) => { return x * y; };
                    break;

                case "/":
                    myOperator = (x, y) =>
                    {
                        if (y != 0)                 // zero check;
                        {
                            return x / (double)y;
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero!");
                            return 0;               // Delegate returns double. 
                        }
                    };
                    break;

                default:
                    Console.WriteLine("This operation is not supported");
                    break;
            }
            if (myOperator != null)
                Console.WriteLine(myOperator(a, b));
        }
    }
}