using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            string[] split = operation.Split('+', '-', '*', '/');
            double res = 0;

            if (operation.Contains("+"))
            {
                res = Convert.ToDouble(split.GetValue(0)) + Convert.ToDouble(split.GetValue(1));

            }
            return res;
        }

        
    }
}