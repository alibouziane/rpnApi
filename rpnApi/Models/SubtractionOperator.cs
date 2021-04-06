namespace rpnApi.Models
{
    public class SubtractionOperator : Operator
    {


        public SubtractionOperator(string v)
        {
            this.Op = v;
        }

        public override decimal Calculate(decimal left, decimal right)
        {
            return left - right;
        }
    }
}