using System;

namespace SolidExercices
{
    public interface IOperation
    {
        bool CanCalculate(string operation);
        decimal Calculate(string operation);
    }
}