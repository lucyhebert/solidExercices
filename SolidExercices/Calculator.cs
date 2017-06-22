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
            try
            {
                foreach (var item in _operationList)
                {
                    if (item.CanCalculate(operation))
                    {
                        res = item.Calculate(operation);
                    }
                }
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("ERREUR : trop d'opérateurs !");
            }
            catch (DivideByZeroException e)
            {
                throw new DivideByZeroException("ERREUR : division par zéro impossible !");
            }
            return res;
        }

    }
}