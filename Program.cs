using System;

namespace Calculator
{
    internal class Program
    {

        static double numberOne()
        {
            Console.Write("Enter the first number: ");
            double numOne = double.Parse(Console.ReadLine());
            return numOne;
        }

        static double numberTwo()
        {
            Console.Write("Entger the second number: ");
            double numTwo = double.Parse(Console.ReadLine());
            return numTwo;
        }

        static char mathematicsOperator()
        {
            Console.Write("Enter the operator: ");
            char mathOperator = char.Parse(Console.ReadLine());
            return mathOperator;
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
                throw new Exception("Invalid Operator");
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
