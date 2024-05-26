using Microsoft.AspNetCore.Mvc;

namespace QueteRoutage.Controllers
{
    public class HelloController : Controller
    {
        public string Say()
        {
            return "Hello !";
        }

        public string Yell()
        {
            return "HELLO !";
        }

        [Route("/{controller}/Say")]
        public string SayAttribut() 
        {
            return Yell();
        }


        [Route("/controller}/YELL")]
        public string YellAttribut()
        {
            return Yell();
        }
    }
}
