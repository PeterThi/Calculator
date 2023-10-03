using Microsoft.AspNetCore.Mvc;

namespace RetractionService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetractionController : ControllerBase
    {

        public RetractionController()
        {

        }

        [HttpPost(Name = "PostRetraction")]
        public int Post(int leftNumber, int rightNumber)
        {
            return leftNumber - rightNumber;
        }
    }
}
