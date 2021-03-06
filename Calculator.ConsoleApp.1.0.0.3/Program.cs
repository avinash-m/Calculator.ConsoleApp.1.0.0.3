﻿/*
    Avinash M
    08/17/2018
    Caluclator application with functionalities imported from custom made class library
 
 */


using System;
using MathLibrary; // Using custom class library

namespace Calculator.ConsoleApp._1._0._0._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Calculator App ***");

            double firstNumber = 0.00D;
            double secondNumber = 0.00D;
            try
            {
                Console.Write("Enter first number: ");
                firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                secondNumber = Convert.ToDouble(Console.ReadLine());
                // Avinash Program code------------------------------------

                DoCalculationsUsingSaticClass(firstNumber, secondNumber);

                // Durga Program code------------------------------------

                DoCalculationsUsingNonSaticClass(firstNumber, secondNumber);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input which cannot be converted into double.");
            }

            



            Console.WriteLine("\nPress any key to continue....................");
            Console.ReadKey();
        }

        private static void DoCalculationsUsingSaticClass(double firstNumber, double secondNumber)
        {
            Console.WriteLine("\n--------------Avinash Math Operations---------------------");

            MathOperations.Addition(firstNumber, secondNumber);
            MathOperations.Subtraction(firstNumber, secondNumber);
            MathOperations.Multiplication(firstNumber, secondNumber);
            MathOperations.Division(firstNumber, secondNumber);

            Console.WriteLine("-----------------------------------------------------------");
        }

        private static void DoCalculationsUsingNonSaticClass(double firstNumber, double secondNumber)
        {
            Console.WriteLine("\n--------------Durga Math Operations---------------------\n");

            DurgaMathOperations mathoperations = new DurgaMathOperations();

            mathoperations.addition(firstNumber, secondNumber);
            mathoperations.subtraction(firstNumber, secondNumber);
            mathoperations.multiplication(firstNumber, secondNumber);
            mathoperations.division(firstNumber, secondNumber);
            mathoperations.Reminder(firstNumber, secondNumber);
        }
    }

    
}
