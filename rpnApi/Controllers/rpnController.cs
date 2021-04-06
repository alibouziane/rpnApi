using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace rpnApi.Controllers
{
    public class rpnController : ApiController
    {
        //GET /rpn/op
        [Route("rpn/op")]
        public IHttpActionResult GetOp()
        {

            return Ok(WebApiApplication.Operators.Select(x => x.Op));

        }




        [HttpPost]
        [Route("rpn/stack")]
        public IHttpActionResult Stack()
        {
            WebApiApplication.stack = new Stack<decimal>();
            return Ok(WebApiApplication.stack);
        }

        //POST rpn/stack/stack_id
        [HttpPost]
        [Route("rpn/stack/stack_id")]
        public IHttpActionResult Stack(string stack_id)
        {
            decimal numericInput;
            if (decimal.TryParse(stack_id, out numericInput))
            {
                WebApiApplication.stack.Push(numericInput);
                return Ok(WebApiApplication.stack);
            }

            throw new InvalidOperationException("Invalid input, " + stack_id);
        }


        [HttpDelete]
        [Route("rpn/stack/stack_id")]
        public IHttpActionResult Stack(int stack_id)
        {
            WebApiApplication.stack.Pop();// je supprime le dernier input saisie
            // a voir lequel de l'element faut il supprimer???


            return Ok(WebApiApplication.stack);
        }



        //GET rpn/stack
        [Route("rpn/stack")]
        public IHttpActionResult GetStack()
        {
            return Ok(WebApiApplication.stack);
        }


        [Route("rpn/stack/stack_id")]
        public IHttpActionResult GetStack(int stack_id)
        {
            if (stack_id <= WebApiApplication.stack.Count)
                return Ok(WebApiApplication.stack.ElementAt(stack_id));
            throw new InvalidOperationException("Invalid input, the index should be <= stack count.");
        }



        [HttpPost]
        //[Route(@"rpn/{" + "'op'" + "}/stack/{stack_id}")]
        [Route(@"rpn/op/{op}/stack/{stack_id}")]
        public IHttpActionResult OpStack(string op, string stack_id)
        {
            foreach (var oper in WebApiApplication.Operators)
            {
                if (oper.Op == op)
                {
                    oper.Calculate(WebApiApplication.stack);
                }
            }
            decimal numericInput;
            if (decimal.TryParse(stack_id, out numericInput))
            {
                WebApiApplication.stack.Push(numericInput);
            }
            return Ok(WebApiApplication.stack);

        }



    }
}
