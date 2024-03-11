using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaprServiceBusMessageConsumer.Controllers
{
    [Route("/")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        [HttpPost("servicebus")]
        public async Task<ActionResult<string>> processMessage()
        {
            string request = await new StreamReader(Request.Body).ReadToEndAsync();
            Console.WriteLine(request);
            return "CID" + request;
        }

        [HttpGet]
        public ActionResult<string> Index()
        {
            return "Hello";
        }
    }
}
