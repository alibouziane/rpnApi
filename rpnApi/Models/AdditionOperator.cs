namespace rpnApi.Models
{
    public class AdditionOperator : Operator
    {

        public override decimal Calculate(decimal left, decimal right)
        {
            return left + right;
        }

        public AdditionOperator(string symbole)
        {
            Op = symbole;
        }
    }
}