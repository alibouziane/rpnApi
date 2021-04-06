namespace rpnApi.Models
{
    public class MultiplicationOperator : Operator
    {


        public MultiplicationOperator(string v)
        {
            this.Op = v;
        }

        public override decimal Calculate(decimal left, decimal right)
        {
            return left * right;
        }
    }
}