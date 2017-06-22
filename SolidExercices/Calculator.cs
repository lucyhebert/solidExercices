using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        private readonly List<IOperation> _operationList;

        public Calculator(List<IOperation> operationList)
        {
            this._operationList = operationList;
        }

        public decimal Calculate(string operation)
        {
            decimal res = 0;
            if (operation.Split('+', '-', '*', '/').Length > 3)
            {
                foreach (var item in _operationList)
                {
                    if (item.CanCalculate(operation))
                    {
                        res = item.Calculate(operation);
                    }
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