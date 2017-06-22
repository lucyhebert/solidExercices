using System;
using System.Collections.Generic;

namespace SolidExercices
{
    public class CalculatorRunner
    {

        public static void Main(string[] args)
        {
            public static List<IOperation> OperationList = new List<IOperation> {new Sum(), new Substraction(), new Product(), new Division()};
            public Calculator Calculator = new Calculator(OperationList);
            
            
        }
    }
}