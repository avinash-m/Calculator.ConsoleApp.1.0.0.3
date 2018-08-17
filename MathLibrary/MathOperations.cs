using System;

namespace MathLibrary
{
    // Avinash
    public static class MathOperations
    {
        static MathOperations()
        {
            Console.WriteLine("--- In Static Class ---\n");
        }

        public static void Addition(double firstNumber, double secondNumber)
        {
            if (firstNumber > 0 && secondNumber > 0)
            {
                double sum = firstNumber + secondNumber;
                Console.WriteLine($"Addition of numbers: { sum }");
            }
            else
            {
                Console.WriteLine("Additon: Numbers should be greater than zero.");
            }
        }

        public static void Subtraction(double firstNumber, double secondNumber)
        {
            if (firstNumber != 0 && secondNumber != 0)
            {
                double sum = firstNumber - secondNumber;
                Console.WriteLine($"Subtraction of numbers: { sum }");
            }
            else
            {
                Console.WriteLine("Subtraction of two zeros is zero");
            }
        }

        public static void Multiplication(double firstNumber, double secondNumber)
        {
            decimal Multiplier = (decimal)firstNumber * (decimal)secondNumber;

            Console.WriteLine("Multiplication of Numbers: {0}", Multiplier.ToString());
        }

        public static void Division(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                double quotient = firstNumber / secondNumber;
                Console.WriteLine($"Division of Numbers: {quotient:0.000}");
            }
            else
            {
                Console.WriteLine("Division: Denominator cannot be zero.");
            }

        }

        public static void Remainder(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                double remainder = firstNumber % secondNumber;
                Console.WriteLine($"Remainder of Numbers: {remainder:0.000}");
            }
            else
            {
                Console.WriteLine("Remainder: Denominator cannot be zero.");
            }

        }
    }

    
    
}
