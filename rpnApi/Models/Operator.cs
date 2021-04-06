using System;
using System.Collections.Generic;

namespace rpnApi.Models
{
    public abstract class Operator
    {
        public string Op { get; set; }
        public abstract decimal Calculate(decimal left, decimal right);

        internal void Calculate(Stack<decimal> stack)
        {
            if (stack.Count < 2)
            {
                throw new InvalidOperationException("A operator requires at least 2 numbers in the stack");
            }

            decimal right = stack.Pop();
            decimal left = stack.Pop();

            decimal result = Calculate(left, right);

            stack.Push(result);

        }
    }
}