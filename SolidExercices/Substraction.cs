using System;

namespace SolidExercices
{
    internal class Substraction  : IOperation
    {
        bool IOperation.CanCalculate(string operation)
        {
            return operation.Contains("-");
        }

        public decimal Calculate(string operation)
        {
            var split = operation.Split('-');

            var firstNumber = Convert.ToDecimal(split.GetValue(0));
            var secondNumber = Convert.ToDecimal(split.GetValue(1));

            return firstNumber - secondNumber;
        }
    }
}