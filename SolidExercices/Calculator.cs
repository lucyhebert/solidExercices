using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            string[] split = operation.Split('+', '-', '*', '/');
            decimal res = 0;

            if (split.Length == 2)
            {
                decimal firstNumber = Convert.ToDecimal(split.GetValue(0));
                decimal secondNumber = Convert.ToDecimal(split.GetValue(1));

                if (operation.Contains("+"))
                {
                    res = firstNumber + secondNumber;
                }
                else if (operation.Contains("-"))
                {
                    res = firstNumber - secondNumber;
                }
                else if (operation.Contains("*"))
                {
                    res = firstNumber * secondNumber;
                }
                else if (operation.Contains("/"))
                {
                    res = firstNumber / secondNumber;
                }
            }
            else
            {
                throw new ArgumentException("ERREUR : trop d'opérateurs !");
            }
            
            return res;
        }

        
    }
}