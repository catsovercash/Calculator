using System;

namespace Calculator
{
    internal class Program
    {
        static double numberOne()
        {

            bool access = false;

            while (!access)
            {

                try
                {

                    Console.Write("Enter the first number: ");
                    double numOne = double.Parse(Console.ReadLine());
                    access = true;
                    return numOne;

                }

                catch (FormatException)
                {

                    Console.Write("Invalid Input\n");

                }
            }

            return 0;

        }


        static double numberTwo()
        {
            bool access = false;

            while (!access)
            {

                try
                {

                    Console.Write("Enter the second number: ");
                    double numTwo = double.Parse(Console.ReadLine());
                    access = true;
                    return numTwo;

                }

                catch (FormatException)
                {

                    Console.Write("Invalid Input\n");

                }
            }

            return 0;
        }

        static char mathematicsOperator()
        {
            while (true)
            {
                Console.Write("Enter the operator (+, -, *, /): ");

                try
                {
                    char mathOperator = char.Parse(Console.ReadLine());

                    if (mathOperator == '+' || mathOperator == '-' ||
                        mathOperator == '*' || mathOperator == '/')
                    {
                        return mathOperator;
                    }
                    else
                    {
                        Console.Write("Invalid operator. Use +, -, *, /\n");
                    }

                }
                catch (FormatException)
                {
                    Console.Write("Invalid input\n");
                }
            }
        }



        static double add(double numOne, double numTwo)
        {
            double total = numOne + numTwo;
            return total;
        }

        static double substract(double numOne, double numTwo)
        {
            double total = numOne - numTwo;
            return total;
        }

        static double multiply(double numOne, double numTwo)
        {
            double total = numOne * numTwo;
            return total;
        }

        static double divide(double numOne, double numTwo)
        {
            double total = numOne / numTwo;
            return total;
        }

        static void calculate(double numOne, double numTwo, char mathOperator)
        {

            if (mathOperator == '+')
            {
                Console.Write(numOne + " + " + numTwo + " = " + add(numOne, numTwo));
            }
            else if (mathOperator == '-')
            {
                Console.Write(numOne + " - " + numTwo + " = " + substract(numOne, numTwo));
            }
            else if (mathOperator == '*')
            {
                Console.Write(numOne + " * " + numTwo + " = " + multiply(numOne, numTwo));
            }
            else if (mathOperator == '/')
            {
                Console.Write(numOne + " / " + numTwo + " = " + divide(numOne, numTwo));
            }
            else
            {
                Console.WriteLine("Invalid operator.");
            }


        }

        static void Main(string[] args)
        {
            double numOne = numberOne();
            double numTwo = numberTwo();
            char mathOperator = mathematicsOperator();
            calculate(numOne, numTwo, mathOperator);
        }
    }
}
