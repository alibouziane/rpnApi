using System.Collections.Generic;
using System.Web.Http;

namespace rpnApi.Controllers
{
    public class stackController : ApiController
    {
        private Stack<decimal> _stack;

        [HttpPost]
        public IHttpActionResult PostStack()
        {
            this._stack = new Stack<decimal>();
            return Ok();
        }



    }
}
