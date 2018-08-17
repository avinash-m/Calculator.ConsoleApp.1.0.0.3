using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{

    //--------------------Non Static Math Operations-----------------------------

    public class DurgaMathOperations
    {
                
        public void addition(double firstnumber, double secondnumber)
        {
            double add = firstnumber + secondnumber;
            Console.WriteLine("Addition of Two Numbers: {0}", add);
        }

        public void subtraction(double firstnumber, double secondnumber)
        {
            double sub = firstnumber - secondnumber;
            Console.WriteLine("Subtraction of Two Numbers: {0}", sub);
        }

        public void multiplication (double firstnumber, double secondnumber)
        {                      
            double Mul = firstnumber * secondnumber;
            Console.WriteLine("Multiplication of Two Numbers: {0}", Mul.ToString("0"));
            
        }

        public void division(double firstnumber, double secondnumber)
        {
            if (secondnumber != 0)
            {
                double div = firstnumber / secondnumber;
                Console.WriteLine("Division of Two Numbers: {0}", div.ToString("0.0000"));
            }
        }

        public void Reminder(double firstnumber, double secondnumber)
        {
            if (secondnumber != 0)
            {
                double Rem = firstnumber % secondnumber;
                Console.WriteLine($"Reminder of Two Numbers: {Rem:0.00}");
            }
        }
        
    }
}
