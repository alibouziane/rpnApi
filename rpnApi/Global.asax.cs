using rpnApi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace rpnApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static IEnumerable<Operator> Operators;
        public static Stack<decimal> stack { get; set; }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);


            stack = new Stack<decimal>();


            Operators = new List<Operator>
                {
                    new AdditionOperator("+"),
                    new SubtractionOperator("-"),
                    new MultiplicationOperator("*"),
                    new DivisionOperator("/")
                };

        }
    }
}
