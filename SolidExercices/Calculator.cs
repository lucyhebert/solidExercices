using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        private readonly List<IOperation> _operationList;

        public Calculator()
        {
            _operationList = new List<IOperation>();
            _operationList.Add(new Sum());
            _operationList.Add(new Substraction());
            _operationList.Add(new Product());
            _operationList.Add(new Division());
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