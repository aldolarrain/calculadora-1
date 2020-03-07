using Microsoft.AspNetCore.Mvc;

namespace webapiCalculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public CalculatorController()
        {

        }

        [Route("Add")]
        [HttpPost]
        public int Add([FromHeader]int a, [FromHeader] int b, int c)
        {
            return a + b;
        }

        [Route("Add")]
        [HttpGet]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [Route("Multiply")]
        [HttpPost]
        public int Multiply([FromHeader]int a, [FromHeader] int b, int c)
        {
            return a * b;
        }

        [Route("Multiply")]
        [HttpGet]
        public int Multiply(int a, int b)
        {
            return a * b;
        }


        ///
        [Route("Adddec")]
        [HttpPost]
        public double Adddec([FromHeader]double a, [FromHeader] double b, double c)
        {
            return a + b;
        }

        [Route("Adddec")]
        [HttpGet]
        public double Adddec(double a, double b)
        {
            return a + b;
        }

        [Route("Add3")]
        [HttpPost]
        public int Add3([FromHeader]int a, [FromHeader] int b, int c,int d)
        {
            return a + b+c;
        }

        [Route("Add3")]
        [HttpGet]
        public int Add3(int a, int b,int c)
        {
            return a + b+c;
        }

        [Route("Mult3")]
        [HttpPost]
        public int Mult3([FromHeader]int a, [FromHeader] int b, int c, int d)
        {
            return a * b * c;
        }

        [Route("Mult3")]
        [HttpGet]
        public int Mult3(int a, int b, int c)
        {
            return a * b * c;
        }



        


    }
}