using System;

namespace rpnApi.Models
{
    public class DivisionOperator : Operator
    {


        public DivisionOperator(string v)
        {
            this.Op = v;
        }

        public override decimal Calculate(decimal left, decimal right)
        {
            if (right == 0)
            {
                throw new InvalidOperationException("Arithmetic error: Division by zero");
            }
            return left / right;
        }


    }
}