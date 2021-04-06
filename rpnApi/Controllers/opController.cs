using rpnApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace rpnApi.Controllers
{
    public class opController : ApiController
    {
        private Stack<decimal> _stack;

        public opController()
        {
            if (this._stack == null)
                this._stack = new Stack<decimal>();
        }

        //GET /api/op
        public IHttpActionResult Getop(string query = null)
        {

            var operators = new List<Operator>
                {
                    new AdditionOperator("+"),
                    new SubtractionOperator("-"),
                    new MultiplicationOperator("*"),
                    new DivisionOperator("/")
                }.Select(s => s.Symbole);

            return Ok(operators);

        }

        //POST /api/stack
        [HttpPost]
        public IHttpActionResult PostStack(string input)
        {
            decimal numericInput;
            if (decimal.TryParse(input, out numericInput))
            {
                this._stack.Push(numericInput);
                //return Ok(_stack);
            }

            //throw new InvalidOperationException("Invalid input, I don't know what \"" + input + "\" means.");

            return Ok(this._stack);
            //return Created(new Uri(Request.RequestUri + "/" + input), input);





        }






    }
}
