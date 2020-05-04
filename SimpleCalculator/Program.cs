using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int mistake = 0;
            int tryCount = 0;

            while (true)
            {
                Console.Write("Enter an Operator: ");
                string op = (Console.ReadLine());
                bool isnotvalid = false;

                for (int i = 1; i <= 2; i++)
                {
                    if (op != "+" && op != "-" && op != "*" && op != "/")
                    {
                        Console.Write("Invalid Operator, try again:");
                        op = Console.ReadLine();

                    }
                    if (i == 2 && op != "+" && op != "-" && op != "*" && op != "/")
                    {
                        Console.WriteLine("You messed up");
                        isnotvalid = true;
                        mistake++;
                        Console.WriteLine($"This is mistake number {mistake}");
                    }
                }
                if (isnotvalid != true)
                {
                    Console.Write("Please enter your first number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Calc(num1, op, num2));
                    tryCount++;
                    Console.WriteLine($"This is try number {tryCount}");

                }

            }



        }
        static public int Calc(int num1, string op, int num2)
        {

            if (op == "+")
            {
                return num1 + num2;
            }
            else if (op == "-")
            {
                return num1 - num2;
            }
            else if (op == "*")
            {
                return num1 * num2;
            }
            else if (op == "/")
            {
                return num1 / num2;
            }
            else
            {
                return 0;
            }
        }

    }
}

